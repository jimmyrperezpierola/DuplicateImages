using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Shell32;

namespace DuplicateImages
{
    public partial class MainForm : Form
    {
        Dictionary<string, List<string>> bunches = null;
        Shell _shell;
        Folder _recyclingBin;
        List<string> _directoriesToIgnore = new List<string>();
        List<string> ImageExtensions = new List<string> { ".png", ".jpg", ".gif" };
        
        enum CullAction { KeepShortest, KeepLongest, KeepFirst}
        CullAction CurrentCullAction = CullAction.KeepShortest;

        public MainForm()
        {
            InitializeComponent();
            _shell = new Shell();
            _recyclingBin = _shell.NameSpace(10);
        }

        private void lbDirectories_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lbDirectories_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                if (Directory.Exists(file))
                    lbDirectories.Items.Add(file);
        }

        private void lbDirectories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lbDirectories.SelectedIndices.Count > 0)
                    for (var i = lbDirectories.SelectedIndices.Count - 1; i >= 0; i--)
                        lbDirectories.Items.RemoveAt(lbDirectories.SelectedIndices[i]);
            }
        }

        private void lbClusters_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCluster();
            if (lbMembers.Items.Count > 0)
            {
                lbMembers.SelectedIndex = 0;
                lbMembers.Select();
            }
        }

        void LoadCluster()
        {
            lbMembers.Items.Clear();
            if (bunches == null)
                return;
            var item = lbClusters.SelectedItem as string;
            if (item == null)
                return;
            List<string> members = null;
            if (bunches.TryGetValue(item, out members))
            {
                foreach (var member in members)
                    lbMembers.Items.Add(member);
            }
        }

        void UnloadImage()
        {
            if (pbImage.Image != null)
            {
                pbImage.Image.Dispose();
                pbImage.Image = null;
            }
            lbImage.Text = "";
        }

        private void lbMembers_SelectedValueChanged(object sender, EventArgs e)
        {
            UnloadImage();
            if (lbMembers.SelectedIndices.Count < 1)
                return;

            var image_path = lbMembers.SelectedItem as string;
            if (image_path == null)
                return;
            var extension = Path.GetExtension(image_path).ToLowerInvariant();
            if (null == ImageExtensions.FirstOrDefault(match => match.Equals(extension)))
                return;
            try
            {
                pbImage.Image = Image.FromFile(image_path);
                lbImage.Text = image_path;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                UnloadImage();
            }
        }

        private void findMatchingDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunches = new Dictionary<string, List<string>>();
            WalkDirectories(GetDirectories(), dir => {
                var leafname = Path.GetFileNameWithoutExtension(dir);
                if (bunches.ContainsKey(leafname))
                    bunches[leafname].Add(dir);
                else
                    bunches.Add(leafname, new List<string> { dir });
            });
            if (removeSingletonsToolStripMenuItem.Checked)
                RemoveSingletons(bunches);
            LoadBunches();
        }

        private void findMatchingFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ignoreBest is for a very specific need I have for my picture directories
            var ignoreBest = ignoreDirectoriesContainingbestToolStripMenuItem.Checked;
            bunches = new Dictionary<string, List<string>>();
            WalkFiles(GetDirectories(), filename => {
                if (ignoreBest && filename.ToLowerInvariant().IndexOf("best") > -1)
                    return;
                var dir = Path.GetDirectoryName(filename);
                if (_directoriesToIgnore.Exists(f => f.Equals(dir)))
                    return;
                var fi = new FileInfo(filename);
                var hash = $"{fi.Length} bytes, {Path.GetFileName(filename)}";
                if (bunches.ContainsKey(hash))
                    bunches[hash].Add(filename);
                else
                    bunches.Add(hash, new List<string> { filename });
            });
            if (removeSingletonsToolStripMenuItem.Checked)
                RemoveSingletons(bunches);
            LoadBunches();
            lbTotalBytes.Text = $"{Convert.ToDecimal(GetTotalBytes()).ToString("#,##0")} extra bytes";
        }

        long GetTotalBytes()
        {
            var total = 0L;
            foreach (var kv in bunches)
                total += int.Parse(kv.Key.Split(' ')[0]) * (kv.Value.Count - 1);
            return total;
        }

        long GetTotalBytes3()
        {
            var total = 0L;
            foreach (var kv in bunches)
            {
                var delta = int.Parse(kv.Key.Split(' ')[0]) * (kv.Value.Count - 1);
                if (delta < 0)
                    Console.WriteLine("here");
                total += delta;
            }
            return total;
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            var path = lbImage.Text;  // must happen before unload
            UnloadImage();
            if (path == null || path.Length < 1)
                return;
            _recyclingBin.MoveHere(path);
            RemoveFromCluster(lbClusters.SelectedItem as string, path);
            LoadCluster();
        }

        private void btnRemoveDuplicatesInDirectory_Click(object sender, EventArgs e)
        {
            var path = lbMembers.SelectedItem as string;  // must happen before unload
            if (path == null)
                return;
            UnloadImage();
            var dir = Path.GetDirectoryName(path);
            foreach (var lst in bunches.Values)
                foreach (var image_path in lst)
                    if (dir.Equals(Path.GetDirectoryName(image_path)))
                        _recyclingBin.MoveHere(image_path);
            findMatchingFilesToolStripMenuItem_Click(null, null);
        }

        private void btnRemoveUnselected_Click(object sender, EventArgs e)
        {
            var path = lbMembers.SelectedItem as string;  // must happen before unload
            if (path == null)
                return;
            UnloadImage();
            foreach (var image_path in lbMembers.Items)
                if (!path.Equals(image_path))
                    _recyclingBin.MoveHere(image_path);
            //findMatchingFilesToolStripMenuItem_Click(null, null);
        }

        private void ignoreCurrentDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbImage.Text == null || lbImage.Text.Length < 1)
                return;
            var path = Path.GetDirectoryName(lbImage.Text);
            _directoriesToIgnore.Add(path);
            findMatchingFilesToolStripMenuItem_Click(null, null);
        }

        List<string> GetDirectories()
        {
            var r = new List<string>();
            for (var i = 0; i < lbDirectories.Items.Count; i++)
                r.Add(lbDirectories.Items[i].ToString());
            return r;
        }

        void LoadBunches()
        {
            lbClusters.Items.Clear();
            lbMembers.Items.Clear();
            if (bunches == null)
                return;
            foreach (var key in bunches.Keys)
                lbClusters.Items.Add(key);
        }

        void RemoveSingletons(Dictionary<string, List<string>> dict)
        {
            var singletons = new List<string>();
            foreach (var kv in dict)
                if (kv.Value.Count < 2)
                    singletons.Add(kv.Key);
            foreach (var singleton in singletons)
                dict.Remove(singleton);
        }

        void RemoveFromCluster(string key, string to_remove)
        {
            List<string> cluster = null;
            if (!bunches.TryGetValue(key, out cluster))
                return;
            cluster.Remove(to_remove);  // eq
        }

        private void WalkDirectories(List<string> dirs, Action<string> func)
        {
            foreach (var dir in dirs)
                WalkDirectories(dir, func);
        }

        private void WalkDirectories(string dir, Action<string> func)
        {
            func(dir);
            foreach (var subdir in Directory.EnumerateDirectories(dir))
                WalkDirectories(subdir, func);
        }

        private void WalkFiles(List<string> dirs, Action<string> func)
        {
            WalkDirectories(dirs, dir =>
            {
                foreach (var file in Directory.EnumerateFiles(dir))
                    func(file);
            });
        }

        private void lbMembers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeleteImage_Click(null, null);
            }
        }

        IEnumerable<string> EnumerateClusterKeys()
        {
            if (selectedClusterToolStripMenuItem.Checked)
            {
                foreach (var item in lbClusters.SelectedItems)
                    yield return item as string;
            }
            else
            {
                foreach (var item in lbClusters.Items)
                    yield return item as string;
            }
        }

        private void btnCullClusters_Click(object sender, EventArgs e)
        {
            UnloadImage();
            foreach (var key in EnumerateClusterKeys())
            {
                List<string> lst;
                if (!bunches.TryGetValue(key as string, out lst))
                    continue;
                var shortestLength = CurrentCullAction == CullAction.KeepShortest ? int.MaxValue : int.MinValue;
                var keepIndex = -1;
                if (CurrentCullAction == CullAction.KeepFirst)
                    keepIndex = 0;
                else
                {
                    for (var index = 0; index < lst.Count; index++)
                    {
                        var path = lst[index];
                        var len = path.Length;
                        if (CurrentCullAction == CullAction.KeepShortest && len < shortestLength
                            || CurrentCullAction == CullAction.KeepLongest && len > shortestLength)
                        {
                            shortestLength = path.Length;
                            keepIndex = index;
                        }
                    }
                }
                for (var index = 0; index < lst.Count; index++)
                    if (index != keepIndex)
                        _recyclingBin.MoveHere(lst[index]);
            }
            findMatchingFilesToolStripMenuItem_Click(null, null);
        }

        private void keepShortestPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentCullAction = CullAction.KeepShortest;
            keepFirstPathToolStripMenuItem.Checked = false;
            keepLongestPathToolStripMenuItem.Checked = false;
            keepShortestPathToolStripMenuItem.Checked = true;
        }

        private void keepLongestPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentCullAction = CullAction.KeepLongest;
            keepFirstPathToolStripMenuItem.Checked = false;
            keepLongestPathToolStripMenuItem.Checked = true;
            keepShortestPathToolStripMenuItem.Checked = false;
        }

        private void keepFirstPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentCullAction = CullAction.KeepFirst;
            keepFirstPathToolStripMenuItem.Checked = true;
            keepLongestPathToolStripMenuItem.Checked = false;
            keepShortestPathToolStripMenuItem.Checked = false;
        }

        private void selectedClusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedClusterToolStripMenuItem.Checked = true;
            allClustersToolStripMenuItem.Checked = false;
        }

        private void allClustersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedClusterToolStripMenuItem.Checked = false;
            allClustersToolStripMenuItem.Checked = true;
        }

        private void ignoreDirectoriesContainingbestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ignoreDirectoriesContainingbestToolStripMenuItem.Checked = !ignoreDirectoriesContainingbestToolStripMenuItem.Checked;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell32;

namespace DuplicateImages
{
    public partial class MainForm : Form
    {
        Dictionary<string, List<string>> bunches = null;
        Shell _shell;
        Folder _recyclingBin;

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
            bunches = new Dictionary<string, List<string>>();
            WalkFiles(GetDirectories(), filename => {
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
    }
}

namespace DuplicateImages
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbDirectories = new System.Windows.Forms.ListBox();
            this.pnlDirectories = new System.Windows.Forms.Panel();
            this.pnlClusters = new System.Windows.Forms.Panel();
            this.lbClusters = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSingletonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchingDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchingFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ignoreCurrentDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepShortestPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepLongestPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepFirstPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCullClusters = new System.Windows.Forms.Button();
            this.btnRemoveDuplicatesInDirectory = new System.Windows.Forms.Button();
            this.lbImage = new System.Windows.Forms.Label();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnRemoveUnselected = new System.Windows.Forms.Button();
            this.lbTotalBytes = new System.Windows.Forms.Label();
            this.cullClusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedClusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allClustersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreDirectoriesContainingbestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDirectories.SuspendLayout();
            this.pnlClusters.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMembers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag directories here";
            // 
            // lbDirectories
            // 
            this.lbDirectories.AllowDrop = true;
            this.lbDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDirectories.FormattingEnabled = true;
            this.lbDirectories.Location = new System.Drawing.Point(0, 13);
            this.lbDirectories.Name = "lbDirectories";
            this.lbDirectories.Size = new System.Drawing.Size(325, 109);
            this.lbDirectories.TabIndex = 1;
            this.lbDirectories.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDirectories_DragDrop);
            this.lbDirectories.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDirectories_DragEnter);
            this.lbDirectories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbDirectories_KeyDown);
            // 
            // pnlDirectories
            // 
            this.pnlDirectories.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDirectories.Controls.Add(this.lbDirectories);
            this.pnlDirectories.Controls.Add(this.label1);
            this.pnlDirectories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDirectories.Location = new System.Drawing.Point(0, 0);
            this.pnlDirectories.Name = "pnlDirectories";
            this.pnlDirectories.Size = new System.Drawing.Size(325, 122);
            this.pnlDirectories.TabIndex = 2;
            // 
            // pnlClusters
            // 
            this.pnlClusters.Controls.Add(this.lbClusters);
            this.pnlClusters.Controls.Add(this.lbTotalBytes);
            this.pnlClusters.Controls.Add(this.label2);
            this.pnlClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClusters.Location = new System.Drawing.Point(0, 125);
            this.pnlClusters.Name = "pnlClusters";
            this.pnlClusters.Size = new System.Drawing.Size(325, 377);
            this.pnlClusters.TabIndex = 4;
            // 
            // lbClusters
            // 
            this.lbClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClusters.FormattingEnabled = true;
            this.lbClusters.Location = new System.Drawing.Point(0, 26);
            this.lbClusters.Name = "lbClusters";
            this.lbClusters.Size = new System.Drawing.Size(325, 351);
            this.lbClusters.TabIndex = 2;
            this.lbClusters.SelectedValueChanged += new System.EventHandler(this.lbClusters_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clusters";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.cullToolStripMenuItem,
            this.cullClusterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSingletonsToolStripMenuItem,
            this.ignoreDirectoriesContainingbestToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // removeSingletonsToolStripMenuItem
            // 
            this.removeSingletonsToolStripMenuItem.Checked = true;
            this.removeSingletonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeSingletonsToolStripMenuItem.Name = "removeSingletonsToolStripMenuItem";
            this.removeSingletonsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.removeSingletonsToolStripMenuItem.Text = "Remove Singletons";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMatchingDirectoriesToolStripMenuItem,
            this.findMatchingFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ignoreCurrentDirectoryToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.executeToolStripMenuItem.Text = "&Execute";
            // 
            // findMatchingDirectoriesToolStripMenuItem
            // 
            this.findMatchingDirectoriesToolStripMenuItem.Name = "findMatchingDirectoriesToolStripMenuItem";
            this.findMatchingDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.findMatchingDirectoriesToolStripMenuItem.Text = "Find Matching &Directories";
            this.findMatchingDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.findMatchingDirectoriesToolStripMenuItem_Click);
            // 
            // findMatchingFilesToolStripMenuItem
            // 
            this.findMatchingFilesToolStripMenuItem.Name = "findMatchingFilesToolStripMenuItem";
            this.findMatchingFilesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.findMatchingFilesToolStripMenuItem.Text = "Find Matching Files";
            this.findMatchingFilesToolStripMenuItem.Click += new System.EventHandler(this.findMatchingFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // ignoreCurrentDirectoryToolStripMenuItem
            // 
            this.ignoreCurrentDirectoryToolStripMenuItem.Name = "ignoreCurrentDirectoryToolStripMenuItem";
            this.ignoreCurrentDirectoryToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.ignoreCurrentDirectoryToolStripMenuItem.Text = "Ignore Current Directory";
            this.ignoreCurrentDirectoryToolStripMenuItem.Click += new System.EventHandler(this.ignoreCurrentDirectoryToolStripMenuItem_Click);
            // 
            // cullToolStripMenuItem
            // 
            this.cullToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keepShortestPathToolStripMenuItem,
            this.keepLongestPathToolStripMenuItem,
            this.keepFirstPathToolStripMenuItem});
            this.cullToolStripMenuItem.Name = "cullToolStripMenuItem";
            this.cullToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.cullToolStripMenuItem.Text = "&Cull";
            // 
            // keepShortestPathToolStripMenuItem
            // 
            this.keepShortestPathToolStripMenuItem.Checked = true;
            this.keepShortestPathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepShortestPathToolStripMenuItem.Name = "keepShortestPathToolStripMenuItem";
            this.keepShortestPathToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.keepShortestPathToolStripMenuItem.Text = "Keep &Shortest Path";
            this.keepShortestPathToolStripMenuItem.Click += new System.EventHandler(this.keepShortestPathToolStripMenuItem_Click);
            // 
            // keepLongestPathToolStripMenuItem
            // 
            this.keepLongestPathToolStripMenuItem.Name = "keepLongestPathToolStripMenuItem";
            this.keepLongestPathToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.keepLongestPathToolStripMenuItem.Text = "Keep Longest Path";
            this.keepLongestPathToolStripMenuItem.Click += new System.EventHandler(this.keepLongestPathToolStripMenuItem_Click);
            // 
            // keepFirstPathToolStripMenuItem
            // 
            this.keepFirstPathToolStripMenuItem.Name = "keepFirstPathToolStripMenuItem";
            this.keepFirstPathToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.keepFirstPathToolStripMenuItem.Text = "Keep First Path";
            this.keepFirstPathToolStripMenuItem.Click += new System.EventHandler(this.keepFirstPathToolStripMenuItem_Click);
            // 
            // pnlMembers
            // 
            this.pnlMembers.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMembers.Controls.Add(this.lbMembers);
            this.pnlMembers.Controls.Add(this.label3);
            this.pnlMembers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMembers.Location = new System.Drawing.Point(328, 24);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Size = new System.Drawing.Size(327, 502);
            this.pnlMembers.TabIndex = 7;
            // 
            // lbMembers
            // 
            this.lbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(0, 13);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(327, 489);
            this.lbMembers.TabIndex = 1;
            this.lbMembers.SelectedValueChanged += new System.EventHandler(this.lbMembers_SelectedValueChanged);
            this.lbMembers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbMembers_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cluster Members";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlClusters);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.pnlDirectories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 502);
            this.panel1.TabIndex = 8;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 122);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(325, 3);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(325, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 502);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 44);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(559, 458);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 10;
            this.pbImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(658, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 502);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoveUnselected);
            this.panel3.Controls.Add(this.btnCullClusters);
            this.panel3.Controls.Add(this.btnRemoveDuplicatesInDirectory);
            this.panel3.Controls.Add(this.lbImage);
            this.panel3.Controls.Add(this.btnDeleteImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 31);
            this.panel3.TabIndex = 11;
            // 
            // btnCullClusters
            // 
            this.btnCullClusters.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCullClusters.Location = new System.Drawing.Point(261, 0);
            this.btnCullClusters.Name = "btnCullClusters";
            this.btnCullClusters.Size = new System.Drawing.Size(113, 31);
            this.btnCullClusters.TabIndex = 3;
            this.btnCullClusters.Text = "Cull Clusters";
            this.btnCullClusters.UseVisualStyleBackColor = true;
            this.btnCullClusters.Click += new System.EventHandler(this.btnCullClusters_Click);
            // 
            // btnRemoveDuplicatesInDirectory
            // 
            this.btnRemoveDuplicatesInDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveDuplicatesInDirectory.Location = new System.Drawing.Point(374, 0);
            this.btnRemoveDuplicatesInDirectory.Name = "btnRemoveDuplicatesInDirectory";
            this.btnRemoveDuplicatesInDirectory.Size = new System.Drawing.Size(110, 31);
            this.btnRemoveDuplicatesInDirectory.TabIndex = 2;
            this.btnRemoveDuplicatesInDirectory.Text = "Remove Duplicates";
            this.btnRemoveDuplicatesInDirectory.UseVisualStyleBackColor = true;
            this.btnRemoveDuplicatesInDirectory.Click += new System.EventHandler(this.btnRemoveDuplicatesInDirectory_Click);
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Location = new System.Drawing.Point(6, 9);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(90, 13);
            this.lbImage.TabIndex = 1;
            this.lbImage.Text = "<selected image>";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteImage.Location = new System.Drawing.Point(484, 0);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteImage.TabIndex = 0;
            this.btnDeleteImage.Text = "Delete";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected Image";
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(655, 24);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 502);
            this.splitter3.TabIndex = 12;
            this.splitter3.TabStop = false;
            // 
            // btnRemoveUnselected
            // 
            this.btnRemoveUnselected.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveUnselected.Location = new System.Drawing.Point(139, 0);
            this.btnRemoveUnselected.Name = "btnRemoveUnselected";
            this.btnRemoveUnselected.Size = new System.Drawing.Size(122, 31);
            this.btnRemoveUnselected.TabIndex = 4;
            this.btnRemoveUnselected.Text = "Remove Unselected";
            this.btnRemoveUnselected.UseVisualStyleBackColor = true;
            this.btnRemoveUnselected.Click += new System.EventHandler(this.btnRemoveUnselected_Click);
            // 
            // lbTotalBytes
            // 
            this.lbTotalBytes.AutoSize = true;
            this.lbTotalBytes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTotalBytes.Location = new System.Drawing.Point(0, 13);
            this.lbTotalBytes.Name = "lbTotalBytes";
            this.lbTotalBytes.Size = new System.Drawing.Size(59, 13);
            this.lbTotalBytes.TabIndex = 3;
            this.lbTotalBytes.Text = "Total bytes";
            // 
            // cullClusterToolStripMenuItem
            // 
            this.cullClusterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedClusterToolStripMenuItem,
            this.allClustersToolStripMenuItem});
            this.cullClusterToolStripMenuItem.Name = "cullClusterToolStripMenuItem";
            this.cullClusterToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cullClusterToolStripMenuItem.Text = "Cull Cluster";
            // 
            // selectedClusterToolStripMenuItem
            // 
            this.selectedClusterToolStripMenuItem.Checked = true;
            this.selectedClusterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectedClusterToolStripMenuItem.Name = "selectedClusterToolStripMenuItem";
            this.selectedClusterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.selectedClusterToolStripMenuItem.Text = "Selected Cluster";
            this.selectedClusterToolStripMenuItem.Click += new System.EventHandler(this.selectedClusterToolStripMenuItem_Click);
            // 
            // allClustersToolStripMenuItem
            // 
            this.allClustersToolStripMenuItem.Name = "allClustersToolStripMenuItem";
            this.allClustersToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.allClustersToolStripMenuItem.Text = "All Clusters";
            this.allClustersToolStripMenuItem.Click += new System.EventHandler(this.allClustersToolStripMenuItem_Click);
            // 
            // ignoreDirectoriesContainingbestToolStripMenuItem
            // 
            this.ignoreDirectoriesContainingbestToolStripMenuItem.Checked = true;
            this.ignoreDirectoriesContainingbestToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreDirectoriesContainingbestToolStripMenuItem.Name = "ignoreDirectoriesContainingbestToolStripMenuItem";
            this.ignoreDirectoriesContainingbestToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.ignoreDirectoriesContainingbestToolStripMenuItem.Text = "Ignore directories containing \'best\'";
            this.ignoreDirectoriesContainingbestToolStripMenuItem.Click += new System.EventHandler(this.ignoreDirectoriesContainingbestToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.pnlMembers);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Duplicate Images";
            this.pnlDirectories.ResumeLayout(false);
            this.pnlDirectories.PerformLayout();
            this.pnlClusters.ResumeLayout(false);
            this.pnlClusters.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMembers.ResumeLayout(false);
            this.pnlMembers.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDirectories;
        private System.Windows.Forms.Panel pnlDirectories;
        private System.Windows.Forms.Panel pnlClusters;
        private System.Windows.Forms.ListBox lbClusters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMembers;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchingDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSingletonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchingFilesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnRemoveDuplicatesInDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ignoreCurrentDirectoryToolStripMenuItem;
        private System.Windows.Forms.Button btnCullClusters;
        private System.Windows.Forms.ToolStripMenuItem cullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepShortestPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepLongestPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepFirstPathToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveUnselected;
        private System.Windows.Forms.Label lbTotalBytes;
        private System.Windows.Forms.ToolStripMenuItem cullClusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedClusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allClustersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreDirectoriesContainingbestToolStripMenuItem;
    }
}


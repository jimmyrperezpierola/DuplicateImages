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
            this.label2 = new System.Windows.Forms.Label();
            this.lbClusters = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchingDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSingletonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchingFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.lbImage = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
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
            this.pnlClusters.Controls.Add(this.label2);
            this.pnlClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClusters.Location = new System.Drawing.Point(0, 125);
            this.pnlClusters.Name = "pnlClusters";
            this.pnlClusters.Size = new System.Drawing.Size(325, 377);
            this.pnlClusters.TabIndex = 4;
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
            // lbClusters
            // 
            this.lbClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClusters.FormattingEnabled = true;
            this.lbClusters.Location = new System.Drawing.Point(0, 13);
            this.lbClusters.Name = "lbClusters";
            this.lbClusters.Size = new System.Drawing.Size(325, 364);
            this.lbClusters.TabIndex = 2;
            this.lbClusters.SelectedValueChanged += new System.EventHandler(this.lbClusters_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.executeToolStripMenuItem});
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
            this.removeSingletonsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
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
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMatchingDirectoriesToolStripMenuItem,
            this.findMatchingFilesToolStripMenuItem});
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
            // removeSingletonsToolStripMenuItem
            // 
            this.removeSingletonsToolStripMenuItem.Checked = true;
            this.removeSingletonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeSingletonsToolStripMenuItem.Name = "removeSingletonsToolStripMenuItem";
            this.removeSingletonsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.removeSingletonsToolStripMenuItem.Text = "Remove Singletons";
            // 
            // findMatchingFilesToolStripMenuItem
            // 
            this.findMatchingFilesToolStripMenuItem.Name = "findMatchingFilesToolStripMenuItem";
            this.findMatchingFilesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.findMatchingFilesToolStripMenuItem.Text = "Find Matching Files";
            this.findMatchingFilesToolStripMenuItem.Click += new System.EventHandler(this.findMatchingFilesToolStripMenuItem_Click);
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(325, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 502);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lbImage);
            this.panel3.Controls.Add(this.btnDeleteImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 31);
            this.panel3.TabIndex = 11;
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
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Location = new System.Drawing.Point(6, 9);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(90, 13);
            this.lbImage.TabIndex = 1;
            this.lbImage.Text = "<selected image>";
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(655, 24);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 502);
            this.splitter3.TabIndex = 12;
            this.splitter3.TabStop = false;
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
    }
}


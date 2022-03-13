
namespace AppTruyen.Views
{
    partial class fTruyen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTruyen));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnMaximunsize = new System.Windows.Forms.Button();
            this.dgvTruyen = new System.Windows.Forms.DataGridView();
            this.IDTruyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTruyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorTruyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconAppTruyen = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnsAppTruyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruyen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlTitle.Controls.Add(this.lbTitleBar);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnMinisize);
            this.pnlTitle.Controls.Add(this.btnMaximunsize);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(803, 28);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitleBar.Location = new System.Drawing.Point(28, 0);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(516, 28);
            this.lbTitleBar.TabIndex = 4;
            this.lbTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::AppTruyen.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinisize
            // 
            this.btnMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinisize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinisize.Location = new System.Drawing.Point(747, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(28, 28);
            this.btnMinisize.TabIndex = 2;
            this.btnMinisize.TabStop = false;
            this.btnMinisize.Text = "-";
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnMaximunsize
            // 
            this.btnMaximunsize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximunsize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximunsize.FlatAppearance.BorderSize = 0;
            this.btnMaximunsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximunsize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximunsize.Location = new System.Drawing.Point(775, 0);
            this.btnMaximunsize.Name = "btnMaximunsize";
            this.btnMaximunsize.Size = new System.Drawing.Size(28, 28);
            this.btnMaximunsize.TabIndex = 1;
            this.btnMaximunsize.TabStop = false;
            this.btnMaximunsize.Text = "X";
            this.btnMaximunsize.UseVisualStyleBackColor = true;
            this.btnMaximunsize.Click += new System.EventHandler(this.btnMaximunsize_Click);
            // 
            // dgvTruyen
            // 
            this.dgvTruyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTruyen,
            this.NameTruyen,
            this.AuthorTruyen});
            this.dgvTruyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTruyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTruyen.Location = new System.Drawing.Point(0, 28);
            this.dgvTruyen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTruyen.MultiSelect = false;
            this.dgvTruyen.Name = "dgvTruyen";
            this.dgvTruyen.ReadOnly = true;
            this.dgvTruyen.RowHeadersVisible = false;
            this.dgvTruyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTruyen.Size = new System.Drawing.Size(803, 622);
            this.dgvTruyen.TabIndex = 2;
            this.dgvTruyen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTruyen_CellDoubleClick);
            this.dgvTruyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTruyen_KeyDown);
            // 
            // IDTruyen
            // 
            this.IDTruyen.DataPropertyName = "id";
            this.IDTruyen.HeaderText = "ID";
            this.IDTruyen.Name = "IDTruyen";
            this.IDTruyen.ReadOnly = true;
            this.IDTruyen.Width = 50;
            // 
            // NameTruyen
            // 
            this.NameTruyen.DataPropertyName = "title";
            this.NameTruyen.HeaderText = "Tên Truyện";
            this.NameTruyen.Name = "NameTruyen";
            this.NameTruyen.ReadOnly = true;
            this.NameTruyen.Width = 450;
            // 
            // AuthorTruyen
            // 
            this.AuthorTruyen.DataPropertyName = "author";
            this.AuthorTruyen.HeaderText = "Tác Giả";
            this.AuthorTruyen.Name = "AuthorTruyen";
            this.AuthorTruyen.ReadOnly = true;
            this.AuthorTruyen.Width = 283;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindowsToolStripMenuItem,
            this.newStoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeWindowsToolStripMenuItem
            // 
            this.closeWindowsToolStripMenuItem.Name = "closeWindowsToolStripMenuItem";
            this.closeWindowsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeWindowsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.closeWindowsToolStripMenuItem.Text = "Close windows";
            this.closeWindowsToolStripMenuItem.Click += new System.EventHandler(this.closeWindowsToolStripMenuItem_Click);
            // 
            // newStoryToolStripMenuItem
            // 
            this.newStoryToolStripMenuItem.Name = "newStoryToolStripMenuItem";
            this.newStoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newStoryToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newStoryToolStripMenuItem.Text = "NewStory";
            this.newStoryToolStripMenuItem.Click += new System.EventHandler(this.newStoryToolStripMenuItem_Click);
            // 
            // notifyIconAppTruyen
            // 
            this.notifyIconAppTruyen.BalloonTipTitle = "App Truyện [v2020.08.20]";
            this.notifyIconAppTruyen.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconAppTruyen.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconAppTruyen.Icon")));
            this.notifyIconAppTruyen.Text = "App Truyện [v2020.08.20]";
            this.notifyIconAppTruyen.Visible = true;
            this.notifyIconAppTruyen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconAppTruyen_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAppTruyen,
            this.mnsExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // mnsAppTruyen
            // 
            this.mnsAppTruyen.Name = "mnsAppTruyen";
            this.mnsAppTruyen.Size = new System.Drawing.Size(134, 22);
            this.mnsAppTruyen.Text = "App Truyện";
            this.mnsAppTruyen.Click += new System.EventHandler(this.mnsAppTruyen_Click);
            // 
            // mnsExit
            // 
            this.mnsExit.Name = "mnsExit";
            this.mnsExit.Size = new System.Drawing.Size(134, 22);
            this.mnsExit.Text = "Thoát";
            this.mnsExit.Click += new System.EventHandler(this.mnsExit_Click);
            // 
            // fTruyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 650);
            this.Controls.Add(this.dgvTruyen);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fTruyen";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Truyện";
            this.Load += new System.EventHandler(this.fTruyen_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruyen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnMaximunsize;
        private System.Windows.Forms.DataGridView dgvTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorTruyen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconAppTruyen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsAppTruyen;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.ToolStripMenuItem newStoryToolStripMenuItem;
    }
}
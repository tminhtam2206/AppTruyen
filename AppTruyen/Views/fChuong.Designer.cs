
namespace AppTruyen.Views
{
    partial class fChuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChuong));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbNewChapter = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnMaximunsize = new System.Windows.Forms.Button();
            this.dgvChuong = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.newChapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDChuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameChuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlTitle.Controls.Add(this.lbNewChapter);
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnMinisize);
            this.pnlTitle.Controls.Add(this.btnMaximunsize);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(655, 28);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lbNewChapter
            // 
            this.lbNewChapter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNewChapter.ForeColor = System.Drawing.Color.Gold;
            this.lbNewChapter.Location = new System.Drawing.Point(473, 0);
            this.lbNewChapter.Name = "lbNewChapter";
            this.lbNewChapter.Size = new System.Drawing.Size(126, 28);
            this.lbNewChapter.TabIndex = 5;
            this.lbNewChapter.Text = "label1";
            this.lbNewChapter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitle.Location = new System.Drawing.Point(28, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(439, 28);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
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
            this.btnMinisize.Location = new System.Drawing.Point(599, 0);
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
            this.btnMaximunsize.Location = new System.Drawing.Point(627, 0);
            this.btnMaximunsize.Name = "btnMaximunsize";
            this.btnMaximunsize.Size = new System.Drawing.Size(28, 28);
            this.btnMaximunsize.TabIndex = 1;
            this.btnMaximunsize.TabStop = false;
            this.btnMaximunsize.Text = "X";
            this.btnMaximunsize.UseVisualStyleBackColor = true;
            this.btnMaximunsize.Click += new System.EventHandler(this.btnMaximunsize_Click);
            // 
            // dgvChuong
            // 
            this.dgvChuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChuong,
            this.SoChuong,
            this.NameChuong,
            this.WordLength});
            this.dgvChuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvChuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuong.Location = new System.Drawing.Point(0, 28);
            this.dgvChuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChuong.MultiSelect = false;
            this.dgvChuong.Name = "dgvChuong";
            this.dgvChuong.ReadOnly = true;
            this.dgvChuong.RowHeadersVisible = false;
            this.dgvChuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuong.Size = new System.Drawing.Size(655, 622);
            this.dgvChuong.TabIndex = 3;
            this.dgvChuong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuong_CellDoubleClick);
            this.dgvChuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvChuong_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStripTitle";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsReload,
            this.mnsClose,
            this.newChapToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnsReload
            // 
            this.mnsReload.Name = "mnsReload";
            this.mnsReload.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnsReload.Size = new System.Drawing.Size(169, 22);
            this.mnsReload.Text = "Reload";
            this.mnsReload.Click += new System.EventHandler(this.mnsReload_Click);
            // 
            // mnsClose
            // 
            this.mnsClose.Name = "mnsClose";
            this.mnsClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnsClose.Size = new System.Drawing.Size(169, 22);
            this.mnsClose.Text = "Close";
            this.mnsClose.Click += new System.EventHandler(this.mnsClose_Click);
            // 
            // newChapToolStripMenuItem
            // 
            this.newChapToolStripMenuItem.Name = "newChapToolStripMenuItem";
            this.newChapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newChapToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.newChapToolStripMenuItem.Text = "NewChap";
            this.newChapToolStripMenuItem.Click += new System.EventHandler(this.newChapToolStripMenuItem_Click);
            // 
            // IDChuong
            // 
            this.IDChuong.DataPropertyName = "IdChapter";
            this.IDChuong.HeaderText = "ID";
            this.IDChuong.Name = "IDChuong";
            this.IDChuong.ReadOnly = true;
            this.IDChuong.Width = 50;
            // 
            // SoChuong
            // 
            this.SoChuong.DataPropertyName = "NumChapter";
            this.SoChuong.HeaderText = "Số Chương";
            this.SoChuong.Name = "SoChuong";
            this.SoChuong.ReadOnly = true;
            this.SoChuong.Width = 150;
            // 
            // NameChuong
            // 
            this.NameChuong.DataPropertyName = "NameChapter";
            this.NameChuong.HeaderText = "Tên Chương";
            this.NameChuong.Name = "NameChuong";
            this.NameChuong.ReadOnly = true;
            this.NameChuong.Width = 350;
            // 
            // WordLength
            // 
            this.WordLength.DataPropertyName = "WordLength";
            this.WordLength.HeaderText = "S.Chữ";
            this.WordLength.Name = "WordLength";
            this.WordLength.ReadOnly = true;
            this.WordLength.Width = 85;
            // 
            // fChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 650);
            this.Controls.Add(this.dgvChuong);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fChuong";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Chương";
            this.Load += new System.EventHandler(this.fChuong_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnMaximunsize;
        private System.Windows.Forms.DataGridView dgvChuong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsReload;
        private System.Windows.Forms.ToolStripMenuItem mnsClose;
        private System.Windows.Forms.ToolStripMenuItem newChapToolStripMenuItem;
        private System.Windows.Forms.Label lbNewChapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameChuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordLength;
    }
}
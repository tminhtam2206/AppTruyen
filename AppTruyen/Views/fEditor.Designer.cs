
namespace AppTruyen.Views
{
    partial class fEditor
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbTitleChap = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ckbTo = new System.Windows.Forms.CheckBox();
            this.ckbAutoSave = new System.Windows.Forms.CheckBox();
            this.pnlRealTime = new System.Windows.Forms.Panel();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.pnlPrevNext = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnColorWhite = new System.Windows.Forms.Button();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnRenameChapter = new System.Windows.Forms.Button();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.rtxbMain = new System.Windows.Forms.RichTextBox();
            this.timerSystem = new System.Windows.Forms.Timer(this.components);
            this.menuStripTitle = new System.Windows.Forms.MenuStrip();
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRenameTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsNewChap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsNextChap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrevChap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReloadData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsColorGold = new System.Windows.Forms.ToolStripMenuItem();
            this.colorWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsChangeWK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCopy2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMediaUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMediaDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbWord = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lbTotalWordCount = new System.Windows.Forms.Label();
            this.lbWordCount = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlRealTime.SuspendLayout();
            this.pnlPrevNext.SuspendLayout();
            this.menuStripTitle.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlTitle.Controls.Add(this.lbTitleChap);
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnMinisize);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(450, 28);
            this.pnlTitle.TabIndex = 3;
            // 
            // lbTitleChap
            // 
            this.lbTitleChap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitleChap.ForeColor = System.Drawing.Color.Gold;
            this.lbTitleChap.Location = new System.Drawing.Point(78, 0);
            this.lbTitleChap.Name = "lbTitleChap";
            this.lbTitleChap.Size = new System.Drawing.Size(316, 28);
            this.lbTitleChap.TabIndex = 5;
            this.lbTitleChap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitleChap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitle.Location = new System.Drawing.Point(28, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(50, 28);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Editor";
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
            this.btnMinisize.Location = new System.Drawing.Point(394, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(28, 28);
            this.btnMinisize.TabIndex = 2;
            this.btnMinisize.TabStop = false;
            this.btnMinisize.Text = "-";
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(422, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.ckbTo);
            this.pnlMenu.Controls.Add(this.ckbAutoSave);
            this.pnlMenu.Controls.Add(this.pnlRealTime);
            this.pnlMenu.Controls.Add(this.pnlPrevNext);
            this.pnlMenu.Controls.Add(this.btnColorWhite);
            this.pnlMenu.Controls.Add(this.btnGold);
            this.pnlMenu.Controls.Add(this.btnRenameChapter);
            this.pnlMenu.Controls.Add(this.btnCopyAll);
            this.pnlMenu.Controls.Add(this.btnReload);
            this.pnlMenu.Controls.Add(this.btnSave);
            this.pnlMenu.Controls.Add(this.btnNew);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 28);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(450, 24);
            this.pnlMenu.TabIndex = 4;
            // 
            // ckbTo
            // 
            this.ckbTo.AutoSize = true;
            this.ckbTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTo.Location = new System.Drawing.Point(165, 1);
            this.ckbTo.Name = "ckbTo";
            this.ckbTo.Size = new System.Drawing.Size(45, 23);
            this.ckbTo.TabIndex = 6;
            this.ckbTo.Text = "Tô";
            this.ckbTo.UseVisualStyleBackColor = true;
            // 
            // ckbAutoSave
            // 
            this.ckbAutoSave.AutoSize = true;
            this.ckbAutoSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoSave.Location = new System.Drawing.Point(224, 1);
            this.ckbAutoSave.Name = "ckbAutoSave";
            this.ckbAutoSave.Size = new System.Drawing.Size(92, 23);
            this.ckbAutoSave.TabIndex = 6;
            this.ckbAutoSave.Text = "Auto Save";
            this.ckbAutoSave.UseVisualStyleBackColor = true;
            this.ckbAutoSave.CheckedChanged += new System.EventHandler(this.ckbAutoSave_CheckedChanged);
            // 
            // pnlRealTime
            // 
            this.pnlRealTime.Controls.Add(this.lbTitleBar);
            this.pnlRealTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRealTime.Location = new System.Drawing.Point(308, 0);
            this.pnlRealTime.Name = "pnlRealTime";
            this.pnlRealTime.Size = new System.Drawing.Size(86, 24);
            this.pnlRealTime.TabIndex = 5;
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleBar.ForeColor = System.Drawing.Color.Blue;
            this.lbTitleBar.Location = new System.Drawing.Point(5, 0);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(81, 24);
            this.lbTitleBar.TabIndex = 19;
            this.lbTitleBar.Text = "00 : 00 : 00";
            this.lbTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPrevNext
            // 
            this.pnlPrevNext.Controls.Add(this.btnNext);
            this.pnlPrevNext.Controls.Add(this.btnPrev);
            this.pnlPrevNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrevNext.Location = new System.Drawing.Point(394, 0);
            this.pnlPrevNext.Name = "pnlPrevNext";
            this.pnlPrevNext.Size = new System.Drawing.Size(56, 24);
            this.pnlPrevNext.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::AppTruyen.Properties.Resources.fast_forward_20px;
            this.btnNext.Location = new System.Drawing.Point(31, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 24);
            this.btnNext.TabIndex = 1;
            this.btnNext.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNext, "Chương sau (F9)");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = global::AppTruyen.Properties.Resources.rewind_20px2;
            this.btnPrev.Location = new System.Drawing.Point(-1, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(25, 24);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPrev, "Chương trước (F8)");
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnColorWhite
            // 
            this.btnColorWhite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnColorWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorWhite.FlatAppearance.BorderSize = 0;
            this.btnColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorWhite.Location = new System.Drawing.Point(122, 0);
            this.btnColorWhite.Name = "btnColorWhite";
            this.btnColorWhite.Size = new System.Drawing.Size(25, 24);
            this.btnColorWhite.TabIndex = 1;
            this.btnColorWhite.TabStop = false;
            this.toolTip1.SetToolTip(this.btnColorWhite, "Tô chữ màu trắng (F3)");
            this.btnColorWhite.UseVisualStyleBackColor = false;
            this.btnColorWhite.Click += new System.EventHandler(this.btnColorWhite_Click);
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.Color.Gold;
            this.btnGold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGold.FlatAppearance.BorderSize = 0;
            this.btnGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGold.Location = new System.Drawing.Point(91, 0);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(25, 24);
            this.btnGold.TabIndex = 1;
            this.btnGold.TabStop = false;
            this.toolTip1.SetToolTip(this.btnGold, "Tô chữ màu vàng (F1)");
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnRenameChapter
            // 
            this.btnRenameChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenameChapter.FlatAppearance.BorderSize = 0;
            this.btnRenameChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameChapter.Image = global::AppTruyen.Properties.Resources.rename_20px;
            this.btnRenameChapter.Location = new System.Drawing.Point(91, 0);
            this.btnRenameChapter.Name = "btnRenameChapter";
            this.btnRenameChapter.Size = new System.Drawing.Size(25, 24);
            this.btnRenameChapter.TabIndex = 1;
            this.btnRenameChapter.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRenameChapter, "Đổi tên chương (F2)");
            this.btnRenameChapter.UseVisualStyleBackColor = true;
            this.btnRenameChapter.Visible = false;
            this.btnRenameChapter.Click += new System.EventHandler(this.btnRenameChapter_Click);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyAll.FlatAppearance.BorderSize = 0;
            this.btnCopyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyAll.Image = global::AppTruyen.Properties.Resources.copy_20px;
            this.btnCopyAll.Location = new System.Drawing.Point(60, 0);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(25, 24);
            this.btnCopyAll.TabIndex = 1;
            this.btnCopyAll.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCopyAll, "Sao chép tất cả nội dung chương (F12)");
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Image = global::AppTruyen.Properties.Resources.refresh_20px;
            this.btnReload.Location = new System.Drawing.Point(60, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 24);
            this.btnReload.TabIndex = 1;
            this.btnReload.TabStop = false;
            this.toolTip1.SetToolTip(this.btnReload, "Tải lại chương (F5)");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AppTruyen.Properties.Resources.download_20px;
            this.btnSave.Location = new System.Drawing.Point(30, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSave, "Lưu chương (ctrl + s)");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AppTruyen.Properties.Resources.plus_25px;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(25, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNew, "Thêm chương mới (ctrl + n)");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rtxbMain
            // 
            this.rtxbMain.AcceptsTab = true;
            this.rtxbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(41)))));
            this.rtxbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxbMain.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxbMain.Location = new System.Drawing.Point(0, 52);
            this.rtxbMain.Margin = new System.Windows.Forms.Padding(4);
            this.rtxbMain.Name = "rtxbMain";
            this.rtxbMain.Size = new System.Drawing.Size(450, 618);
            this.rtxbMain.TabIndex = 5;
            this.rtxbMain.Text = "";
            this.rtxbMain.SelectionChanged += new System.EventHandler(this.rtxbMain_SelectionChanged);
            this.rtxbMain.TextChanged += new System.EventHandler(this.rtxbMain_TextChanged);
            // 
            // timerSystem
            // 
            this.timerSystem.Enabled = true;
            this.timerSystem.Interval = 1000;
            this.timerSystem.Tick += new System.EventHandler(this.timerSystem_Tick);
            // 
            // menuStripTitle
            // 
            this.menuStripTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.toolToolStripMenuItem,
            this.mediaToolStripMenuItem});
            this.menuStripTitle.Location = new System.Drawing.Point(0, 0);
            this.menuStripTitle.Name = "menuStripTitle";
            this.menuStripTitle.Size = new System.Drawing.Size(450, 24);
            this.menuStripTitle.TabIndex = 7;
            this.menuStripTitle.Text = "menuStrip1";
            this.menuStripTitle.Visible = false;
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSave,
            this.mnsRenameTitle,
            this.mnsNewChap,
            this.mnsNextChap,
            this.mnsPrevChap,
            this.mnsReplace,
            this.mnsCopyAll});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(37, 20);
            this.mnsFile.Text = "File";
            // 
            // mnsSave
            // 
            this.mnsSave.Name = "mnsSave";
            this.mnsSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnsSave.Size = new System.Drawing.Size(172, 22);
            this.mnsSave.Text = "Save";
            this.mnsSave.Click += new System.EventHandler(this.mnsSave_Click);
            // 
            // mnsRenameTitle
            // 
            this.mnsRenameTitle.Name = "mnsRenameTitle";
            this.mnsRenameTitle.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnsRenameTitle.Size = new System.Drawing.Size(172, 22);
            this.mnsRenameTitle.Text = "Rename";
            this.mnsRenameTitle.Click += new System.EventHandler(this.mnsRenameTitle_Click);
            // 
            // mnsNewChap
            // 
            this.mnsNewChap.Name = "mnsNewChap";
            this.mnsNewChap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnsNewChap.Size = new System.Drawing.Size(172, 22);
            this.mnsNewChap.Text = "New Chap";
            this.mnsNewChap.Click += new System.EventHandler(this.mnsNewChap_Click);
            // 
            // mnsNextChap
            // 
            this.mnsNextChap.Name = "mnsNextChap";
            this.mnsNextChap.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mnsNextChap.Size = new System.Drawing.Size(172, 22);
            this.mnsNextChap.Text = "Next Chap";
            this.mnsNextChap.Click += new System.EventHandler(this.mnsNextChap_Click);
            // 
            // mnsPrevChap
            // 
            this.mnsPrevChap.Name = "mnsPrevChap";
            this.mnsPrevChap.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mnsPrevChap.Size = new System.Drawing.Size(172, 22);
            this.mnsPrevChap.Text = "Prev Chap";
            this.mnsPrevChap.Click += new System.EventHandler(this.mnsPrevChap_Click);
            // 
            // mnsReplace
            // 
            this.mnsReplace.Name = "mnsReplace";
            this.mnsReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnsReplace.Size = new System.Drawing.Size(172, 22);
            this.mnsReplace.Text = "Replace";
            this.mnsReplace.Click += new System.EventHandler(this.mnsReplace_Click);
            // 
            // mnsCopyAll
            // 
            this.mnsCopyAll.Name = "mnsCopyAll";
            this.mnsCopyAll.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnsCopyAll.Size = new System.Drawing.Size(172, 22);
            this.mnsCopyAll.Text = "Copy All";
            this.mnsCopyAll.Click += new System.EventHandler(this.mnsCopyAll_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsReloadData,
            this.mnsClose,
            this.mnsColorGold,
            this.colorWhiteToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.mnsChangeWK,
            this.mnsCopy2});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // mnsReloadData
            // 
            this.mnsReloadData.Name = "mnsReloadData";
            this.mnsReloadData.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnsReloadData.Size = new System.Drawing.Size(193, 22);
            this.mnsReloadData.Text = "Reload Data";
            this.mnsReloadData.Click += new System.EventHandler(this.mnsReloadData_Click);
            // 
            // mnsClose
            // 
            this.mnsClose.Name = "mnsClose";
            this.mnsClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnsClose.Size = new System.Drawing.Size(193, 22);
            this.mnsClose.Text = "Close window";
            this.mnsClose.Click += new System.EventHandler(this.mnsClose_Click);
            // 
            // mnsColorGold
            // 
            this.mnsColorGold.Name = "mnsColorGold";
            this.mnsColorGold.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnsColorGold.Size = new System.Drawing.Size(193, 22);
            this.mnsColorGold.Text = "Color Gold";
            this.mnsColorGold.Click += new System.EventHandler(this.mnsColorGold_Click);
            // 
            // colorWhiteToolStripMenuItem
            // 
            this.colorWhiteToolStripMenuItem.Name = "colorWhiteToolStripMenuItem";
            this.colorWhiteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.colorWhiteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.colorWhiteToolStripMenuItem.Text = "Color White";
            this.colorWhiteToolStripMenuItem.Click += new System.EventHandler(this.btnColorWhite_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // mnsChangeWK
            // 
            this.mnsChangeWK.Name = "mnsChangeWK";
            this.mnsChangeWK.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnsChangeWK.Size = new System.Drawing.Size(193, 22);
            this.mnsChangeWK.Text = "ChangeWK";
            this.mnsChangeWK.Click += new System.EventHandler(this.mnsChangeWK_Click);
            // 
            // mnsCopy2
            // 
            this.mnsCopy2.Name = "mnsCopy2";
            this.mnsCopy2.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnsCopy2.Size = new System.Drawing.Size(193, 22);
            this.mnsCopy2.Text = "Copy2";
            this.mnsCopy2.Click += new System.EventHandler(this.mnsCopy2_Click);
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMediaUp,
            this.mnsMediaDown});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // mnsMediaUp
            // 
            this.mnsMediaUp.Name = "mnsMediaUp";
            this.mnsMediaUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.mnsMediaUp.Size = new System.Drawing.Size(207, 22);
            this.mnsMediaUp.Text = "media_up";
            this.mnsMediaUp.Click += new System.EventHandler(this.mnsMediaUp_Click);
            // 
            // mnsMediaDown
            // 
            this.mnsMediaDown.Name = "mnsMediaDown";
            this.mnsMediaDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.mnsMediaDown.Size = new System.Drawing.Size(207, 22);
            this.mnsMediaDown.Text = "media_down";
            this.mnsMediaDown.Click += new System.EventHandler(this.mnsMediaDown_Click);
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbWord.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbWord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbWord.Location = new System.Drawing.Point(0, 0);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(15, 17);
            this.lbWord.TabIndex = 1;
            this.lbWord.Text = "0";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVersion
            // 
            this.lbVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVersion.Location = new System.Drawing.Point(378, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(72, 20);
            this.lbVersion.TabIndex = 20;
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbStatus.Location = new System.Drawing.Point(311, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(67, 20);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.pnlBottom.Controls.Add(this.lbTotalWordCount);
            this.pnlBottom.Controls.Add(this.lbWordCount);
            this.pnlBottom.Controls.Add(this.lbStatus);
            this.pnlBottom.Controls.Add(this.lbVersion);
            this.pnlBottom.Controls.Add(this.lbWord);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 650);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(450, 20);
            this.pnlBottom.TabIndex = 6;
            // 
            // lbTotalWordCount
            // 
            this.lbTotalWordCount.AutoSize = true;
            this.lbTotalWordCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTotalWordCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbTotalWordCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalWordCount.Location = new System.Drawing.Point(30, 0);
            this.lbTotalWordCount.Name = "lbTotalWordCount";
            this.lbTotalWordCount.Size = new System.Drawing.Size(15, 17);
            this.lbTotalWordCount.TabIndex = 24;
            this.lbTotalWordCount.Text = "0";
            this.lbTotalWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWordCount
            // 
            this.lbWordCount.AutoSize = true;
            this.lbWordCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbWordCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbWordCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbWordCount.Location = new System.Drawing.Point(15, 0);
            this.lbWordCount.Name = "lbWordCount";
            this.lbWordCount.Size = new System.Drawing.Size(15, 17);
            this.lbWordCount.TabIndex = 23;
            this.lbWordCount.Text = "0";
            this.lbWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbWordCount.Visible = false;
            // 
            // fEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 670);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.rtxbMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.menuStripTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTitle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fEditor";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.fEditor_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlRealTime.ResumeLayout(false);
            this.pnlPrevNext.ResumeLayout(false);
            this.menuStripTitle.ResumeLayout(false);
            this.menuStripTitle.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.RichTextBox rtxbMain;
        private System.Windows.Forms.Label lbTitleChap;
        private System.Windows.Forms.Timer timerSystem;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnColorWhite;
        private System.Windows.Forms.MenuStrip menuStripTitle;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsSave;
        private System.Windows.Forms.ToolStripMenuItem mnsRenameTitle;
        private System.Windows.Forms.ToolStripMenuItem mnsNewChap;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolStripMenuItem mnsNextChap;
        private System.Windows.Forms.ToolStripMenuItem mnsPrevChap;
        private System.Windows.Forms.ToolStripMenuItem mnsReplace;
        private System.Windows.Forms.ToolStripMenuItem mnsCopyAll;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsReloadData;
        private System.Windows.Forms.ToolStripMenuItem mnsClose;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRenameChapter;
        private System.Windows.Forms.Panel pnlRealTime;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.Panel pnlPrevNext;
        private System.Windows.Forms.ToolStripMenuItem mnsColorGold;
        private System.Windows.Forms.CheckBox ckbAutoSave;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lbWordCount;
        private System.Windows.Forms.ToolStripMenuItem colorWhiteToolStripMenuItem;
        private System.Windows.Forms.Label lbTotalWordCount;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckbTo;
        private System.Windows.Forms.ToolStripMenuItem mnsChangeWK;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsMediaUp;
        private System.Windows.Forms.ToolStripMenuItem mnsMediaDown;
        private System.Windows.Forms.ToolStripMenuItem mnsCopy2;
    }
}
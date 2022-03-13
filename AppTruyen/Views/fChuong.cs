using AppTruyen.Controllers;
using AppTruyen.DTO;
using AppTruyen.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTruyen.Views
{
    public partial class fChuong : Form
    {
        #region Move Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public fChuong()
        {
            InitializeComponent();
        }

        private void fChuong_Load(object sender, EventArgs e)
        {
            //lbTitle.Text = lbTitle.Text + " [" + Genarel.NAME_TRUYEN + "]";
            dgvChuong.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgvChuong.EnableHeadersVisualStyles = false;
            dgvChuong.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold);
            dgvChuong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvChuong.RowTemplate.Height = 30;
            dgvChuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvChuong.AllowUserToResizeRows = false;
            LoadData();
        }

        private void dgvChuong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChuong.SelectedRows.Count > 0)
            {
                if(dgvChuong.CurrentRow.Cells[0].Value.ToString().Length > 0)
                {
                    GetCurrentChapter();
                }
            }
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximunsize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<DTO_Chapter> ds = Chuong.Instance.LoadData(Genarel.ID_TRUYEN);
            int count_chap_upload = 0;
            int count_chap_web = 0;
            int total_WK = 0;

            foreach (DTO_Chapter item in ds)
            {
                if (item.NameChapter.Contains("[upload]"))
                {
                    count_chap_upload++;
                }

                if (item.NameChapter.Contains(" ✓"))
                {
                    count_chap_web++;
                    total_WK += item.WordLength;
                }
            }

            lbTitle.Text = "Truyện " + Chuong.Instance.GetNameStory(Genarel.ID_TRUYEN) + " (đã đăng " + (count_chap_web) + " chương - " + Genarel.NumToText(total_WK) + ")";
            lbNewChapter.Text = " (" + (count_chap_upload) + " chương mới)";
            dgvChuong.DataSource = ds;
        }

        private void dgvChuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.dgvChuong.CurrentRow.Selected = true;
                e.Handled = true;

                if (dgvChuong.SelectedRows.Count > 0)
                {
                    if (dgvChuong.CurrentRow.Cells[0].Value.ToString().Length > 0)
                    {
                        GetCurrentChapter();
                    }
                }
            }
        }

        private void mnsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetCurrentChapter()
        {
            int num_chapter = 0;
            int.TryParse(dgvChuong.CurrentRow.Cells[2].Value.ToString(), out num_chapter);

            Genarel.ID_CHUONG = (int)dgvChuong.CurrentRow.Cells[0].Value;
            Genarel.NUM_CHUONG = num_chapter;//Convert.ToInt32(dgvChuong.CurrentRow.Cells[2].Value.ToString());
            Genarel.NAME_CHUONG = dgvChuong.CurrentRow.Cells[1].Value.ToString();

            fEditor f = new fEditor();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }

        private void newChapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddChapter f = new fAddChapter();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }
    }
}

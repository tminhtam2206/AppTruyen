using AppTruyen.Controllers;
using AppTruyen.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTruyen.Views
{
    public partial class fTruyen : Form
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

        public fTruyen()
        {
            InitializeComponent();
        }

        private void fTruyen_Load(object sender, EventArgs e)
        {
            //notifyIconAppTruyen.BalloonTipText = "App Truyện đang hoạt động";
            //notifyIconAppTruyen.ShowBalloonTip(50);

            dgvTruyen.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgvTruyen.EnableHeadersVisualStyles = false;
            dgvTruyen.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold);
            dgvTruyen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTruyen.RowTemplate.Height = 30;
            dgvTruyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTruyen.AllowUserToResizeRows = false;
            LoadData();
        }

        private void dgvTruyen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTruyen.SelectedRows.Count > 0)
            {
                if(dgvTruyen.CurrentRow.Cells[0].Value.ToString().Length > 0)
                {
                    Genarel.ID_TRUYEN = (int)dgvTruyen.CurrentRow.Cells[0].Value;
                    Genarel.NAME_TRUYEN = dgvTruyen.CurrentRow.Cells[1].Value.ToString();

                    fChuong f = new fChuong();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    LoadData();
                }
            }
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximunsize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadData()
        {
            lbTitleBar.Text = "Tàng Kinh Các " + "["+ Truyen.Instance.LoadData().Rows.Count+ " Truyện - " + Infomation.Instance.getSizeDB() + "MiB]" + Genarel.VERSION;
            dgvTruyen.DataSource = Truyen.Instance.LoadData();
        }

        private void dgvTruyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.dgvTruyen.CurrentRow.Selected = true;
                e.Handled = true;

                if (dgvTruyen.SelectedRows.Count > 0)
                {
                    if (dgvTruyen.CurrentRow.Cells[0].Value.ToString().Length > 0)
                    {
                        Genarel.ID_TRUYEN = (int)dgvTruyen.CurrentRow.Cells[0].Value;
                        Genarel.NAME_TRUYEN = dgvTruyen.CurrentRow.Cells[1].Value.ToString();

                        fChuong f = new fChuong();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        LoadData();
                    }
                }
            }
        }

        private void closeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIconAppTruyen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void mnsExit_Click(object sender, EventArgs e)
        {
            Genarel.CLOSE_FORM_TRUYEN = true;
            //Process[] workers = Process.GetProcessesByName("xampp-control");
            //foreach (Process worker in workers)
            //{
            //    worker.Kill();
            //    worker.WaitForExit();
            //    worker.Dispose();
            //}
            this.Close();
        }

        private void mnsAppTruyen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void newStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddTruyen f = new fAddTruyen();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }
    }
}

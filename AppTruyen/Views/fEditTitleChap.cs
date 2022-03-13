using AppTruyen.Controllers;
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
    public partial class fEditTitleChap : Form
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

        public fEditTitleChap()
        {
            InitializeComponent();
        }

        private void fEditTitleChap_Load(object sender, EventArgs e)
        {
            txbTitleChapter.Text = Genarel.NAME_CHUONG;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = Chuong.Instance.UpdateTitle(txbTitleChapter.Text, Genarel.GenerateSlug(txbTitleChapter.Text), Genarel.ID_CHUONG);

            if(result > 0)
            {
                Genarel.NAME_CHUONG = txbTitleChapter.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên chương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnsCheckOk_Click(object sender, EventArgs e)
        {
            string text_check = " ✓";
            string data = txbTitleChapter.Text;


            if (data.EndsWith(text_check))
            {
                txbTitleChapter.Text = data.Replace(text_check, "");
            }
            else
            {
                txbTitleChapter.Text = data + text_check;
            }
        }

        private void uploadCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txbTitleChapter.Text.EndsWith(" [upload]"))
            {
                txbTitleChapter.Text = txbTitleChapter.Text.Replace(" [upload]", "");
            }
            else
            {
                txbTitleChapter.Text = txbTitleChapter.Text + " [upload]";
            }
        }
    }
}

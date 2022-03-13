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
    public partial class fAddChapter : Form
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

        public fAddChapter()
        {
            InitializeComponent();
        }

        private void fAddChapter_Load(object sender, EventArgs e)
        {
            lbTitle.Text = lbTitle.Text + " " + Chuong.Instance.GetNumChap(Genarel.ID_TRUYEN);
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
            if(txbTitleChapter.Text.Length > 0)
            {
                int num_chap = Chuong.Instance.GetNumChap(Genarel.ID_TRUYEN);
                int result = Chuong.Instance.AddChapter(num_chap, txbTitleChapter.Text, Genarel.GenerateSlug(txbTitleChapter.Text), Genarel.ID_TRUYEN);

                if (result > 0)
                {
                    Genarel.NUM_CHUONG = num_chap;
                    Genarel.NAME_CHUONG = txbTitleChapter.Text;
                    Genarel.ID_CHUONG = Chuong.Instance.GetIdNewChapter(Genarel.ID_TRUYEN);
                    Truyen.Instance.UpdateChapter(Genarel.ID_TRUYEN);
                    Truyen.Instance.UpdateDate(Genarel.ID_TRUYEN);

                    this.Close();
                }
                else
                    MessageBox.Show("Thêm chương thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên chương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}

using AppTruyen.Models;
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
    public partial class fConnectToServer : Form
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

        public fConnectToServer()
        {
            InitializeComponent();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximunsize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.SetConnectionString(txbHost.Text, txbDatabase.Text, txbUsername.Text, txbPassword.Text);

            try
            {
                if (DataProvider.Instance.ExecuteScalar("SELECT id from taikhoan") > 0)
                {
                    fTruyen f = new fTruyen();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

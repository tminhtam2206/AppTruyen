using AppTruyen.Controllers;
using AppTruyen.Models;
using AppTruyen.Systems;
using AppTruyen.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTruyen
{
    public partial class fLogin : Form
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


        public fLogin()
        {
            InitializeComponent();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximunsize_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txbUsername.Text;
            string pass = txbPassword.Text;

            if(user == "root" & pass == "")
            {
                Genarel.CLOSE_FORM_TRUYEN = false;
                this.Hide();
                fTruyen f = new fTruyen();
                f.Show();
            }

            //DataProvider.Instance.SetConnectionString("192.168.0.105", "db_tangkinhcac_mvc", txbUsername.Text, txbPassword.Text);
            //if (DataProvider.Instance.ExecuteScalar("SELECT id from taikhoan") > 0)
            //{
                
            //}

            //try
            //{
                
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể kết nối tới server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        public static bool IsRunning(string process_name)
        {
            Process[] pname = Process.GetProcessesByName(process_name);
            if (pname.Length == 0)
                return false;
            return true;
        }

        private void mnsConnectToServer_Click(object sender, EventArgs e)
        {
            fConnectToServer f = new fConnectToServer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Genarel.CLOSE_FORM_TRUYEN == true)
            {
                Application.Exit();
            }
        }

        private void mnsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

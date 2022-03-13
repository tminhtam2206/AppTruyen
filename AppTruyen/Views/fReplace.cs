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
    public partial class fReplace : Form
    {
        private string DATA_RE = "";

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

        public fReplace()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Genarel.DATA_TEMP = DATA_RE.Replace(txbInput.Text, txbOutput.Text);
            this.Close();
        }

        #region Set Data
        [Category("Data"), Description("inputText")]
        public string inputText
        {
            set { txbInput.Text = value; }
        }

        [Category("Data"), Description("MyData")]
        public string MyData
        {
            set { DATA_RE = value; }
        }
        #endregion

        private void fReplace_Load(object sender, EventArgs e)
        {
            if (txbInput.Text.Length < 1)
                txbInput.Text = Genarel.CLIPBOARD;

            if (txbInput.Text.Length > 0) txbInput.Focus();
            else txbOutput.Focus(); 
        }
    }
}

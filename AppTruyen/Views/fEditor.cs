using AppTruyen.Controllers;
using AppTruyen.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Media;

namespace AppTruyen.Views
{
    public partial class fEditor : Form
    {
        #region Bien
        private int ID_CHAPTER          = 0;
        private int NUM_CHAPTER = 0;
        private string NAME_CHAPTER     = "";
        private string CONTENT_CHAPTER  = "";
        private DateTime time_tmp;
        private int count_time_save = 5;
        private string MD5_CHECK = "";
        private bool prevChap = false;
        private bool nextChap = false;
        private bool newChap = false;
        private bool reloadChap = false;
        private int time_hide_wordcount = 3;

        private bool check_save = false;
        private int time_check_save = 999999;
        private bool check_change_wk = true;

        private SoundPlayer player;
        #endregion

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

        public fEditor()
        {
            InitializeComponent();
        }

        private void fEditor_Load(object sender, EventArgs e)
        {
            lbVersion.Text = Genarel.ConvertVersion(Genarel.VERSION);
            time_tmp = DateTime.Now;
            LoadData();
            PlayBackgroundMusic();
        }

        private void PlayBackgroundMusic()
        {
            player = new SoundPlayer();
            player.SoundLocation = Application.StartupPath + "\\bg.wav";

            if (Genarel.PLAY_BACKGROUND)
            {
                player.PlayLooping();
            }
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ckbAutoSave.Checked = false;
            if (lbTitleChap.Text.StartsWith("*"))
            {
                if (MessageBox.Show("Bạn có muốn lưu chương này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    SaveChapter();
            }
            player.Stop();
            this.Close();
        }

        private void rtxbMain_TextChanged(object sender, EventArgs e)
        {
            if (check_change_wk)
            {
                if (Genarel.CountWords(rtxbMain.Text) <= Genarel.MAX_LENGTH)
                    lbWord.Text = Genarel.CountWords(rtxbMain.Text) + "/" + Genarel.MAX_LENGTH;
                else if (Genarel.CountWords(rtxbMain.Text) > Genarel.MAX_LENGTH && Genarel.CountWords(rtxbMain.Text) <= 2400)
                    lbWord.Text = Genarel.CountWords(rtxbMain.Text) + "/2400";
                else
                    lbWord.Text = Genarel.CountWords(rtxbMain.Text).ToString();
            }
            else lbWord.Text = Genarel.MAX_LENGTH - Genarel.CountWords(rtxbMain.Text) + "";

            CheckChapter();
            if (lbTitleChap.Text.Contains("*"))
            {
                check_save = false;
                time_check_save = 1;
            }
        }

        private void timerSystem_Tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;

            TimeSpan tx1 = current - time_tmp;

            double gio = tx1.Hours;
            double phut = tx1.Minutes;
            double giay = tx1.Seconds;

            string str_gio = gio.ToString();
            string str_phut = phut.ToString();
            string str_giay = giay.ToString();

            if (str_gio.Length == 1) str_gio = "0" + gio;
            if (str_phut.Length == 1) str_phut = "0" + phut;
            if (str_giay.Length == 1) str_giay = "0" + giay;

            lbTitleBar.Text = str_gio + " : " + str_phut + " : " + str_giay;
            CountTimeSave();

            if (ckbAutoSave.Checked)
            {
                if (time_check_save > 0)
                {
                    time_check_save--;
                    check_save = false;
                }
                else
                {
                    time_check_save = 999999;
                    check_save = true;
                }
            }

            if (ckbAutoSave.Checked && check_save)
            {
                saveFile_TXT();
                SaveChapter();
                lbTitleChap.Text = lbTitleChap.Text.Replace("*", String.Empty);
            }
        }

        private void rtxbMain_SelectionChanged(object sender, EventArgs e)
        {
            lbWordCount.Text = Genarel.CountWords(rtxbMain.SelectedText) + " từ";
            if (ckbTo.Checked) rtxbMain.SelectionColor = btnGold.BackColor;

            if (lbWordCount.Text == "0 từ")
            {
                lbWordCount.Visible = false;
            }
            else
            {
                lbWordCount.Visible = true;
            }
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            rtxbMain.SelectionColor = btnGold.BackColor;
        }

        private void btnColorWhite_Click(object sender, EventArgs e)
        {
            rtxbMain.SelectionColor = btnColorWhite.BackColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void mnsSave_Click(object sender, EventArgs e)
        {
            if (!ckbAutoSave.Checked) SaveData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewChap();
        }

        private void mnsRenameTitle_Click(object sender, EventArgs e)
        {
            RenameChapter();
        }

        private void mnsNewChap_Click(object sender, EventArgs e)
        {
            if (!ckbAutoSave.Checked)
            {
                NewChap();
                nextChap = true;
                NextChapter();
                nextChap = false;
            }   
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ckbAutoSave.Checked = false;
            nextChap = true;
            NextChapter();
            nextChap = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ckbAutoSave.Checked = false;
            prevChap = true;
            PrevChapter();
            prevChap = false;
        }

        private void mnsNextChap_Click(object sender, EventArgs e)
        {
            if (!ckbAutoSave.Checked)
            {
                ckbAutoSave.Checked = false;
                nextChap = true;
                NextChapter();
                nextChap = false;
            }   
        }

        private void mnsPrevChap_Click(object sender, EventArgs e)
        {
            if (!ckbAutoSave.Checked)
            {
                ckbAutoSave.Checked = false;
                prevChap = true;
                PrevChapter();
                prevChap = false;
            }   
        }

        private void mnsReplace_Click(object sender, EventArgs e)
        {
            Genarel.DATA_TEMP = rtxbMain.Text;

            if(rtxbMain.SelectedText.Length > 0) 
                Genarel.CLIPBOARD = rtxbMain.SelectedText;
            
            fReplace f = new fReplace();
            f.inputText = rtxbMain.SelectedText;
            f.MyData = rtxbMain.Text;
            f.ShowDialog();

            rtxbMain.Text = Genarel.DATA_TEMP;
            Genarel.DATA_TEMP = "";
        }

        private void mnsCopyAll_Click(object sender, EventArgs e)
        {
            CopyAllDataFromRichTextBox();
        }

        private void mnsReloadData_Click(object sender, EventArgs e)
        {
            reloadChap = true;
            ReloadData();
            reloadChap = false;
        }

        private void mnsClose_Click(object sender, EventArgs e)
        {
            ckbAutoSave.Checked = false;
            if (lbTitleChap.Text.StartsWith("*"))
            {
                if (MessageBox.Show("Bạn có muốn lưu chương này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    SaveChapter();
            }
            player.Stop();
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reloadChap = true;
            ReloadData();
            reloadChap = false;
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            CopyAllDataFromRichTextBox();
        }

        private void btnRenameChapter_Click(object sender, EventArgs e)
        {
            RenameChapter();
        }

        //Ham tu dinh nghia
        #region Self-define Function
        private void RenameChapter()
        {
            fEditTitleChap f = new fEditTitleChap();
            f.ShowDialog();
            NAME_CHAPTER = lbTitleChap.Text = "Chương " + NUM_CHAPTER + ": " +  Genarel.NAME_CHUONG;
        }

        private void PrevChapter()
        {
            if (lbTitleChap.Text.StartsWith("*"))
            {
                if (MessageBox.Show("Bạn có muốn lưu chương này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveChapter();
                }
            }

            DataTable data = Chuong.Instance.GetPrevChapter(Genarel.ID_TRUYEN, NUM_CHAPTER - 1);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    Genarel.ID_CHUONG = ID_CHAPTER = (int)row["id"];
                    Genarel.NUM_CHUONG = NUM_CHAPTER = (int)row["num_chap"];
                    Genarel.NAME_CHUONG = NAME_CHAPTER = row["title"].ToString();
                    CONTENT_CHAPTER = Genarel.LoadContent(row["content"].ToString());
                }

                MD5_CHECK = Genarel.CreateMD5(CONTENT_CHAPTER);
                lbTitleChap.Text = "Chương " + NUM_CHAPTER + ": " + NAME_CHAPTER;
                rtxbMain.SelectAll();
                rtxbMain.SelectionColor = btnColorWhite.BackColor;
                rtxbMain.Text = CONTENT_CHAPTER;
            }
        }

        private void NextChapter()
        {
            DataTable data = Chuong.Instance.GetNextChapter(Genarel.ID_TRUYEN, NUM_CHAPTER + 1);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    Genarel.ID_CHUONG = ID_CHAPTER = (int)row["id"];
                    Genarel.NUM_CHUONG = NUM_CHAPTER = (int)row["num_chap"];
                    Genarel.NAME_CHUONG = NAME_CHAPTER = row["title"].ToString();
                    CONTENT_CHAPTER = Genarel.LoadContent(row["content"].ToString());
                }

                MD5_CHECK = Genarel.CreateMD5(CONTENT_CHAPTER);
                lbTitleChap.Text = "Chương " + NUM_CHAPTER + ": " + NAME_CHAPTER;
                rtxbMain.SelectAll();
                rtxbMain.SelectionColor = btnColorWhite.BackColor;
                rtxbMain.Text = CONTENT_CHAPTER;
            }
        }

        private void CheckChapter()
        {
            if (newChap == false)
            {
                string md5_current = Genarel.CreateMD5(rtxbMain.Text);

                if (MD5_CHECK != md5_current)
                {
                    string check = "*";
                    if (!lbTitleChap.Text.StartsWith(check))
                        lbTitleChap.Text = "*" + lbTitleChap.Text;
                }
                else
                    lbTitleChap.Text = lbTitleChap.Text.Replace("*", String.Empty);
            }

            if (prevChap == true || nextChap == true)
            {
                lbTitleChap.Text = lbTitleChap.Text.Replace("*", String.Empty);
            }
        }

        private void CopyAllDataFromRichTextBox()
        {
            string titile_tmp = lbTitleChap.Text.Replace(" [upload]", "").Replace(" ✓", "") + "\n";
            Clipboard.SetText(titile_tmp + rtxbMain.Text);
            lbStatus.Text = "Copied";
        }

        private void NewChap()
        {
            newChap = true;
            SaveData();
            rtxbMain.Clear();

            fAddChapter f = new fAddChapter();
            this.Hide();
            f.ShowDialog();
            this.Show();
            newChap = false;
            ReloadData();
        }

        private void ReloadData()
        {
            if (!newChap)
            {
                if (lbTitleChap.Text.StartsWith("*"))
                {
                    if (MessageBox.Show("Bạn có muốn lưu chương này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SaveChapter();
                    }
                }
            }

            //ID_CHAPTER = Genarel.ID_CHUONG;
            //NUM_CHAPTER = Genarel.NUM_CHUONG;
            //NAME_CHAPTER = Genarel.NAME_CHUONG;
            //lbTitleChap.Text = "Chương " + NUM_CHAPTER + ": " + NAME_CHAPTER;
            getSizeDB();
            rtxbMain.Text = CONTENT_CHAPTER;
        }

        private void CountTimeSave()
        {
            if (count_time_save <= 0)
            {
                lbStatus.Text = "";
                count_time_save = 5;
            }

            if(lbStatus.Text.Length > 0)
                count_time_save--;
        }

        private void SaveChapter()
        {
            int id_chap = ID_CHAPTER;
            string content = rtxbMain.Text;
            string[] arr_wk = lbWord.Text.Split('/');
            int wk = (arr_wk.Length == 2) ? Int32.Parse(arr_wk[0]) : (2000 - Int32.Parse(arr_wk[0]));

            new Thread(()=> {
                if (Chuong.Instance.UpdateData(id_chap, content, wk) > 0)
                {
                    lbStatus.Invoke(new Action(()=> {
                        lbStatus.Text = "đã lưu";
                    }));
                    Truyen.Instance.UpdateDate(Genarel.ID_TRUYEN);
                    CONTENT_CHAPTER = content;
                    MD5_CHECK = Genarel.CreateMD5(CONTENT_CHAPTER);
                    Truyen.Instance.UpdateWordCount(Genarel.ID_TRUYEN);
                }
                else
                {
                    lbStatus.Invoke(new Action(() => {
                        lbStatus.Text = "Lỗi";
                    }));
                }

                getSizeDB();
            }) { IsBackground = true }.Start();
        }

        private void SaveData()
        {
            saveFile_TXT();

            if (newChap) SaveChapter();
            else
            {
                if (rtxbMain.Text.Length <= 100)
                {
                    if (MessageBox.Show("Chương dưới 100 ký tự?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        SaveChapter();
                }
                else SaveChapter();
            }

            
            lbTitleChap.Text = lbTitleChap.Text.Replace("*", String.Empty);
        }

        private void LoadData()
        {
            DataTable data = Chuong.Instance.GetChapter(Genarel.ID_CHUONG);

            foreach (DataRow row in data.Rows)
            {
                ID_CHAPTER = (int)row["id"];
                NUM_CHAPTER = (int)row["num_chap"];
                NAME_CHAPTER = row["title"].ToString();
                CONTENT_CHAPTER = Genarel.LoadContent(row["content"].ToString());
                MD5_CHECK = Genarel.CreateMD5(CONTENT_CHAPTER);
            }

            Genarel.NAME_CHUONG = NAME_CHAPTER;
            lbTitleChap.Text = "Chương " + NUM_CHAPTER + ": " + NAME_CHAPTER;
            getSizeDB();
            rtxbMain.Text = CONTENT_CHAPTER;
        }

        private void getSizeDB()
        {
            lbTotalWordCount.Text = "[Tổng " + Genarel.NumToText(Truyen.Instance.GetWordCount(Genarel.ID_TRUYEN)) + "]";
        }
        #endregion

        private void mnsColorGold_Click(object sender, EventArgs e)
        {
            rtxbMain.SelectionColor = btnGold.BackColor;
        }

        //donwload txt
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile_TXT();
        }

        private void saveFile_TXT()
        {
            string current_time_save = " (" + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ")";
            string name_save = Application.StartupPath + "//data//" + "["+ Genarel.NAME_TRUYEN + "] " + lbTitleChap.Text.Replace(":", " - ").Replace(" ✓", "").Replace("*", "") + current_time_save + ".txt";
            string data = rtxbMain.Text + "\n\n Số chữ: " + Genarel.CountWords(rtxbMain.Text);

            new Thread(()=> {
                File.WriteAllText(name_save, data);
            }) { IsBackground = true }.Start();
            
        }

        private void mnsChangeWK_Click(object sender, EventArgs e)
        {
            if (check_change_wk)
            {
                check_change_wk = false;
                lbWord.Text = Genarel.MAX_LENGTH - Genarel.CountWords(rtxbMain.Text) + "";
            }
            else
            {
                check_change_wk = true;
                lbWord.Text = Genarel.CountWords(rtxbMain.Text) + "/" + Genarel.MAX_LENGTH;
            }
        }

        private void mnsMediaUp_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
            Genarel.PLAY_BACKGROUND = true;
        }

        private void mnsMediaDown_Click(object sender, EventArgs e)
        {
            player.Stop();
            Genarel.PLAY_BACKGROUND = false;
        }

        private void mnsCopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxbMain.Text);
            lbStatus.Text = "Copied";
        }

        private void ckbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoSave.Checked)
            {
                btnSave.Enabled = false;
                btnNew.Enabled = false;
                btnPrev.Enabled = btnNext.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                btnNew.Enabled = true;
                btnPrev.Enabled = btnNext.Enabled = true;
            }
        }
    }
}

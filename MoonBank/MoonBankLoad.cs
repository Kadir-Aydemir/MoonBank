using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MoonBank.Properties;
using System.Xml;
using System.Media;

namespace MoonBank
{
    public partial class MoonBankLoad : Form
    {
        public MoonBankLoad()
        {
            InitializeComponent();
            PbProfileImageSet.AllowDrop = true;
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void moveimagebox(object sender)
        {
            Guna2Button B = (Guna2Button)sender;
            imageslide.Location = new Point(B.Location.X + 25, B.Location.Y - 25);
            imageslide.SendToBack();
        }
        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            HomeUserControl1 huc = new HomeUserControl1();
            huc.numara = lblNumber.Text;
            addUserControl(huc);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.100;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }
        public string number;
        int alimsayisi;
        int durum;
        void gelen()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select ID,GONDEREN,TUTAR,SAAT,AYADI,GUN,ARTAN,TARIH from HAREKETLER where ALICI='" + number + "'", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            DataGridView1Gelen.DataSource = dt2;
            durum = (DataGridView1Gelen.Rows.Count - 1);
            // lblcountsetting.Text = alimsayisi.ToString();
        }
        private void MoonBankLoad_Load(object sender, EventArgs e)
        {           
            SqlCommand komut = new SqlCommand("select * from KISILER where HESAPNO='" + number + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {               
                PbProfileImagee.ImageLocation = dr[8].ToString();
                lblNumber.Text = dr[5].ToString();
                lbladsoyad.Text = "Welcome, " + dr[1] + " " + dr[2];
            }
            bgl.baglanti().Close();

            //gelen hareket bildirimi için
            gelen();
            alimsayisi = (DataGridView1Gelen.Rows.Count - 1);
            timer4.Start();
            ToggleSwitchNotifications.Checked = Settings1.Default.Notify;

            HomeUserControl1 huc = new HomeUserControl1();
            huc.numara = lblNumber.Text;
            addUserControl(huc);
        }      

        private void btnMenu_CheckedChanged(object sender, EventArgs e)
        {            
            if (btnMenu.Checked)
            {
                timer2.Start();                
            }
            else
            {
                timer3.Start();
                imageslide.Visible = true;
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            btnMenu.Enabled = false;
            panelMenu.Height = panelMenu.Height - 10;
            if (panelMenu.Height <= 120)
            {
                timer2.Stop();
                imageslide.Visible = false;
                btnMenu.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            btnMenu.Enabled = false;
            panelMenu.Height = panelMenu.Height + 10;
            if (panelMenu.Height >= 551)
            {
                timer3.Stop();
                btnMenu.Enabled = true;
            }
        }

        private void btnSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSetting.Checked)
            {
                btnNotify.Checked = false;
                PbProfileImageSet.ImageLocation = (Application.StartupPath + "//picture//dragdrop.png");
                PanelSetting.Visible = true;
                PanelSetting.BringToFront();
                pbset.Visible = true;
            }
            else
            {
                PanelSetting.Visible = false;
                PanelSetting.SendToBack();
                pbset.Visible = false;
                pbset.SendToBack();
            }
        }

        private void btnNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNotify.Checked)
            {
                btnSetting.Checked = false;
                PanelNotify.Visible = true;
                pbnotify.Visible = true;
                PanelNotify.BringToFront();                              
            }
            else
            {
                pbnotify.Visible = false;
                PanelNotify.Visible = false;
                PanelNotify.SendToBack();
                pbnotify.SendToBack();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferUserControl1 tuc = new TransferUserControl1();
            tuc.numara = lblNumber.Text;
            addUserControl(tuc);
        }

        private void btnAccountSetting_CheckedChanged(object sender, EventArgs e)
        {
            moveimagebox(sender);
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            ActivitiesUserControl1 auc = new ActivitiesUserControl1();
            auc.numara = lblNumber.Text;
            addUserControl(auc);
            btnActivities.FillColor = Color.FromArgb(53, 41, 123);
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            SettingUserControl1 suc = new SettingUserControl1();
            suc.numara = lblNumber.Text;
            addUserControl(suc);
        }

        Image img;
        private void PbProfileImageSet_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                img= Image.FromFile(pic);
                PbProfileImageSet.Image = img;
            }
        }

        private void PbProfileImageSet_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                string fotoyolu = Application.StartupPath + "//picture//" + number + ".jpg";
                img.Save(fotoyolu);
                SqlCommand komut = new SqlCommand("update KISILER set FOTO='" + fotoyolu + "' where HESAPNO='" + number + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                PbProfileImagee.Image = img;
                
                using (MsgBox ms = new MsgBox())
                {
                    ms.lblInfo.Text = "Your photo has been successfully\n                      updated.";
                    ms.ShowDialog();
                    if (ms.DialogResult == DialogResult.OK)
                    {
                        PbProfileImageSet.Image = Resources.drag_and_drop_icon;
                        img = null;
                    }
                }
            }
            else
            {            
                using (MsgBox ms = new MsgBox())
                {
                    ms.lblInfo.Text = "Please, select a photo file.";
                    ms.pbicon.Image = Resources.icons8_error_cloud_96px;
                    ms.ShowDialog();        
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG(*.JPG)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string dosya = ofd.FileName;
                img = Image.FromFile(dosya);
                PbProfileImageSet.Image = img;
            }
        }
        public void Alert()
        {
            Alert fr = new Alert();
            fr.showAlert();
        }
        int sayac = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 100)
            {
                if (Settings1.Default.Notify == true)
                {
                    gelen();
                    if (alimsayisi < durum)
                    {
                        this.Alert();
                        btnActivities.FillColor = Color.Firebrick;
                        SoundPlayer sd= new SoundPlayer(@"messagetone.wav");
                        sd.Play();
                        alimsayisi = (DataGridView1Gelen.Rows.Count - 1);
                       
                    }
                    if (alimsayisi > durum)
                    {
                        alimsayisi = (DataGridView1Gelen.Rows.Count - 1);
                    }
                }
                sayac = 0;
            }
        }

        private void ToggleSwitchNotifications_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitchNotifications.Checked)
            {
                Settings1.Default.Notify = Convert.ToBoolean("True");
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.Notify = Convert.ToBoolean("False");
                Settings1.Default.Save();
            }           
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btninstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/kadir.aay");
        }

        private void btnfacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100067922795777");
        }

        private void btntwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/kadiraYdemir0");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbProfileImagee_Click(object sender, EventArgs e)
        {
            if (btnSetting.Checked == false)
            {
                btnSetting.Checked = true;
            }
            else
            {
                btnSetting.Checked = false;
            }
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Kadir-Aydemir");
        }
    }
}

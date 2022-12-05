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
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace MoonBank
{
    public partial class PasswordUserControl1 : UserControl
    {
        public PasswordUserControl1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnCheckit_Click(object sender, EventArgs e)
        {
            clean();
            if (txtAccountNumber.Text != "")
            {
                SqlCommand komut = new SqlCommand("select MAIL,SIFRE from KISILER where HESAPNO=" + txtAccountNumber.Text, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    btnCheckit.Visible = false;
                    btnSendMail.Visible = true;
                    txtMail.Visible = true;
                    lblempty.Visible = false;
                    lblaccount.Visible = false;
                    txtMail.Text = dr[0].ToString();
                    lblsifre.Text = dr[1].ToString();
                }
                else
                {
                    lblaccount.Visible = true;
                }
            }
            else
            {
                lblempty.Visible = true;
            }
        }
        void clean()
        {
            btnSendMail.Visible = false;
            btnVerify.Visible = false;
            CircleProgressBar1.Visible = false;
            CircleProgressBar1.Value = 100;
            txtMail.Visible = false;
            txtMail.Clear();
            lblempty.Visible = false;
            txtVerify.Visible = false;
            txtVerify.Clear();
            lblmailsent.Visible = false;
            lblaccount.Visible = false;
            lbltimeup.Visible = false;
            btnCheckit.Visible = true;
        }
        Random rdm = new Random();
        int sayi;
       
        int sayac = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            CircleProgressBar1.Value = sayac;            
            if (sayac == 5)
            {
                lblmailsent.Visible = false;
                lbltimeup.Visible = true;
                lbltimeup.BringToFront();
            }
            if (sayac == 0)
            {
                timer1.Stop();
                clean();
                sayac = 100;
                this.SendToBack();
                this.Visible=false;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text == sayi.ToString())
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                string kime = txtMail.Text;
                string konu = "Your Moon Bank account information";
                string icerik = "Your information is safe with us.\n Account password is: " + lblsifre.Text;

                sc.Credentials = new NetworkCredential("aydemirsoftware@gmail.com", "191119ea");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("aydemirsoftware@gmail.com", "AYDEMİR YAZILIM");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);               
                this.SendToBack();
                this.Visible = false;
            }
            else
            {
                txtVerify.BorderColor = Color.Red;
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                sayi = rdm.Next(10000, 99999);
                string kime = txtMail.Text;
                string konu = "Your Moon Bank account verify!";
                string icerik = "Your information is safe with us.\n Verification Code is: " + sayi.ToString();

                sc.Credentials = new NetworkCredential("aydemirsoftware@gmail.com", "191119ea");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("aydemirsoftware@gmail.com", "AYDEMİR YAZILIM");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);
                lblmailsent.Visible = true;
                btnSendMail.Visible = false;
                btnVerify.Visible = true;
                CircleProgressBar1.Visible = true;
                txtVerify.Visible = true;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

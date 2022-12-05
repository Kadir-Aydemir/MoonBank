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

namespace MoonBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
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
        private void Init_Data()
        {
            if (Settings1.Default.Accountnumber != string.Empty)
            {
                if (Settings1.Default.Remember == true)
                {
                    txtAccountNumber.Text = Settings1.Default.Accountnumber;
                    ToggleSwitchRemember.Checked = true;
                    txtAccountNumber.TabIndex = 3;
                    txtAccountPassword.TabIndex=1;
                    btnLogin.TabIndex = 2;
                }
                else
                {
                    txtAccountNumber.Clear();
                    txtAccountNumber.PlaceholderText = "Account Number";
                }
            }
        }
        private void Save_Data()
        {
            if (ToggleSwitchRemember.Checked)
            {
                Settings1.Default.Accountnumber = txtAccountNumber.Text.Trim();
                Settings1.Default.Remember = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.Accountnumber = "";
                Settings1.Default.Remember = false;
                Settings1.Default.Save();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            passwordUserControl11.SendToBack();
            passwordUserControl11.Visible = false;
            applyUserControl11.SendToBack();
            applyUserControl11.Visible = false;
            btnApplyNow.BringToFront();
            linkLabelPassword.BringToFront();
            lblbecome.BringToFront();
            label6.BringToFront();
            ToggleSwitchRemember.BringToFront();
            label1.BringToFront();
            lblwrong.BringToFront();
            txtAccountNumber.BringToFront();
            txtAccountPassword.BringToFront();
            btnBack.Visible = false;
        }

        private void linkLabelPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordUserControl11.BringToFront();
            passwordUserControl11.Visible = true;
            applyUserControl11.SendToBack();
            applyUserControl11.Visible = false;
            btnApplyNow.SendToBack();
            linkLabelPassword.SendToBack();
            lblbecome.SendToBack();
            label6.SendToBack();
            ToggleSwitchRemember.SendToBack();
            label1.SendToBack();
            lblwrong.SendToBack();
            txtAccountNumber.SendToBack();
            txtAccountPassword.SendToBack();
            btnBack.Visible = true;
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {
            passwordUserControl11.SendToBack();
            passwordUserControl11.Visible = false;
            applyUserControl11.BringToFront();
            applyUserControl11.Visible = true;
            btnApplyNow.SendToBack();
            linkLabelPassword.SendToBack();
            lblbecome.SendToBack();
            label6.SendToBack();
            ToggleSwitchRemember.SendToBack();
            label1.SendToBack();
            lblwrong.SendToBack();
            txtAccountNumber.SendToBack();
            txtAccountPassword.SendToBack();
            btnBack.Visible = true;
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblback.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblback.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from KISILER where HESAPNO=@P1 and SIFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAccountNumber.Text);
            komut.Parameters.AddWithValue("@P2", txtAccountPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Save_Data();               
                MoonBankLoad mbl = new MoonBankLoad();
                mbl.number = txtAccountNumber.Text;
                mbl.Show();
                this.Hide();
            }
            else
            {
                lblwrong.Visible = true;
            }
            bgl.baglanti().Close();
        }     
    }
}

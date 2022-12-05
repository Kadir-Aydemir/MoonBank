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
using Guna.UI2.WinForms;

namespace MoonBank
{
    public partial class SettingUserControl1 : UserControl
    {
        public SettingUserControl1()
        {
            InitializeComponent();
        }
        public string numara;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnPhone_Click(object sender, EventArgs e)
        {           
            SqlCommand komut = new SqlCommand("select TELEFON from KISILER where HESAPNO='" + numara + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                mskTel.Text = dr[0].ToString();
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {            
            SqlCommand komut = new SqlCommand("select MAIL from KISILER where HESAPNO='" + numara + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMail.Text = dr[0].ToString();
            }
        }

        private void btnShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                txtCurrentPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtNewPassAgain.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtNewPassAgain.UseSystemPasswordChar = true;
            }
        }
        string pass;
        private void btnPassNext_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select SIFRE from KISILER where HESAPNO='" + numara + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if(txtCurrentPass.Text!=""&& txtNewPass.Text != ""&& txtNewPassAgain.Text != "")
                {
                    lblEnterPass.Visible = false;
                    pass = dr[0].ToString();
                    if (txtCurrentPass.Text == pass)
                    {
                        lblPasswordCurrent.Visible = false;
                        if (txtNewPass.Text == txtNewPassAgain.Text)
                        {
                            lblPasswordNew.Visible = false;
                            SqlCommand komut1 = new SqlCommand("update KISILER set SIFRE='" + txtNewPass.Text + "' where HESAPNO='" + numara + "'", bgl.baglanti());
                            komut1.ExecuteNonQuery();
                            bgl.baglanti().Close();
                            
                            using (MsgBox ms = new MsgBox())
                            {
                                ms.lblInfo.Text = "Your password has been successfully\n                       changed.";
                                ms.ShowDialog();
                                if (ms.DialogResult == DialogResult.OK)
                                {
                                    txtCurrentPass.Clear();
                                    txtNewPass.Clear();
                                    txtNewPassAgain.Clear();
                                }
                            }
                        }
                        else
                        {
                            lblPasswordNew.Visible = true;
                            lblPasswordNew.BringToFront();
                            lblEnterPass.Visible = false;
                            lblPasswordCurrent.Visible = false;
                        }
                    }
                    else
                    {
                        lblPasswordCurrent.Visible = true;
                        lblPasswordCurrent.BringToFront();
                        lblEnterPass.Visible = false;
                        lblPasswordNew.Visible = false;
                    }
                }
                else
                {
                    lblEnterPass.Visible = true;
                    lblEnterPass.BringToFront();
                    lblPasswordNew.Visible = false;
                    lblPasswordCurrent.Visible = false;
                }
            }
        }

        private void btnPhoneNext_Click(object sender, EventArgs e)
        {
            if (mskNewTel.Text != "" && mskNewTel.Text!= "(   )    -")
            {
                lblPhoneEnter.Visible = false;
                SqlCommand komut = new SqlCommand("update KISILER set TELEFON='" + mskNewTel.Text + "' where HESAPNO='" + numara + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                
                using (MsgBox ms = new MsgBox())
                {
                    ms.lblInfo.Text = "Your Phone has been successfully\n                         changed.";
                    ms.ShowDialog();
                    if (ms.DialogResult == DialogResult.OK)
                    {
                        mskTel.Text = mskNewTel.Text;
                        mskNewTel.Clear();
                    }
                }
            }
            else
            {
                lblPhoneEnter.Visible = true;
            }
        }

        private void btnMailNext_Click(object sender, EventArgs e)
        {
            if (txtNewMail.Text != "")
            {
                lblMailEnter.Visible = false;
                SqlCommand komut = new SqlCommand("update KISILER set MAIL='" + txtNewMail.Text + "' where HESAPNO='" + numara + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                
                using (MsgBox ms = new MsgBox())
                {
                    ms.lblInfo.Text = "Your E-Mail has been successfully\n                       changed.";
                    ms.ShowDialog();
                    if (ms.DialogResult == DialogResult.OK)
                    {
                        txtMail.Text = txtNewMail.Text;
                        txtNewMail.Clear();
                    }
                }
            }
            else
            {
                lblMailEnter.Visible = true;
            }
        }
        private void moveimagebox(object sender)
        {
            Guna2GradientButton B = (Guna2GradientButton)sender;
            imageslide.Left = B.Left;
        }

        private void btnPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            moveimagebox(sender);
            if (btnMail.Checked)
            {
                PanelMail.Visible = true;
                PanelMail.BringToFront();
            }
            else
            {
                PanelMail.Visible = false;
                PanelMail.SendToBack();
            }
            if (btnPassword.Checked)
            {
                PanelPassword.Visible = true;
                PanelPassword.BringToFront();
            }
            else
            {
                PanelPassword.Visible = false;
                PanelPassword.SendToBack();
            }
            if (btnPhone.Checked)
            {
                PanelPhone.Visible = true;
                PanelPhone.BringToFront();
            }
            else
            {
                PanelPhone.Visible = false;
                PanelPhone.SendToBack();
            }
        }

    }
}

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
    public partial class ApplyUserControl1 : UserControl
    {
        public ApplyUserControl1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked == true)
            {
                lblaccept.ForeColor = Color.Black;
            }
            if (guna2CustomCheckBox1.Checked == false)
            {
                lblaccept.ForeColor = Color.Red;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked == true)
            {
                if (txtPassword.Text == txtRePassword.Text)
                {
                    if(txtPassword.Text != "" && txtFistname.Text != "" && txtLastname.Text != "" && txtTC.Text != "" && txtPhone.Text != "" && txtMail.Text != "" && txtAccountNumber.Text != "" && txtRePassword.Text != "")
                    {
                        SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE,MAIL,FOTO) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", txtFistname.Text);
                        komut.Parameters.AddWithValue("@p2", txtLastname.Text);
                        komut.Parameters.AddWithValue("@p3", txtTC.Text);
                        komut.Parameters.AddWithValue("@p4", txtPhone.Text);
                        komut.Parameters.AddWithValue("@p5", txtAccountNumber.Text);
                        komut.Parameters.AddWithValue("@p6", txtPassword.Text);
                        komut.Parameters.AddWithValue("@p7", txtMail.Text);
                        komut.Parameters.AddWithValue("@p8", Application.StartupPath + "\\picture\\default.png");
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();

                        SqlCommand komut2 = new SqlCommand("insert into HESAP (HESAPNO) values (@p1)", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@p1", txtAccountNumber.Text);
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();

                        btnApply.Enabled = false;
                        lblsuccessfully.Visible = true;
                        lblpassword.Visible = false;
                        lblblank.Visible = false;
                    }
                    else
                    {
                        lblpassword.Visible = false;
                        lblblank.Visible = true;
                    }
                }
                else
                {
                    lblpassword.Visible = true;
                    lblblank.Visible = false;
                }
            }
            else
            {
                lblaccept.ForeColor = Color.Red;
            }           
        }
        bool durum;
        int sayi;
        void mukerrer()
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(100000, 1000000);
            SqlCommand komut = new SqlCommand("select * from KISILER where HESAPNO=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sayi.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            bgl.baglanti().Close();
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                txtAccountNumber.Text = sayi.ToString();
            }
            else
            {
                for (durum = false; durum == true;)
                {
                    mukerrer();
                    if (durum == true)
                    {
                        txtAccountNumber.Text = sayi.ToString();
                    }
                }
            }                       
        }
    }
}

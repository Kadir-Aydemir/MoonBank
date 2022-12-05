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
    public partial class TransferUserControl1 : UserControl
    {
        public TransferUserControl1()
        {
            InitializeComponent();
        }
        public string numara;
        private void TransferUserControl1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SqlDataAdapter da = new SqlDataAdapter("select KAYITAD,HESAPALICI from KAYIT where HESAPSAHIP='" + numara+"'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridView1.DataSource = dt;            
            KayitPanel();
            songonderilen();
            balance();
            sikgonderilen();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRegistered.Checked)
            {
                btnRegistered.BringToFront();
                PanelNewBuyer.SendToBack();
                PanelNewBuyer.Visible=false;
                PanelRegistered.BringToFront();
                PanelRegistered.Visible = true;
            }            
        }

        private void btnNewBuyer_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNewBuyer.Checked)
            {
                btnNewBuyer.BringToFront();
                PanelRegistered.SendToBack();
                PanelRegistered.Visible = false;
                PanelNewBuyer.BringToFront();
                PanelNewBuyer.Visible = true;
            }
        }
        void isimgetir(string hesapno)
        {
            SqlCommand komut = new SqlCommand("select * from KISILER where HESAPNO='" + hesapno + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAlıcıadsoyad.Text = dr[1] + " " + dr[2];
            }
        }
        private void btnNewContinue_Click(object sender, EventArgs e)
        {
            if(txtAccountNumber.Text!="" && txtAccountNumber.TextLength==6 && txtName.Text != "")
            {
                SqlCommand komut1 = new SqlCommand("select * from KISILER where HESAPNO='" + txtAccountNumber.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    if (ToggleSwitchRegister.Checked)
                    {
                        SqlCommand komut = new SqlCommand("insert into KAYIT (HESAPSAHIP,HESAPALICI,KAYITAD) values (@p1,@p2,@p3)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", numara);
                        komut.Parameters.AddWithValue("@p2", txtAccountNumber.Text);
                        komut.Parameters.AddWithValue("@p3", txtName.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        KayitPanel();
                        CircleButton1.Visible = false;
                        pb1.BringToFront();
                        btnback1.Visible = true;
                        CircleButton2.ForeColor = Color.White;
                        CircleButton2.FillColor = Color.Firebrick;
                        PanelRegistered.Visible = false;
                        PanelNewBuyer.Visible = false;
                        PanelPrice.Visible = true;
                        btnNewBuyer.Visible = false;
                        btnRegistered.Visible = false;
                        lblsecilenalıcı.Text = txtAccountNumber.Text;
                        isimgetir(txtAccountNumber.Text);
                    }
                    else
                    {
                        CircleButton1.Visible = false;
                        pb1.BringToFront();
                        btnback1.Visible = true;
                        CircleButton2.ForeColor = Color.White;
                        CircleButton2.FillColor = Color.Firebrick;
                        PanelRegistered.Visible = false;
                        PanelNewBuyer.Visible = false;
                        PanelPrice.Visible = true;
                        btnNewBuyer.Visible = false;
                        btnRegistered.Visible = false;
                        lblsecilenalıcı.Text = txtAccountNumber.Text;
                        isimgetir(txtAccountNumber.Text);
                    }
                }
                else
                {
                    lblblank.Visible = false;
                    lblnotfound.Visible = true;
                    lblnotfound.BringToFront();
                }
            }
            else
            {
                lblnotfound.Visible = false;
                lblblank.Visible = true;
                lblblank.BringToFront();
            }
        }
        private void KayitPanel()
        {
            PanelRegistered.Controls.Clear();
            for(int i = 1; i < DataGridView1.RowCount; i++)
            {
                Guna2GradientButton btn = new Guna2GradientButton();
                btn.Name = DataGridView1.Rows[i - 1].Cells[1].Value.ToString();
                btn.Text = DataGridView1.Rows[i - 1].Cells[0].Value.ToString() + "\nTR" + DataGridView1.Rows[i - 1].Cells[1].Value.ToString() + " / TL";
                btn.Size = new Size(200, 64);
                btn.Location = new Point(12, ((i-1) * 76) + 12);
                btn.BorderThickness = 1;
                btn.BackColor = Color.Transparent;
                btn.BorderRadius = 12;
                btn.FillColor = Color.FromArgb(178, 8, 55);
                btn.FillColor2 = Color.FromArgb(255, 159, 1);
                Font eski = btnRegistered.Font;
                btn.Font = new Font(eski.FontFamily, eski.Size, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.TextAlign= HorizontalAlignment.Left;
                btn.UseTransparentBackground = true;
                btn.Animated = true;
                btn.Cursor = Cursors.Hand;
                btn.Click += Btn_Click;
                PanelRegistered.AutoScroll = true;
                PanelRegistered.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            CircleButton1.Visible = false;
            pb1.Visible = true;
            pb1.BringToFront();
            btnback1.Visible = true;
            CircleButton2.ForeColor = Color.White;
            CircleButton2.FillColor = Color.Firebrick;
            PanelRegistered.Visible = false;
            PanelNewBuyer.Visible = false;
            PanelPrice.Visible = true;
            btnNewBuyer.Visible = false;
            btnRegistered.Visible = false;
            Guna2GradientButton btn = (sender as Guna2GradientButton);
            lblsecilenalıcı.Text = btn.Name;
            isimgetir(lblsecilenalıcı.Text);
        }
        void back1()
        {
            CircleButton1.Visible = true;
            CircleButton1.BringToFront();
            btnback1.Visible = false;
            CircleButton2.ForeColor = Color.Black;
            CircleButton2.FillColor = Color.Silver;
            PanelRegistered.Visible = true;
            PanelNewBuyer.Visible = true;
            PanelPrice.Visible = false;
            btnNewBuyer.Visible = true;
            btnRegistered.Visible = true;
        }
        private void btnback1_Click(object sender, EventArgs e)
        {
            back1();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();
            lblAyAdı.Text = DateTime.Now.ToString("MMM");
            lblGun.Text = DateTime.Now.ToString("dd");
        }

        private void btnLastAmount_Click(object sender, EventArgs e)
        {
            lblAmount.Text = lblLastAmount.Text;
            lblincorrect.Visible = false;
            CircleButton2.Visible = false;
            pb2.BringToFront();
            btnback1.Visible = false;
            btnback2.Visible = true;
            CircleButton3.ForeColor = Color.White;
            CircleButton3.FillColor = Color.Firebrick;
            PanelPrice.Visible = false;
            PanelSonuc.Visible = true;
        }

        private void btnAnotherAmount_Click(object sender, EventArgs e)
        {
            if (mskDeger.Text != "" && mskKusurat.Text != "")
            {
                lblincorrect.Visible = false;
                lblAmount.Text = mskDeger.Text + "," + mskKusurat.Text;
                CircleButton2.Visible = false;
                pb2.BringToFront();
                btnback1.Visible = false;
                btnback2.Visible = true;
                CircleButton3.ForeColor = Color.White;
                CircleButton3.FillColor = Color.Firebrick;
                PanelPrice.Visible = false;
                PanelSonuc.Visible = true;
            }
            else
            {
                lblincorrect.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double bakiye, tutar,artan;
            bakiye = double.Parse(lblprice.Text);
            tutar = double.Parse(lblAmount.Text);

            SqlCommand komut4 = new SqlCommand("select BAKIYE from HESAP where HESAPNO='" + lblsecilenalıcı.Text + "'", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblartan.Text = dr4[0].ToString();
            }
            artan = double.Parse(lblartan.Text);
            if(bakiye >= tutar)
            {
                // hareketler
                SqlCommand komut = new SqlCommand("insert into HAREKETLER (GONDEREN,ALICI,TUTAR,TARIH,SAAT,AYADI,GUN,KALAN,ARTAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", numara);
                komut.Parameters.AddWithValue("@p2", lblsecilenalıcı.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(lblAmount.Text));
                komut.Parameters.AddWithValue("@p4", Convert.ToDateTime(lbltarih.Text));
                komut.Parameters.AddWithValue("@p5", lblsaat.Text);
                komut.Parameters.AddWithValue("@p6", lblAyAdı.Text);
                komut.Parameters.AddWithValue("@p7", lblGun.Text);
                komut.Parameters.AddWithValue("@p8", bakiye-(tutar+0.60));
                komut.Parameters.AddWithValue("@p9", artan +tutar);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // hesap
                SqlCommand komut2 = new SqlCommand("update HESAP set BAKIYE=BAKIYE+@a1 where HESAPNO='"+lblsecilenalıcı.Text+"'", bgl.baglanti());
                komut2.Parameters.AddWithValue("@a1", decimal.Parse(lblAmount.Text));
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                SqlCommand komut3 = new SqlCommand("update HESAP set BAKIYE=BAKIYE-@g1 where HESAPNO='" + numara + "'", bgl.baglanti());
                komut3.Parameters.AddWithValue("@g1",(tutar+0.60));
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                CircleButton3.Visible = false;
                pb3.BringToFront();
                btnback2.Visible = false;
                songonderilen();
                balance();
                KayitPanel();
                sikgonderilen();
               
                using(MsgBox ms=new MsgBox())
                {
                    ms.lblInfo.Text = "Your transaction has been completed.";
                    ms.ShowDialog();
                    if (ms.DialogResult == DialogResult.OK)
                    {
                        back1();
                        back2();
                        PanelPrice.Visible = false;
                        btnback1.Visible = false;
                        CircleButton1.Visible = true;
                        CircleButton1.BringToFront();
                        CircleButton3.Visible = true;
                        CircleButton3.BringToFront();
                    }
                }
            }
            else
            {
                if( MessageBox.Show("Insufficient balance ! \nPlease check the amount to send or cancel the transaction", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    back2();
                }
                else
                {
                    back1();
                    back2();
                    PanelPrice.Visible = false;
                    pb1.Visible = false;
                    CircleButton3.BringToFront();
                }
            }
        }
        void sikgonderilen()
        {
            SqlCommand komut2 = new SqlCommand("SELECT TOP 1 TUTAR FROM HAREKETLER WHERE GONDEREN='" + numara + "' group by TUTAR ORDER BY COUNT(*) DESC ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblsikkullanilan.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();
        }
        public void balance()
        {
            SqlCommand komut = new SqlCommand("select * from HESAP where HESAPNO='" + numara + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblprice.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();          
        }
        void songonderilen()
        {
            SqlCommand komut = new SqlCommand("SELECT top 1 TUTAR FROM HAREKETLER where GONDEREN='" + numara + "' order by ID DESC", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblLastAmount.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void back2()
        {
            CircleButton2.Visible = true;
            CircleButton2.BringToFront();
            btnback2.Visible = false;
            btnback1.Visible = true;
            CircleButton3.ForeColor = Color.Black;
            CircleButton3.FillColor = Color.Silver;
            PanelPrice.Visible = true;
            PanelSonuc.Visible = false;
        }
        private void btnback2_Click(object sender, EventArgs e)
        {
            back2();
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFrequently_Click(object sender, EventArgs e)
        {
            lblAmount.Text = lblsikkullanilan.Text;
            lblincorrect.Visible = false;
            CircleButton2.Visible = false;
            pb2.BringToFront();
            btnback1.Visible = false;
            btnback2.Visible = true;
            CircleButton3.ForeColor = Color.White;
            CircleButton3.FillColor = Color.Firebrick;
            PanelPrice.Visible = false;
            PanelSonuc.Visible = true;
        }
    }
}

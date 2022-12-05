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
    public partial class ActivitiesUserControl1 : UserControl
    {
        public ActivitiesUserControl1()
        {
            InitializeComponent();
        }
        public string numara;
        sqlbaglantisi bgl = new sqlbaglantisi();       

        void ActivitiesPanelGonderdigim()
        {
            PanelDeposited.Controls.Clear();
            for (int i = 1; i < DataGridView1Gonderdigim.RowCount; i++)
            {                
                ActPanelUserControl1 apuc = new ActPanelUserControl1();
                apuc.Name = (i - 1).ToString();
                apuc.btnDetail.Text = (i - 1).ToString();
                apuc.btnReceipt.Text = (i - 1).ToString();
                apuc.lblGun.Text = DataGridView1Gonderdigim.Rows[i - 1].Cells[5].Value.ToString();
                apuc.lblAyAdı.Text = DataGridView1Gonderdigim.Rows[i - 1].Cells[4].Value.ToString();
                apuc.lblSaat.Text = DataGridView1Gonderdigim.Rows[i - 1].Cells[3].Value.ToString();
                string no = DataGridView1Gonderdigim.Rows[i - 1].Cells[1].Value.ToString();
                SqlCommand komut = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    apuc.lblAlıcıadsoyad.Text = dr[0] + " " + dr[1];
                }
                apuc.lblTutar.Text= "-"+DataGridView1Gonderdigim.Rows[i - 1].Cells[2].Value.ToString()+" TL";
                apuc.lblAvailable.Text= "Remaining Balance:  "+ DataGridView1Gonderdigim.Rows[i - 1].Cells[6].Value.ToString()+" TL";
                apuc.lblTutar.ForeColor = Color.Red;
                apuc.Separator1.FillColor = Color.Red;
                apuc.Location = new Point(0,((i-1)*98)+2);
                apuc.btnDetail.Click += PanelActionsGonderdigim_Click;
                apuc.btnReceipt.Click += PanelReceiptGonderdigim_Click;   
                this.AutoScroll = true;               
                PanelDeposited.Controls.Add(apuc);
            }
        }

        private void PanelReceiptGonderdigim_Click(object sender, EventArgs e)
        {
            Form FormBackgroundd = new Form();
            Guna2GradientButton btnn = (sender as Guna2GradientButton);
            try
            {
                using (Receipt rc = new Receipt())
                {
                    FormBackgroundd.StartPosition = FormStartPosition.Manual;
                    FormBackgroundd.FormBorderStyle = FormBorderStyle.None;
                    FormBackgroundd.Opacity = .50d;
                    FormBackgroundd.BackColor = Color.Black;
                    FormBackgroundd.WindowState = FormWindowState.Maximized;
                    FormBackgroundd.TopMost = true;
                    FormBackgroundd.Location = this.Location;
                    FormBackgroundd.ShowInTaskbar = false;
                    FormBackgroundd.Show();

                    int i = Convert.ToInt32(btnn.Text);
                    rc.Owner = FormBackgroundd;
                    string no = DataGridView1Gonderdigim.Rows[i].Cells[1].Value.ToString();
                    SqlCommand komut1 = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + numara + "'", bgl.baglanti());
                    SqlDataReader dr1 = komut1.ExecuteReader();
                    while (dr1.Read())
                    {
                        rc.lblNameSurname.Text = dr1[0] + " " + dr1[1];
                        rc.lblSender.Text = dr1[0] + " " + dr1[1];
                    }

                    SqlCommand komut = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        rc.lblRecipientAc.Text = "TR" + no + " / " + dr[0] + " " + dr[1];
                    }
                    double x = Convert.ToDouble(DataGridView1Gonderdigim.Rows[i].Cells[2].Value.ToString());
                    x = Math.Round(x, 2);
                    rc.lblTransactionAm.Text = DataGridView1Gonderdigim.Rows[i].Cells[2].Value.ToString() + " TL";
                    rc.lblTotalCost.Text= (x + 0.60).ToString()+ " TL";
                    rc.lblinformation.Text = rc.lblTotalCost.Text + " has been deducted from your account.";
                    rc.lblDate.Text = DataGridView1Gonderdigim.Rows[i].Cells[7].Value.ToString();
                    rc.no = numara;
                    rc.ShowDialog();

                    FormBackgroundd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormBackgroundd.Dispose();
            }
        }

        private void PanelActionsGonderdigim_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            Guna2GradientButton btn = (sender as Guna2GradientButton);
            try
            {
                using(Info nf=new Info())
                {
                    FormBackground.StartPosition = FormStartPosition.Manual;
                    FormBackground.FormBorderStyle = FormBorderStyle.None;
                    FormBackground.Opacity = .50d;
                    FormBackground.BackColor = Color.Black;
                    FormBackground.WindowState = FormWindowState.Maximized;
                    FormBackground.TopMost = true;
                    FormBackground.Location = this.Location;
                    FormBackground.ShowInTaskbar = false;
                    FormBackground.Show();

                    int i = Convert.ToInt32(btn.Text);
                    nf.Owner = FormBackground;
                    nf.lblAmount.Text = "-" + DataGridView1Gonderdigim.Rows[i].Cells[2].Value.ToString() + " TL";
                    nf.lblAmount.ForeColor = Color.Red;
                    nf.lblDate.Text = DataGridView1Gonderdigim.Rows[i].Cells[7].Value.ToString();
                    string no = DataGridView1Gonderdigim.Rows[i].Cells[1].Value.ToString();
                   
                    SqlCommand komut = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        nf.lblName.Text = "To "+dr[0] + " " + dr[1];
                    }
                    nf.lblRemainingBalance.Text = DataGridView1Gonderdigim.Rows[i].Cells[6].Value.ToString() + " TL";
                    nf.ShowDialog();

                    FormBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormBackground.Dispose();
            }
        }

        void ActivitiesPanelGelen()
        {
            PanelWithdrawn.Controls.Clear();
            for (int i = 1; i < DataGridView1Gelen.RowCount; i++)
            {               
                ActPanelUserControl1 apuc = new ActPanelUserControl1();
                apuc.Name = (i-1).ToString();
                apuc.btnDetail.Text = (i - 1).ToString();
                apuc.btnReceipt.Text = (i - 1).ToString();
                apuc.lblGun.Text = DataGridView1Gelen.Rows[i - 1].Cells[5].Value.ToString();
                apuc.lblAyAdı.Text = DataGridView1Gelen.Rows[i - 1].Cells[4].Value.ToString();
                apuc.lblSaat.Text = DataGridView1Gelen.Rows[i - 1].Cells[3].Value.ToString();
                string no = DataGridView1Gelen.Rows[i - 1].Cells[1].Value.ToString();                
                SqlCommand komut = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    apuc.lblAlıcıadsoyad.Text = dr[0] + " " + dr[1];
                }
                apuc.lblTutar.Text = "+" + DataGridView1Gelen.Rows[i - 1].Cells[2].Value.ToString() + " TL";
                apuc.lblAvailable.Text = "Remaining Balance:  " + DataGridView1Gelen.Rows[i - 1].Cells[6].Value.ToString() + " TL";
                apuc.lblTutar.ForeColor = Color.LawnGreen;
                apuc.Separator1.FillColor = Color.LawnGreen;
                apuc.Location = new Point(0, ((i - 1) * 98) + 2);
                apuc.btnDetail.Click += PanelActionsGelen_Click;
                apuc.btnReceipt.Click += PanelReceiptGelen_Click;
                this.AutoScroll = true;
                PanelWithdrawn.Controls.Add(apuc);
            }
        }

        private void PanelReceiptGelen_Click(object sender, EventArgs e)
        {
            Form FormBackgroundd = new Form();
            Guna2GradientButton btnn = (sender as Guna2GradientButton);
            try
            {
                using (Receipt rc = new Receipt())
                {
                    FormBackgroundd.StartPosition = FormStartPosition.Manual;
                    FormBackgroundd.FormBorderStyle = FormBorderStyle.None;
                    FormBackgroundd.Opacity = .50d;
                    FormBackgroundd.BackColor = Color.Black;
                    FormBackgroundd.WindowState = FormWindowState.Maximized;
                    FormBackgroundd.TopMost = true;
                    FormBackgroundd.Location = this.Location;
                    FormBackgroundd.ShowInTaskbar = false;
                    FormBackgroundd.Show();

                    int i = Convert.ToInt32(btnn.Text);
                    rc.Owner = FormBackgroundd;
                    string no = DataGridView1Gelen.Rows[i].Cells[1].Value.ToString();
                    SqlCommand komut1 = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + numara + "'", bgl.baglanti());
                    SqlDataReader dr1 = komut1.ExecuteReader();
                    while (dr1.Read())
                    {
                        rc.lblNameSurname.Text = dr1[0] + " " + dr1[1];
                        rc.lblRecipientAc.Text = dr1[0] + " " + dr1[1];
                    }

                    SqlCommand komut = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        rc.lblSender.Text = "TR" + no + " / " + dr[0] + " " + dr[1];
                    }
                    double x = Convert.ToDouble(DataGridView1Gelen.Rows[i].Cells[2].Value.ToString());
                    x = Math.Round(x, 2);
                    rc.lblTransactionAm.Text = DataGridView1Gelen.Rows[i].Cells[2].Value.ToString() + " TL";
                    rc.lblTotalCost.Text = DataGridView1Gelen.Rows[i].Cells[2].Value.ToString() + " TL";
                    rc.lblinformation.Text = rc.lblTotalCost.Text + " has been deposited into your account.";
                    rc.lblDate.Text = DataGridView1Gelen.Rows[i].Cells[7].Value.ToString();
                    rc.lblCommission.Text = "0,00 TL";
                    rc.lblFast.Text = "TRANSFER";
                    rc.no = numara;
                    rc.ShowDialog();

                    FormBackgroundd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormBackgroundd.Dispose();
            }
        }

        private void PanelActionsGelen_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            Guna2GradientButton btn = (sender as Guna2GradientButton);
            try
            {
                using (Info nf = new Info())
                {
                    FormBackground.StartPosition = FormStartPosition.Manual;
                    FormBackground.FormBorderStyle = FormBorderStyle.None;
                    FormBackground.Opacity = .50d;
                    FormBackground.BackColor = Color.Black;
                    FormBackground.WindowState = FormWindowState.Maximized;
                    FormBackground.TopMost = true;
                    FormBackground.Location = this.Location;
                    FormBackground.ShowInTaskbar = false;
                    FormBackground.Show();

                    int i = Convert.ToInt32(btn.Text);
                    nf.Owner = FormBackground;
                    nf.lblAmount.Text = "+" + DataGridView1Gelen.Rows[i].Cells[2].Value.ToString() + " TL";
                    nf.lblAmount.ForeColor = Color.ForestGreen;
                    nf.lblDate.Text = DataGridView1Gelen.Rows[i].Cells[7].Value.ToString();
                    string no = DataGridView1Gelen.Rows[i].Cells[1].Value.ToString();                    
                   
                    SqlCommand komut = new SqlCommand("select AD,SOYAD from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        nf.lblName.Text = "From " + dr[0] + " " + dr[1];
                    }
                    nf.lblRemainingBalance.Text = DataGridView1Gelen.Rows[i].Cells[6].Value.ToString() + " TL";
                    nf.ShowDialog();

                    FormBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormBackground.Dispose();
            }
        }

        private void ActivitiesUserControl1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID,ALICI,TUTAR,SAAT,AYADI,GUN,KALAN,TARIH from HAREKETLER where GONDEREN='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridView1Gonderdigim.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("select ID,GONDEREN,TUTAR,SAAT,AYADI,GUN,ARTAN,TARIH from HAREKETLER where ALICI='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            DataGridView1Gelen.DataSource = dt2;
            PanelDeposited.BringToFront();
            ActivitiesPanelGonderdigim();
            ActivitiesPanelGelen();
        }

        private void btnRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDeposited.Checked)
            {
                btnDeposited.BringToFront();
                PanelWithdrawn.SendToBack();
                PanelWithdrawn.Visible = false;
                PanelDeposited.BringToFront();
                PanelDeposited.Visible = true;
            }
        }

        private void btnWithdrawn_CheckedChanged(object sender, EventArgs e)
        {
            if (btnWithdrawn.Checked)
            {
                btnWithdrawn.BringToFront();
                PanelDeposited.SendToBack();
                PanelDeposited.Visible = false;
                PanelWithdrawn.BringToFront();
                PanelWithdrawn.Visible = true;              
            }
        }

        private void cmbDateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDateFilter.SelectedIndex == 2)
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select ID,ALICI,TUTAR,SAAT,AYADI,GUN,KALAN,TARIH from HAREKETLER where TARIH>dateadd(day,-30,getdate()) and GONDEREN='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                DataGridView1Gonderdigim.DataSource = dt1;
                ActivitiesPanelGonderdigim();

                SqlDataAdapter da2 = new SqlDataAdapter("Select ID,GONDEREN,TUTAR,SAAT,AYADI,GUN,ARTAN,TARIH from HAREKETLER where TARIH>dateadd(day,-30,getdate()) and ALICI='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DataGridView1Gelen.DataSource = dt2;
                ActivitiesPanelGelen();
            }
            else if(cmbDateFilter.SelectedIndex == 0)
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select ID,ALICI,TUTAR,SAAT,AYADI,GUN,KALAN,TARIH from HAREKETLER where TARIH>dateadd(day,-1,getdate()) and GONDEREN='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                DataGridView1Gonderdigim.DataSource = dt1;
                ActivitiesPanelGonderdigim();

                SqlDataAdapter da2 = new SqlDataAdapter("Select ID,GONDEREN,TUTAR,SAAT,AYADI,GUN,ARTAN,TARIH from HAREKETLER where TARIH>dateadd(day,-1,getdate()) and ALICI='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DataGridView1Gelen.DataSource = dt2;
                ActivitiesPanelGelen();
            }
            else if (cmbDateFilter.SelectedIndex == 1)
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select ID,ALICI,TUTAR,SAAT,AYADI,GUN,KALAN,TARIH from HAREKETLER where TARIH>dateadd(day,-7,getdate()) and GONDEREN='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                DataGridView1Gonderdigim.DataSource = dt1;
                ActivitiesPanelGonderdigim();

                SqlDataAdapter da2 = new SqlDataAdapter("Select ID,GONDEREN,TUTAR,SAAT,AYADI,GUN,ARTAN,TARIH from HAREKETLER where TARIH>dateadd(day,-7,getdate()) and ALICI='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DataGridView1Gelen.DataSource = dt2;
                ActivitiesPanelGelen();
            }
            else if (cmbDateFilter.SelectedIndex == 3)
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select ID,ALICI,TUTAR,SAAT,AYADI,GUN,KALAN,TARIH from HAREKETLER where TARIH>dateadd(day,-90,getdate()) and GONDEREN='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                DataGridView1Gonderdigim.DataSource = dt1;
                ActivitiesPanelGonderdigim();

                SqlDataAdapter da2 = new SqlDataAdapter("Select ID,GONDEREN,TUTAR,SAAT,AYADI,GUN,ARTAN,TARIH from HAREKETLER where TARIH>dateadd(day,-90,getdate()) and ALICI='" + numara + "' ORDER BY ID DESC", bgl.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DataGridView1Gelen.DataSource = dt2;
                ActivitiesPanelGelen();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace MoonBank
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string no;
        
        private void btnSendMail_MouseHover(object sender, EventArgs e)
        {
            lbmail.Visible = true;
            lblEmail.Visible = true;
        }

        private void btnSendMail_MouseLeave(object sender, EventArgs e)
        {
            lbmail.Visible = false;
            lblEmail.Visible = false;
        }

        private void btnDownload_MouseHover(object sender, EventArgs e)
        {
            lbdown.Visible = true;
        }

        private void btnDownload_MouseLeave(object sender, EventArgs e)
        {
            lbdown.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream mst = new MemoryStream();
                
                using (var bmp = new Bitmap(panelSS.Width, panelSS.Height))
                {
                    panelSS.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                    System.Drawing.Image img = (System.Drawing.Image)bmp;
                    img.Save(mst, ImageFormat.Jpeg);       
                }
                using(MemoryStream PDFData = new MemoryStream())
                {
                    iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();

                    PdfWriter.GetInstance(pdfDosya, PDFData); // new FileStream(@"RECEIPT\Receipt.pdf", FileMode.Create)

                    pdfDosya.AddCreator("Moon Bank Inc."); //Oluşturan kişinin isminin eklenmesi
                    pdfDosya.AddCreationDate();//Oluşturulma tarihinin eklenmesi
                    pdfDosya.AddAuthor("Moon Bank Inc."); //Yazarın isiminin eklenmesi
                    pdfDosya.AddHeader(lblNameSurname.Text, " RECEIPT");
                    pdfDosya.AddTitle("Your Moon Bank Statement"); //Başlık ve title eklenmesi

                    //Eklenecek resmimizin yolunu tanımladık
                    iTextSharp.text.Image resim = iTextSharp.text.Image.GetInstance(mst.GetBuffer());

                    if (pdfDosya.IsOpen() == false)
                        pdfDosya.Open();

                    pdfDosya.Add(resim); //Resim Nesnemizi Dosyaya eklenmesi
                    pdfDosya.Close();

                    byte[] bytes = PDFData.ToArray(); // akış için çok önemli
                    PDFData.Close();

                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;

                    string kime = lblEmail.Text;
                    string konu = "RECEIPT";
                    string icerik = "The details of your transaction are attached.\nMoon Bank Inc.";

                    sc.Credentials = new NetworkCredential("aydemirsoftware@gmail.com", "191119ea");
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("aydemirsoftware@gmail.com", "MOON BANK Inc.");
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.IsBodyHtml = true;
                    mail.Body = icerik;
                    // pdf yi ekleme
                    mail.Attachments.Add(new Attachment(new MemoryStream(bytes), "RECEIPT.pdf"));
                    sc.Send(mail);
                }               
                using (MsgBox ms = new MsgBox())
                {
                    ms.lblInfo.Text = "Your E-Mail Sending Process was\n           Realized successfully.";
                    ms.ShowDialog();
                    if (ms.DialogResult == DialogResult.OK)
                    {
                        Receipt rc = new Receipt();
                        rc.Close();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
       
        private void Receipt_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select MAIL from KISILER where HESAPNO='" + no + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblEmail.Text = dr[0].ToString();
            }
        }
        
        private void btnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MemoryStream mst = new MemoryStream();
                    using (var bmp = new Bitmap(panelSS.Width, panelSS.Height))
                    {
                        panelSS.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                        System.Drawing.Image img = (System.Drawing.Image)bmp;
                        img.Save(mst,ImageFormat.Jpeg);  //@"picture\Receipt.jpg"
                    }
                    iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();
                    string KlasorYolu;
                    KlasorYolu = fb.SelectedPath;
                    string tarih = DateTime.Now.ToShortDateString();
                    PdfWriter.GetInstance(pdfDosya, new FileStream(KlasorYolu+@"\RECEIPT-"+no+"-"+tarih+".pdf", FileMode.Create));
                    //PDF dosyamızın yolu "\RECEIPT\Receipt.pdf" ve dosyanın açılış biçimi ‘Yeni yarat’

                    pdfDosya.AddCreator("Moon Bank Inc."); //Oluşturan kişinin isminin eklenmesi
                    pdfDosya.AddCreationDate();//Oluşturulma tarihinin eklenmesi
                    pdfDosya.AddAuthor("Moon Bank Inc."); //Yazarın isiminin eklenmesi
                    pdfDosya.AddHeader(lblNameSurname.Text, " RECEIPT");
                    pdfDosya.AddTitle("Your Moon Bank Statement"); //Başlık ve title eklenmesi

                    //Eklenecek resmimizin yolunu tanımladık
                    iTextSharp.text.Image resim = iTextSharp.text.Image.GetInstance(mst.GetBuffer());
                    
                    if (pdfDosya.IsOpen() == false)  //Application.StartupPath+@"\picture\Receipt.jpg"
                        pdfDosya.Open();

                    pdfDosya.Add(resim); //Resim Nesnemizi Dosyaya eklenmesi
                    pdfDosya.Close();                  
                    using (MsgBox ms = new MsgBox())
                    {
                        ms.lblInfo.Text = "Your Receipt Download Has Been\n       Successfully Completed";
                        ms.ShowDialog();
                        if (ms.DialogResult == DialogResult.OK)
                        {
                            Receipt rc = new Receipt();
                            rc.Close();
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

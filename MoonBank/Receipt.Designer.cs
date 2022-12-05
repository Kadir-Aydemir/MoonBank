
namespace MoonBank
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.btnDownload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelSS = new System.Windows.Forms.Panel();
            this.lblinformation = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblTransactionAm = new System.Windows.Forms.Label();
            this.lblRecipientAc = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFast = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbdown = new System.Windows.Forms.Label();
            this.btnSendMail = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbmail = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSS.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDownload.CheckedState.Parent = this.btnDownload;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.HoverState.ImageSize = new System.Drawing.Size(29, 31);
            this.btnDownload.HoverState.Parent = this.btnDownload;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageRotate = 0F;
            this.btnDownload.ImageSize = new System.Drawing.Size(31, 33);
            this.btnDownload.Location = new System.Drawing.Point(199, 439);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedState.ImageSize = new System.Drawing.Size(27, 29);
            this.btnDownload.PressedState.Parent = this.btnDownload;
            this.btnDownload.Size = new System.Drawing.Size(38, 30);
            this.btnDownload.TabIndex = 113;
            this.btnDownload.UseTransparentBackground = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            this.btnDownload.MouseLeave += new System.EventHandler(this.btnDownload_MouseLeave);
            this.btnDownload.MouseHover += new System.EventHandler(this.btnDownload_MouseHover);
            // 
            // panelSS
            // 
            this.panelSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSS.Controls.Add(this.lblinformation);
            this.panelSS.Controls.Add(this.lblTotalCost);
            this.panelSS.Controls.Add(this.lblCommission);
            this.panelSS.Controls.Add(this.lblTransactionAm);
            this.panelSS.Controls.Add(this.lblRecipientAc);
            this.panelSS.Controls.Add(this.lblSender);
            this.panelSS.Controls.Add(this.label11);
            this.panelSS.Controls.Add(this.label10);
            this.panelSS.Controls.Add(this.label9);
            this.panelSS.Controls.Add(this.label8);
            this.panelSS.Controls.Add(this.label7);
            this.panelSS.Controls.Add(this.label6);
            this.panelSS.Controls.Add(this.lblNameSurname);
            this.panelSS.Controls.Add(this.lblDate);
            this.panelSS.Controls.Add(this.label4);
            this.panelSS.Controls.Add(this.lblFast);
            this.panelSS.Controls.Add(this.label12);
            this.panelSS.Controls.Add(this.panel3);
            this.panelSS.Controls.Add(this.panel7);
            this.panelSS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSS.Location = new System.Drawing.Point(0, 0);
            this.panelSS.Name = "panelSS";
            this.panelSS.Size = new System.Drawing.Size(522, 437);
            this.panelSS.TabIndex = 114;
            // 
            // lblinformation
            // 
            this.lblinformation.AutoSize = true;
            this.lblinformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinformation.ForeColor = System.Drawing.Color.Black;
            this.lblinformation.Location = new System.Drawing.Point(19, 364);
            this.lblinformation.Name = "lblinformation";
            this.lblinformation.Size = new System.Drawing.Size(317, 21);
            this.lblinformation.TabIndex = 131;
            this.lblinformation.Text = "11 TL has been deducted from your account.";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCost.Location = new System.Drawing.Point(96, 327);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(39, 21);
            this.lblTotalCost.TabIndex = 130;
            this.lblTotalCost.Text = "Null";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCommission.ForeColor = System.Drawing.Color.Black;
            this.lblCommission.Location = new System.Drawing.Point(116, 290);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(60, 21);
            this.lblCommission.TabIndex = 129;
            this.lblCommission.Text = "0,60 TL";
            // 
            // lblTransactionAm
            // 
            this.lblTransactionAm.AutoSize = true;
            this.lblTransactionAm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionAm.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionAm.Location = new System.Drawing.Point(168, 253);
            this.lblTransactionAm.Name = "lblTransactionAm";
            this.lblTransactionAm.Size = new System.Drawing.Size(39, 21);
            this.lblTransactionAm.TabIndex = 128;
            this.lblTransactionAm.Text = "Null";
            // 
            // lblRecipientAc
            // 
            this.lblRecipientAc.AutoSize = true;
            this.lblRecipientAc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecipientAc.ForeColor = System.Drawing.Color.Black;
            this.lblRecipientAc.Location = new System.Drawing.Point(153, 216);
            this.lblRecipientAc.Name = "lblRecipientAc";
            this.lblRecipientAc.Size = new System.Drawing.Size(39, 21);
            this.lblRecipientAc.TabIndex = 127;
            this.lblRecipientAc.Text = "Null";
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSender.ForeColor = System.Drawing.Color.Black;
            this.lblSender.Location = new System.Drawing.Point(78, 179);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(39, 21);
            this.lblSender.TabIndex = 126;
            this.lblSender.Text = "Null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(386, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 42);
            this.label11.TabIndex = 125;
            this.label11.Text = "      Regards..\r\nMoon Bank Inc.\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 124;
            this.label10.Text = "Transaction Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 123;
            this.label9.Text = "Total Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 122;
            this.label8.Text = "Commission:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 121;
            this.label7.Text = "Recipient Account:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 120;
            this.label6.Text = "Sender:";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.ForeColor = System.Drawing.Color.Black;
            this.lblNameSurname.Location = new System.Drawing.Point(19, 127);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(121, 21);
            this.lblNameSurname.TabIndex = 119;
            this.lblNameSurname.Text = "Name Surname";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(423, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 20);
            this.lblDate.TabIndex = 118;
            this.lblDate.Text = "05/06/2021";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFast
            // 
            this.lblFast.AutoSize = true;
            this.lblFast.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFast.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFast.Location = new System.Drawing.Point(306, 71);
            this.lblFast.Name = "lblFast";
            this.lblFast.Size = new System.Drawing.Size(56, 25);
            this.lblFast.TabIndex = 116;
            this.lblFast.Text = "FAST";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(115, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 25);
            this.label12.TabIndex = 115;
            this.label12.Text = "Account to Account";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(23, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 110);
            this.panel3.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "The best";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(520, 11);
            this.panel7.TabIndex = 114;
            // 
            // lbdown
            // 
            this.lbdown.AutoSize = true;
            this.lbdown.BackColor = System.Drawing.Color.White;
            this.lbdown.Font = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbdown.ForeColor = System.Drawing.Color.DimGray;
            this.lbdown.Location = new System.Drawing.Point(174, 471);
            this.lbdown.Name = "lbdown";
            this.lbdown.Size = new System.Drawing.Size(88, 16);
            this.lbdown.TabIndex = 115;
            this.lbdown.Text = "Download PDF";
            this.lbdown.Visible = false;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMail.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSendMail.CheckedState.Parent = this.btnSendMail;
            this.btnSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMail.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSendMail.HoverState.Parent = this.btnSendMail;
            this.btnSendMail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMail.Image")));
            this.btnSendMail.ImageRotate = 0F;
            this.btnSendMail.ImageSize = new System.Drawing.Size(29, 29);
            this.btnSendMail.Location = new System.Drawing.Point(291, 443);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSendMail.PressedState.Parent = this.btnSendMail;
            this.btnSendMail.Size = new System.Drawing.Size(38, 27);
            this.btnSendMail.TabIndex = 116;
            this.btnSendMail.UseTransparentBackground = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            this.btnSendMail.MouseLeave += new System.EventHandler(this.btnSendMail_MouseLeave);
            this.btnSendMail.MouseHover += new System.EventHandler(this.btnSendMail_MouseHover);
            // 
            // lbmail
            // 
            this.lbmail.AutoSize = true;
            this.lbmail.BackColor = System.Drawing.Color.White;
            this.lbmail.Font = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmail.ForeColor = System.Drawing.Color.DimGray;
            this.lbmail.Location = new System.Drawing.Point(246, 471);
            this.lbmail.Name = "lbmail";
            this.lbmail.Size = new System.Drawing.Size(127, 16);
            this.lbmail.TabIndex = 117;
            this.lbmail.Text = "Send receipt to e-mail";
            this.lbmail.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.Location = new System.Drawing.Point(6, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(38, 25);
            this.btnClose.TabIndex = 118;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(247, 487);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 16);
            this.lblEmail.TabIndex = 119;
            this.lblEmail.Text = "mail";
            this.lblEmail.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(255, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 120;
            this.label5.Text = "or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(306, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Transaction Date";
            // 
            // Receipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbmail);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.panelSS);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lbdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.panelSS.ResumeLayout(false);
            this.panelSS.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnDownload;
        private System.Windows.Forms.Panel panelSS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbdown;
        private Guna.UI2.WinForms.Guna2ImageButton btnSendMail;
        private System.Windows.Forms.Label lbmail;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        internal System.Windows.Forms.Label lblinformation;
        internal System.Windows.Forms.Label lblTotalCost;
        internal System.Windows.Forms.Label lblTransactionAm;
        internal System.Windows.Forms.Label lblRecipientAc;
        internal System.Windows.Forms.Label lblSender;
        internal System.Windows.Forms.Label lblNameSurname;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblCommission;
        internal System.Windows.Forms.Label lblFast;
    }
}

namespace MoonBank
{
    partial class PasswordUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordUserControl1));
            this.btnVerify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCheckit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendMail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtVerify = new Guna.UI2.WinForms.Guna2TextBox();
            this.CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblaccount = new System.Windows.Forms.Label();
            this.lbltimeup = new System.Windows.Forms.Label();
            this.lblmailsent = new System.Windows.Forms.Label();
            this.lblempty = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Animated = true;
            this.btnVerify.BorderRadius = 18;
            this.btnVerify.BorderThickness = 1;
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.btnVerify.FillColor = System.Drawing.Color.Transparent;
            this.btnVerify.FillColor2 = System.Drawing.Color.Transparent;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(75, 386);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(266, 34);
            this.btnVerify.TabIndex = 49;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.Visible = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCheckit
            // 
            this.btnCheckit.Animated = true;
            this.btnCheckit.BorderRadius = 18;
            this.btnCheckit.CheckedState.Parent = this.btnCheckit;
            this.btnCheckit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckit.CustomImages.Parent = this.btnCheckit;
            this.btnCheckit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnCheckit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCheckit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckit.ForeColor = System.Drawing.Color.White;
            this.btnCheckit.HoverState.Parent = this.btnCheckit;
            this.btnCheckit.Location = new System.Drawing.Point(91, 335);
            this.btnCheckit.Name = "btnCheckit";
            this.btnCheckit.ShadowDecoration.Parent = this.btnCheckit;
            this.btnCheckit.Size = new System.Drawing.Size(236, 45);
            this.btnCheckit.TabIndex = 44;
            this.btnCheckit.Text = "Check it";
            this.btnCheckit.Click += new System.EventHandler(this.btnCheckit_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BorderColor = System.Drawing.Color.Black;
            this.txtMail.BorderRadius = 18;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.Parent = this.txtMail;
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.Enabled = false;
            this.txtMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedState.Parent = this.txtMail;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.HoverState.Parent = this.txtMail;
            this.txtMail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMail.IconLeft")));
            this.txtMail.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtMail.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtMail.Location = new System.Drawing.Point(30, 224);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(354, 45);
            this.txtMail.TabIndex = 43;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.Visible = false;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtAccountNumber.BorderColor = System.Drawing.Color.Black;
            this.txtAccountNumber.BorderRadius = 18;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.FocusedState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccountNumber.ForeColor = System.Drawing.Color.White;
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.HoverState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtAccountNumber.IconLeft")));
            this.txtAccountNumber.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtAccountNumber.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtAccountNumber.Location = new System.Drawing.Point(30, 159);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.MaxLength = 6;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "Account Number";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.ShadowDecoration.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Size = new System.Drawing.Size(354, 45);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Animated = true;
            this.btnSendMail.BorderRadius = 18;
            this.btnSendMail.CheckedState.Parent = this.btnSendMail;
            this.btnSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMail.CustomImages.Parent = this.btnSendMail;
            this.btnSendMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnSendMail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnSendMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.HoverState.Parent = this.btnSendMail;
            this.btnSendMail.Location = new System.Drawing.Point(91, 335);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.ShadowDecoration.Parent = this.btnSendMail;
            this.btnSendMail.Size = new System.Drawing.Size(236, 45);
            this.btnSendMail.TabIndex = 50;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.Visible = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // txtVerify
            // 
            this.txtVerify.Animated = true;
            this.txtVerify.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVerify.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtVerify.BackColor = System.Drawing.Color.White;
            this.txtVerify.BorderColor = System.Drawing.Color.Black;
            this.txtVerify.BorderRadius = 10;
            this.txtVerify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerify.DefaultText = "";
            this.txtVerify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerify.DisabledState.Parent = this.txtVerify;
            this.txtVerify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerify.FocusedState.Parent = this.txtVerify;
            this.txtVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVerify.ForeColor = System.Drawing.Color.Black;
            this.txtVerify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerify.HoverState.Parent = this.txtVerify;
            this.txtVerify.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtVerify.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtVerify.Location = new System.Drawing.Point(128, 283);
            this.txtVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVerify.MaxLength = 5;
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.PasswordChar = '\0';
            this.txtVerify.PlaceholderText = "";
            this.txtVerify.SelectedText = "";
            this.txtVerify.ShadowDecoration.Parent = this.txtVerify;
            this.txtVerify.Size = new System.Drawing.Size(167, 45);
            this.txtVerify.TabIndex = 51;
            this.txtVerify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVerify.Visible = false;
            // 
            // CircleProgressBar1
            // 
            this.CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar1.Backwards = true;
            this.CircleProgressBar1.FillThickness = 13;
            this.CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CircleProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.CircleProgressBar1.Location = new System.Drawing.Point(146, 4);
            this.CircleProgressBar1.Name = "CircleProgressBar1";
            this.CircleProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Triangle;
            this.CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.CircleProgressBar1.ProgressThickness = 13;
            this.CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar1.ShadowDecoration.Parent = this.CircleProgressBar1;
            this.CircleProgressBar1.ShowPercentage = true;
            this.CircleProgressBar1.Size = new System.Drawing.Size(115, 115);
            this.CircleProgressBar1.TabIndex = 52;
            this.CircleProgressBar1.Value = 100;
            this.CircleProgressBar1.Visible = false;
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblaccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaccount.ForeColor = System.Drawing.Color.Red;
            this.lblaccount.Location = new System.Drawing.Point(121, 131);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(165, 17);
            this.lblaccount.TabIndex = 53;
            this.lblaccount.Text = "Account do not match !";
            this.lblaccount.Visible = false;
            // 
            // lbltimeup
            // 
            this.lbltimeup.AutoSize = true;
            this.lbltimeup.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltimeup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltimeup.ForeColor = System.Drawing.Color.Red;
            this.lbltimeup.Location = new System.Drawing.Point(173, 131);
            this.lbltimeup.Name = "lbltimeup";
            this.lbltimeup.Size = new System.Drawing.Size(66, 18);
            this.lbltimeup.TabIndex = 55;
            this.lbltimeup.Text = "TIME UP!";
            this.lbltimeup.Visible = false;
            // 
            // lblmailsent
            // 
            this.lblmailsent.AutoSize = true;
            this.lblmailsent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblmailsent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmailsent.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblmailsent.Location = new System.Drawing.Point(162, 128);
            this.lblmailsent.Name = "lblmailsent";
            this.lblmailsent.Size = new System.Drawing.Size(87, 20);
            this.lblmailsent.TabIndex = 56;
            this.lblmailsent.Text = "Mail Sent ..";
            this.lblmailsent.Visible = false;
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblempty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblempty.ForeColor = System.Drawing.Color.Red;
            this.lblempty.Location = new System.Drawing.Point(125, 131);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(151, 17);
            this.lblempty.TabIndex = 57;
            this.lblempty.Text = "User number is empty !";
            this.lblempty.Visible = false;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblsifre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblsifre.Location = new System.Drawing.Point(395, 422);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(17, 20);
            this.lblsifre.TabIndex = 58;
            this.lblsifre.Text = "..";
            this.lblsifre.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PasswordUserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.lblmailsent);
            this.Controls.Add(this.lbltimeup);
            this.Controls.Add(this.lblaccount);
            this.Controls.Add(this.CircleProgressBar1);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnCheckit);
            this.Controls.Add(this.btnSendMail);
            this.Name = "PasswordUserControl1";
            this.Size = new System.Drawing.Size(415, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnVerify;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckit;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2GradientButton btnSendMail;
        private Guna.UI2.WinForms.Guna2TextBox txtVerify;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar1;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.Label lbltimeup;
        private System.Windows.Forms.Label lblmailsent;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace MoonBank
{
    partial class SettingUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingUserControl1));
            this.label12 = new System.Windows.Forms.Label();
            this.btnPhone = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.btnShowPass = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblPasswordCurrent = new System.Windows.Forms.Label();
            this.btnPassNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtNewPassAgain = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrentPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.lblEnterPass = new System.Windows.Forms.Label();
            this.PanelMail = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMailEnter = new System.Windows.Forms.Label();
            this.btnMailNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtNewMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelPhone = new System.Windows.Forms.Panel();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhoneEnter = new System.Windows.Forms.Label();
            this.mskNewTel = new System.Windows.Forms.MaskedTextBox();
            this.btnPhoneNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.imageslide = new System.Windows.Forms.PictureBox();
            this.PanelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageslide)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(30, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Account Settings";
            // 
            // btnPhone
            // 
            this.btnPhone.BackColor = System.Drawing.Color.Transparent;
            this.btnPhone.BorderRadius = 10;
            this.btnPhone.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhone.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPhone.CheckedState.FillColor2 = System.Drawing.Color.White;
            this.btnPhone.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhone.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPhone.CheckedState.Parent = this.btnPhone;
            this.btnPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhone.CustomImages.Parent = this.btnPhone;
            this.btnPhone.FillColor = System.Drawing.Color.White;
            this.btnPhone.FillColor2 = System.Drawing.Color.White;
            this.btnPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhone.ForeColor = System.Drawing.Color.DimGray;
            this.btnPhone.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPhone.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPhone.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnPhone.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhone.HoverState.Parent = this.btnPhone;
            this.btnPhone.Location = new System.Drawing.Point(546, 2);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.PressedColor = System.Drawing.Color.White;
            this.btnPhone.ShadowDecoration.Parent = this.btnPhone;
            this.btnPhone.Size = new System.Drawing.Size(166, 31);
            this.btnPhone.TabIndex = 75;
            this.btnPhone.Text = "Change Phone";
            this.btnPhone.TextOffset = new System.Drawing.Point(0, 5);
            this.btnPhone.UseTransparentBackground = true;
            this.btnPhone.CheckedChanged += new System.EventHandler(this.btnPassword_CheckedChanged_1);
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.BorderRadius = 10;
            this.btnMail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMail.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMail.CheckedState.FillColor2 = System.Drawing.Color.White;
            this.btnMail.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMail.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMail.CheckedState.Parent = this.btnMail;
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.CustomImages.Parent = this.btnMail;
            this.btnMail.FillColor = System.Drawing.Color.White;
            this.btnMail.FillColor2 = System.Drawing.Color.White;
            this.btnMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMail.ForeColor = System.Drawing.Color.DimGray;
            this.btnMail.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnMail.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMail.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnMail.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMail.HoverState.Parent = this.btnMail;
            this.btnMail.Location = new System.Drawing.Point(374, 2);
            this.btnMail.Name = "btnMail";
            this.btnMail.PressedColor = System.Drawing.Color.White;
            this.btnMail.ShadowDecoration.Parent = this.btnMail;
            this.btnMail.Size = new System.Drawing.Size(166, 31);
            this.btnMail.TabIndex = 76;
            this.btnMail.Text = "Change Mail";
            this.btnMail.TextOffset = new System.Drawing.Point(0, 5);
            this.btnMail.UseTransparentBackground = true;
            this.btnMail.CheckedChanged += new System.EventHandler(this.btnPassword_CheckedChanged_1);
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BorderRadius = 10;
            this.btnPassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPassword.Checked = true;
            this.btnPassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPassword.CheckedState.FillColor2 = System.Drawing.Color.White;
            this.btnPassword.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPassword.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPassword.CheckedState.Parent = this.btnPassword;
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.CustomImages.Parent = this.btnPassword;
            this.btnPassword.FillColor = System.Drawing.Color.White;
            this.btnPassword.FillColor2 = System.Drawing.Color.White;
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnPassword.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPassword.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPassword.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnPassword.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPassword.HoverState.Parent = this.btnPassword;
            this.btnPassword.Location = new System.Drawing.Point(202, 2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.PressedColor = System.Drawing.Color.White;
            this.btnPassword.ShadowDecoration.Parent = this.btnPassword;
            this.btnPassword.Size = new System.Drawing.Size(166, 31);
            this.btnPassword.TabIndex = 77;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.TextOffset = new System.Drawing.Point(0, 5);
            this.btnPassword.UseTransparentBackground = true;
            this.btnPassword.CheckedChanged += new System.EventHandler(this.btnPassword_CheckedChanged_1);
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.btnShowPass);
            this.PanelPassword.Controls.Add(this.pictureBox1);
            this.PanelPassword.Controls.Add(this.lbladsoyad);
            this.PanelPassword.Controls.Add(this.lblPasswordCurrent);
            this.PanelPassword.Controls.Add(this.btnPassNext);
            this.PanelPassword.Controls.Add(this.txtNewPassAgain);
            this.PanelPassword.Controls.Add(this.txtNewPass);
            this.PanelPassword.Controls.Add(this.txtCurrentPass);
            this.PanelPassword.Controls.Add(this.lblPasswordNew);
            this.PanelPassword.Controls.Add(this.lblEnterPass);
            this.PanelPassword.Location = new System.Drawing.Point(231, 59);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(337, 348);
            this.PanelPassword.TabIndex = 78;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Animated = true;
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.BorderColor = System.Drawing.Color.White;
            this.btnShowPass.BorderRadius = 10;
            this.btnShowPass.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnShowPass.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnShowPass.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnShowPass.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.CheckedState.Image")));
            this.btnShowPass.CheckedState.Parent = this.btnShowPass;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.CustomImages.Parent = this.btnShowPass;
            this.btnShowPass.FillColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPass.ForeColor = System.Drawing.Color.White;
            this.btnShowPass.HoverState.Parent = this.btnShowPass;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.ImageSize = new System.Drawing.Size(22, 22);
            this.btnShowPass.Location = new System.Drawing.Point(250, 166);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.ShadowDecoration.Parent = this.btnShowPass;
            this.btnShowPass.Size = new System.Drawing.Size(42, 28);
            this.btnShowPass.TabIndex = 82;
            this.btnShowPass.UseTransparentBackground = true;
            this.btnShowPass.CheckedChanged += new System.EventHandler(this.btnShowPass_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.ForeColor = System.Drawing.Color.Firebrick;
            this.lbladsoyad.Location = new System.Drawing.Point(33, 299);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(232, 17);
            this.lbladsoyad.TabIndex = 34;
            this.lbladsoyad.Text = "Must be a maximum of 10 characters !";
            // 
            // lblPasswordCurrent
            // 
            this.lblPasswordCurrent.AutoSize = true;
            this.lblPasswordCurrent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordCurrent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPasswordCurrent.Location = new System.Drawing.Point(63, 261);
            this.lblPasswordCurrent.Name = "lblPasswordCurrent";
            this.lblPasswordCurrent.Size = new System.Drawing.Size(196, 17);
            this.lblPasswordCurrent.TabIndex = 37;
            this.lblPasswordCurrent.Text = "Current password is not correct!";
            this.lblPasswordCurrent.Visible = false;
            // 
            // btnPassNext
            // 
            this.btnPassNext.Animated = true;
            this.btnPassNext.BorderRadius = 18;
            this.btnPassNext.CheckedState.Parent = this.btnPassNext;
            this.btnPassNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassNext.CustomImages.Parent = this.btnPassNext;
            this.btnPassNext.FillColor = System.Drawing.Color.Silver;
            this.btnPassNext.FillColor2 = System.Drawing.Color.Silver;
            this.btnPassNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPassNext.ForeColor = System.Drawing.Color.Black;
            this.btnPassNext.HoverState.Parent = this.btnPassNext;
            this.btnPassNext.Location = new System.Drawing.Point(13, 197);
            this.btnPassNext.Name = "btnPassNext";
            this.btnPassNext.ShadowDecoration.Parent = this.btnPassNext;
            this.btnPassNext.Size = new System.Drawing.Size(295, 38);
            this.btnPassNext.TabIndex = 6;
            this.btnPassNext.Text = "Next";
            this.btnPassNext.Click += new System.EventHandler(this.btnPassNext_Click);
            // 
            // txtNewPassAgain
            // 
            this.txtNewPassAgain.BackColor = System.Drawing.Color.White;
            this.txtNewPassAgain.BorderColor = System.Drawing.Color.Black;
            this.txtNewPassAgain.BorderRadius = 18;
            this.txtNewPassAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassAgain.DefaultText = "";
            this.txtNewPassAgain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassAgain.DisabledState.Parent = this.txtNewPassAgain;
            this.txtNewPassAgain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassAgain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtNewPassAgain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassAgain.FocusedState.Parent = this.txtNewPassAgain;
            this.txtNewPassAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPassAgain.ForeColor = System.Drawing.Color.White;
            this.txtNewPassAgain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassAgain.HoverState.Parent = this.txtNewPassAgain;
            this.txtNewPassAgain.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNewPassAgain.IconLeft")));
            this.txtNewPassAgain.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtNewPassAgain.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtNewPassAgain.Location = new System.Drawing.Point(13, 123);
            this.txtNewPassAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPassAgain.MaxLength = 10;
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.PasswordChar = '\0';
            this.txtNewPassAgain.PlaceholderText = "New Password (again)";
            this.txtNewPassAgain.SelectedText = "";
            this.txtNewPassAgain.ShadowDecoration.Parent = this.txtNewPassAgain;
            this.txtNewPassAgain.Size = new System.Drawing.Size(295, 38);
            this.txtNewPassAgain.TabIndex = 5;
            this.txtNewPassAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassAgain.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.White;
            this.txtNewPass.BorderColor = System.Drawing.Color.Black;
            this.txtNewPass.BorderRadius = 18;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNewPass.IconLeft")));
            this.txtNewPass.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtNewPass.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtNewPass.Location = new System.Drawing.Point(13, 75);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.MaxLength = 10;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "New Password";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(295, 38);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BackColor = System.Drawing.Color.White;
            this.txtCurrentPass.BorderColor = System.Drawing.Color.Black;
            this.txtCurrentPass.BorderRadius = 18;
            this.txtCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPass.DefaultText = "";
            this.txtCurrentPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPass.DisabledState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtCurrentPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPass.FocusedState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.White;
            this.txtCurrentPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPass.HoverState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtCurrentPass.IconLeft")));
            this.txtCurrentPass.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtCurrentPass.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtCurrentPass.Location = new System.Drawing.Point(13, 26);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrentPass.MaxLength = 10;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '\0';
            this.txtCurrentPass.PlaceholderText = "Current Password";
            this.txtCurrentPass.SelectedText = "";
            this.txtCurrentPass.ShadowDecoration.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Size = new System.Drawing.Size(295, 38);
            this.txtCurrentPass.TabIndex = 3;
            this.txtCurrentPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordNew.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPasswordNew.Location = new System.Drawing.Point(63, 261);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(198, 17);
            this.lblPasswordNew.TabIndex = 36;
            this.lblPasswordNew.Text = "New Passwords does not match!";
            this.lblPasswordNew.Visible = false;
            // 
            // lblEnterPass
            // 
            this.lblEnterPass.AutoSize = true;
            this.lblEnterPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnterPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEnterPass.Location = new System.Drawing.Point(80, 261);
            this.lblEnterPass.Name = "lblEnterPass";
            this.lblEnterPass.Size = new System.Drawing.Size(162, 17);
            this.lblEnterPass.TabIndex = 83;
            this.lblEnterPass.Text = "Please enter a Passwords !";
            this.lblEnterPass.Visible = false;
            // 
            // PanelMail
            // 
            this.PanelMail.Controls.Add(this.pictureBox2);
            this.PanelMail.Controls.Add(this.label6);
            this.PanelMail.Controls.Add(this.lblMailEnter);
            this.PanelMail.Controls.Add(this.btnMailNext);
            this.PanelMail.Controls.Add(this.txtNewMail);
            this.PanelMail.Controls.Add(this.txtMail);
            this.PanelMail.Location = new System.Drawing.Point(235, 58);
            this.PanelMail.Name = "PanelMail";
            this.PanelMail.Size = new System.Drawing.Size(331, 364);
            this.PanelMail.TabIndex = 79;
            this.PanelMail.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(29, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Attention! Your previous email will be deleted.";
            // 
            // lblMailEnter
            // 
            this.lblMailEnter.AutoSize = true;
            this.lblMailEnter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailEnter.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMailEnter.Location = new System.Drawing.Point(97, 206);
            this.lblMailEnter.Name = "lblMailEnter";
            this.lblMailEnter.Size = new System.Drawing.Size(141, 17);
            this.lblMailEnter.TabIndex = 52;
            this.lblMailEnter.Text = "Please enter a E-MAIL !";
            this.lblMailEnter.Visible = false;
            // 
            // btnMailNext
            // 
            this.btnMailNext.Animated = true;
            this.btnMailNext.BorderRadius = 18;
            this.btnMailNext.CheckedState.Parent = this.btnMailNext;
            this.btnMailNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMailNext.CustomImages.Parent = this.btnMailNext;
            this.btnMailNext.FillColor = System.Drawing.Color.Silver;
            this.btnMailNext.FillColor2 = System.Drawing.Color.Silver;
            this.btnMailNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMailNext.ForeColor = System.Drawing.Color.Black;
            this.btnMailNext.HoverState.Parent = this.btnMailNext;
            this.btnMailNext.Location = new System.Drawing.Point(9, 139);
            this.btnMailNext.Name = "btnMailNext";
            this.btnMailNext.ShadowDecoration.Parent = this.btnMailNext;
            this.btnMailNext.Size = new System.Drawing.Size(295, 38);
            this.btnMailNext.TabIndex = 46;
            this.btnMailNext.Text = "Next";
            this.btnMailNext.Click += new System.EventHandler(this.btnMailNext_Click);
            // 
            // txtNewMail
            // 
            this.txtNewMail.BackColor = System.Drawing.Color.White;
            this.txtNewMail.BorderColor = System.Drawing.Color.Black;
            this.txtNewMail.BorderRadius = 18;
            this.txtNewMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewMail.DefaultText = "";
            this.txtNewMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewMail.DisabledState.Parent = this.txtNewMail;
            this.txtNewMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtNewMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewMail.FocusedState.Parent = this.txtNewMail;
            this.txtNewMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewMail.ForeColor = System.Drawing.Color.White;
            this.txtNewMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewMail.HoverState.Parent = this.txtNewMail;
            this.txtNewMail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNewMail.IconLeft")));
            this.txtNewMail.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtNewMail.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtNewMail.Location = new System.Drawing.Point(9, 81);
            this.txtNewMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewMail.MaxLength = 50;
            this.txtNewMail.Name = "txtNewMail";
            this.txtNewMail.PasswordChar = '\0';
            this.txtNewMail.PlaceholderText = "Enter your new email";
            this.txtNewMail.SelectedText = "";
            this.txtNewMail.ShadowDecoration.Parent = this.txtNewMail;
            this.txtNewMail.Size = new System.Drawing.Size(295, 38);
            this.txtNewMail.TabIndex = 45;
            this.txtNewMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedState.Parent = this.txtMail;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.LightGray;
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.HoverState.Parent = this.txtMail;
            this.txtMail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMail.IconLeft")));
            this.txtMail.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtMail.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtMail.Location = new System.Drawing.Point(9, 26);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.ReadOnly = true;
            this.txtMail.SelectedText = "";
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(295, 38);
            this.txtMail.TabIndex = 44;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelPhone
            // 
            this.PanelPhone.Controls.Add(this.mskTel);
            this.PanelPhone.Controls.Add(this.pictureBox3);
            this.PanelPhone.Controls.Add(this.label7);
            this.PanelPhone.Controls.Add(this.lblPhoneEnter);
            this.PanelPhone.Controls.Add(this.mskNewTel);
            this.PanelPhone.Controls.Add(this.btnPhoneNext);
            this.PanelPhone.Controls.Add(this.guna2TextBox5);
            this.PanelPhone.Controls.Add(this.guna2TextBox4);
            this.PanelPhone.Location = new System.Drawing.Point(232, 62);
            this.PanelPhone.Name = "PanelPhone";
            this.PanelPhone.Size = new System.Drawing.Size(357, 316);
            this.PanelPhone.TabIndex = 80;
            this.PanelPhone.Visible = false;
            // 
            // mskTel
            // 
            this.mskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.mskTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.ForeColor = System.Drawing.Color.Silver;
            this.mskTel.Location = new System.Drawing.Point(56, 31);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.ReadOnly = true;
            this.mskTel.Size = new System.Drawing.Size(144, 22);
            this.mskTel.TabIndex = 48;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(32, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Attention! Your previous number will be deleted.";
            // 
            // lblPhoneEnter
            // 
            this.lblPhoneEnter.AutoSize = true;
            this.lblPhoneEnter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneEnter.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhoneEnter.Location = new System.Drawing.Point(66, 202);
            this.lblPhoneEnter.Name = "lblPhoneEnter";
            this.lblPhoneEnter.Size = new System.Drawing.Size(185, 17);
            this.lblPhoneEnter.TabIndex = 51;
            this.lblPhoneEnter.Text = "Please enter a phone number!";
            this.lblPhoneEnter.Visible = false;
            // 
            // mskNewTel
            // 
            this.mskNewTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.mskNewTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskNewTel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskNewTel.ForeColor = System.Drawing.Color.White;
            this.mskNewTel.Location = new System.Drawing.Point(56, 85);
            this.mskNewTel.Mask = "(999) 000-0000";
            this.mskNewTel.Name = "mskNewTel";
            this.mskNewTel.Size = new System.Drawing.Size(144, 22);
            this.mskNewTel.TabIndex = 49;
            // 
            // btnPhoneNext
            // 
            this.btnPhoneNext.Animated = true;
            this.btnPhoneNext.BorderRadius = 18;
            this.btnPhoneNext.CheckedState.Parent = this.btnPhoneNext;
            this.btnPhoneNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhoneNext.CustomImages.Parent = this.btnPhoneNext;
            this.btnPhoneNext.FillColor = System.Drawing.Color.Silver;
            this.btnPhoneNext.FillColor2 = System.Drawing.Color.Silver;
            this.btnPhoneNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhoneNext.ForeColor = System.Drawing.Color.Black;
            this.btnPhoneNext.HoverState.Parent = this.btnPhoneNext;
            this.btnPhoneNext.Location = new System.Drawing.Point(12, 135);
            this.btnPhoneNext.Name = "btnPhoneNext";
            this.btnPhoneNext.ShadowDecoration.Parent = this.btnPhoneNext;
            this.btnPhoneNext.Size = new System.Drawing.Size(296, 38);
            this.btnPhoneNext.TabIndex = 47;
            this.btnPhoneNext.Text = "Next";
            this.btnPhoneNext.Click += new System.EventHandler(this.btnPhoneNext_Click);
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BackColor = System.Drawing.Color.White;
            this.guna2TextBox5.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox5.BorderRadius = 18;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TextBox5.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox5.IconLeft")));
            this.guna2TextBox5.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.guna2TextBox5.IconLeftSize = new System.Drawing.Size(22, 22);
            this.guna2TextBox5.Location = new System.Drawing.Point(12, 77);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox5.MaxLength = 50;
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.ReadOnly = true;
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(295, 38);
            this.guna2TextBox5.TabIndex = 46;
            this.guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BackColor = System.Drawing.Color.White;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox4.BorderRadius = 18;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TextBox4.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox4.IconLeft")));
            this.guna2TextBox4.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.guna2TextBox4.IconLeftSize = new System.Drawing.Size(22, 22);
            this.guna2TextBox4.Location = new System.Drawing.Point(13, 22);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.MaxLength = 50;
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.ReadOnly = true;
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(295, 38);
            this.guna2TextBox4.TabIndex = 45;
            this.guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageslide
            // 
            this.imageslide.Image = ((System.Drawing.Image)(resources.GetObject("imageslide.Image")));
            this.imageslide.Location = new System.Drawing.Point(202, 32);
            this.imageslide.Name = "imageslide";
            this.imageslide.Size = new System.Drawing.Size(166, 24);
            this.imageslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageslide.TabIndex = 81;
            this.imageslide.TabStop = false;
            // 
            // SettingUserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelPhone);
            this.Controls.Add(this.imageslide);
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PanelMail);
            this.Name = "SettingUserControl1";
            this.Size = new System.Drawing.Size(790, 422);
//            this.Load += new System.EventHandler(this.SettingUserControl1_Load);
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMail.ResumeLayout(false);
            this.PanelMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelPhone.ResumeLayout(false);
            this.PanelPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageslide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GradientButton btnPhone;
        private Guna.UI2.WinForms.Guna2GradientButton btnMail;
        private Guna.UI2.WinForms.Guna2GradientButton btnPassword;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.Panel PanelMail;
        private System.Windows.Forms.Panel PanelPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassAgain;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPass;
        private Guna.UI2.WinForms.Guna2GradientButton btnPassNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.Label lblPasswordCurrent;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2GradientButton btnMailNext;
        private Guna.UI2.WinForms.Guna2TextBox txtNewMail;
        private Guna.UI2.WinForms.Guna2GradientButton btnPhoneNext;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.MaskedTextBox mskNewTel;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label lblMailEnter;
        private System.Windows.Forms.Label lblPhoneEnter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnShowPass;
        private System.Windows.Forms.Label lblEnterPass;
        private System.Windows.Forms.PictureBox imageslide;
    }
}

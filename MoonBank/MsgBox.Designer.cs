
namespace MoonBank
{
    partial class MsgBox
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
            this.btnOK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pbicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Animated = true;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 15;
            this.btnOK.BorderThickness = 1;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnOK.FillColor2 = System.Drawing.Color.Firebrick;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(26, 166);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(328, 36);
            this.btnOK.TabIndex = 81;
            this.btnOK.Text = "OK";
            this.btnOK.UseTransparentBackground = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.Location = new System.Drawing.Point(68, 105);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(243, 42);
            this.lblInfo.TabIndex = 121;
            this.lblInfo.Text = "Your photo has been successfully \r\n                      updated.";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pbicon
            // 
            this.pbicon.Image = global::MoonBank.Properties.Resources.icons8_ok_96px_1;
            this.pbicon.Location = new System.Drawing.Point(141, 17);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(107, 77);
            this.pbicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbicon.TabIndex = 82;
            this.pbicon.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(382, 222);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbicon);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        internal System.Windows.Forms.Label lblInfo;
        internal Guna.UI2.WinForms.Guna2GradientButton btnOK;
        internal System.Windows.Forms.PictureBox pbicon;
    }
}

namespace LoginForm___Lopez
{
    partial class EDP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.compLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.accName = new System.Windows.Forms.Label();
            this.usernameIcon = new System.Windows.Forms.PictureBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.compLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleName = "";
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.HideSelection = false;
            this.txtUsername.Location = new System.Drawing.Point(302, 197);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            // 
            // compLogo
            // 
            this.compLogo.BackgroundImage = global::LoginForm___Lopez.Properties.Resources.crop_image_1547328138787;
            this.compLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compLogo.Location = new System.Drawing.Point(339, 48);
            this.compLogo.Name = "compLogo";
            this.compLogo.Size = new System.Drawing.Size(97, 87);
            this.compLogo.TabIndex = 0;
            this.compLogo.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "";
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(302, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            // 
            // buttonSignup
            // 
            this.buttonSignup.AccessibleName = "";
            this.buttonSignup.Location = new System.Drawing.Point(302, 275);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(60, 24);
            this.buttonSignup.TabIndex = 3;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AccessibleName = "";
            this.buttonLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonLogin.Location = new System.Drawing.Point(416, 275);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(60, 24);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // accName
            // 
            this.accName.AccessibleName = "accName";
            this.accName.AutoSize = true;
            this.accName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accName.Location = new System.Drawing.Point(339, 152);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(103, 21);
            this.accName.TabIndex = 5;
            this.accName.Text = "EDP Account";
            this.accName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameIcon
            // 
            this.usernameIcon.AccessibleName = "";
            this.usernameIcon.BackgroundImage = global::LoginForm___Lopez.Properties.Resources.user__3_1;
            this.usernameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usernameIcon.Location = new System.Drawing.Point(260, 197);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(27, 23);
            this.usernameIcon.TabIndex = 6;
            this.usernameIcon.TabStop = false;
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackgroundImage = global::LoginForm___Lopez.Properties.Resources.key;
            this.passwordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordIcon.Location = new System.Drawing.Point(260, 236);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(27, 23);
            this.passwordIcon.TabIndex = 7;
            this.passwordIcon.TabStop = false;
            // 
            // EDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 473);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.usernameIcon);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.compLogo);
            this.Name = "EDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Driven Programming";
            ((System.ComponentModel.ISupportInitialize)(this.compLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox compLogo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label accName;
        private System.Windows.Forms.PictureBox usernameIcon;
        private System.Windows.Forms.PictureBox passwordIcon;
    }
}


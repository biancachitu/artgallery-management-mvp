using System.Drawing;
using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.viewArtBtn = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelWelcome2 = new System.Windows.Forms.Label();
            this.labelStaffLogin = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewArtBtn
            // 
            this.viewArtBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewArtBtn.ForeColor = System.Drawing.Color.Purple;
            this.viewArtBtn.Location = new System.Drawing.Point(905, 509);
            this.viewArtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewArtBtn.Name = "viewArtBtn";
            this.viewArtBtn.Size = new System.Drawing.Size(167, 76);
            this.viewArtBtn.TabIndex = 0;
            this.viewArtBtn.Text = "View artworks";
            this.viewArtBtn.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Verdana", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Magenta;
            this.labelWelcome.Location = new System.Drawing.Point(612, 252);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(498, 73);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Drawn to art?";
            // 
            // labelWelcome2
            // 
            this.labelWelcome2.AutoSize = true;
            this.labelWelcome2.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelWelcome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelWelcome2.Location = new System.Drawing.Point(846, 363);
            this.labelWelcome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome2.Name = "labelWelcome2";
            this.labelWelcome2.Size = new System.Drawing.Size(415, 34);
            this.labelWelcome2.TabIndex = 4;
            this.labelWelcome2.Text = "Come art-seeing with us!";
            // 
            // labelStaffLogin
            // 
            this.labelStaffLogin.AutoSize = true;
            this.labelStaffLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelStaffLogin.Location = new System.Drawing.Point(1503, 22);
            this.labelStaffLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStaffLogin.Name = "labelStaffLogin";
            this.labelStaffLogin.Size = new System.Drawing.Size(120, 22);
            this.labelStaffLogin.TabIndex = 5;
            this.labelStaffLogin.Text = "Staff Login";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelEmail.Location = new System.Drawing.Point(1504, 64);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 18);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelPassword.Location = new System.Drawing.Point(1504, 105);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(85, 18);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1627, 56);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1627, 97);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.Purple;
            this.loginBtn.Location = new System.Drawing.Point(1651, 148);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(86, 47);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelStaffLogin);
            this.Controls.Add(this.labelWelcome2);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.viewArtBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginView";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewArtBtn;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelWelcome2;
        private System.Windows.Forms.Label labelStaffLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button loginBtn;
    }
}

namespace ShoesStoreManagement.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pbxMovingMan = new System.Windows.Forms.PictureBox();
            this.pbxShoes = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsernameNotice = new System.Windows.Forms.Label();
            this.lblPasswordNotice = new System.Windows.Forms.Label();
            this.pbxSize = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovingMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbxPassword.Location = new System.Drawing.Point(513, 362);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(371, 60);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.TabStop = false;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(705, 113);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 65);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(513, 510);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(571, 77);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbxUsername.Location = new System.Drawing.Point(513, 228);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(371, 60);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.TabStop = false;
            this.tbxUsername.Text = "Username";
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.pbxMovingMan);
            this.pnlLeft.Controls.Add(this.pbxShoes);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(334, 700);
            this.pnlLeft.TabIndex = 8;
            // 
            // pbxMovingMan
            // 
            this.pbxMovingMan.Image = global::ShoesStoreManagement.Properties.Resources.Moving_gif;
            this.pbxMovingMan.Location = new System.Drawing.Point(13, 376);
            this.pbxMovingMan.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMovingMan.Name = "pbxMovingMan";
            this.pbxMovingMan.Size = new System.Drawing.Size(300, 300);
            this.pbxMovingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMovingMan.TabIndex = 1;
            this.pbxMovingMan.TabStop = false;
            // 
            // pbxShoes
            // 
            this.pbxShoes.Image = ((System.Drawing.Image)(resources.GetObject("pbxShoes.Image")));
            this.pbxShoes.Location = new System.Drawing.Point(13, 35);
            this.pbxShoes.Margin = new System.Windows.Forms.Padding(2);
            this.pbxShoes.Name = "pbxShoes";
            this.pbxShoes.Size = new System.Drawing.Size(300, 290);
            this.pbxShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShoes.TabIndex = 0;
            this.pbxShoes.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(508, 238);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(312, 50);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "_________________________\r\n\r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(508, 369);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(312, 50);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "_________________________\r\n\r\n";
            // 
            // lblUsernameNotice
            // 
            this.lblUsernameNotice.AutoSize = true;
            this.lblUsernameNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameNotice.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameNotice.Location = new System.Drawing.Point(509, 301);
            this.lblUsernameNotice.Name = "lblUsernameNotice";
            this.lblUsernameNotice.Size = new System.Drawing.Size(163, 24);
            this.lblUsernameNotice.TabIndex = 5;
            this.lblUsernameNotice.Text = "Nhập Username!!!";
            this.lblUsernameNotice.Visible = false;
            // 
            // lblPasswordNotice
            // 
            this.lblPasswordNotice.AutoSize = true;
            this.lblPasswordNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNotice.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordNotice.Location = new System.Drawing.Point(509, 436);
            this.lblPasswordNotice.Name = "lblPasswordNotice";
            this.lblPasswordNotice.Size = new System.Drawing.Size(158, 24);
            this.lblPasswordNotice.TabIndex = 6;
            this.lblPasswordNotice.Text = "Nhập Password!!!";
            this.lblPasswordNotice.Visible = false;
            // 
            // pbxSize
            // 
            this.pbxSize.Image = global::ShoesStoreManagement.Properties.Resources.Dash;
            this.pbxSize.Location = new System.Drawing.Point(1175, 11);
            this.pbxSize.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSize.Name = "pbxSize";
            this.pbxSize.Size = new System.Drawing.Size(40, 40);
            this.pbxSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSize.TabIndex = 4;
            this.pbxSize.TabStop = false;
            this.pbxSize.Click += new System.EventHandler(this.pbxSize_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Image = global::ShoesStoreManagement.Properties.Resources.X;
            this.pbxClose.Location = new System.Drawing.Point(1241, 11);
            this.pbxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(40, 40);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClose.TabIndex = 5;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.lblPasswordNotice);
            this.Controls.Add(this.lblUsernameNotice);
            this.Controls.Add(this.pbxSize);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovingMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pbxShoes;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxSize;
        private System.Windows.Forms.PictureBox pbxMovingMan;
        private System.Windows.Forms.Label lblUsernameNotice;
        private System.Windows.Forms.Label lblPasswordNotice;
        private System.Windows.Forms.Label lblUsername;
    }
}
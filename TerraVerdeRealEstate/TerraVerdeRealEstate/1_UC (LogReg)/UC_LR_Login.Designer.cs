namespace TerraVerdeRealEstate.UC__LogReg_
{
    partial class UC_LR_Login
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
            this.btn_goclient = new System.Windows.Forms.Button();
            this.btn_goseller = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_fpass = new System.Windows.Forms.Label();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.lbl_noaccountmsg = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_goadmin = new System.Windows.Forms.Button();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pb_wallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_goclient
            // 
            this.btn_goclient.Location = new System.Drawing.Point(514, 247);
            this.btn_goclient.Name = "btn_goclient";
            this.btn_goclient.Size = new System.Drawing.Size(83, 35);
            this.btn_goclient.TabIndex = 37;
            this.btn_goclient.TabStop = false;
            this.btn_goclient.Text = "client";
            this.btn_goclient.UseVisualStyleBackColor = true;
            this.btn_goclient.Visible = false;
            this.btn_goclient.Click += new System.EventHandler(this.btn_goclient_Click);
            // 
            // btn_goseller
            // 
            this.btn_goseller.Location = new System.Drawing.Point(514, 177);
            this.btn_goseller.Name = "btn_goseller";
            this.btn_goseller.Size = new System.Drawing.Size(83, 35);
            this.btn_goseller.TabIndex = 36;
            this.btn_goseller.TabStop = false;
            this.btn_goseller.Text = "sellers";
            this.btn_goseller.UseVisualStyleBackColor = true;
            this.btn_goseller.Visible = false;
            this.btn_goseller.Click += new System.EventHandler(this.btn_goseller_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_login.Location = new System.Drawing.Point(266, 308);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(88, 28);
            this.lbl_login.TabIndex = 34;
            this.lbl_login.Text = "LOGIN";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_password.Location = new System.Drawing.Point(121, 426);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(115, 18);
            this.lbl_password.TabIndex = 33;
            this.lbl_password.Text = "Enter Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_username.Location = new System.Drawing.Point(121, 358);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 18);
            this.lbl_username.TabIndex = 32;
            this.lbl_username.Text = "Enter Username:";
            // 
            // lbl_fpass
            // 
            this.lbl_fpass.AutoSize = true;
            this.lbl_fpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fpass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fpass.Location = new System.Drawing.Point(323, 478);
            this.lbl_fpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fpass.Name = "lbl_fpass";
            this.lbl_fpass.Size = new System.Drawing.Size(163, 20);
            this.lbl_fpass.TabIndex = 31;
            this.lbl_fpass.Text = "I forgot my password";
            this.lbl_fpass.Click += new System.EventHandler(this.lbl_fpass_Click);
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_signup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.Location = new System.Drawing.Point(249, 641);
            this.lbl_signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(108, 20);
            this.lbl_signup.TabIndex = 30;
            this.lbl_signup.Text = "Register now!";
            this.lbl_signup.Click += new System.EventHandler(this.lbl_signup_Click);
            // 
            // lbl_noaccountmsg
            // 
            this.lbl_noaccountmsg.AutoSize = true;
            this.lbl_noaccountmsg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noaccountmsg.Location = new System.Drawing.Point(169, 613);
            this.lbl_noaccountmsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_noaccountmsg.Name = "lbl_noaccountmsg";
            this.lbl_noaccountmsg.Size = new System.Drawing.Size(292, 20);
            this.lbl_noaccountmsg.TabIndex = 29;
            this.lbl_noaccountmsg.Text = "Don\'t have a TerraVerde account yet?";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.MintCream;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1253, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(27, 24);
            this.btn_exit.TabIndex = 28;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(125, 526);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(357, 39);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Sign in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_password.Location = new System.Drawing.Point(125, 449);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(357, 26);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_username.Location = new System.Drawing.Point(125, 381);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(357, 26);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            // 
            // btn_goadmin
            // 
            this.btn_goadmin.Location = new System.Drawing.Point(514, 316);
            this.btn_goadmin.Name = "btn_goadmin";
            this.btn_goadmin.Size = new System.Drawing.Size(83, 35);
            this.btn_goadmin.TabIndex = 38;
            this.btn_goadmin.TabStop = false;
            this.btn_goadmin.Text = "admin";
            this.btn_goadmin.UseVisualStyleBackColor = true;
            this.btn_goadmin.Visible = false;
            this.btn_goadmin.Click += new System.EventHandler(this.btn_goadmin_Click);
            // 
            // img_logo
            // 
            this.img_logo.Image = global::TerraVerdeRealEstate.Properties.Resources.logo_vertical;
            this.img_logo.Location = new System.Drawing.Point(153, 74);
            this.img_logo.Margin = new System.Windows.Forms.Padding(2);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(296, 232);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_logo.TabIndex = 35;
            this.img_logo.TabStop = false;
            // 
            // pb_wallpaper
            // 
            this.pb_wallpaper.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_wallpaper.Image = global::TerraVerdeRealEstate.Properties.Resources.wallpaper_login;
            this.pb_wallpaper.Location = new System.Drawing.Point(640, 0);
            this.pb_wallpaper.Name = "pb_wallpaper";
            this.pb_wallpaper.Size = new System.Drawing.Size(640, 720);
            this.pb_wallpaper.TabIndex = 24;
            this.pb_wallpaper.TabStop = false;
            // 
            // UC_LR_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_goadmin);
            this.Controls.Add(this.btn_goclient);
            this.Controls.Add(this.btn_goseller);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_fpass);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.lbl_noaccountmsg);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pb_wallpaper);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "UC_LR_Login";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_goclient;
        private System.Windows.Forms.Button btn_goseller;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_fpass;
        private System.Windows.Forms.Label lbl_signup;
        private System.Windows.Forms.Label lbl_noaccountmsg;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pb_wallpaper;
        private System.Windows.Forms.Button btn_goadmin;
    }
}

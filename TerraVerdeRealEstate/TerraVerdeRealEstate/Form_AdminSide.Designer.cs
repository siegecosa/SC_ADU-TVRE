namespace TerraVerdeRealEstate
{
    partial class Form_AdminSide
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.img_profile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_verify = new Guna.UI2.WinForms.Guna2Button();
            this.btn_transactions = new Guna.UI2.WinForms.Guna2Button();
            this.btn_settings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_frontsmall = new System.Windows.Forms.Label();
            this.lbl_frontbig = new System.Windows.Forms.Label();
            this.panelmain_admin = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_top.Controls.Add(this.btn_logout);
            this.panel_top.Controls.Add(this.lbl_username);
            this.panel_top.Controls.Add(this.img_profile);
            this.panel_top.Controls.Add(this.pb_logo);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1280, 71);
            this.panel_top.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1175, 26);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(71, 20);
            this.btn_logout.TabIndex = 20;
            this.btn_logout.Text = "Sign Out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(93, 25);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(97, 24);
            this.lbl_username.TabIndex = 19;
            this.lbl_username.Text = "Username";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // img_profile
            // 
            this.img_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_profile.ImageRotate = 0F;
            this.img_profile.Location = new System.Drawing.Point(21, 9);
            this.img_profile.Name = "img_profile";
            this.img_profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img_profile.Size = new System.Drawing.Size(57, 53);
            this.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_profile.TabIndex = 1;
            this.img_profile.TabStop = false;
            this.img_profile.Click += new System.EventHandler(this.img_profile_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::TerraVerdeRealEstate.Properties.Resources.logo_widehorizontal;
            this.pb_logo.Location = new System.Drawing.Point(591, 9);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(207, 50);
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.White;
            this.panel_left.Controls.Add(this.btn_verify);
            this.panel_left.Controls.Add(this.btn_transactions);
            this.panel_left.Controls.Add(this.btn_settings);
            this.panel_left.Controls.Add(this.btn_dashboard);
            this.panel_left.Controls.Add(this.panel2);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 71);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(150, 649);
            this.panel_left.TabIndex = 3;
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_verify.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_verify.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verify.CustomBorderColor = System.Drawing.Color.White;
            this.btn_verify.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btn_verify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verify.FillColor = System.Drawing.Color.White;
            this.btn_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_verify.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_verify.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_verify.Location = new System.Drawing.Point(0, 141);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(150, 141);
            this.btn_verify.TabIndex = 5;
            this.btn_verify.Text = "Verify User Accounts";
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // btn_transactions
            // 
            this.btn_transactions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_transactions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_transactions.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_transactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transactions.CustomBorderColor = System.Drawing.Color.White;
            this.btn_transactions.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btn_transactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_transactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_transactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_transactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_transactions.FillColor = System.Drawing.Color.White;
            this.btn_transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transactions.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_transactions.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_transactions.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_transactions.Location = new System.Drawing.Point(0, 282);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(150, 141);
            this.btn_transactions.TabIndex = 4;
            this.btn_transactions.Text = "Transaction Logs";
            this.btn_transactions.Click += new System.EventHandler(this.btn_transactions_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_settings.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.CustomBorderColor = System.Drawing.Color.White;
            this.btn_settings.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btn_settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_settings.FillColor = System.Drawing.Color.White;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_settings.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(0, 423);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(150, 141);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Settings";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_dashboard.Checked = true;
            this.btn_dashboard.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_dashboard.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.CustomBorderColor = System.Drawing.Color.White;
            this.btn_dashboard.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.FillColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_dashboard.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(150, 141);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 649);
            this.panel2.TabIndex = 2;
            // 
            // lbl_frontsmall
            // 
            this.lbl_frontsmall.AutoSize = true;
            this.lbl_frontsmall.BackColor = System.Drawing.Color.Transparent;
            this.lbl_frontsmall.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_frontsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frontsmall.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_frontsmall.Location = new System.Drawing.Point(173, 110);
            this.lbl_frontsmall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_frontsmall.Name = "lbl_frontsmall";
            this.lbl_frontsmall.Size = new System.Drawing.Size(201, 18);
            this.lbl_frontsmall.TabIndex = 31;
            this.lbl_frontsmall.Text = "Welcome, Fname Sname!";
            // 
            // lbl_frontbig
            // 
            this.lbl_frontbig.AutoSize = true;
            this.lbl_frontbig.BackColor = System.Drawing.Color.Transparent;
            this.lbl_frontbig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_frontbig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frontbig.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_frontbig.Location = new System.Drawing.Point(171, 85);
            this.lbl_frontbig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_frontbig.Name = "lbl_frontbig";
            this.lbl_frontbig.Size = new System.Drawing.Size(126, 25);
            this.lbl_frontbig.TabIndex = 30;
            this.lbl_frontbig.Text = "Dashboard";
            // 
            // panelmain_admin
            // 
            this.panelmain_admin.BackColor = System.Drawing.Color.DimGray;
            this.panelmain_admin.Location = new System.Drawing.Point(168, 131);
            this.panelmain_admin.Name = "panelmain_admin";
            this.panelmain_admin.Size = new System.Drawing.Size(1100, 578);
            this.panelmain_admin.TabIndex = 29;
            // 
            // Form_AdminSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lbl_frontsmall);
            this.Controls.Add(this.lbl_frontbig);
            this.Controls.Add(this.panelmain_admin);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form_AdminSide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdminSide";
            this.Load += new System.EventHandler(this.Form_AdminSide_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label btn_logout;
        private System.Windows.Forms.Label lbl_username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox img_profile;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel_left;
        private Guna.UI2.WinForms.Guna2Button btn_verify;
        private Guna.UI2.WinForms.Guna2Button btn_transactions;
        private Guna.UI2.WinForms.Guna2Button btn_settings;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_frontsmall;
        private System.Windows.Forms.Label lbl_frontbig;
        private System.Windows.Forms.Panel panelmain_admin;
    }
}
namespace TerraVerdeRealEstate._1_UC__OTPPass_
{
    partial class UC_OP_PassReset
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_cpassword = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_show1 = new System.Windows.Forms.Button();
            this.btn_show2 = new System.Windows.Forms.Button();
            this.btn_submitnewpass = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_username.Location = new System.Drawing.Point(103, 129);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(241, 23);
            this.lbl_username.TabIndex = 23;
            this.lbl_username.Text = "Enter your new password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_password.Location = new System.Drawing.Point(105, 159);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(303, 30);
            this.txt_password.TabIndex = 20;
            this.txt_password.TabStop = false;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_title.Location = new System.Drawing.Point(197, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(191, 30);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Password Reset";
            // 
            // txt_cpassword
            // 
            this.txt_cpassword.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_cpassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_cpassword.Location = new System.Drawing.Point(105, 249);
            this.txt_cpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cpassword.Name = "txt_cpassword";
            this.txt_cpassword.PasswordChar = '*';
            this.txt_cpassword.Size = new System.Drawing.Size(304, 30);
            this.txt_cpassword.TabIndex = 21;
            this.txt_cpassword.TabStop = false;
            this.txt_cpassword.Text = "Confirm Password";
            this.txt_cpassword.Enter += new System.EventHandler(this.txt_cpassword_Enter);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_email.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_email.Location = new System.Drawing.Point(104, 225);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(223, 23);
            this.lbl_email.TabIndex = 22;
            this.lbl_email.Text = "Confirm new password:";
            // 
            // btn_show1
            // 
            this.btn_show1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show1.Location = new System.Drawing.Point(404, 159);
            this.btn_show1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_show1.Name = "btn_show1";
            this.btn_show1.Size = new System.Drawing.Size(69, 32);
            this.btn_show1.TabIndex = 24;
            this.btn_show1.TabStop = false;
            this.btn_show1.Text = "Show";
            this.btn_show1.UseVisualStyleBackColor = true;
            this.btn_show1.Click += new System.EventHandler(this.btn_show1_Click);
            // 
            // btn_show2
            // 
            this.btn_show2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show2.Location = new System.Drawing.Point(405, 249);
            this.btn_show2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_show2.Name = "btn_show2";
            this.btn_show2.Size = new System.Drawing.Size(69, 32);
            this.btn_show2.TabIndex = 25;
            this.btn_show2.TabStop = false;
            this.btn_show2.Text = "Show";
            this.btn_show2.UseVisualStyleBackColor = true;
            this.btn_show2.Click += new System.EventHandler(this.btn_show2_Click);
            // 
            // btn_submitnewpass
            // 
            this.btn_submitnewpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submitnewpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_submitnewpass.Location = new System.Drawing.Point(103, 369);
            this.btn_submitnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submitnewpass.Name = "btn_submitnewpass";
            this.btn_submitnewpass.Size = new System.Drawing.Size(371, 37);
            this.btn_submitnewpass.TabIndex = 26;
            this.btn_submitnewpass.TabStop = false;
            this.btn_submitnewpass.Text = "Reset Password";
            this.btn_submitnewpass.UseVisualStyleBackColor = true;
            this.btn_submitnewpass.Click += new System.EventHandler(this.btn_submitnewpass_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_cancel.Location = new System.Drawing.Point(104, 427);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(369, 36);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // UC_OP_PassReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_submitnewpass);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_show2);
            this.Controls.Add(this.btn_show1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_cpassword);
            this.Controls.Add(this.lbl_email);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(600, 615);
            this.MinimumSize = new System.Drawing.Size(600, 615);
            this.Name = "UC_OP_PassReset";
            this.Size = new System.Drawing.Size(600, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_cpassword;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_show1;
        private System.Windows.Forms.Button btn_show2;
        private System.Windows.Forms.Button btn_submitnewpass;
        private System.Windows.Forms.Button btn_cancel;
    }
}

namespace TerraVerdeRealEstate._1_UC__OTPPass_
{
    partial class UC_OP_OTP
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_submitotp = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_entercode = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Button();
            this.timer_code = new System.Windows.Forms.Timer(this.components);
            this.error_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_otp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_otp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_username.Location = new System.Drawing.Point(77, 105);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(162, 18);
            this.lbl_username.TabIndex = 18;
            this.lbl_username.Text = "Enter your username:";
            this.lbl_username.Validating += new System.ComponentModel.CancelEventHandler(this.lbl_username_Validating);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_username.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_username.Location = new System.Drawing.Point(79, 129);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(274, 26);
            this.txt_username.TabIndex = 10;
            this.txt_username.TabStop = false;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            // 
            // btn_submitotp
            // 
            this.btn_submitotp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submitotp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_submitotp.Location = new System.Drawing.Point(80, 361);
            this.btn_submitotp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_submitotp.Name = "btn_submitotp";
            this.btn_submitotp.Size = new System.Drawing.Size(278, 30);
            this.btn_submitotp.TabIndex = 13;
            this.btn_submitotp.TabStop = false;
            this.btn_submitotp.Text = "Submit OTP";
            this.btn_submitotp.UseVisualStyleBackColor = true;
            this.btn_submitotp.Click += new System.EventHandler(this.btn_submitotp_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_title.Location = new System.Drawing.Point(148, 44);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(150, 23);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Password Reset";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_cancel.Location = new System.Drawing.Point(81, 408);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(277, 29);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_entercode
            // 
            this.lbl_entercode.AutoSize = true;
            this.lbl_entercode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_entercode.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_entercode.Location = new System.Drawing.Point(75, 257);
            this.lbl_entercode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_entercode.Name = "lbl_entercode";
            this.lbl_entercode.Size = new System.Drawing.Size(123, 18);
            this.lbl_entercode.TabIndex = 16;
            this.lbl_entercode.Text = "Enter OTP code:";
            this.lbl_entercode.Validating += new System.ComponentModel.CancelEventHandler(this.lbl_entercode_Validating);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_code.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_code.Location = new System.Drawing.Point(78, 278);
            this.txt_code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_code.MaxLength = 6;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(277, 26);
            this.txt_code.TabIndex = 12;
            this.txt_code.TabStop = false;
            this.txt_code.Text = "OTP Code";
            this.txt_code.Enter += new System.EventHandler(this.txt_code_Enter);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_email.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_email.Location = new System.Drawing.Point(78, 199);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(277, 26);
            this.txt_email.TabIndex = 11;
            this.txt_email.TabStop = false;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_email.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_email.Location = new System.Drawing.Point(77, 180);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(131, 18);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Enter your email:";
            this.lbl_email.Validating += new System.ComponentModel.CancelEventHandler(this.lbl_email_Validating);
            // 
            // lbl_code
            // 
            this.lbl_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_code.Location = new System.Drawing.Point(254, 278);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(104, 26);
            this.lbl_code.TabIndex = 19;
            this.lbl_code.TabStop = false;
            this.lbl_code.Text = "Send OTP Code";
            this.lbl_code.UseVisualStyleBackColor = true;
            this.lbl_code.Click += new System.EventHandler(this.lbl_code_Click);
            // 
            // timer_code
            // 
            this.timer_code.Interval = 1000;
            this.timer_code.Tick += new System.EventHandler(this.timer_code_Tick);
            // 
            // error_username
            // 
            this.error_username.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_username.ContainerControl = this;
            // 
            // error_email
            // 
            this.error_email.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_email.ContainerControl = this;
            // 
            // error_otp
            // 
            this.error_otp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_otp.ContainerControl = this;
            // 
            // UC_OP_OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_submitotp);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_entercode);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "UC_OP_OTP";
            this.Size = new System.Drawing.Size(450, 500);
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_otp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_submitotp;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_entercode;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button lbl_code;
        private System.Windows.Forms.Timer timer_code;
        private System.Windows.Forms.ErrorProvider error_username;
        private System.Windows.Forms.ErrorProvider error_email;
        private System.Windows.Forms.ErrorProvider error_otp;
    }
}

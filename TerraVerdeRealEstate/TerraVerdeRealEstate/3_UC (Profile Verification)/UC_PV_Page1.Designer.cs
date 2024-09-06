namespace TerraVerdeRealEstate._3_UC__Profile_Verification_
{
    partial class UC_PV_Page1
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
            this.lbl = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.timer_code = new System.Windows.Forms.Timer(this.components);
            this.error_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_otp = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkboxagree = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_otp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl.Location = new System.Drawing.Point(51, 278);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(271, 45);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Terra Verde End-User Software Verification Agreement";
            // 
            // btn_proceed
            // 
            this.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed.Enabled = false;
            this.btn_proceed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_proceed.Location = new System.Drawing.Point(53, 424);
            this.btn_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(278, 30);
            this.btn_proceed.TabIndex = 24;
            this.btn_proceed.TabStop = false;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_title.Location = new System.Drawing.Point(38, 23);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(302, 53);
            this.lbl_title.TabIndex = 20;
            this.lbl_title.Text = "Terra Verde User Verification Process";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_cancel.Location = new System.Drawing.Point(54, 469);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(277, 29);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // timer_code
            // 
            this.timer_code.Interval = 1000;
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
            // checkboxagree
            // 
            this.checkboxagree.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxagree.Location = new System.Drawing.Point(42, 326);
            this.checkboxagree.Name = "checkboxagree";
            this.checkboxagree.Size = new System.Drawing.Size(298, 52);
            this.checkboxagree.TabIndex = 40;
            this.checkboxagree.Text = "By checking the box and proceeding, you acknowledge and agree to the following Te" +
    "rra Verde\r\n";
            this.checkboxagree.UseVisualStyleBackColor = true;
            this.checkboxagree.CheckedChanged += new System.EventHandler(this.checkboxagree_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(134, 359);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(150, 16);
            this.lbl_status.TabIndex = 41;
            this.lbl_status.Text = "Terms and Conditions.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 514);
            this.panel1.TabIndex = 44;
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_logo.Image = global::TerraVerdeRealEstate.Properties.Resources.pic_verificationstart;
            this.pb_logo.Location = new System.Drawing.Point(40, 61);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(268, 167);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 29;
            this.pb_logo.TabStop = false;
            // 
            // UC_PV_Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.checkboxagree);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(380, 550);
            this.MinimumSize = new System.Drawing.Size(380, 550);
            this.Name = "UC_PV_Page1";
            this.Size = new System.Drawing.Size(380, 550);
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_otp)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Timer timer_code;
        private System.Windows.Forms.ErrorProvider error_username;
        private System.Windows.Forms.ErrorProvider error_email;
        private System.Windows.Forms.ErrorProvider error_otp;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.CheckBox checkboxagree;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Panel panel1;
    }
}

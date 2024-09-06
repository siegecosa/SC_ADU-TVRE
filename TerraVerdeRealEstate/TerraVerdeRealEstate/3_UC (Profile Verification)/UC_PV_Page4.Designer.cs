namespace TerraVerdeRealEstate._3_UC__Profile_Verification_
{
    partial class UC_PV_Page4
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pb_selfie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_selfie)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_upload.Location = new System.Drawing.Point(110, 367);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(167, 30);
            this.btn_upload.TabIndex = 54;
            this.btn_upload.TabStop = false;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 94);
            this.label1.TabIndex = 53;
            this.label1.Text = "To complete your verification process, please upload a clear and recent selfie. E" +
    "nsure that your face is fully visible and well-lit, with no obstructions such as" +
    " hats or sunglasses. ";
            // 
            // btn_proceed
            // 
            this.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed.Enabled = false;
            this.btn_proceed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_proceed.Location = new System.Drawing.Point(50, 447);
            this.btn_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(278, 30);
            this.btn_proceed.TabIndex = 50;
            this.btn_proceed.TabStop = false;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_title.Location = new System.Drawing.Point(36, 16);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(311, 53);
            this.lbl_title.TabIndex = 49;
            this.lbl_title.Text = "Selfie";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_cancel.Location = new System.Drawing.Point(51, 492);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(277, 29);
            this.btn_cancel.TabIndex = 51;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pb_selfie
            // 
            this.pb_selfie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_selfie.Image = global::TerraVerdeRealEstate.Properties.Resources.pic_selfie;
            this.pb_selfie.Location = new System.Drawing.Point(99, 72);
            this.pb_selfie.Name = "pb_selfie";
            this.pb_selfie.Size = new System.Drawing.Size(178, 198);
            this.pb_selfie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_selfie.TabIndex = 52;
            this.pb_selfie.TabStop = false;
            // 
            // UC_PV_Page4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_selfie);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.MaximumSize = new System.Drawing.Size(380, 550);
            this.MinimumSize = new System.Drawing.Size(380, 550);
            this.Name = "UC_PV_Page4";
            this.Size = new System.Drawing.Size(380, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pb_selfie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_selfie;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancel;
    }
}

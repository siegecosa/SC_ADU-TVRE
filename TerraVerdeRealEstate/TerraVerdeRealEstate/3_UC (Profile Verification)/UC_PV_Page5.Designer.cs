namespace TerraVerdeRealEstate._3_UC__Profile_Verification_
{
    partial class UC_PV_Page5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 94);
            this.label1.TabIndex = 59;
            this.label1.Text = "Your account verification has been queued. An administrator will review your subm" +
    "ission shortly. Please refer to your Terra Verde profile to see your verificatio" +
    "n progress.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_proceed
            // 
            this.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.btn_proceed.Location = new System.Drawing.Point(57, 447);
            this.btn_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(278, 30);
            this.btn_proceed.TabIndex = 56;
            this.btn_proceed.TabStop = false;
            this.btn_proceed.Text = "Done";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_title.Location = new System.Drawing.Point(42, 254);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(311, 53);
            this.lbl_title.TabIndex = 55;
            this.lbl_title.Text = "Verification in Progress...";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.White;
            this.pb_logo.Image = global::TerraVerdeRealEstate.Properties.Resources.Untitled_design;
            this.pb_logo.Location = new System.Drawing.Point(64, 47);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(264, 167);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 60;
            this.pb_logo.TabStop = false;
            // 
            // UC_PV_Page5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.lbl_title);
            this.MaximumSize = new System.Drawing.Size(380, 550);
            this.MinimumSize = new System.Drawing.Size(380, 550);
            this.Name = "UC_PV_Page5";
            this.Size = new System.Drawing.Size(380, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

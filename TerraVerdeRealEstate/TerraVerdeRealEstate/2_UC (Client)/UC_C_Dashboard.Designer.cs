namespace TerraVerdeRealEstate.UC__Client_
{
    partial class UC_C_Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pb_ad = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pb_verified = new System.Windows.Forms.PictureBox();
            this.lbl_verificationstatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.property_container = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myproperty = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_verified)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verification Status";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.pb_ad);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(12, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(745, 247);
            this.panel5.TabIndex = 12;
            // 
            // pb_ad
            // 
            this.pb_ad.BackColor = System.Drawing.Color.Gray;
            this.pb_ad.Location = new System.Drawing.Point(0, 29);
            this.pb_ad.Name = "pb_ad";
            this.pb_ad.Size = new System.Drawing.Size(745, 203);
            this.pb_ad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ad.TabIndex = 2;
            this.pb_ad.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latest Terra Verde News";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.pb_verified);
            this.panel4.Controls.Add(this.lbl_verificationstatus);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(394, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 283);
            this.panel4.TabIndex = 14;
            // 
            // pb_verified
            // 
            this.pb_verified.Location = new System.Drawing.Point(105, 76);
            this.pb_verified.Name = "pb_verified";
            this.pb_verified.Size = new System.Drawing.Size(141, 121);
            this.pb_verified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_verified.TabIndex = 2;
            this.pb_verified.TabStop = false;
            this.pb_verified.Click += new System.EventHandler(this.pb_verified_Click);
            // 
            // lbl_verificationstatus
            // 
            this.lbl_verificationstatus.AutoSize = true;
            this.lbl_verificationstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificationstatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_verificationstatus.Location = new System.Drawing.Point(144, 221);
            this.lbl_verificationstatus.Name = "lbl_verificationstatus";
            this.lbl_verificationstatus.Size = new System.Drawing.Size(62, 20);
            this.lbl_verificationstatus.TabIndex = 1;
            this.lbl_verificationstatus.Text = "Status";
            this.lbl_verificationstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.property_container);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(775, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 548);
            this.panel3.TabIndex = 13;
            // 
            // property_container
            // 
            this.property_container.BackColor = System.Drawing.Color.Gray;
            this.property_container.Location = new System.Drawing.Point(20, 51);
            this.property_container.Name = "property_container";
            this.property_container.Size = new System.Drawing.Size(276, 482);
            this.property_container.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Recent Activities";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.myproperty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 283);
            this.panel1.TabIndex = 11;
            // 
            // myproperty
            // 
            this.myproperty.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myproperty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.myproperty.FormattingEnabled = true;
            this.myproperty.ItemHeight = 18;
            this.myproperty.Location = new System.Drawing.Point(18, 51);
            this.myproperty.Name = "myproperty";
            this.myproperty.Size = new System.Drawing.Size(333, 202);
            this.myproperty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "My Properties";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_C_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_C_Dashboard";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_C_Dashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_verified)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel property_container;
        private System.Windows.Forms.ListBox myproperty;
        private System.Windows.Forms.Label lbl_verificationstatus;
        private System.Windows.Forms.PictureBox pb_verified;
        private System.Windows.Forms.PictureBox pb_ad;
        private System.Windows.Forms.Timer timer1;
    }
}

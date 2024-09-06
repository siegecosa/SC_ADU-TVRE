namespace TerraVerdeRealEstate.UC__Seller_
{
    partial class UC_S_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.seller_name = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pb_verified = new System.Windows.Forms.PictureBox();
            this.lbl_verificationstatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ract = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Smyproperty = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_verified)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seller_name
            // 
            this.seller_name.AutoSize = true;
            this.seller_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.seller_name.Location = new System.Drawing.Point(14, 12);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(158, 20);
            this.seller_name.TabIndex = 0;
            this.seller_name.Text = "Verification Status";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(18, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 270);
            this.panel5.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(53, 35);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(668, 222);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Revenue";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.pb_verified);
            this.panel4.Controls.Add(this.lbl_verificationstatus);
            this.panel4.Controls.Add(this.seller_name);
            this.panel4.Location = new System.Drawing.Point(393, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 265);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pb_verified
            // 
            this.pb_verified.Location = new System.Drawing.Point(110, 60);
            this.pb_verified.Name = "pb_verified";
            this.pb_verified.Size = new System.Drawing.Size(141, 121);
            this.pb_verified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_verified.TabIndex = 4;
            this.pb_verified.TabStop = false;
            // 
            // lbl_verificationstatus
            // 
            this.lbl_verificationstatus.AutoSize = true;
            this.lbl_verificationstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificationstatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_verificationstatus.Location = new System.Drawing.Point(149, 205);
            this.lbl_verificationstatus.Name = "lbl_verificationstatus";
            this.lbl_verificationstatus.Size = new System.Drawing.Size(62, 20);
            this.lbl_verificationstatus.TabIndex = 3;
            this.lbl_verificationstatus.Text = "Status";
            this.lbl_verificationstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.ract);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(768, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 547);
            this.panel3.TabIndex = 9;
            // 
            // ract
            // 
            this.ract.BackColor = System.Drawing.Color.Gray;
            this.ract.Location = new System.Drawing.Point(20, 46);
            this.ract.Name = "ract";
            this.ract.Size = new System.Drawing.Size(277, 488);
            this.ract.TabIndex = 4;
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
            this.panel1.Controls.Add(this.Smyproperty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 265);
            this.panel1.TabIndex = 7;
            // 
            // Smyproperty
            // 
            this.Smyproperty.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Smyproperty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Smyproperty.FormattingEnabled = true;
            this.Smyproperty.ItemHeight = 18;
            this.Smyproperty.Location = new System.Drawing.Point(18, 46);
            this.Smyproperty.Name = "Smyproperty";
            this.Smyproperty.Size = new System.Drawing.Size(337, 184);
            this.Smyproperty.TabIndex = 3;
            this.Smyproperty.SelectedIndexChanged += new System.EventHandler(this.Smyproperty_SelectedIndexChanged);
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
            // UC_S_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_S_Dashboard";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_S_Dashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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

        private System.Windows.Forms.Label seller_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel ract;
        private System.Windows.Forms.ListBox Smyproperty;
        private System.Windows.Forms.PictureBox pb_verified;
        private System.Windows.Forms.Label lbl_verificationstatus;
    }
}

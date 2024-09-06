namespace TerraVerdeRealEstate._2_UC__Admin_
{
    partial class UC_A_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_propertyName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_numofunverified = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_recentactivities = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_recenttransaction = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recentactivities)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_propertyName
            // 
            this.lbl_propertyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_propertyName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propertyName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_propertyName.Location = new System.Drawing.Point(71, 28);
            this.lbl_propertyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_propertyName.Name = "lbl_propertyName";
            this.lbl_propertyName.Size = new System.Drawing.Size(348, 30);
            this.lbl_propertyName.TabIndex = 68;
            this.lbl_propertyName.Text = "Pending User Verification";
            this.lbl_propertyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_numofunverified);
            this.panel1.Controls.Add(this.lbl_propertyName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 153);
            this.panel1.TabIndex = 75;
            // 
            // lbl_numofunverified
            // 
            this.lbl_numofunverified.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numofunverified.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numofunverified.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numofunverified.Location = new System.Drawing.Point(71, 69);
            this.lbl_numofunverified.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numofunverified.Name = "lbl_numofunverified";
            this.lbl_numofunverified.Size = new System.Drawing.Size(348, 43);
            this.lbl_numofunverified.TabIndex = 69;
            this.lbl_numofunverified.Text = "00";
            this.lbl_numofunverified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.dgv_recentactivities);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 382);
            this.panel3.TabIndex = 77;
            // 
            // dgv_recentactivities
            // 
            this.dgv_recentactivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recentactivities.Location = new System.Drawing.Point(18, 41);
            this.dgv_recentactivities.Name = "dgv_recentactivities";
            this.dgv_recentactivities.RowHeadersWidth = 51;
            this.dgv_recentactivities.Size = new System.Drawing.Size(1041, 324);
            this.dgv_recentactivities.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(14, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 30);
            this.label4.TabIndex = 68;
            this.label4.Text = "Recent User Activities:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lbl_recenttransaction);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(582, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 153);
            this.panel4.TabIndex = 78;
            // 
            // lbl_recenttransaction
            // 
            this.lbl_recenttransaction.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recenttransaction.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recenttransaction.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_recenttransaction.Location = new System.Drawing.Point(86, 69);
            this.lbl_recenttransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_recenttransaction.Name = "lbl_recenttransaction";
            this.lbl_recenttransaction.Size = new System.Drawing.Size(348, 43);
            this.lbl_recenttransaction.TabIndex = 69;
            this.lbl_recenttransaction.Text = "00";
            this.lbl_recenttransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(86, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 30);
            this.label5.TabIndex = 68;
            this.label5.Text = "Transactions in the last 24h:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 41);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1041, 324);
            this.chart1.TabIndex = 70;
            this.chart1.Text = "chart1";
            // 
            // UC_A_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1100, 578);
            this.MinimumSize = new System.Drawing.Size(1100, 578);
            this.Name = "UC_A_Dashboard";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_A_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recentactivities)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_propertyName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_numofunverified;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_recentactivities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_recenttransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

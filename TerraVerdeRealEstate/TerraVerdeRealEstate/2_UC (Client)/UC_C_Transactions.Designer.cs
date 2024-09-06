namespace TerraVerdeRealEstate.UC__Client_
{
    partial class UC_C_Transactions
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgv_clienttransactions = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_spendings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.property_container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_monthlyspendings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_totalspendings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clienttransactions)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_spendings)).BeginInit();
            this.panel3.SuspendLayout();
            this.property_container.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.dgv_clienttransactions);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 250);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(777, 325);
            this.panel7.TabIndex = 25;
            // 
            // dgv_clienttransactions
            // 
            this.dgv_clienttransactions.AllowUserToAddRows = false;
            this.dgv_clienttransactions.AllowUserToDeleteRows = false;
            this.dgv_clienttransactions.AllowUserToResizeColumns = false;
            this.dgv_clienttransactions.AllowUserToResizeRows = false;
            this.dgv_clienttransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clienttransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clienttransactions.Location = new System.Drawing.Point(22, 45);
            this.dgv_clienttransactions.MultiSelect = false;
            this.dgv_clienttransactions.Name = "dgv_clienttransactions";
            this.dgv_clienttransactions.ReadOnly = true;
            this.dgv_clienttransactions.RowHeadersVisible = false;
            this.dgv_clienttransactions.RowHeadersWidth = 51;
            this.dgv_clienttransactions.Size = new System.Drawing.Size(733, 268);
            this.dgv_clienttransactions.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Transaction History";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.chart_spendings);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(328, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 241);
            this.panel2.TabIndex = 23;
            // 
            // chart_spendings
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_spendings.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_spendings.Legends.Add(legend1);
            this.chart_spendings.Location = new System.Drawing.Point(22, 40);
            this.chart_spendings.Name = "chart_spendings";
            this.chart_spendings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_spendings.Series.Add(series1);
            this.chart_spendings.Size = new System.Drawing.Size(408, 186);
            this.chart_spendings.TabIndex = 17;
            this.chart_spendings.Text = "chart1";
            this.chart_spendings.Click += new System.EventHandler(this.chart_spendings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Monthly Gastos Chart";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(100, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Monthly Spendings";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.property_container);
            this.panel3.Location = new System.Drawing.Point(786, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 572);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "My Recent Sellers";
            // 
            // property_container
            // 
            this.property_container.AutoScroll = true;
            this.property_container.BackColor = System.Drawing.Color.Gray;
            this.property_container.Controls.Add(this.panel6);
            this.property_container.Location = new System.Drawing.Point(16, 40);
            this.property_container.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.property_container.Name = "property_container";
            this.property_container.Size = new System.Drawing.Size(282, 520);
            this.property_container.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 61);
            this.panel6.TabIndex = 4;
            // 
            // lbl_monthlyspendings
            // 
            this.lbl_monthlyspendings.AutoSize = true;
            this.lbl_monthlyspendings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_monthlyspendings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthlyspendings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_monthlyspendings.Location = new System.Drawing.Point(99, 47);
            this.lbl_monthlyspendings.Name = "lbl_monthlyspendings";
            this.lbl_monthlyspendings.Size = new System.Drawing.Size(66, 24);
            this.lbl_monthlyspendings.TabIndex = 19;
            this.lbl_monthlyspendings.Text = "$ 0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Spendings";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.lbl_totalspendings);
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 104);
            this.panel4.TabIndex = 18;
            // 
            // lbl_totalspendings
            // 
            this.lbl_totalspendings.AutoSize = true;
            this.lbl_totalspendings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalspendings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalspendings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_totalspendings.Location = new System.Drawing.Point(99, 47);
            this.lbl_totalspendings.Name = "lbl_totalspendings";
            this.lbl_totalspendings.Size = new System.Drawing.Size(66, 24);
            this.lbl_totalspendings.TabIndex = 19;
            this.lbl_totalspendings.Text = "$ 0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 241);
            this.panel1.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.lbl_monthlyspendings);
            this.panel5.Controls.Add(this.guna2CirclePictureBox2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 104);
            this.panel5.TabIndex = 19;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::TerraVerdeRealEstate.Properties.Resources._2;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(14, 20);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(66, 63);
            this.guna2CirclePictureBox2.TabIndex = 18;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::TerraVerdeRealEstate.Properties.Resources._1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(14, 20);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(66, 63);
            this.guna2CirclePictureBox1.TabIndex = 18;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UC_C_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_C_Transactions";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_C_Transactions_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clienttransactions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_spendings)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.property_container.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgv_clienttransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_spendings;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel property_container;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_monthlyspendings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_totalspendings;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}

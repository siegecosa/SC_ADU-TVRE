namespace TerraVerdeRealEstate._2_UC__Admin_
{
    partial class UC_A_Transactionlogs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_transactionlogs = new System.Windows.Forms.DataGridView();
            this.lbl_propertyName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactionlogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgv_transactionlogs);
            this.panel1.Controls.Add(this.lbl_propertyName);
            this.panel1.Location = new System.Drawing.Point(19, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 676);
            this.panel1.TabIndex = 77;
            // 
            // dgv_transactionlogs
            // 
            this.dgv_transactionlogs.AllowUserToAddRows = false;
            this.dgv_transactionlogs.AllowUserToDeleteRows = false;
            this.dgv_transactionlogs.AllowUserToResizeColumns = false;
            this.dgv_transactionlogs.AllowUserToResizeRows = false;
            this.dgv_transactionlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_transactionlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transactionlogs.Location = new System.Drawing.Point(21, 74);
            this.dgv_transactionlogs.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_transactionlogs.MultiSelect = false;
            this.dgv_transactionlogs.Name = "dgv_transactionlogs";
            this.dgv_transactionlogs.ReadOnly = true;
            this.dgv_transactionlogs.RowHeadersVisible = false;
            this.dgv_transactionlogs.RowHeadersWidth = 51;
            this.dgv_transactionlogs.Size = new System.Drawing.Size(1384, 586);
            this.dgv_transactionlogs.TabIndex = 69;
            // 
            // lbl_propertyName
            // 
            this.lbl_propertyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_propertyName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propertyName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_propertyName.Location = new System.Drawing.Point(16, 22);
            this.lbl_propertyName.Name = "lbl_propertyName";
            this.lbl_propertyName.Size = new System.Drawing.Size(487, 37);
            this.lbl_propertyName.TabIndex = 68;
            this.lbl_propertyName.Text = "All user transactions";
            this.lbl_propertyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_A_Transactionlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1467, 711);
            this.MinimumSize = new System.Drawing.Size(1467, 711);
            this.Name = "UC_A_Transactionlogs";
            this.Size = new System.Drawing.Size(1467, 711);
            this.Load += new System.EventHandler(this.UC_A_Transactionlogs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactionlogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_transactionlogs;
        private System.Windows.Forms.Label lbl_propertyName;
    }
}

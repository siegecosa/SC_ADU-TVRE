namespace TerraVerdeRealEstate._2_UC__Admin_
{
    partial class UC_A_UserVerificationLogs
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
            this.dgv_userverificationlogs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_propertyName = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userverificationlogs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_userverificationlogs
            // 
            this.dgv_userverificationlogs.AllowUserToAddRows = false;
            this.dgv_userverificationlogs.AllowUserToDeleteRows = false;
            this.dgv_userverificationlogs.AllowUserToResizeColumns = false;
            this.dgv_userverificationlogs.AllowUserToResizeRows = false;
            this.dgv_userverificationlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_userverificationlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userverificationlogs.Location = new System.Drawing.Point(16, 60);
            this.dgv_userverificationlogs.MultiSelect = false;
            this.dgv_userverificationlogs.Name = "dgv_userverificationlogs";
            this.dgv_userverificationlogs.ReadOnly = true;
            this.dgv_userverificationlogs.RowHeadersVisible = false;
            this.dgv_userverificationlogs.RowHeadersWidth = 51;
            this.dgv_userverificationlogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_userverificationlogs.Size = new System.Drawing.Size(1035, 408);
            this.dgv_userverificationlogs.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgv_userverificationlogs);
            this.panel1.Controls.Add(this.lbl_propertyName);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 488);
            this.panel1.TabIndex = 87;
            // 
            // lbl_propertyName
            // 
            this.lbl_propertyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_propertyName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propertyName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_propertyName.Location = new System.Drawing.Point(12, 17);
            this.lbl_propertyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_propertyName.Name = "lbl_propertyName";
            this.lbl_propertyName.Size = new System.Drawing.Size(302, 30);
            this.lbl_propertyName.TabIndex = 68;
            this.lbl_propertyName.Text = "User Accounts Verification Logs";
            this.lbl_propertyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.Location = new System.Drawing.Point(963, 528);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 35);
            this.btn_back.TabIndex = 88;
            this.btn_back.Text = "<<  Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // UC_A_UserVerificationLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.MaximumSize = new System.Drawing.Size(1100, 578);
            this.MinimumSize = new System.Drawing.Size(1100, 578);
            this.Name = "UC_A_UserVerificationLogs";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_A_UserVerificationLogs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userverificationlogs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_userverificationlogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_propertyName;
        private System.Windows.Forms.Button btn_back;
    }
}

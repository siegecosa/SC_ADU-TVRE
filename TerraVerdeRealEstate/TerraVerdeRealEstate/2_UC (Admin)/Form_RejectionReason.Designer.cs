namespace TerraVerdeRealEstate._2_UC__Admin_
{
    partial class Form_RejectionReason
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_rejectionreason = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_rejectionreason
            // 
            this.tb_rejectionreason.Location = new System.Drawing.Point(26, 49);
            this.tb_rejectionreason.Name = "tb_rejectionreason";
            this.tb_rejectionreason.Size = new System.Drawing.Size(610, 20);
            this.tb_rejectionreason.TabIndex = 91;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancel.Location = new System.Drawing.Point(504, 84);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 35);
            this.btn_cancel.TabIndex = 90;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.DimGray;
            this.btn_submit.Location = new System.Drawing.Point(357, 84);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(132, 35);
            this.btn_submit.TabIndex = 89;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 30);
            this.label1.TabIndex = 88;
            this.label1.Text = "Enter reason/s for rejection:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_RejectionReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(659, 131);
            this.Controls.Add(this.tb_rejectionreason);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(659, 131);
            this.MinimumSize = new System.Drawing.Size(659, 131);
            this.Name = "Form_RejectionReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RejectionReason";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rejectionreason;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
    }
}
namespace TerraVerdeRealEstate.UC__Small_Layouts_
{
    partial class UC_S_RecentClients
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
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.circle_img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circle_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitle.Location = new System.Drawing.Point(99, 36);
            this.lbl_subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(253, 28);
            this.lbl_subtitle.TabIndex = 5;
            this.lbl_subtitle.Text = "Email Address";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(99, 12);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(253, 28);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Fname Sname";
            // 
            // circle_img
            // 
            this.circle_img.ImageRotate = 0F;
            this.circle_img.Location = new System.Drawing.Point(15, 1);
            this.circle_img.Margin = new System.Windows.Forms.Padding(4);
            this.circle_img.Name = "circle_img";
            this.circle_img.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circle_img.Size = new System.Drawing.Size(76, 71);
            this.circle_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle_img.TabIndex = 3;
            this.circle_img.TabStop = false;
            // 
            // UC_S_RecentClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lbl_subtitle);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.circle_img);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_S_RecentClients";
            this.Size = new System.Drawing.Size(367, 75);
            ((System.ComponentModel.ISupportInitialize)(this.circle_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circle_img;
    }
}

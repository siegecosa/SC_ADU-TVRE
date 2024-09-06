namespace TerraVerdeRealEstate._3_UC__Small_Layouts_
{
    partial class UC_AddPropertyLayout
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
            this.icon_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_add)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_add
            // 
            this.icon_add.Image = global::TerraVerdeRealEstate.Properties.Resources.ic_add_property;
            this.icon_add.Location = new System.Drawing.Point(63, 131);
            this.icon_add.Name = "icon_add";
            this.icon_add.Size = new System.Drawing.Size(149, 133);
            this.icon_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_add.TabIndex = 0;
            this.icon_add.TabStop = false;
            // 
            // UC_AddPropertyLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.icon_add);
            this.Name = "UC_AddPropertyLayout";
            this.Size = new System.Drawing.Size(289, 417);
            ((System.ComponentModel.ISupportInitialize)(this.icon_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_add;
    }
}

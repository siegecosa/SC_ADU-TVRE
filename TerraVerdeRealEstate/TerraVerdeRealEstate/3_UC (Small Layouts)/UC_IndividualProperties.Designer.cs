namespace TerraVerdeRealEstate.UC__Small_Layouts_
{
    partial class UC_IndividualProperties
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
            this.btn_buy = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_propertyName = new System.Windows.Forms.Label();
            this.img_property = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_property)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buy
            // 
            this.btn_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy.Location = new System.Drawing.Point(120, 297);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(81, 30);
            this.btn_buy.TabIndex = 22;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(11, 314);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(110, 13);
            this.lbl_price.TabIndex = 21;
            this.lbl_price.Text = "PRICE";
            // 
            // lbl_location
            // 
            this.lbl_location.Location = new System.Drawing.Point(11, 164);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(245, 14);
            this.lbl_location.TabIndex = 20;
            this.lbl_location.Text = "LOCATION";
            this.lbl_location.Click += new System.EventHandler(this.lbl_location_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_desc.Location = new System.Drawing.Point(11, 197);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(190, 51);
            this.lbl_desc.TabIndex = 19;
            this.lbl_desc.Text = "Description blah blah blah";
            // 
            // lbl_propertyName
            // 
            this.lbl_propertyName.Location = new System.Drawing.Point(11, 148);
            this.lbl_propertyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_propertyName.Name = "lbl_propertyName";
            this.lbl_propertyName.Size = new System.Drawing.Size(245, 16);
            this.lbl_propertyName.TabIndex = 18;
            this.lbl_propertyName.Text = "PROPERTY NAME";
            this.lbl_propertyName.Click += new System.EventHandler(this.lbl_propertyName_Click);
            // 
            // img_property
            // 
            this.img_property.Location = new System.Drawing.Point(0, 0);
            this.img_property.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_property.Name = "img_property";
            this.img_property.Size = new System.Drawing.Size(217, 146);
            this.img_property.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_property.TabIndex = 17;
            this.img_property.TabStop = false;
            // 
            // UC_IndividualProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_propertyName);
            this.Controls.Add(this.img_property);
            this.Name = "UC_IndividualProperties";
            this.Size = new System.Drawing.Size(217, 339);
            this.Load += new System.EventHandler(this.UC_IndividualProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_property)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_propertyName;
        private System.Windows.Forms.PictureBox img_property;
    }
}

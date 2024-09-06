namespace TerraVerdeRealEstate.UC__Seller_
{
    partial class UC_S_Properties
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_commercial = new System.Windows.Forms.RadioButton();
            this.rb_allCategory = new System.Windows.Forms.RadioButton();
            this.rb_residential = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_townhouse = new System.Windows.Forms.RadioButton();
            this.rb_condominium = new System.Windows.Forms.RadioButton();
            this.rb_apartment = new System.Windows.Forms.RadioButton();
            this.rb_allType = new System.Windows.Forms.RadioButton();
            this.property_container = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AddProperty = new System.Windows.Forms.Button();
            this.panel_searchbar = new System.Windows.Forms.Panel();
            this.img_search = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_searchbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(41, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filter By:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_commercial);
            this.groupBox1.Controls.Add(this.rb_allCategory);
            this.groupBox1.Controls.Add(this.rb_residential);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // rb_commercial
            // 
            this.rb_commercial.AutoSize = true;
            this.rb_commercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_commercial.Location = new System.Drawing.Point(19, 44);
            this.rb_commercial.Margin = new System.Windows.Forms.Padding(2);
            this.rb_commercial.Name = "rb_commercial";
            this.rb_commercial.Size = new System.Drawing.Size(92, 19);
            this.rb_commercial.TabIndex = 9;
            this.rb_commercial.Text = "Commercial";
            this.rb_commercial.UseVisualStyleBackColor = true;
            this.rb_commercial.CheckedChanged += new System.EventHandler(this.rb_commercial_CheckedChanged_1);
            // 
            // rb_allCategory
            // 
            this.rb_allCategory.AutoSize = true;
            this.rb_allCategory.Checked = true;
            this.rb_allCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_allCategory.Location = new System.Drawing.Point(19, 23);
            this.rb_allCategory.Margin = new System.Windows.Forms.Padding(2);
            this.rb_allCategory.Name = "rb_allCategory";
            this.rb_allCategory.Size = new System.Drawing.Size(38, 19);
            this.rb_allCategory.TabIndex = 7;
            this.rb_allCategory.TabStop = true;
            this.rb_allCategory.Text = "All";
            this.rb_allCategory.UseVisualStyleBackColor = true;
            this.rb_allCategory.CheckedChanged += new System.EventHandler(this.rb_allCategory_CheckedChanged_1);
            // 
            // rb_residential
            // 
            this.rb_residential.AutoSize = true;
            this.rb_residential.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_residential.Location = new System.Drawing.Point(19, 65);
            this.rb_residential.Margin = new System.Windows.Forms.Padding(2);
            this.rb_residential.Name = "rb_residential";
            this.rb_residential.Size = new System.Drawing.Size(87, 19);
            this.rb_residential.TabIndex = 8;
            this.rb_residential.Text = "Residential";
            this.rb_residential.UseVisualStyleBackColor = true;
            this.rb_residential.CheckedChanged += new System.EventHandler(this.rb_residential_CheckedChanged_1);
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_search.Location = new System.Drawing.Point(10, 13);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(338, 19);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Search...";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter_1);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_townhouse);
            this.groupBox3.Controls.Add(this.rb_condominium);
            this.groupBox3.Controls.Add(this.rb_apartment);
            this.groupBox3.Controls.Add(this.rb_allType);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 111);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // rb_townhouse
            // 
            this.rb_townhouse.AutoSize = true;
            this.rb_townhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_townhouse.Location = new System.Drawing.Point(19, 82);
            this.rb_townhouse.Margin = new System.Windows.Forms.Padding(2);
            this.rb_townhouse.Name = "rb_townhouse";
            this.rb_townhouse.Size = new System.Drawing.Size(94, 19);
            this.rb_townhouse.TabIndex = 10;
            this.rb_townhouse.Text = "Town House";
            this.rb_townhouse.UseVisualStyleBackColor = true;
            this.rb_townhouse.CheckedChanged += new System.EventHandler(this.rb_townhouse_CheckedChanged_1);
            // 
            // rb_condominium
            // 
            this.rb_condominium.AutoSize = true;
            this.rb_condominium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_condominium.Location = new System.Drawing.Point(19, 62);
            this.rb_condominium.Margin = new System.Windows.Forms.Padding(2);
            this.rb_condominium.Name = "rb_condominium";
            this.rb_condominium.Size = new System.Drawing.Size(103, 19);
            this.rb_condominium.TabIndex = 8;
            this.rb_condominium.Text = "Condominuim";
            this.rb_condominium.UseVisualStyleBackColor = true;
            this.rb_condominium.CheckedChanged += new System.EventHandler(this.rb_condominium_CheckedChanged_1);
            // 
            // rb_apartment
            // 
            this.rb_apartment.AutoSize = true;
            this.rb_apartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_apartment.Location = new System.Drawing.Point(19, 41);
            this.rb_apartment.Margin = new System.Windows.Forms.Padding(2);
            this.rb_apartment.Name = "rb_apartment";
            this.rb_apartment.Size = new System.Drawing.Size(81, 19);
            this.rb_apartment.TabIndex = 9;
            this.rb_apartment.Text = "Apartment";
            this.rb_apartment.UseVisualStyleBackColor = true;
            this.rb_apartment.CheckedChanged += new System.EventHandler(this.rb_apartment_CheckedChanged_1);
            // 
            // rb_allType
            // 
            this.rb_allType.AutoSize = true;
            this.rb_allType.Checked = true;
            this.rb_allType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_allType.Location = new System.Drawing.Point(19, 20);
            this.rb_allType.Margin = new System.Windows.Forms.Padding(2);
            this.rb_allType.Name = "rb_allType";
            this.rb_allType.Size = new System.Drawing.Size(38, 19);
            this.rb_allType.TabIndex = 7;
            this.rb_allType.TabStop = true;
            this.rb_allType.Text = "All";
            this.rb_allType.UseVisualStyleBackColor = true;
            this.rb_allType.CheckedChanged += new System.EventHandler(this.rb_allType_CheckedChanged_1);
            // 
            // property_container
            // 
            this.property_container.AutoScroll = true;
            this.property_container.BackColor = System.Drawing.Color.Gray;
            this.property_container.Location = new System.Drawing.Point(158, 60);
            this.property_container.Margin = new System.Windows.Forms.Padding(2);
            this.property_container.Name = "property_container";
            this.property_container.Size = new System.Drawing.Size(932, 506);
            this.property_container.TabIndex = 23;
            // 
            // btn_AddProperty
            // 
            this.btn_AddProperty.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProperty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_AddProperty.Location = new System.Drawing.Point(552, 9);
            this.btn_AddProperty.Name = "btn_AddProperty";
            this.btn_AddProperty.Size = new System.Drawing.Size(128, 46);
            this.btn_AddProperty.TabIndex = 0;
            this.btn_AddProperty.Text = "Add Property";
            this.btn_AddProperty.UseVisualStyleBackColor = true;
            this.btn_AddProperty.Click += new System.EventHandler(this.btn_AddProperty_Click);
            // 
            // panel_searchbar
            // 
            this.panel_searchbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_searchbar.Controls.Add(this.txt_search);
            this.panel_searchbar.Location = new System.Drawing.Point(685, 8);
            this.panel_searchbar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_searchbar.Name = "panel_searchbar";
            this.panel_searchbar.Size = new System.Drawing.Size(365, 45);
            this.panel_searchbar.TabIndex = 24;
            // 
            // img_search
            // 
            this.img_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.img_search.BackgroundImage = global::TerraVerdeRealEstate.Properties.Resources.whitesearch_icon;
            this.img_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_search.Location = new System.Drawing.Point(1049, 8);
            this.img_search.Margin = new System.Windows.Forms.Padding(2);
            this.img_search.Name = "img_search";
            this.img_search.Size = new System.Drawing.Size(41, 45);
            this.img_search.TabIndex = 25;
            this.img_search.TabStop = false;
            this.img_search.Click += new System.EventHandler(this.img_search_Click_1);
            // 
            // UC_S_Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btn_AddProperty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.property_container);
            this.Controls.Add(this.panel_searchbar);
            this.Controls.Add(this.img_search);
            this.Name = "UC_S_Properties";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_S_Properties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_searchbar.ResumeLayout(false);
            this.panel_searchbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_commercial;
        private System.Windows.Forms.RadioButton rb_allCategory;
        private System.Windows.Forms.RadioButton rb_residential;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_townhouse;
        private System.Windows.Forms.RadioButton rb_condominium;
        private System.Windows.Forms.RadioButton rb_apartment;
        private System.Windows.Forms.RadioButton rb_allType;
        private System.Windows.Forms.FlowLayoutPanel property_container;
        private System.Windows.Forms.Panel panel_searchbar;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.Button btn_AddProperty;
    }
}

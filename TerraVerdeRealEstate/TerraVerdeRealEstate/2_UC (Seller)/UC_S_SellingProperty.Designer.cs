namespace TerraVerdeRealEstate._2_UC__Seller_
{
    partial class UC_S_SellingProperty
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
            this.components = new System.ComponentModel.Container();
            this.property_name = new System.Windows.Forms.Label();
            this.btn_uploadimg = new System.Windows.Forms.Button();
            this.pb_propertyimg = new System.Windows.Forms.PictureBox();
            this.txt_propertyname = new System.Windows.Forms.TextBox();
            this.num_pricepersqm = new System.Windows.Forms.NumericUpDown();
            this.cb_propertycategory = new System.Windows.Forms.ComboBox();
            this.btn_saveproperty = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_propertyaddress = new System.Windows.Forms.TextBox();
            this.property_address = new System.Windows.Forms.Label();
            this.txt_propertydesc = new System.Windows.Forms.TextBox();
            this.prop_desc = new System.Windows.Forms.Label();
            this.prop_category = new System.Windows.Forms.Label();
            this.prop_type = new System.Windows.Forms.Label();
            this.cb_propertytype = new System.Windows.Forms.ComboBox();
            this.prop_stat = new System.Windows.Forms.Label();
            this.cb_propertystatus = new System.Windows.Forms.ComboBox();
            this.price_sqrm = new System.Windows.Forms.Label();
            this.error_pname = new System.Windows.Forms.ErrorProvider(this.components);
            this.prop_sqr = new System.Windows.Forms.Label();
            this.property_sqm = new System.Windows.Forms.NumericUpDown();
            this.lbl_propertyName = new System.Windows.Forms.Label();
            this.terms_and_conditions = new System.Windows.Forms.Label();
            this.txt_termsandconditions = new System.Windows.Forms.TextBox();
            this.lbl_monthlyrentalamount = new System.Windows.Forms.Label();
            this.monthly_rental_amount = new System.Windows.Forms.NumericUpDown();
            this.utilitybillsincluded = new System.Windows.Forms.Label();
            this.chkbox_utility = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_propertyimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pricepersqm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_sqm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_rental_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // property_name
            // 
            this.property_name.AutoSize = true;
            this.property_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.property_name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.property_name.Location = new System.Drawing.Point(29, 58);
            this.property_name.Name = "property_name";
            this.property_name.Size = new System.Drawing.Size(126, 18);
            this.property_name.TabIndex = 0;
            this.property_name.Text = "Property Name:";
            this.property_name.Validating += new System.ComponentModel.CancelEventHandler(this.property_name_Validating);
            // 
            // btn_uploadimg
            // 
            this.btn_uploadimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uploadimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.btn_uploadimg.Location = new System.Drawing.Point(726, 361);
            this.btn_uploadimg.Name = "btn_uploadimg";
            this.btn_uploadimg.Size = new System.Drawing.Size(194, 36);
            this.btn_uploadimg.TabIndex = 12;
            this.btn_uploadimg.Text = "Upload Image";
            this.btn_uploadimg.UseVisualStyleBackColor = true;
            this.btn_uploadimg.Click += new System.EventHandler(this.btn_uploadimg_Click);
            // 
            // pb_propertyimg
            // 
            this.pb_propertyimg.BackColor = System.Drawing.Color.Silver;
            this.pb_propertyimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_propertyimg.Location = new System.Drawing.Point(549, 79);
            this.pb_propertyimg.Name = "pb_propertyimg";
            this.pb_propertyimg.Size = new System.Drawing.Size(530, 267);
            this.pb_propertyimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_propertyimg.TabIndex = 3;
            this.pb_propertyimg.TabStop = false;
            // 
            // txt_propertyname
            // 
            this.txt_propertyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_propertyname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_propertyname.Location = new System.Drawing.Point(32, 79);
            this.txt_propertyname.Name = "txt_propertyname";
            this.txt_propertyname.Size = new System.Drawing.Size(483, 24);
            this.txt_propertyname.TabIndex = 1;
            this.txt_propertyname.Text = "Property Name";
            this.txt_propertyname.Enter += new System.EventHandler(this.txt_propertyname_Enter);
            // 
            // num_pricepersqm
            // 
            this.num_pricepersqm.DecimalPlaces = 2;
            this.num_pricepersqm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.num_pricepersqm.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.num_pricepersqm.Location = new System.Drawing.Point(32, 400);
            this.num_pricepersqm.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_pricepersqm.Name = "num_pricepersqm";
            this.num_pricepersqm.Size = new System.Drawing.Size(204, 24);
            this.num_pricepersqm.TabIndex = 8;
            this.num_pricepersqm.Enter += new System.EventHandler(this.num_pricepersqm_Enter);
            // 
            // cb_propertycategory
            // 
            this.cb_propertycategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_propertycategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_propertycategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cb_propertycategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_propertycategory.FormattingEnabled = true;
            this.cb_propertycategory.Items.AddRange(new object[] {
            "Residential",
            "Commercial"});
            this.cb_propertycategory.Location = new System.Drawing.Point(32, 268);
            this.cb_propertycategory.Name = "cb_propertycategory";
            this.cb_propertycategory.Size = new System.Drawing.Size(204, 26);
            this.cb_propertycategory.TabIndex = 4;
            this.cb_propertycategory.DropDown += new System.EventHandler(this.cb_propertycategory_DropDown);
            // 
            // btn_saveproperty
            // 
            this.btn_saveproperty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveproperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.btn_saveproperty.Location = new System.Drawing.Point(549, 512);
            this.btn_saveproperty.Name = "btn_saveproperty";
            this.btn_saveproperty.Size = new System.Drawing.Size(235, 36);
            this.btn_saveproperty.TabIndex = 13;
            this.btn_saveproperty.Text = "Conitnue";
            this.btn_saveproperty.UseVisualStyleBackColor = true;
            this.btn_saveproperty.Click += new System.EventHandler(this.btn_saveproperty_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.btn_cancel.Location = new System.Drawing.Point(844, 512);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(235, 36);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_propertyaddress
            // 
            this.txt_propertyaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_propertyaddress.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_propertyaddress.Location = new System.Drawing.Point(32, 136);
            this.txt_propertyaddress.Name = "txt_propertyaddress";
            this.txt_propertyaddress.Size = new System.Drawing.Size(483, 24);
            this.txt_propertyaddress.TabIndex = 2;
            this.txt_propertyaddress.Text = "Property Address";
            this.txt_propertyaddress.Enter += new System.EventHandler(this.txt_propertyaddress_Enter);
            // 
            // property_address
            // 
            this.property_address.AutoSize = true;
            this.property_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.property_address.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.property_address.Location = new System.Drawing.Point(29, 115);
            this.property_address.Name = "property_address";
            this.property_address.Size = new System.Drawing.Size(143, 18);
            this.property_address.TabIndex = 9;
            this.property_address.Text = "Property Address:";
            this.property_address.Validating += new System.ComponentModel.CancelEventHandler(this.property_address_Validating);
            // 
            // txt_propertydesc
            // 
            this.txt_propertydesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_propertydesc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_propertydesc.Location = new System.Drawing.Point(32, 196);
            this.txt_propertydesc.Name = "txt_propertydesc";
            this.txt_propertydesc.Size = new System.Drawing.Size(483, 24);
            this.txt_propertydesc.TabIndex = 3;
            this.txt_propertydesc.Text = "Property Description";
            this.txt_propertydesc.Enter += new System.EventHandler(this.txt_propertydesc_Enter);
            // 
            // prop_desc
            // 
            this.prop_desc.AutoSize = true;
            this.prop_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.prop_desc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prop_desc.Location = new System.Drawing.Point(29, 175);
            this.prop_desc.Name = "prop_desc";
            this.prop_desc.Size = new System.Drawing.Size(168, 18);
            this.prop_desc.TabIndex = 11;
            this.prop_desc.Text = "Property Description:";
            this.prop_desc.Validating += new System.ComponentModel.CancelEventHandler(this.prop_desc_Validating);
            // 
            // prop_category
            // 
            this.prop_category.AutoSize = true;
            this.prop_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.prop_category.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prop_category.Location = new System.Drawing.Point(29, 248);
            this.prop_category.Name = "prop_category";
            this.prop_category.Size = new System.Drawing.Size(150, 18);
            this.prop_category.TabIndex = 13;
            this.prop_category.Text = "Property Category:";
            this.prop_category.Validating += new System.ComponentModel.CancelEventHandler(this.prop_category_Validating);
            // 
            // prop_type
            // 
            this.prop_type.AutoSize = true;
            this.prop_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.prop_type.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prop_type.Location = new System.Drawing.Point(310, 248);
            this.prop_type.Name = "prop_type";
            this.prop_type.Size = new System.Drawing.Size(118, 18);
            this.prop_type.TabIndex = 15;
            this.prop_type.Text = "Property Type:";
            this.prop_type.Validating += new System.ComponentModel.CancelEventHandler(this.prop_type_Validating);
            // 
            // cb_propertytype
            // 
            this.cb_propertytype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_propertytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_propertytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cb_propertytype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_propertytype.FormattingEnabled = true;
            this.cb_propertytype.Items.AddRange(new object[] {
            "Condo",
            "Town House",
            "Apartment"});
            this.cb_propertytype.Location = new System.Drawing.Point(313, 268);
            this.cb_propertytype.Name = "cb_propertytype";
            this.cb_propertytype.Size = new System.Drawing.Size(204, 26);
            this.cb_propertytype.TabIndex = 5;
            this.cb_propertytype.DropDown += new System.EventHandler(this.cb_propertytype_DropDown);
            // 
            // prop_stat
            // 
            this.prop_stat.AutoSize = true;
            this.prop_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.prop_stat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prop_stat.Location = new System.Drawing.Point(310, 316);
            this.prop_stat.Name = "prop_stat";
            this.prop_stat.Size = new System.Drawing.Size(130, 18);
            this.prop_stat.TabIndex = 17;
            this.prop_stat.Text = "Property Status:";
            this.prop_stat.Validating += new System.ComponentModel.CancelEventHandler(this.prop_stat_Validating);
            // 
            // cb_propertystatus
            // 
            this.cb_propertystatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_propertystatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_propertystatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cb_propertystatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_propertystatus.FormattingEnabled = true;
            this.cb_propertystatus.Items.AddRange(new object[] {
            "For Sale",
            "For Rent"});
            this.cb_propertystatus.Location = new System.Drawing.Point(313, 335);
            this.cb_propertystatus.Name = "cb_propertystatus";
            this.cb_propertystatus.Size = new System.Drawing.Size(204, 26);
            this.cb_propertystatus.TabIndex = 7;
            this.cb_propertystatus.DropDown += new System.EventHandler(this.cb_propertystatus_DropDown);
            this.cb_propertystatus.SelectedIndexChanged += new System.EventHandler(this.cb_propertystatus_SelectedIndexChanged);
            // 
            // price_sqrm
            // 
            this.price_sqrm.AutoSize = true;
            this.price_sqrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.price_sqrm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.price_sqrm.Location = new System.Drawing.Point(29, 379);
            this.price_sqrm.Name = "price_sqrm";
            this.price_sqrm.Size = new System.Drawing.Size(189, 18);
            this.price_sqrm.TabIndex = 18;
            this.price_sqrm.Text = "Price Per Square Meter:";
            this.price_sqrm.Validating += new System.ComponentModel.CancelEventHandler(this.price_sqrm_Validating);
            // 
            // error_pname
            // 
            this.error_pname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_pname.ContainerControl = this;
            // 
            // prop_sqr
            // 
            this.prop_sqr.AutoSize = true;
            this.prop_sqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.prop_sqr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prop_sqr.Location = new System.Drawing.Point(29, 316);
            this.prop_sqr.Name = "prop_sqr";
            this.prop_sqr.Size = new System.Drawing.Size(183, 18);
            this.prop_sqr.TabIndex = 21;
            this.prop_sqr.Text = "Property Square Meter:";
            this.prop_sqr.Validating += new System.ComponentModel.CancelEventHandler(this.prop_sqr_Validating);
            // 
            // property_sqm
            // 
            this.property_sqm.DecimalPlaces = 2;
            this.property_sqm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.property_sqm.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.property_sqm.Location = new System.Drawing.Point(32, 337);
            this.property_sqm.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.property_sqm.Name = "property_sqm";
            this.property_sqm.Size = new System.Drawing.Size(204, 24);
            this.property_sqm.TabIndex = 6;
            this.property_sqm.Enter += new System.EventHandler(this.property_sqm_Enter_1);
            // 
            // lbl_propertyName
            // 
            this.lbl_propertyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_propertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propertyName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_propertyName.Location = new System.Drawing.Point(28, 17);
            this.lbl_propertyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_propertyName.Name = "lbl_propertyName";
            this.lbl_propertyName.Size = new System.Drawing.Size(158, 30);
            this.lbl_propertyName.TabIndex = 69;
            this.lbl_propertyName.Text = "Property Details";
            this.lbl_propertyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // terms_and_conditions
            // 
            this.terms_and_conditions.AutoSize = true;
            this.terms_and_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.terms_and_conditions.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.terms_and_conditions.Location = new System.Drawing.Point(310, 379);
            this.terms_and_conditions.Name = "terms_and_conditions";
            this.terms_and_conditions.Size = new System.Drawing.Size(179, 18);
            this.terms_and_conditions.TabIndex = 70;
            this.terms_and_conditions.Text = "Terms and Conditions:";
            // 
            // txt_termsandconditions
            // 
            this.txt_termsandconditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_termsandconditions.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_termsandconditions.Location = new System.Drawing.Point(313, 400);
            this.txt_termsandconditions.Multiline = true;
            this.txt_termsandconditions.Name = "txt_termsandconditions";
            this.txt_termsandconditions.Size = new System.Drawing.Size(204, 59);
            this.txt_termsandconditions.TabIndex = 9;
            this.txt_termsandconditions.Text = "Terms and Conditions";
            this.txt_termsandconditions.Enter += new System.EventHandler(this.txt_termsandconditions_Enter);
            // 
            // lbl_monthlyrentalamount
            // 
            this.lbl_monthlyrentalamount.AutoSize = true;
            this.lbl_monthlyrentalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_monthlyrentalamount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_monthlyrentalamount.Location = new System.Drawing.Point(29, 447);
            this.lbl_monthlyrentalamount.Name = "lbl_monthlyrentalamount";
            this.lbl_monthlyrentalamount.Size = new System.Drawing.Size(182, 18);
            this.lbl_monthlyrentalamount.TabIndex = 72;
            this.lbl_monthlyrentalamount.Text = "Monthly Rental Amount";
            // 
            // monthly_rental_amount
            // 
            this.monthly_rental_amount.DecimalPlaces = 2;
            this.monthly_rental_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.monthly_rental_amount.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.monthly_rental_amount.Location = new System.Drawing.Point(32, 470);
            this.monthly_rental_amount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.monthly_rental_amount.Name = "monthly_rental_amount";
            this.monthly_rental_amount.Size = new System.Drawing.Size(204, 24);
            this.monthly_rental_amount.TabIndex = 10;
            this.monthly_rental_amount.Enter += new System.EventHandler(this.monthly_rental_amount_Enter);
            // 
            // utilitybillsincluded
            // 
            this.utilitybillsincluded.AutoSize = true;
            this.utilitybillsincluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.utilitybillsincluded.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.utilitybillsincluded.Location = new System.Drawing.Point(335, 476);
            this.utilitybillsincluded.Name = "utilitybillsincluded";
            this.utilitybillsincluded.Size = new System.Drawing.Size(154, 18);
            this.utilitybillsincluded.TabIndex = 74;
            this.utilitybillsincluded.Text = "Utility Bills Included";
            // 
            // chkbox_utility
            // 
            this.chkbox_utility.AutoSize = true;
            this.chkbox_utility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbox_utility.Location = new System.Drawing.Point(314, 480);
            this.chkbox_utility.Name = "chkbox_utility";
            this.chkbox_utility.Size = new System.Drawing.Size(15, 14);
            this.chkbox_utility.TabIndex = 11;
            this.chkbox_utility.UseVisualStyleBackColor = true;
            // 
            // UC_S_SellingProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.chkbox_utility);
            this.Controls.Add(this.utilitybillsincluded);
            this.Controls.Add(this.monthly_rental_amount);
            this.Controls.Add(this.lbl_monthlyrentalamount);
            this.Controls.Add(this.txt_termsandconditions);
            this.Controls.Add(this.terms_and_conditions);
            this.Controls.Add(this.lbl_propertyName);
            this.Controls.Add(this.property_sqm);
            this.Controls.Add(this.prop_sqr);
            this.Controls.Add(this.price_sqrm);
            this.Controls.Add(this.prop_stat);
            this.Controls.Add(this.cb_propertystatus);
            this.Controls.Add(this.prop_type);
            this.Controls.Add(this.cb_propertytype);
            this.Controls.Add(this.prop_category);
            this.Controls.Add(this.txt_propertydesc);
            this.Controls.Add(this.prop_desc);
            this.Controls.Add(this.txt_propertyaddress);
            this.Controls.Add(this.property_address);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_saveproperty);
            this.Controls.Add(this.cb_propertycategory);
            this.Controls.Add(this.num_pricepersqm);
            this.Controls.Add(this.txt_propertyname);
            this.Controls.Add(this.pb_propertyimg);
            this.Controls.Add(this.btn_uploadimg);
            this.Controls.Add(this.property_name);
            this.MaximumSize = new System.Drawing.Size(1100, 578);
            this.MinimumSize = new System.Drawing.Size(1100, 578);
            this.Name = "UC_S_SellingProperty";
            this.Size = new System.Drawing.Size(1100, 578);
            this.Load += new System.EventHandler(this.UC_S_SellingProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_propertyimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pricepersqm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_sqm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_rental_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label property_name;
        private System.Windows.Forms.Button btn_uploadimg;
        private System.Windows.Forms.PictureBox pb_propertyimg;
        private System.Windows.Forms.TextBox txt_propertyname;
        private System.Windows.Forms.NumericUpDown num_pricepersqm;
        private System.Windows.Forms.ComboBox cb_propertycategory;
        private System.Windows.Forms.Button btn_saveproperty;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_propertyaddress;
        private System.Windows.Forms.Label property_address;
        private System.Windows.Forms.TextBox txt_propertydesc;
        private System.Windows.Forms.Label prop_desc;
        private System.Windows.Forms.Label prop_category;
        private System.Windows.Forms.Label prop_type;
        private System.Windows.Forms.ComboBox cb_propertytype;
        private System.Windows.Forms.Label prop_stat;
        private System.Windows.Forms.ComboBox cb_propertystatus;
        private System.Windows.Forms.Label price_sqrm;
        private System.Windows.Forms.ErrorProvider error_pname;
        private System.Windows.Forms.Label prop_sqr;
        private System.Windows.Forms.NumericUpDown property_sqm;
        private System.Windows.Forms.Label lbl_propertyName;
        private System.Windows.Forms.Label utilitybillsincluded;
        private System.Windows.Forms.NumericUpDown monthly_rental_amount;
        private System.Windows.Forms.Label lbl_monthlyrentalamount;
        private System.Windows.Forms.TextBox txt_termsandconditions;
        private System.Windows.Forms.Label terms_and_conditions;
        private System.Windows.Forms.CheckBox chkbox_utility;
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate.UC__LogReg_;
using TerraVerdeRealEstate.UC__Seller_;

namespace TerraVerdeRealEstate._2_UC__Seller_
{
    public partial class UC_S_SellingProperty : UserControl
    {


        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        public int sellerid;
        public int userID;
        public string tempPropertyName;
        public string tempPropertyAddress;
        public string tempPropertyDescription;
        public string tempPropertyCategory;
        public string tempPropertyType;
        public string temptermsandconditions;
        public string tempPropertyStatus;
        public decimal tempPropertySQM;
        public decimal tempPricePerSQM;
        public decimal monthlyRentalAmount;
        public int utilityBillsIncluded;
        static Image tempPropertyImage = null;
        public static string tempPropertyImageBase64;
        public UC_S_SellingProperty()
        {
            InitializeComponent();
            userID = UC__LogReg_.UC_LR_Login.userID;
            cb_propertycategory.KeyPress += (sender, e) => { e.Handled = true; };
            cb_propertystatus.KeyPress += (sender, e) => { e.Handled = true; };
            cb_propertytype.KeyPress += (sender, e) => { e.Handled = true; };

        }


        #region Validation

        private void property_name_Validating(object sender, CancelEventArgs e)
        {
            if (txt_propertyname.Text == "Property Name" || txt_propertyname.Text == "") { e.Cancel = true; txt_propertyname.Focus(); error_pname.SetError(property_name, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(property_name, null); }
        }
        private void property_address_Validating(object sender, CancelEventArgs e)
        {
            if (txt_propertyaddress.Text == "Property Address" || txt_propertyaddress.Text == "") { e.Cancel = true; txt_propertyaddress.Focus(); error_pname.SetError(property_address, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(property_address, null); }
        }
        private void prop_desc_Validating(object sender, CancelEventArgs e)
        {
            if (txt_propertydesc.Text == "Property Description" || txt_propertydesc.Text == "") { e.Cancel = true; txt_propertydesc.Focus(); error_pname.SetError(prop_desc, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(prop_desc, null); }
        }
        private void prop_sqr_Validating(object sender, CancelEventArgs e)
        {
            if (property_sqm.Text == "0.00" || property_sqm.Text == "") { e.Cancel = true; property_sqm.Focus(); error_pname.SetError(prop_sqr, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(prop_sqr, null); }
        }
        private void prop_category_Validating(object sender, CancelEventArgs e)
        {
            if (cb_propertycategory.Text == "Property Category" || cb_propertycategory.Text == "") { e.Cancel = true; cb_propertycategory.Focus(); error_pname.SetError(prop_category, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(prop_category, null); }
        }
        private void prop_stat_Validating(object sender, CancelEventArgs e)
        {
            if (cb_propertystatus.Text == "Property Status" || cb_propertystatus.Text == "") { e.Cancel = true; cb_propertystatus.Focus(); error_pname.SetError(prop_stat, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(prop_stat, null); }
        }
        private void prop_type_Validating(object sender, CancelEventArgs e)
        {
            if (cb_propertytype.Text == "Property Type" || cb_propertytype.Text == "") { e.Cancel = true; cb_propertytype.Focus(); error_pname.SetError(prop_type, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(prop_type, null); }
        }
        private void price_sqrm_Validating(object sender, CancelEventArgs e)
        {
            if (num_pricepersqm.Text == "0.00" || num_pricepersqm.Text == "") { e.Cancel = true; num_pricepersqm.Focus(); error_pname.SetError(price_sqrm, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(price_sqrm, null); }
        }


        private void terms_and_conditions_Validating(object sender, CancelEventArgs e)
        {


            if (txt_termsandconditions.Text == "Terms and Conditions" || txt_termsandconditions.Text == "")
            {
                e.Cancel = true;
                txt_termsandconditions.Focus();
                error_pname.SetError(terms_and_conditions, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                error_pname.SetError(terms_and_conditions, null);
            }
        }
        private void monthly_rental_amount_Validating(object sender, CancelEventArgs e)
        {
            if (monthly_rental_amount.Text == "0.00" || monthly_rental_amount.Text == "") { e.Cancel = true; monthly_rental_amount.Focus(); error_pname.SetError(lbl_monthlyrentalamount, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(lbl_monthlyrentalamount, null); }
        }




        private void resettxt()
        {
            if (string.IsNullOrWhiteSpace(txt_propertyname.Text)) { txt_propertyname.Text = "Property Name"; txt_propertyname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_propertyaddress.Text)) { txt_propertyaddress.Text = "Property Address"; txt_propertyaddress.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_propertydesc.Text)) { txt_propertydesc.Text = "Property Description"; txt_propertydesc.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(property_sqm.Text)) { property_sqm.Text = "0.00"; property_sqm.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(num_pricepersqm.Text)) { num_pricepersqm.Text = "0.00"; num_pricepersqm.ForeColor = SystemColors.ButtonShadow; }
            
            if (string.IsNullOrWhiteSpace(txt_termsandconditions.Text)) { txt_termsandconditions.Text = "Terms and Conditions"; txt_termsandconditions.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(monthly_rental_amount.Text)) { monthly_rental_amount.Text = "0.00"; monthly_rental_amount.ForeColor = SystemColors.ButtonShadow; }

        }
        #endregion

        #region Enter   
        private void txt_propertyname_Enter(object sender, EventArgs e)
        {
            resettxt(); txt_propertyname.ForeColor = Color.Black; if (txt_propertyname.Text == "Property Name") { txt_propertyname.Text = ""; }
        }
        private void txt_propertyaddress_Enter(object sender, EventArgs e)
        {
            resettxt(); txt_propertyaddress.ForeColor = Color.Black; if (txt_propertyaddress.Text == "Property Address") { txt_propertyaddress.Text = ""; }
        }
        private void txt_propertydesc_Enter(object sender, EventArgs e)
        {
            resettxt(); txt_propertydesc.ForeColor = Color.Black; if (txt_propertydesc.Text == "Property Description") { txt_propertydesc.Text = ""; }
        }

        private void property_sqm_Enter_1(object sender, EventArgs e)
        {
            resettxt(); property_sqm.ForeColor = Color.Black; if (property_sqm.Text == "0.00") { property_sqm.Text = ""; }
        }

        private void num_pricepersqm_Enter(object sender, EventArgs e)
        {
            resettxt(); num_pricepersqm.ForeColor = Color.Black; if (num_pricepersqm.Text == "0.00") { num_pricepersqm.Text = ""; }
        }

        private void txt_termsandconditions_Enter(object sender, EventArgs e)
        {
            resettxt(); txt_termsandconditions.ForeColor = Color.Black; if (txt_termsandconditions.Text == "Terms and Conditions") { txt_termsandconditions.Text = ""; }
        }

        private void monthly_rental_amount_Enter(object sender, EventArgs e)
        {
            resettxt(); monthly_rental_amount.ForeColor = Color.Black; if (monthly_rental_amount.Text == "0.00") { monthly_rental_amount.Text = ""; }
        }


        #endregion

        #region dropdown
        private void cb_propertycategory_DropDown(object sender, EventArgs e)
        {
            cb_propertycategory.ForeColor = Color.Black;
        }
        private void cb_propertytype_DropDown(object sender, EventArgs e)
        {
            cb_propertytype.ForeColor = Color.Black;
        }
        private void cb_propertystatus_DropDown(object sender, EventArgs e)
        {
            cb_propertystatus.ForeColor = Color.Black;
        }
        #endregion


        private void btn_saveproperty_Click(object sender, EventArgs e)
        {
            
            resettxt();
            ValidateChildren(ValidationConstraints.Enabled);
            if (!(pb_propertyimg.Image == null || txt_propertyname.Text == "Property Name" || txt_propertyaddress.Text == "Property Address" || txt_propertydesc.Text == "Property Description" || property_sqm.Text == "Property Sqm" || cb_propertycategory.Text == "Property Category" || cb_propertystatus.Text == "Property Status" || cb_propertytype.Text == "Property Type" || num_pricepersqm.Text == "0.00" || string.IsNullOrEmpty(txt_propertyname.Text) || string.IsNullOrEmpty(txt_propertyaddress.Text) || string.IsNullOrEmpty(txt_propertydesc.Text) || string.IsNullOrEmpty(property_sqm.Text) || string.IsNullOrEmpty(cb_propertycategory.Text) || string.IsNullOrEmpty(cb_propertystatus.Text) || string.IsNullOrEmpty(cb_propertytype.Text) || string.IsNullOrEmpty(num_pricepersqm.Text)))
            {
                // Temporarily save the values from UC_S_SellingProperty to temp variables.
                tempPropertyName = txt_propertyname.Text;
                tempPropertyAddress = txt_propertyaddress.Text;
                tempPropertyDescription = txt_propertydesc.Text;
                tempPropertyCategory = cb_propertycategory.Text;
                tempPropertyType = cb_propertytype.Text;
                tempPropertyStatus = cb_propertystatus.Text;
                tempPropertySQM = property_sqm.Value;
                tempPricePerSQM = num_pricepersqm.Value;
                tempPropertyImage = propertyimg;
                temptermsandconditions = txt_termsandconditions.Text;

                using (MemoryStream ms = new MemoryStream())
                {
                    propertyimg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                    tempPropertyImageBase64 = Convert.ToBase64String(ms.ToArray());
                }

                int sellerId = 0;
                string connstr = "server=localhost;user=root;password='';database=terraverde_db";
                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    string query = "SELECT SELLER_ID FROM seller WHERE USER_ID = @UserId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userID); // Assuming userID is the logged-in user's ID

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                sellerId = Convert.ToInt32(result);
                            }
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching seller ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the function if there's an error
                        }
                    }
                }
                bool isRent = cb_propertystatus.Text == "For Rent";

                // Prepare the values for MONTHLY_RENTAL_AMOUNT and UTILITY_BILLS_INCLUDED
                monthlyRentalAmount = isRent ? monthly_rental_amount.Value : 0;
                utilityBillsIncluded = isRent && chkbox_utility.Checked ? 1 : 0;
                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    string sql = @"INSERT INTO property (SELLER_ID, PROPERTY_CATEGORY, PROPERTY_TYPE, PROPERTY_PRICE_PER_SQM, PROPERTY_ADDRESS, PROPERTY_NAME, PROPERTY_DESCRIPTION, PROPERTY_STATUS, PROPERTY_SQM, PROPERTY_TOTAL_PRICE, PROPERTY_IMAGE, TERMS_AND_CONDITIONS,MONTHLY_RENTAL_AMOUNT, UTILITY_BILLS_INCLUDED)
                       VALUES (@sellerId, @category, @type, @pricePerSqm, @address, @name, @description, @status, @sqm, @totalPrice, @image, @termsandconditons,  @monthlyRentalAmount, @utilityBillsIncluded)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@sellerId", sellerId); // Assuming userID is the logged-in user's ID
                        cmd.Parameters.AddWithValue("@category", tempPropertyCategory);
                        cmd.Parameters.AddWithValue("@type", tempPropertyType);
                        cmd.Parameters.AddWithValue("@pricePerSqm", tempPricePerSQM);
                        cmd.Parameters.AddWithValue("@address", tempPropertyAddress);
                        cmd.Parameters.AddWithValue("@name", tempPropertyName);
                        cmd.Parameters.AddWithValue("@description", tempPropertyDescription);
                        cmd.Parameters.AddWithValue("@status", tempPropertyStatus);
                        cmd.Parameters.AddWithValue("@sqm", tempPropertySQM);
                        cmd.Parameters.AddWithValue("@totalPrice", tempPricePerSQM * tempPropertySQM); // Calculate total price
                        cmd.Parameters.AddWithValue("@image", tempPropertyImageBase64);
                        cmd.Parameters.AddWithValue("@termsandconditons", temptermsandconditions);
                        cmd.Parameters.AddWithValue("@monthlyRentalAmount", monthlyRentalAmount);
                        cmd.Parameters.AddWithValue("@utilityBillsIncluded", utilityBillsIncluded);

                        try
                        {
                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Dialogbox();
                                MessageBox.Show("Proceeding to Documentation of Property. Please upload the necessary files related to the property like title deed, documents, document description, etc.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //* PASSSSSS
                                //Insert code for moving to UC_S_ProertyDocumentation
                                UC_S_PropertyDocumentation uc = new UC_S_PropertyDocumentation();
                                uc.Dock = DockStyle.Fill;
                                var panelcontainerParent = this.Parent as Panel;
                                var formParent = panelcontainerParent.TopLevelControl as Form;
                                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
                                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
                                uc.BringToFront();
                            }
                            else
                            {
                                MessageBox.Show("Failed to save property details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are filled out and an image of the property is uploaded.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void send()
        {
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";
            int sellerId = 0;

            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                string query = "SELECT SELLER_ID FROM seller WHERE USER_ID = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            sellerId = Convert.ToInt32(result);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching seller ID: " + ex.Message);
                    }
                }
            }

            /*using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                string sql = @"INSERT INTO property (SELLER_ID, PROPERTY_CATEGORY, PROPERTY_TYPE, PROPERTY_PRICE_PER_SQM, PROPERTY_ADDRESS, PROPERTY_NAME, PROPERTY_DESCRIPTION, PROPERTY_STATUS, PROPERTY_SQM, PROPERTY_TOTAL_PRICE, PROPERTY_IMAGE)VALUES (@sellerId, @category, @type, @pricePerSqm, @address, @name, @description, @status, @sqm, @totalPrice, @image)";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    
                    int property_sqm_int = (int)Convert.ToDecimal(property_sqm.Value);
                    int num_pricepersqm_int = (int)Convert.ToDecimal(num_pricepersqm.Value);

                    cmd.Parameters.AddWithValue("@sellerId", sellerId);
                    cmd.Parameters.AddWithValue("@category", cb_propertycategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@type", cb_propertytype.SelectedItem.ToString().ToUpper());
                    cmd.Parameters.AddWithValue("@pricePerSqm", Convert.ToDecimal(num_pricepersqm.Value));
                    cmd.Parameters.AddWithValue("@address", txt_propertyaddress.Text);
                    cmd.Parameters.AddWithValue("@name", txt_propertyname.Text);
                    cmd.Parameters.AddWithValue("@description", txt_propertydesc.Text);
                    cmd.Parameters.AddWithValue("@status", cb_propertystatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sqm", Convert.ToDecimal(property_sqm.Value));


                    int total_price_sqr = property_sqm_int * num_pricepersqm_int;

                    cmd.Parameters.AddWithValue("@totalPrice", total_price_sqr);

                    try
                    {
                        connection.Open();

                        byte[] imageBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pb_propertyimg.Image.Save(ms, pb_propertyimg.Image.RawFormat);
                            imageBytes = ms.ToArray();
                        }
                        string base64String = Convert.ToBase64String(imageBytes);
                        cmd.Parameters.AddWithValue("@image", base64String);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Insertion successful!");
                        }
                        else
                        {
                            Console.WriteLine("Insertion failed!");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting property: " + ex.Message);
                    }
                }
            }*/
        }

        private void Dialogbox()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save these property details?", "Save Property", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Perform the save action
                MessageBox.Show("Property details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                send();
                // Refresh the UC
                //propform();

            }

        }

        private void propform()
        {
            UC_S_Properties uc = new UC_S_Properties();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            propform();
        }

        static Image propertyimg = null;
        private void btn_uploadimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog uploadImg = new OpenFileDialog())
            {
                uploadImg.Filter = "choose image(*.jpg;*.png;)|*.jpg;*.png";
                if (uploadImg.ShowDialog() == DialogResult.OK)
                {
                    propertyimg = Image.FromFile(uploadImg.FileName);
                    pb_propertyimg.Image = propertyimg;
                }
            }
        }

        private void UC_S_SellingProperty_Load(object sender, EventArgs e)
        {
            lbl_monthlyrentalamount.Visible = false;
            utilitybillsincluded.Visible = false;
            monthly_rental_amount.Visible = false;
            chkbox_utility.Visible = false;
        }

            private void cb_propertystatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cb_propertystatus.SelectedItem.ToString();

            // Show or hide controls based on the property status
            lbl_monthlyrentalamount.Visible = selectedStatus == "For Rent";
            utilitybillsincluded.Visible = selectedStatus == "For Rent";
            monthly_rental_amount.Visible = selectedStatus == "For Rent";
            chkbox_utility.Visible = selectedStatus == "For Rent";

            // If the status is "SELL", set the values to 0 or hide the controls
            if (selectedStatus == "SELL")
            {
            }
        }


    }
}

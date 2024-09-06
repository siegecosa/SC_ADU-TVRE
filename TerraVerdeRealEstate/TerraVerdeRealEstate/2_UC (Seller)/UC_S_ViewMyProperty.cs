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
using TerraVerdeRealEstate.UC__Client_;
using TerraVerdeRealEstate.UC__Seller_;

namespace TerraVerdeRealEstate._2_UC__Seller_
{
    public partial class UC_S_ViewMyProperty : UserControl
    {

        private int propertyId;
        public UC_S_ViewMyProperty(int prop_id)
        {
            InitializeComponent();
            propertyId = prop_id;
            LoadPropertyDetails();
            cb_propertystatus.SelectedIndexChanged += cb_propertystatus_SelectedIndexChanged;
        }

        private void LoadPropertyDetails()
        {
            string connectionString = "server=localhost;user=root;password=;database=terraverde_db";

            // Define SQL query to fetch property details
            string query = "SELECT PROPERTY_CATEGORY, PROPERTY_TYPE, PROPERTY_PRICE_PER_SQM, PROPERTY_ADDRESS, " +
                           "PROPERTY_NAME, PROPERTY_DESCRIPTION, PROPERTY_STATUS, PROPERTY_SQM, PROPERTY_IMAGE, " +
                           "TERMS_AND_CONDITIONS, MONTHLY_RENTAL_AMOUNT, UTILITY_BILLS_INCLUDED " +
                           "FROM property " +
                           "WHERE PROPERTY_ID = @PropertyId";

            // Create connection and command objects
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PropertyId", propertyId);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate form fields with fetched data
                        cb_propertycategory.Text = reader["PROPERTY_CATEGORY"].ToString();
                        cb_propertytype.Text = reader["PROPERTY_TYPE"].ToString();
                        num_pricepersqm.Value = Convert.ToDecimal(reader["PROPERTY_PRICE_PER_SQM"]);
                        txt_propertyaddress.Text = reader["PROPERTY_ADDRESS"].ToString();
                        txt_propertyname.Text = reader["PROPERTY_NAME"].ToString();
                        txt_propertydesc.Text = reader["PROPERTY_DESCRIPTION"].ToString();
                        cb_propertystatus.Text = reader["PROPERTY_STATUS"].ToString();
                        property_sqm.Value = Convert.ToDecimal(reader["PROPERTY_SQM"]);

                        pb_propertyimg.Image = Base64ToImage(reader["PROPERTY_IMAGE"].ToString());

                        // Load terms and conditions
                        text_termsandconditions.Text = reader["TERMS_AND_CONDITIONS"].ToString();

                        // Load monthly rental amount if the property status is "For Rent"
                        if (cb_propertystatus.Text == "For Rent")
                        {
                            monthly_rental_amount.Value = Convert.ToDecimal(reader["MONTHLY_RENTAL_AMOUNT"]);
                        }

                        // Update the state of chxbox_utility based on UTILITY_BILLS_INCLUDED
                        chxbox_utility.Checked = Convert.ToInt32(reader["UTILITY_BILLS_INCLUDED"]) == 1;
                    }
                    else
                    {
                        MessageBox.Show("Property not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // Method to convert base64 string to image
        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
            Image image = Image.FromStream(ms);
            return image;
        }



        private void btn_editproperty_Click(object sender, EventArgs e)
        {
            txt_propertyaddress.Enabled = true;
            txt_propertyname.Enabled = true;
            txt_propertydesc.Enabled = true;  
            cb_propertycategory.Enabled = true;
            cb_propertystatus.Enabled = true;
            cb_propertytype.Enabled = true;
            property_sqm.Enabled = true;
            num_pricepersqm.Enabled = true;
            btn_editproperty.Enabled = true;
            btn_uploadimg.Enabled = true;
            btn_editproperty.Enabled = false;
            btn_save.Enabled = true;
            text_termsandconditions.Enabled = true;
            monthly_rental_amount.Enabled = true;
            chxbox_utility.Enabled = true;


            text_termsandconditions.ForeColor = Color.Black;
            monthly_rental_amount.ForeColor = Color.Black;
            num_pricepersqm.ForeColor = Color.Black;
            property_sqm.ForeColor = Color.Black;
            cb_propertycategory.ForeColor = Color.Black;
            cb_propertystatus.ForeColor = Color.Black;
            cb_propertytype.ForeColor = Color.Black;
            txt_propertyaddress.ForeColor = Color.Black;
            txt_propertydesc.ForeColor = Color.Black;
            txt_propertyname.ForeColor = Color.Black;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            UC_C_Properties.passBuyOrRent = "";
            UC_S_Properties.sell = "";
            text_termsandconditions.ForeColor = SystemColors.ButtonShadow;
            monthly_rental_amount.ForeColor = SystemColors.ButtonShadow;
            num_pricepersqm.ForeColor = SystemColors.ButtonShadow;
            property_sqm.ForeColor = SystemColors.ButtonShadow;
            cb_propertycategory.ForeColor = SystemColors.ButtonShadow;
            cb_propertystatus.ForeColor = SystemColors.ButtonShadow;
            cb_propertytype.ForeColor = SystemColors.ButtonShadow;
            txt_propertyaddress.ForeColor = SystemColors.ButtonShadow;
            txt_propertydesc.ForeColor = SystemColors.ButtonShadow;
            txt_propertyname.ForeColor = SystemColors.ButtonShadow;
           




            // Convert the image to Base64 string
            string imageBase64 = ImageToBase64(pb_propertyimg.Image);
            string connectionString = "server=localhost;user=root;password=;database=terraverde_db";

            // Prepare the SQL update query
            string query = "UPDATE property SET " +
                           "PROPERTY_CATEGORY = @PropertyCategory, " +
                           "PROPERTY_TYPE = @PropertyType, " +
                           "PROPERTY_PRICE_PER_SQM = @PropertyPricePerSqm, " +
                           "PROPERTY_ADDRESS = @PropertyAddress, " +
                           "PROPERTY_NAME = @PropertyName, " +
                           "PROPERTY_DESCRIPTION = @PropertyDescription, " +
                           "PROPERTY_STATUS = @PropertyStatus, " +
                           "PROPERTY_IMAGE = @PropertyImage, " +
                           "PROPERTY_SQM = @PropertySqm, " +
                           "PROPERTY_TOTAL_PRICE = @PropertyTotalPrice, " +
                           "TERMS_AND_CONDITIONS = @TermsAndConditions ";

            // Add conditional updates for MONTHLY_RENTAL_AMOUNT and UTILITY_BILLS_INCLUDED
            if (cb_propertystatus.SelectedIndex == 1) // Assuming "For Rent" is the second item in the ComboBox
            {
                query += ", MONTHLY_RENTAL_AMOUNT = @MonthlyRentalAmount, UTILITY_BILLS_INCLUDED = @UtilityBillsIncluded ";
            }
            else
            {
                query += ", MONTHLY_RENTAL_AMOUNT = 0, UTILITY_BILLS_INCLUDED = 0 ";
            }

            query += "WHERE PROPERTY_ID = @PropertyId";

            // Create connection and command objects
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PropertyId", propertyId);
                command.Parameters.AddWithValue("@PropertyCategory", cb_propertycategory.Text);
                command.Parameters.AddWithValue("@PropertyType", cb_propertytype.Text.ToUpper());
                command.Parameters.AddWithValue("@PropertyPricePerSqm", num_pricepersqm.Value);
                command.Parameters.AddWithValue("@PropertyAddress", txt_propertyaddress.Text);
                command.Parameters.AddWithValue("@PropertyName", txt_propertyname.Text);
                command.Parameters.AddWithValue("@PropertyDescription", txt_propertydesc.Text);
                command.Parameters.AddWithValue("@PropertyStatus", cb_propertystatus.Text);
                command.Parameters.AddWithValue("@PropertyImage", imageBase64);
                command.Parameters.AddWithValue("@PropertySqm", property_sqm.Value); // Assuming property_sqm is a NumericUpDown control
                command.Parameters.AddWithValue("@PropertyTotalPrice", num_pricepersqm.Value * property_sqm.Value);
                command.Parameters.AddWithValue("@TermsAndConditions", text_termsandconditions.Text);

                // Conditional parameters for MONTHLY_RENTAL_AMOUNT and UTILITY_BILLS_INCLUDED
                if (cb_propertystatus.SelectedIndex == 1)
                {
                    command.Parameters.AddWithValue("@MonthlyRentalAmount", monthly_rental_amount.Value);
                    command.Parameters.AddWithValue("@UtilityBillsIncluded", chxbox_utility.Checked ? 1 : 0);
                }

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Property updated successfully");
                        propform();
                    }
                    else
                    {
                        MessageBox.Show("No changes made to the property");
                        propform();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Re-enable the form fields and buttons
            EnableFormFields(false);
        }


        // Method to convert image to Base64 string
        private string ImageToBase64(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        // Method to enable or disable form fields and buttons
        private void EnableFormFields(bool enable)
        {
            txt_propertyaddress.Enabled = enable;
            txt_propertyname.Enabled = enable;
            txt_propertydesc.Enabled = enable;
            cb_propertycategory.Enabled = enable;
            cb_propertystatus.Enabled = enable;
            cb_propertytype.Enabled = enable;
            property_sqm.Enabled = enable;
            num_pricepersqm.Enabled = enable;
            btn_editproperty.Enabled = enable;
            btn_uploadimg.Enabled = enable;
            btn_save.Enabled = !enable;
            text_termsandconditions.Enabled = !enable;
            monthly_rental_amount.Enabled = !enable;
            chxbox_utility.Enabled = !enable;
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

        private void UC_S_ViewMyProperty_Load(object sender, EventArgs e)
        {
            monthlyrentalamount.Visible = false;
            utilitybillsincluded.Visible = false;
            monthly_rental_amount.Visible = false;
            monthly_rental_amount.Enabled = false;
            chxbox_utility.Enabled = false;
            chxbox_utility.Visible = false;

            if (cb_propertystatus.SelectedIndex == 1)
            {
                monthlyrentalamount.Visible = true;
                utilitybillsincluded.Visible = true;
                monthly_rental_amount.Visible = true;
                chxbox_utility.Visible = true;
            }
            else
            {
                monthlyrentalamount.Visible = false;
                utilitybillsincluded.Visible = false;
                monthly_rental_amount.Visible = false;
                chxbox_utility.Visible = false;
            }
        }

        private void cb_propertystatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_propertystatus.SelectedIndex == 1)
            {
                monthlyrentalamount.Visible = true;
                utilitybillsincluded.Visible = true;
                monthly_rental_amount.Visible = true;
                chxbox_utility.Visible = true;
                monthly_rental_amount.Enabled = true;
                chxbox_utility.Enabled = true;
            }
            else
            {
                monthlyrentalamount.Visible = false;
                utilitybillsincluded.Visible = false;
                monthly_rental_amount.Visible = false;
                chxbox_utility.Visible = false;
            }
        }

    }
}


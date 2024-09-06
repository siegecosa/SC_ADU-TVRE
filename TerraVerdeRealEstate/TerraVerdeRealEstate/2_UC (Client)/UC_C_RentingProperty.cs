using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate._4_Payment;
using TerraVerdeRealEstate.UC__Client_;

namespace TerraVerdeRealEstate._2_UC__Client_
{
    public partial class UC_C_RentingProperty : UserControl
    {
        private int id;
        public UC_C_RentingProperty(int prop_id)
        {
            InitializeComponent();
            id = prop_id;
            string connStr = "server=localhost;user=root;password='';database=terraverde_db";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT PROPERTY_ADDRESS, PROPERTY_DESCRIPTION, PROPERTY_IMAGE, PROPERTY_TOTAL_PRICE, PROPERTY_NAME FROM property WHERE PROPERTY_ID = @prop_id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // Add parameter for prop_id
                    command.Parameters.AddWithValue("@prop_id", prop_id);

                    conn.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Check if there is a row matching the prop_id
                        {
                            string address = reader["PROPERTY_ADDRESS"].ToString();
                            string description = reader["PROPERTY_DESCRIPTION"].ToString();
                            string base64Image = reader["PROPERTY_IMAGE"].ToString();
                            string property_name = reader["PROPERTY_NAME"].ToString();
                            decimal totalPrice = Convert.ToDecimal(reader["PROPERTY_TOTAL_PRICE"]);

                            lbl_desc.Text = description;
                            lbl_address.Text = address;
                            lbl_propertyName.Text = property_name;
                            lbl_rentpermonth.Text = totalPrice.ToString();

                            byte[] imageBytes = Convert.FromBase64String(base64Image);

                            // Convert byte array to Image
                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }
                            img_property.Image = image;
                        }
                        else
                        {
                            // Handle case where no row with matching prop_id is found
                            MessageBox.Show("Property not found.");
                        }
                    }
                }
            }

        }

        private void btn_GoBacktoProperty_Click(object sender, EventArgs e)
        {
            UC_C_Properties uc = new UC_C_Properties();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_rentproperty_Click(object sender, EventArgs e)
        {
            string propertyName = lbl_propertyName.Text;
            string rentDuration = cb_rentduration.Text;

            if (string.IsNullOrEmpty(rentDuration))
            {
                MessageBox.Show("Please select a rent duration.", "Rent Duration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution if no rent duration is selected
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to rent for {rentDuration} in {propertyName}?", "Rent Property", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NavigateToPropertiesUC(rentDuration);
            }
        }

        private void NavigateToPropertiesUC(string rent)
        {
            UC_CardPayment uc = new UC_CardPayment(id, rent);
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }


    

        private void UC_C_RentingProperty_Load(object sender, EventArgs e)
        {

        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }
    }
}

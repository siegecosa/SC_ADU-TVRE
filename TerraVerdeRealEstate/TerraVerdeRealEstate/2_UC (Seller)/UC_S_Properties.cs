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
using TerraVerdeRealEstate._2_UC__Client_;
using TerraVerdeRealEstate._2_UC__Seller_;
using TerraVerdeRealEstate.UC__LogReg_;


namespace TerraVerdeRealEstate.UC__Seller_
{
    public partial class UC_S_Properties : UserControl
    {

        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VAR
        public static int Seller;
        public static string sell;
        int sellerid;
        int userID;
        string propertyStatus = "(PROPERTY_STATUS='FOR RENT' OR PROPERTY_STATUS='FOR SALE')";
        string propertyCategory = "(PROPERTY_CATEGORY='COMMERCIAL' OR PROPERTY_CATEGORY='RESIDENTIAL')";
        string propertyType = "(PROPERTY_TYPE='APARTMENT' OR PROPERTY_TYPE='CONDO' OR PROPERTY_TYPE='TOWN HOUSE')";
        string propertySearch = "";
        #endregion

        #region Filter

        private void rb_allCategory_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyCategory = "(PROPERTY_CATEGORY='COMMERCIAL' OR PROPERTY_CATEGORY='RESIDENTIAL')"; loadData();
        }
        private void rb_commercial_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyCategory = "PROPERTY_CATEGORY='COMMERCIAL'"; loadData();
        }
        private void rb_residential_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyCategory = "PROPERTY_CATEGORY='RESIDENTIAL'"; loadData();
        }
        private void rb_allType_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyType = "(PROPERTY_TYPE='APARTMENT' OR PROPERTY_TYPE='CONDO' OR PROPERTY_TYPE='TOWN HOUSE')"; loadData();
        }
        private void rb_apartment_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyType = "PROPERTY_TYPE='APARTMENT'"; loadData();
        }
        private void rb_condominium_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyType = "PROPERTY_TYPE='CONDO'"; loadData();
        }
        private void rb_townhouse_CheckedChanged_1(object sender, EventArgs e)
        {
            propertyType = "PROPERTY_TYPE='TOWN HOUSE'"; loadData();
        }
        #endregion

        #region Search

        private void txt_search_Enter_1(object sender, EventArgs e)
        {
            txt_search.Text = ""; txt_search.ForeColor = Color.Black;
        }
        private void txt_search_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text)) { txt_search.Text = "Search..."; txt_search.ForeColor = SystemColors.ButtonShadow; ; }
        }
        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txt_search.Text) || txt_search.Text == "Search...")) { propertySearch = " AND PROPERTY_NAME LIKE'%" + txt_search.Text + "%'"; } else { propertySearch = ""; }
        }
        private void img_search_Click_1(object sender, EventArgs e)
        {
            loadData();
        }


        #endregion

        public UC_S_Properties()
        {

            InitializeComponent();
            userID = UC__LogReg_.UC_LR_Login.userID;
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            get_sellerid();

            int userId = UC__LogReg_.UC_LR_Login.userID; // Adjust this line as necessary

            // Check verification status
            string verificationStatus = CheckVerificationStatus(userId);

            if (verificationStatus == "Not Verified")
            {
                MessageBox.Show("Your account is not yet approved. Please wait for the admin's approval.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (verificationStatus == "Under Review")
            {
                MessageBox.Show("Your account is currently under review. Please wait for the admin's decision.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (verificationStatus == "Rejected")
            {
                MessageBox.Show("Your account has been rejected. Please go to the profile to submit a verification again.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificationStatus != "Verified")
            {
                // This is a fallback for any other status not explicitly handled above.
                MessageBox.Show("An unexpected error occurred. Please contact support.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_AddProperty.Enabled = verificationStatus == "Verified";

            loadData();
        }

        private void btn_AddProperty_Click(object sender, EventArgs e)
        {
            UC_S_Properties.sell = "";
            UC_S_SellingProperty uc = new UC_S_SellingProperty();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }

        int prop_id;
        #region Functions
        void loadData()
        {
            property_container.Controls.Clear();

            int rowCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string countSql = "SELECT COUNT(*) FROM property WHERE SELLER_ID = @sellerId";

                MySqlCommand countCmd = new MySqlCommand(countSql, conn);
                countCmd.Parameters.AddWithValue("@sellerId", sellerid);
                rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
            }

            // Check if there are rows to load
            if (rowCount > 0)
            {
                UC__Small_Layouts_.UC_IndividualProperties[] property = new UC__Small_Layouts_.UC_IndividualProperties[rowCount];

                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    conn.Open();

                    sql = "SELECT PROPERTY_ID, PROPERTY_NAME, PROPERTY_DESCRIPTION, PROPERTY_ADDRESS, PROPERTY_TOTAL_PRICE, PROPERTY_STATUS, PROPERTY_IMAGE FROM property WHERE SELLER_ID = @sellerId AND " + propertyStatus + " AND " + propertyCategory + " AND " + propertyType + propertySearch;

                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sellerId", sellerid);

                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            int i = 0;
                            while (dr.Read() && i < property.Length)
                            {
                                prop_id = dr.GetInt32("PROPERTY_ID");
                                property[i] = new UC__Small_Layouts_.UC_IndividualProperties(prop_id);

                                property[i].propertyName = dr.GetString("PROPERTY_NAME");
                                property[i].propertyDesc = dr.GetString("PROPERTY_DESCRIPTION");
                                property[i].propertyLocation = dr.GetString("PROPERTY_ADDRESS");
                                property[i].propertyPrice = "Php " + dr.GetDouble("PROPERTY_TOTAL_PRICE");
                                string propertyStatus = dr.GetString("PROPERTY_STATUS");

                                
                                property[i].propertyStatus = "My Property";
                                sell = "My Property";
                                string base64String = dr["PROPERTY_IMAGE"].ToString();



                                if (!string.IsNullOrEmpty(base64String))
                                {
                                    try
                                    {
                                        byte[] imgBLOB = Convert.FromBase64String(base64String);
                                        using (MemoryStream ms = new MemoryStream(imgBLOB))
                                        {
                                            property[i].propertyImage = Image.FromStream(ms);



                                            

                                        }
                                    }
                                    catch (FormatException ex)
                                    {
                                        // Handle the exception, e.g., log the error or show a message to the user
                                        Console.WriteLine("Invalid Base64 string: " + ex.Message);
                                    }
                                    catch (ArgumentNullException ex)
                                    {
                                        // Handle the exception, e.g., log the error or show a message to the user
                                        Console.WriteLine("Base64 string is null or empty: " + ex.Message);
                                    }
                                }
                                else
                                {
                                    // Handle the case where base64String is null or empty
                                    Console.WriteLine("Base64 string is null or empty.");
                                }


                                property_container.Controls.Add(property[i]);
                                i++;
                            }
                        }
                        else
                        {
                            Label lbl_soldProperty = new Label();
                            lbl_soldProperty.AutoSize = true;
                            lbl_soldProperty.Font = new Font(lbl_soldProperty.Font.FontFamily, 40, FontStyle.Bold);
                            lbl_soldProperty.ForeColor = SystemColors.ButtonShadow;
                            lbl_soldProperty.Text = "No properties available.";
                            property_container.Controls.Add(lbl_soldProperty);
                        }

                    }
                    conn.Close();
                }
            }
            else
            {
                // No properties available
                Label lbl_soldProperty = new Label();
                lbl_soldProperty.AutoSize = true;
                lbl_soldProperty.Font = new Font(lbl_soldProperty.Font.FontFamily, 40, FontStyle.Bold);
                lbl_soldProperty.ForeColor = SystemColors.ButtonShadow;
                lbl_soldProperty.Text = "No properties available.";
                property_container.Controls.Add(lbl_soldProperty);
            }
        }

        void get_sellerid()
        {
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";
            

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
                            sellerid = Convert.ToInt32(result);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching seller ID: " + ex.Message);
                    }
                }
            }
        }

        #endregion


        private void UC_S_Properties_Load(object sender, EventArgs e)
        {
          }

        private string CheckVerificationStatus(int userId)
        {
            string verificationStatus = "Pending"; // Default status
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";

            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                string query = "SELECT VERIFICATION_STATUS FROM verification WHERE USER_ID = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            verificationStatus = result.ToString();
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching verification status: " + ex.Message);
                    }
                }
            }

            return verificationStatus;
        }

        
    }
}

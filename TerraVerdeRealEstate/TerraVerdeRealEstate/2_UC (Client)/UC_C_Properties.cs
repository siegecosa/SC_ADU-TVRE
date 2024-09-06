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
using MySql.Data.MySqlClient;
using TerraVerdeRealEstate._4_Payment;
using TerraVerdeRealEstate.UC__Common_;

namespace TerraVerdeRealEstate.UC__Client_
{
    public partial class UC_C_Properties : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VAR
        string propertyStatus = "(PROPERTY_STATUS='FOR RENT' OR PROPERTY_STATUS='FOR SALE')";
        string propertyCategory = "(PROPERTY_CATEGORY='COMMERCIAL' OR PROPERTY_CATEGORY='RESIDENTIAL')";
        string propertyType = "(PROPERTY_TYPE='APARTMENT' OR PROPERTY_TYPE='CONDO' OR PROPERTY_TYPE='TOWN HOUSE')";
        string propertySearch = "";

        public static int Client;
        public static string passBuyOrRent;
        public static int passPropertyID;
        #endregion

        public UC_C_Properties()
        {
            InitializeComponent();

            int userId = UC__LogReg_.UC_LR_Login.userID; // Adjust this line as necessary

            string verificationStatus = CheckVerificationStatus(userId);
            if (verificationStatus == "Not Verified")
            {
                MessageBox.Show("Your account is not yet approved. Please wait for the admin's approval.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (verificationStatus == "Under Review")
            {
                MessageBox.Show("Your verification is under review by the admin.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (verificationStatus == "Rejected")
            {
                MessageBox.Show("Your verification has been rejected by the admin. Go to Profile to verify again.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificationStatus == "Verified")
            {
                // Access everything
            }
            else
            {
                // Handle unexpected status
                MessageBox.Show("Unexpected verification status.", "Verification Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            loadData();
        }

        #region Filter
        private void rb_allStatus_CheckedChanged(object sender, EventArgs e) { propertyStatus = "(PROPERTY_STATUS='FOR RENT' OR PROPERTY_STATUS='FOR SALE')"; loadData(); }
        private void rb_forRent_CheckedChanged(object sender, EventArgs e) { propertyStatus = "PROPERTY_STATUS='FOR RENT'"; loadData(); }
        private void rb_forSale_CheckedChanged(object sender, EventArgs e) { propertyStatus = "PROPERTY_STATUS='FOR SALE'"; loadData(); }

        private void rb_allCategory_CheckedChanged(object sender, EventArgs e) { propertyCategory = "(PROPERTY_CATEGORY='COMMERCIAL' OR PROPERTY_CATEGORY='RESIDENTIAL')"; loadData(); }
        private void rb_commercial_CheckedChanged(object sender, EventArgs e) { propertyCategory = "PROPERTY_CATEGORY='COMMERCIAL'"; loadData(); }
        private void rb_residential_CheckedChanged(object sender, EventArgs e) { propertyCategory = "PROPERTY_CATEGORY='RESIDENTIAL'"; loadData(); }

        private void rb_allType_CheckedChanged(object sender, EventArgs e) { propertyType = "(PROPERTY_TYPE='APARTMENT' OR PROPERTY_TYPE='CONDO' OR PROPERTY_TYPE='TOWN HOUSE')"; loadData(); }
        private void rb_apartment_CheckedChanged(object sender, EventArgs e) { propertyType = "PROPERTY_TYPE='APARTMENT'"; loadData(); }
        private void rb_condominium_CheckedChanged(object sender, EventArgs e) { propertyType = "PROPERTY_TYPE='CONDO'"; loadData(); }
        private void rb_townhouse_CheckedChanged(object sender, EventArgs e) { propertyType = "PROPERTY_TYPE='TOWN HOUSE'"; loadData(); }
        #endregion

        #region Search
        private void txt_search_Enter(object sender, EventArgs e) { txt_search.Text = ""; txt_search.ForeColor = Color.Black; }
        private void txt_search_Leave(object sender, EventArgs e) { if (string.IsNullOrWhiteSpace(txt_search.Text)) { txt_search.Text = "Search..."; txt_search.ForeColor = SystemColors.ButtonShadow; ; } }
        private void txt_search_TextChanged(object sender, EventArgs e) { if (!(string.IsNullOrWhiteSpace(txt_search.Text) || txt_search.Text == "Search...")) { propertySearch = " AND PROPERTY_NAME LIKE'%" + txt_search.Text + "%'"; } else { propertySearch = ""; } }
        private void img_search_Click(object sender, EventArgs e) { loadData(); }
        #endregion

        #region Functions
        void loadData()

        {
            
            property_container.Controls.Clear();
            Client = 1;
            int rowCount = 0;
            int Soldcount = 0;
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string countSql = "SELECT COUNT(*) FROM property";
                MySqlCommand countCmd = new MySqlCommand(countSql, conn);
                rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
            }

            UC__Small_Layouts_.UC_IndividualProperties[] property = new UC__Small_Layouts_.UC_IndividualProperties[rowCount];
            int[] arrayPropertyID = new int[rowCount];
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string countSql = "SELECT COUNT(*) FROM property WHERE PROPERTY_STATUS = @propertyStatus";
                MySqlCommand countCmd = new MySqlCommand(countSql, conn);
                countCmd.Parameters.AddWithValue("@propertyStatus", "SOLD"); 
                Soldcount = Convert.ToInt32(countCmd.ExecuteScalar());
            }

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                sql = "SELECT PROPERTY_ID, PROPERTY_NAME, PROPERTY_DESCRIPTION, PROPERTY_ADDRESS, PROPERTY_TOTAL_PRICE, PROPERTY_STATUS, PROPERTY_IMAGE FROM property WHERE NOT (PROPERTY_STATUS ='SOLD') AND " + propertyStatus + " AND " + propertyCategory + " AND " + propertyType + propertySearch; //add select image
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        int i = 0;
                        while (dr.Read() && i < property.Length)
                        {
                            Console.WriteLine(Soldcount);
                            int prop_id = dr.GetInt32("PROPERTY_ID");

                            property[i] = new UC__Small_Layouts_.UC_IndividualProperties(prop_id);

                            property[i].propertyName = dr.GetString("PROPERTY_NAME");
                            property[i].propertyDesc = dr.GetString("PROPERTY_DESCRIPTION");
                            property[i].propertyLocation = dr.GetString("PROPERTY_ADDRESS");
                            property[i].propertyPrice = "Php " + dr.GetDouble("PROPERTY_TOTAL_PRICE");
                            string propertyStatus = dr.GetString("PROPERTY_STATUS");
                            arrayPropertyID[i] = dr.GetInt32("PROPERTY_ID");


                            if (propertyStatus == "FOR SALE") { property[i].propertyStatus = "Buy"; passBuyOrRent = "Buy"; }
                            else if (propertyStatus == "FOR RENT") { property[i].propertyStatus = "Rent"; passBuyOrRent = "Rent"; }
                    

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


        #endregion

        private void property_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_C_Properties_Load(object sender, EventArgs e)
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

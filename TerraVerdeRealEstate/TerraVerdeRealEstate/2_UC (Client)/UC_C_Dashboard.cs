using MySql.Data.MySqlClient;
using Spire.Additions.Xps.Schema;
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

namespace TerraVerdeRealEstate.UC__Client_
{
    public partial class UC_C_Dashboard : UserControl
    {


        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataTable dt = new DataTable();

        //GLOBAL VARIABLE

        int clientId;
        public UC_C_Dashboard()
        {
            clientId = Form_ClientSide.clientId;
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            pb_ad.Image = Properties.Resources.ad1;
        }

        private void UC_C_Dashboard_Load(object sender, EventArgs e)
        {
            loadRecentProperty();
            loadproperties();
            loadVerificationStatus();
        }

        private void loadproperties()
        {
            // Create a MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connstr);

            // Check if myPropertyListBox is not null before proceeding
            if (myproperty != null)
            {
                // Open the database connection
                conn.Open();

                string sql = "SELECT p.PROPERTY_NAME, p.PROPERTY_ADDRESS " +
              "FROM property p " +
              "INNER JOIN transaction t ON p.PROPERTY_ID = t.PROPERTY_ID " +
              "WHERE t.CLIENT_ID = @clientId";

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@clientId", clientId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string propertyName = reader.GetString("PROPERTY_NAME");
                        string propertyAddress = reader.GetString("PROPERTY_ADDRESS");

                        // Add the property to the ListBox
                        myproperty.Items.Add(propertyName + " - " + propertyAddress);
                    }
                }

                // Close the database connection
                conn.Close();
            }
            else
            {
                // Handle the case where myPropertyListBox is null
                // For example, display an error message or log the issue
                Console.WriteLine("myPropertyListBox is null.");
            }

        }



        private void loadVerificationStatus()
        {
            // Create a MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connstr);
            int userId = UC__LogReg_.UC_LR_Login.userID;
            try
            {
                // Open the database connection
                conn.Open();

                string sql = "SELECT VERIFICATION_STATUS FROM verification WHERE USER_ID = @clientId";

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@clientId", userId); // Pass clientId parameter to the query

                // Execute the query and fetch the verification status
                object verificationStatus = cmd.ExecuteScalar();

                // Check if verification status is not null and set it to the label
                if (verificationStatus != null)
                {

                    lbl_verificationstatus.Text = verificationStatus.ToString();
                    string verifyImage = verificationStatus.ToString(); // Replace with the actual verification status fetched from the database
                    DisplayVerificationImage(verifyImage);
                }
                else
                {
                    lbl_verificationstatus.Text = "No verification status found";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database access
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }

        private void DisplayVerificationImage(string verificationStatus)
        {
            // Set default image
            Image statusImage = Properties.Resources.default_avatar; // Set your default image here

            switch (verificationStatus)
            {
                case "Not Verified":
                    statusImage = Properties.Resources.z_unverified;
                    break;
                case "Verified":
                    statusImage = Properties.Resources.z_verified;
                    break;
                case "Under Review":
                    statusImage = Properties.Resources.z_underreview;
                    break;
                case "Rejected":
                    statusImage = Properties.Resources.z_rejected;
                    break;
                default:
                    // Handle any other status if needed
                    break;
            }

            // Display the image in your PictureBox or wherever you want to show it
            pb_verified.Image = statusImage;
        }





        private void loadRecentProperty()
        {
            property_container.Controls.Clear();

            int rowCount = 0;
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string countSql = "SELECT COUNT(*) FROM transaction WHERE CLIENT_ID = " + clientId;
                MySqlCommand countCmd = new MySqlCommand(countSql, conn);
                rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
            }

            UC__Small_Layouts_.UC_S_RecentClients[] property = new UC__Small_Layouts_.UC_S_RecentClients[rowCount];

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string sql = "SELECT p.PROPERTY_NAME, p.PROPERTY_IMAGE, t.PROPERTY_TRANSACTION_TYPE, CONCAT(c.CLIENT_FN, ' ', c.CLIENT_LN) AS 'ClientName', t.TRANSACTION_DATE " +
              "FROM transaction AS t " +
              "INNER JOIN property AS p ON t.PROPERTY_ID = p.PROPERTY_ID " +
              "INNER JOIN client AS c ON t.CLIENT_ID = c.CLIENT_ID " +
              "WHERE t.CLIENT_ID = @clientId";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@clientId", clientId);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        int i = 0;
                        while (dr.Read() && i < property.Length)
                        {
                            property[i] = new UC__Small_Layouts_.UC_S_RecentClients();

                            property[i].title = dr.GetString("PROPERTY_NAME");
                            string type = dr.GetString("PROPERTY_TRANSACTION_TYPE");
                            string client = dr.GetString("ClientName");
                            DateTime transactionDate = dr.GetDateTime("TRANSACTION_DATE"); // Retrieve TRANSACTION_DATE


                            if (type == "RENT") { property[i].subtitle = "Day Rented: " + transactionDate; }
                            else if (type == "SELL") { property[i].subtitle = "Day Bought: " + transactionDate; }


                            string base64String = dr["PROPERTY_IMAGE"].ToString();
                            if (!string.IsNullOrEmpty(base64String))
                            {
                                try
                                {
                                    byte[] imgBLOB = Convert.FromBase64String(base64String);
                                    using (MemoryStream ms = new MemoryStream(imgBLOB))
                                    {
                                        property[i].image = Image.FromStream(ms);
                                    }
                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine("Invalid Base64 string: " + ex.Message);
                                }
                                catch (ArgumentNullException ex)
                                {
                                    Console.WriteLine("Base64 string is null or empty: " + ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Base64 string is null or empty.");
                            }

                            property_container.Controls.Add(property[i]);
                            i++;
                        }
                    }
                    else
                    {
                        Label lbl_noProperty = new Label();
                        lbl_noProperty.AutoSize = true;
                        lbl_noProperty.Font = new Font(lbl_noProperty.Font.FontFamily, 30, FontStyle.Bold);
                        lbl_noProperty.ForeColor = SystemColors.ButtonShadow;
                        lbl_noProperty.Text = "No list available.";
                        property_container.Controls.Add(lbl_noProperty);
                    }

                }
                conn.Close();
            }
        }









        //ads
        private int currentImageIndex = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Set the image of pb_ad based on the current image index
            switch (currentImageIndex)
            {
                case 0:
                    pb_ad.Image = Properties.Resources.ad1;
                    break;
                case 1:
                    pb_ad.Image = Properties.Resources.ad2;
                    break;
                case 2:
                    pb_ad.Image = Properties.Resources.ad3;
                    break;
                // Add more cases if you have more images
                default:
                    // Reset to the first image if all images have been displayed
                    currentImageIndex = -1;
                    break;
            }

            // Increment the image index for the next tick
            currentImageIndex++;
        }

        private void pb_verified_Click(object sender, EventArgs e)
        {

        }
    }
}

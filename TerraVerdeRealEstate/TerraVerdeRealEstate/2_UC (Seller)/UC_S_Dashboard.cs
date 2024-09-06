using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace TerraVerdeRealEstate.UC__Seller_
{
    public partial class UC_S_Dashboard : UserControl
    {
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataTable dt = new DataTable();

        int sellerId;
        static string[] months = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        static int[] spendings = new int[12];
        public UC_S_Dashboard()
        {
            sellerId = Form_SellerSide.sellerId;
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            loadproperty();
            loadRecentProperty();      
            populateChart();
            loadVerificationStatus();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UC_S_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void loadproperty()
        {
            // Create a MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connstr);

            // Check if myPropertyListBox is not null before proceeding
            if (Smyproperty != null)
            {
                // Open the database connection
                conn.Open();

                // SQL query to select properties with a status of "FOR SALE" or "FOR RENT"
                string sql = "SELECT PROPERTY_NAME, PROPERTY_ADDRESS " +
                             "FROM property " +
                             "WHERE PROPERTY_STATUS IN ('FOR SALE', 'FOR RENT')";

                cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string propertyName = reader.GetString("PROPERTY_NAME");
                        string propertyAddress = reader.GetString("PROPERTY_ADDRESS");

                        // Add the property to the ListBox
                        Smyproperty.Items.Add(propertyName + " - " + propertyAddress);
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



        private void loadRecentProperty()
        {
            ract.Controls.Clear();

            int rowCount = 0;
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string countSql = "SELECT COUNT(*) FROM transaction WHERE SELLER_ID = " + sellerId;
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
                  "WHERE t.SELLER_ID = @sellerId"; cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@sellerId", sellerId);
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
                            else if (type == "SELL") { property[i].subtitle = "Day Sold: " + transactionDate; }


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

                            ract.Controls.Add(property[i]);
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
                        ract.Controls.Add(lbl_noProperty);
                    }

                }
                conn.Close();
            }
        }
        private void getMonthlyEarnings()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                for (int month = 1; month <= 12; month++)
                {
                    sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'CURRENT EARNINGS' FROM transaction WHERE SELLER_ID = " + sellerId + " AND MONTH(TRANSACTION_DATE) = " + month;
                    cmd = new MySqlCommand(sql, conn);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read() && dr["CURRENT EARNINGS"] != DBNull.Value)
                            {
                                spendings[month - 1] = Convert.ToInt32(dr["CURRENT EARNINGS"]);
                            }
                        }
                        else
                        {
                            spendings[month - 1] = 0;
                        }
                    }
                }
                conn.Close();
            }
        }
        private void populateChart()
        {
            getMonthlyEarnings();
            chart1.Series.Clear();
            chart1.Legends.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            for (int i = 0; i < months.Length; i++)
            {
                series.Points.AddXY(months[i], spendings[i]);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Title = "Amount Earned";
            chart1.ChartAreas[0].AxisX.Title = "Months";


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

                string sql = "SELECT VERIFICATION_STATUS FROM verification WHERE USER_ID = @sellerId";

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sellerId", userId); // Pass clientId parameter to the query

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Smyproperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

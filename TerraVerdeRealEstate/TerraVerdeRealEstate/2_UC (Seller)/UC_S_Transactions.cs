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
using MySql.Data.MySqlClient;

namespace TerraVerdeRealEstate.UC__Seller_
{
    public partial class UC_S_Transactions : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataTable dt = new DataTable();

        //GLOBAL VARIABLE
        static int sellerId;
        static string[] months = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        static int[] spendings = new int[12];

        #endregion
        public UC_S_Transactions()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void UC_S_Transactions_Load(object sender, EventArgs e)
        {
            sellerId = Form_SellerSide.sellerId;
            loadTransactionData();
            populateChart();
            loadRecentProperty();
        }
        #region Functions
        private void loadTransactionData()
        {
            getTotalEarnings();
            getMonthlyEarnings();
            getCurrentMonthEarning();
            getTransactionData();
        }

        private void getTotalEarnings()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'TOTAL EARNINGS' FROM transaction WHERE SELLER_ID = " + sellerId;
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lbl_totalearnings.Text = "Php " + dr["TOTAL EARNINGS"].ToString();
                        }
                    }
                    else
                    {
                        lbl_totalearnings.Text = "Php 0.00";
                    }
                }
                conn.Close();
            }
        }

        private void getCurrentMonthEarning()
        {
            int currentMonth = DateTime.Now.Month;

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'CURRENT EARNINGS' FROM transaction WHERE SELLER_ID = @SellerId AND MONTH(TRANSACTION_DATE) = @CurrentMonth";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SellerId", sellerId);
                cmd.Parameters.AddWithValue("@CurrentMonth", currentMonth);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read() && !dr.IsDBNull(0))
                    {
                        lbl_monthlyprofit.Text = "Php " + dr["CURRENT EARNINGS"].ToString();
                    }
                    else
                    {
                        lbl_monthlyprofit.Text = "Php 0.00";
                    }
                }
            }
        }

        private void getTransactionData()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                sql = "SELECT t.REFERENCE_NUMBER AS 'Reference ID', t.TRANSACTION_DATE AS 'Transaction Date', CONCAT(c.CLIENT_LN, ', ', c.CLIENT_FN) AS 'Client Name', p.PROPERTY_NAME AS 'Property Name', t.MODE_OF_PAYMENT AS 'Payment Method', t.AMOUNT_PAID AS 'Amount Paid' FROM transaction AS t INNER JOIN client AS c ON t.CLIENT_ID = c.CLIENT_ID INNER JOIN property AS p ON t.PROPERTY_ID = p.PROPERTY_ID WHERE t.SELLER_ID =  " + sellerId ;
                da = new MySqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                dgv_sellertransactions.DataSource = dt;
                conn.Close();
            }


        }

        private void populateChart()
        {
            chart_profit.Series.Clear();
            chart_profit.Legends.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            // Get the days of the current month with property purchases
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1); // Last day of the current month
            
            // Add data points for each day with property purchases
            for (int i = 0; i < months.Length; i++)
            {
                series.Points.AddXY(months[i], spendings[i]);
            }

            chart_profit.Series.Add(series);

            chart_profit.ChartAreas[0].AxisX.Interval = 1;
            chart_profit.ChartAreas[0].AxisY.Minimum = 0;
            chart_profit.ChartAreas[0].AxisY.Title = "Amount Earned";
            chart_profit.ChartAreas[0].AxisX.Title = "Days";
        }

        private int GetDailyEarnings(int day)
        {
            int dailyEarnings = 0;

            

            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                // Get the total amount paid on the specified day
                sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'DAILY EARNINGS' FROM transaction WHERE SELLER_ID = " + sellerId + " AND DAY(TRANSACTION_DATE) = " + day;
                cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    dailyEarnings = Convert.ToInt32(result);
                }

                conn.Close();
            }

            return dailyEarnings;
        }

        private List<int> GetDaysWithPurchases(DateTime startDate, DateTime endDate)
        {
            List<int> daysWithPurchases = new List<int>();

            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    // Check if there are property purchases on the current date
                    sql = "SELECT COUNT(*) FROM transaction WHERE SELLER_ID = " + sellerId + " AND TRANSACTION_DATE = '" + date.ToString("yyyy-MM-dd") + "'";
                    cmd = new MySqlCommand(sql, conn);
                    int purchaseCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (purchaseCount > 0)
                    {
                        daysWithPurchases.Add(date.Day);
                    }
                }

                conn.Close();
            }

            return daysWithPurchases;
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

        private void loadRecentProperty()
        {
            property_container.Controls.Clear();

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

                sql = "SELECT c.CLIENT_EMAIL, p.PROPERTY_NAME, c.CLIENT_IMAGE, t.PROPERTY_TRANSACTION_TYPE, CONCAT(c.CLIENT_FN, ' ', c.CLIENT_LN) AS 'ClientName' FROM transaction AS t INNER JOIN property as p ON t.PROPERTY_ID = p.PROPERTY_ID INNER JOIN client AS c ON t.CLIENT_ID = c.CLIENT_ID WHERE t.SELLER_ID = " + sellerId;
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        int i = 0;
                        while (dr.Read() && i < property.Length)
                        {
                            property[i] = new UC__Small_Layouts_.UC_S_RecentClients();

                            property[i].title = dr.GetString("ClientName");
                            //string type = dr.GetString("PROPERTY_TRANSACTION_TYPE");
                            string client = dr.GetString("ClientName");
                            string clientemail = dr.GetString("CLIENT_EMAIL");
                            property[i].subtitle = clientemail;


                            string base64String = dr["CLIENT_IMAGE"].ToString();
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


        #endregion


    }
}

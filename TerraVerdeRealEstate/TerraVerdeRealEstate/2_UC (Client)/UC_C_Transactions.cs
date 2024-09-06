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


namespace TerraVerdeRealEstate.UC__Client_
{
    public partial class UC_C_Transactions : UserControl
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
        static int clientId;
        static string[] months = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        static int[] spendings = new int[12];

        #endregion


        public UC_C_Transactions()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void UC_C_Transactions_Load(object sender, EventArgs e)
        {
            clientId = Form_ClientSide.clientId;
            loadTransactionData();
            populateChart();
            loadRecentProperty();
        }

        #region Functions
        private void loadTransactionData()
        {
            getTotalSpendings();
            getCurrentMonthSpending();
            getTransactionData();
        }

        private void getTotalSpendings()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'TOTAL SPENDINGS' FROM transaction WHERE CLIENT_ID = " + clientId;
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows) 
                    {
                        while (dr.Read())
                        {
                            lbl_totalspendings.Text = "Php " + dr["TOTAL SPENDINGS"].ToString();
                        }
                    }
                    else
                    {
                        lbl_totalspendings.Text = "Php 0.00";
                    }
                }
                conn.Close();
            }
        }

        private void getCurrentMonthSpending()
        {
            int currentMonth = DateTime.Now.Month;

            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'CURRENT SPENDINGS' FROM transaction WHERE CLIENT_ID = " + clientId + " AND MONTH(TRANSACTION_DATE) = " + currentMonth;
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lbl_monthlyspendings.Text = "Php " + dr["CURRENT SPENDINGS"].ToString();
                        }
                    }
                    else
                    {
                        lbl_monthlyspendings.Text = "Php 0.00";
                    }
                }
                conn.Close();
            }
        }

        private void getTransactionData()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                sql = "SELECT t.REFERENCE_NUMBER AS 'Reference ID', t.TRANSACTION_DATE AS 'Transaction Date', CONCAT(s.SELLER_LN, ', ', s.SELLER_FN) AS 'Seller Name', p.PROPERTY_NAME AS 'Property Name', t.MODE_OF_PAYMENT AS 'Payment Method', t.AMOUNT_PAID AS 'Amount Paid' FROM transaction AS t INNER JOIN seller AS s ON t.SELLER_ID = s.SELLER_ID INNER JOIN property AS p ON t.PROPERTY_ID = p.PROPERTY_ID WHERE t.CLIENT_ID =  " + clientId;
                da = new MySqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                dgv_clienttransactions.DataSource = dt;
                conn.Close();
            }       
        }

        private void populateChart()
        {
            getMonthlySpendings();
            chart_spendings.Series.Clear();
            chart_spendings.Legends.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            for (int i = 0; i < months.Length; i++)
            {
                series.Points.AddXY(months[i], spendings[i]);
            }

            chart_spendings.Series.Add(series);

            chart_spendings.ChartAreas[0].AxisX.Interval = 1;
            chart_spendings.ChartAreas[0].AxisY.Minimum = 0;
            chart_spendings.ChartAreas[0].AxisY.Title = "Amount Spent"; 
            chart_spendings.ChartAreas[0].AxisX.Title = "Months";


        }

        private void getMonthlySpendings()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();

                for (int month = 1; month <= 12; month++)
                {
                    sql = "SELECT SUM(TOTAL_AMOUNT_PAID) AS 'CURRENT SPENDINGS' FROM transaction WHERE CLIENT_ID = " + clientId + " AND MONTH(TRANSACTION_DATE) = " + month;
                    cmd = new MySqlCommand(sql, conn);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read() && dr["CURRENT SPENDINGS"] != DBNull.Value)
                            {
                                spendings[month-1] =  Convert.ToInt32(dr["CURRENT SPENDINGS"]);
                            }
                        }
                        else
                        {
                            spendings[month-1] = 0;
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

                string countSql = "SELECT COUNT(*) FROM transaction WHERE CLIENT_ID = " + clientId;
                MySqlCommand countCmd = new MySqlCommand(countSql, conn);
                rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
            }

            UC__Small_Layouts_.UC_S_RecentClients[] property = new UC__Small_Layouts_.UC_S_RecentClients[rowCount];

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string sql = @"
            SELECT 
                s.SELLER_ID,
                CONCAT(s.SELLER_FN, ' ', s.SELLER_LN) AS 'SellerName',
                s.SELLER_IMAGE,
                s.SELLER_EMAIL,
                COUNT(*) AS 'TransactionCount'
            FROM 
                transaction AS t 
            INNER JOIN 
                seller AS s ON t.SELLER_ID = s.SELLER_ID 
            WHERE 
                t.CLIENT_ID = " + clientId + @"
            GROUP BY 
                s.SELLER_ID,
                s.SELLER_FN,
                s.SELLER_LN,
                s.SELLER_IMAGE
            ORDER BY 
                TransactionCount DESC
            LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        int i = 0;
                        while (dr.Read() && i < property.Length)
                        {
                            property[i] = new UC__Small_Layouts_.UC_S_RecentClients();

                            property[i].title = dr.GetString("SellerName");
                            string sellerImageBase64 = dr.GetString("SELLER_IMAGE");
                            string selleremail = dr.GetString("SELLER_EMAIL");
                            property[i].subtitle = selleremail;

                            if (!string.IsNullOrEmpty(sellerImageBase64))
                            {
                                try
                                {
                                    byte[] imgBLOB = Convert.FromBase64String(sellerImageBase64);
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
                                Console.WriteLine("SELLER_IMAGE Base64 string is null or empty.");
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

        private void chart_spendings_Click(object sender, EventArgs e)
        {

        }
    }
}

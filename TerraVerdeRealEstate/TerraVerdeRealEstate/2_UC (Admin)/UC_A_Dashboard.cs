using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace TerraVerdeRealEstate._2_UC__Admin_
{
    public partial class UC_A_Dashboard : UserControl
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
        #endregion


        static string[] months = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        static int[] spendings = new int[12];

        public UC_A_Dashboard()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void UC_A_Dashboard_Load(object sender, EventArgs e)
        {
            loadDashboardData();
            populateChart();
        }

        #region Functions
        private void loadDashboardData()
        {
            getPendingVerification();
            getRecentTransactions();
        }

        private void getPendingVerification()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
               
                sql = "SELECT CAST(LPAD(COUNT(*), 2, '0') AS CHAR) AS 'Pending Verification' FROM verification WHERE VERIFICATION_STATUS = 'Under Review'";
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lbl_numofunverified.Text = dr["Pending Verification"].ToString();
                        }
                    }
                    else
                    {
                        lbl_numofunverified.Text = "00";
                    }
                }

                conn.Close();
            }
        }

        private void getRecentTransactions()
        {
            using (conn = new MySqlConnection(connstr))
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();

                    sql = "SELECT CAST(LPAD(COUNT(*), 2, '0') AS CHAR) AS 'Recent Transaction' FROM transaction WHERE DATE(TRANSACTION_DATE) = CURDATE()";

                    cmd = new MySqlCommand(sql, conn);

                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lbl_recenttransaction.Text = dr["Recent Transaction"].ToString();
                            }
                        }
                        else
                        {
                            lbl_recenttransaction.Text = "00";
                        }
                    }

                    conn.Close();
                }

            }
        }

        #endregion












        private void populateChart()
        {
            // Initialize database connection
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";
            MySqlConnection conn = new MySqlConnection(connstr);

            try
            {
                conn.Open();

                // Query to fetch data from the database
                string query = "SELECT TRANSACTION_DATE, AMOUNT_PAID FROM transaction";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable transactionData = new DataTable();
                da.Fill(transactionData);

                // Close the connection after fetching data
                conn.Close();

                chart1.Series.Clear();
                chart1.Legends.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Column;

                // Grouping the data by month and summing up the amounts for each month
                var monthlyData = from row in transactionData.AsEnumerable()
                                  group row by new
                                  {
                                      Month = row.Field<DateTime>("TRANSACTION_DATE").Month,
                                      Year = row.Field<DateTime>("TRANSACTION_DATE").Year
                                  } into grp
                                  select new
                                  {
                                      Month = grp.Key.Month,
                                      Year = grp.Key.Year,
                                      TotalAmount = grp.Sum(r => r.Field<decimal>("AMOUNT_PAID"))
                                  };

                // Assuming you want to display data for the past 12 months
                DateTime currentDate = DateTime.Now;
                for (int i = 0; i < 12; i++)
                {
                    DateTime month = currentDate.AddMonths(-i);
                    var dataForMonth = monthlyData.FirstOrDefault(m => m.Month == month.Month && m.Year == month.Year);
                    decimal amountForMonth = dataForMonth != null ? dataForMonth.TotalAmount : 0m;
                    series.Points.AddXY(month.ToString("MMM-yyyy"), amountForMonth);
                }

                chart1.Series.Add(series);

                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Title = "Amount Spent";
                chart1.ChartAreas[0].AxisX.Title = "Months";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Handle the error accordingly
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection if it's still open
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TerraVerdeRealEstate._2_UC__Admin_
{
    public partial class UC_A_Transactionlogs : UserControl
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

        public UC_A_Transactionlogs()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void UC_A_Transactionlogs_Load(object sender, EventArgs e)
        {
            loadTransactionLogs();
        }

        #region Functions
        private void loadTransactionLogs()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                sql = "SELECT t.REFERENCE_NUMBER AS 'Reference ID', t.TRANSACTION_DATE AS 'Transaction Date',  t.PROPERTY_TRANSACTION_TYPE AS 'Transaction Type', CONCAT(c.CLIENT_FN, ' ', c.CLIENT_LN) AS 'Client Name', CONCAT(s.SELLER_FN, ' ', s.SELLER_LN) AS 'Seller Name', p.PROPERTY_NAME AS 'Property Name', t.MODE_OF_PAYMENT AS 'Payment Method', t.AMOUNT_PAID AS 'Amount Paid' FROM transaction AS t INNER JOIN seller AS s ON t.SELLER_ID = s.SELLER_ID INNER JOIN client AS c ON t.CLIENT_ID = c.CLIENT_ID INNER JOIN property AS p ON t.PROPERTY_ID = p.PROPERTY_ID";
                da = new MySqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull("Transaction Type"))
                    {
                        row["Transaction Type"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(row["Transaction Type"].ToString().ToLower());
                    }
                    if (!row.IsNull("Payment Method"))
                    {
                        row["Payment Method"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(row["Payment Method"].ToString().ToLower());
                    }
                }
                dgv_transactionlogs.DataSource = dt;
                conn.Close();
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Assuming you're using SQL Server
using System.Data;
using MySql.Data.MySqlClient;

namespace TerraVerdeRealEstate._2_UC__Admin_
{
    public partial class UC_A_UserVerificationLogs : UserControl
    {
        public UC_A_UserVerificationLogs()
        {
            InitializeComponent();
        }

        //insert db connection
        private void UC_A_UserVerificationLogs_Load_1(object sender, EventArgs e)
        {
            LoadVerificationLogs();
        }


        private void LoadVerificationLogs()
        {
            string connectionString = "server=localhost;user=root;password='';database=terraverde_db";

            string query = @"
            SELECT v.VERIFICATION_ID,
                   v.USER_ID,
                   CONCAT(IFNULL(c.CLIENT_FN, ''), ' ', IFNULL(c.CLIENT_MN, ''), ' ', IFNULL(c.CLIENT_LN, ''), 
                          IFNULL(s.SELLER_FN, ''), ' ', IFNULL(s.SELLER_MN, ''), ' ', IFNULL(s.SELLER_LN, '')) AS Full_Name,
                   v.VERIFICATION_STATUS
            FROM verification v
            LEFT JOIN client c ON v.USER_ID = c.USER_ID
            LEFT JOIN seller s ON v.USER_ID = s.USER_ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgv_userverificationlogs.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            UC_A_Verify uc = new UC_A_Verify();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_admin", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_admin", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }


    }
}

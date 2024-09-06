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
using TerraVerdeRealEstate._2_UC__Admin_;
using TerraVerdeRealEstate.UC__Common_;
using TerraVerdeRealEstate.UC__Seller_;

namespace TerraVerdeRealEstate
{
    public partial class Form_AdminSide : Form
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VARIABLE
        static int userID;
        static string welcomeMsg;
        #endregion

        public Form_AdminSide()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void Form_AdminSide_Load(object sender, EventArgs e)
        {
            loadAdminData();

            lbl_frontbig.Text = "Dashboard";
            lbl_frontsmall.Text = "Welcome, Fname Sname!";
            UC_A_Dashboard uc = new UC_A_Dashboard();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
        }

        public void loadAdminData()
        {
            userID = UC__LogReg_.UC_LR_Login.userID;

            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                sql = "SELECT u.USERNAME, CONCAT(a.ADMIN_FN, ' ', a.ADMIN_LN) AS adminName, a.ADMIN_IMAGE FROM admin AS a INNER JOIN user AS u ON a.USER_ID = u.USER_ID WHERE a.USER_ID = " + userID;
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lbl_username.Text = dr["USERNAME"].ToString();
                        welcomeMsg = "Welcome, " + dr["adminName"].ToString() + "!";
                        lbl_frontsmall.Text = welcomeMsg;

                        string base64String = dr["ADMIN_IMAGE"].ToString();
                        byte[] imgBLOB = Convert.FromBase64String(base64String);
                        using (MemoryStream ms = new MemoryStream(imgBLOB)) { img_profile.Image = Image.FromStream(ms); }
                    }
                }
                conn.Close();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Dashboard";
            lbl_frontsmall.Text = "Welcome, Fname Sname!";
            UC_A_Dashboard uc = new UC_A_Dashboard();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
        }

        public void btn_verify_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Verify User Accounts";
            lbl_frontsmall.Text = "Review unverified user accounts.";
            UC_A_Verify uc = new UC_A_Verify();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
        }

        public void verify()
        {
            btn_verify.PerformClick();
        }

        private void btn_transactions_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Transaction Logs";
            lbl_frontsmall.Text = "Review transactions made by clients and sellers.";
            UC_A_Transactionlogs uc = new UC_A_Transactionlogs();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Settings";
            lbl_frontsmall.Text = "Configure preferred settings.";
            UC_CommonSettings uc = new UC_CommonSettings();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Profile";
            lbl_frontsmall.Text = "See and adjust your profile settings.";
            UC_CommonProfile uc = new UC_CommonProfile();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
            btn_dashboard.Checked = false;
            btn_verify.Checked = false;
            btn_transactions.Checked = false;
            btn_settings.Checked = false;
        }

        private void img_profile_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Profile";
            lbl_frontsmall.Text = "See and adjust your profile settings.";
            UC_CommonProfile uc = new UC_CommonProfile();
            uc.Dock = DockStyle.Fill;
            panelmain_admin.Controls.Clear();
            panelmain_admin.Controls.Add(uc);
            uc.BringToFront();
            btn_dashboard.Checked = false;
            btn_verify.Checked = false;
            btn_transactions.Checked = false;
            btn_settings.Checked = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var formParent = this.FindForm();

                if (formParent != null)
                {
                    formParent.Close();

                    Form_LogReg formLogReg = new Form_LogReg();
                    formLogReg.Show();
                }
            }
        }
    }
}

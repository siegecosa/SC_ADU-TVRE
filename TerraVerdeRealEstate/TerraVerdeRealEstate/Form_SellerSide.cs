using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate.UC__Common_;
using TerraVerdeRealEstate.UC__Seller_;
using MySql.Data.MySqlClient;
using System.IO;

namespace TerraVerdeRealEstate
{
    public partial class Form_SellerSide : Form
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
        public static int sellerId;
        #endregion

        public Form_SellerSide()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        //when the form LOADS THE SELLER SIDE
        private void Form_SellerSide_Load(object sender, EventArgs e)
        {
            loadSellerData();

            lbl_frontbig.Text = "Dashboard";
            lbl_frontsmall.Text = welcomeMsg;
            UC_S_Dashboard uc = new UC_S_Dashboard();
            uc.Dock = DockStyle.Fill;
            panelmain_seller.Controls.Clear();
            panelmain_seller.Controls.Add(uc);
            uc.BringToFront();
        }

        #region Functions
        public void loadSellerData()
        {
            userID = UC__LogReg_.UC_LR_Login.userID;

            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                sql = "SELECT s.SELLER_ID, u.USERNAME, CONCAT(s.SELLER_FN, ' ', s.SELLER_LN) AS sellerName, s.SELLER_IMAGE FROM seller AS s INNER JOIN user AS u ON s.USER_ID = u.USER_ID WHERE s.USER_ID = " + userID; 
                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader()) { 
                    while (dr.Read()) {
                        sellerId = Convert.ToInt32(dr["SELLER_ID"]);
                        lbl_username.Text = dr["USERNAME"].ToString();
                        welcomeMsg = "Welcome, " + dr["sellerName"].ToString() + "!";
                        lbl_frontsmall.Text = welcomeMsg;

                        string base64String = dr["SELLER_IMAGE"].ToString();
                        byte[] imgBLOB = Convert.FromBase64String(base64String);
                        using (MemoryStream ms = new MemoryStream(imgBLOB)) { img_profile.Image = Image.FromStream(ms); }
                    }
                }
                conn.Close();
            }
        }

        public void showSellerProfile()
        {
            lbl_frontbig.Text = "Profile";
            lbl_frontsmall.Text = "See and adjust your profile settings.";
            UC_CommonProfile uc = new UC_CommonProfile();
            uc.Dock = DockStyle.Fill;
            panelmain_seller.Controls.Clear();
            panelmain_seller.Controls.Add(uc);
            uc.BringToFront();
            btn_dashboard.Checked = false;
            btn_properties.Checked = false;
            btn_transactions.Checked = false;
            btn_settings.Checked = false;
        }
        #endregion

        #region NAVIGATION BETWEEN DASHBOARD, PROPERTIES, TRANSACTIONS, SETTINGS, PROFILE, AND SIGN OUT
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Dashboard";
            lbl_frontsmall.Text = welcomeMsg;
            UC_S_Dashboard uc = new UC_S_Dashboard();
            uc.Dock = DockStyle.Fill;
            panelmain_seller.Controls.Clear();
            panelmain_seller.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_properties_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Properties";
            lbl_frontsmall.Text = "Manage your TerraVerde properties.";
            UC_S_Properties uc = new UC_S_Properties();
            uc.Dock = DockStyle.Fill;
            panelmain_seller.Controls.Clear();
            panelmain_seller.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_transactions_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Transactions";
            lbl_frontsmall.Text = "Keep track of your previous transactions.";
            UC_S_Transactions uc = new UC_S_Transactions();
            uc.Dock = DockStyle.Fill;
            panelmain_seller.Controls.Clear();
            panelmain_seller.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            lbl_frontbig.Text = "Settings";
            lbl_frontsmall.Text = "Configure preferred settings.";
            UC_CommonSettings uc = new UC_CommonSettings();
            uc.Dock = DockStyle.Fill;
            panelmain_seller.Controls.Clear();
            panelmain_seller.Controls.Add(uc);
            uc.BringToFront();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            showSellerProfile();
        }

        private void img_profile_Click(object sender, EventArgs e)
        {
            showSellerProfile();

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
        #endregion


    }
}

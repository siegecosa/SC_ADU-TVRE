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
using Org.BouncyCastle.Asn1.X500;

namespace TerraVerdeRealEstate.UC__LogReg_
{

    public partial class UC_LR_Login : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VARIABLE
        public static int userType;
        public static int userID;
        #endregion

        #region Enters
        private void txt_username_Enter(object sender, EventArgs e) { reset_txt(); txt_username.ForeColor = Color.Black; if (txt_username.Text == "Username") { txt_username.Text = ""; } }
        private void txt_password_Enter(object sender, EventArgs e) { reset_txt(); txt_password.ForeColor = Color.Black; if (txt_password.Text == "Password") { txt_password.Text = ""; } }
        #endregion

        #region Functions
        private void reset_txt()
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text)) { txt_username.Text = "Username"; txt_username.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_password.Text)) { txt_password.Text = "Password"; txt_password.ForeColor = SystemColors.ButtonShadow; txt_password.PasswordChar = '\0'; }
        }

        private void go2Seller()
        {
            var formParent = this.FindForm();

            if (formParent != null)
            {
                formParent.Close();

                Form_SellerSide formSellerSide = new Form_SellerSide();
                formSellerSide.Show();
                formParent.Hide();

            }
        }

        private void go2Admin()
        {
            var formParent = this.FindForm();

            if (formParent != null)
            {
                formParent.Close();

                Form_AdminSide formAdminSide = new Form_AdminSide();
                formAdminSide.Show();
                formParent.Hide();

            }
        }

        private void go2Client()
        {
            var formParent = this.FindForm();

            if (formParent != null)
            {
                formParent.Close();

                Form_ClientSide formClientSide = new Form_ClientSide();
                formClientSide.Show();
                formParent.Hide();
            }
        }
        #endregion

        public UC_LR_Login()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            //This is the code to fucking access a UC's parent form, wherein the panelcontainer of the UC resides. Use this code.
            UC_LR_Register uc = new UC_LR_Register();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelcontainer_LogReg", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelcontainer_LogReg", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region To remove
        private void btn_goseller_Click(object sender, EventArgs e)
        {
            //Code for Hiding FOrm_LogReg and then showing Form_SellerSide 
            //Note, under Program.cs on right side>>>>> made modifications on how the application runs. Form1 is dettached from main app run, so it can Close without closing the 2nd form when "seller" button is clicked.
            // Copy paste this code to use it for when navigating thru diff Forms (ex: I want Form_LogReg to close (different from Hide), and Form_SellerSide to Open.
            go2Seller();

        }

        private void btn_goclient_Click(object sender, EventArgs e)
        {
            //Code for Hiding FOrm_LogReg and then showing Form_ClientSide 
            //Note, under Program.cs on right side>>>>> made modifications on how the application runs. Form1 is dettached from main app run, so it can Close without closing the 2nd form when "seller" button is clicked.
            // Copy paste this code to use it for when navigating thru diff Forms (ex: I want Form_LogReg to close (different from Hide), and Form_SellerSide to Open.
            go2Client();
        }
        #endregion

        private void btn_login_Click(object sender, EventArgs e)
        {
          
            conn.Open();

            string txtusername = txt_username.Text;
            string txtpassword = txt_password.Text;

            sql = "SELECT USER_ID, USERNAME, PASSWORD, USER_TYPE FROM user WHERE BINARY USERNAME = @username AND BINARY PASSWORD = @password";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtusername);
            cmd.Parameters.AddWithValue("@password", txtpassword);

            dr = cmd.ExecuteReader();

            if (dr.Read()) {
                string username = dr.GetString(1);
                string password = dr.GetString(2);
                userType = dr.GetInt32(3);
                userID = dr.GetInt32(0);

                if (userType == 1) {
                    go2Client();
                }
                else if (userType == 2) {
                    go2Seller();
                }
                else if (userType == 0)
                {
                    go2Admin();
                }
            } 
            else {
                txt_password.Clear();
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            reset_txt();
            conn.Close();
        }

        private void lbl_fpass_Click(object sender, EventArgs e)
        {
            Form_OTPPass formOTPPass = new Form_OTPPass("Login");
            this.Enabled = false;
            formOTPPass.Show();
            formOTPPass.TopMost = true;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void btn_goadmin_Click(object sender, EventArgs e)
        {
            var formParent = this.FindForm();

            if (formParent != null)
            {
                formParent.Close();

                Form_AdminSide formAdminSide = new Form_AdminSide();
                formAdminSide.Show();
                formParent.Hide();
            }
        }
    }
}

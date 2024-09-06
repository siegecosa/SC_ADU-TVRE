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


namespace TerraVerdeRealEstate._1_UC__OTPPass_
{
    public partial class UC_OP_PassReset : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VARIABLE 
        static string formName;
        #endregion

        public UC_OP_PassReset(string fromFormName)
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
            formName = fromFormName;
        }

        private void btn_submitnewpass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your password?", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (txt_password.Text == txt_cpassword.Text)
                {
                    string username = UC_OP_OTP.username;

                    sql = "UPDATE user SET password = @password WHERE username=@username";
                    conn.Open();
                    using (cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", txt_cpassword.Text);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("New Password and Confirm Password did not match.");
                }

                var formParent = this.FindForm();

                if (formParent != null)
                {
                    formParent.Close();

                    Form_LogReg formSellerSide = new Form_LogReg();
                    formSellerSide.Show();
                    formSellerSide.Enabled = true;
                }
            }

            reset_txt();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var formParent = this.FindForm();

            if (formParent != null)
            {
                formParent.Close();

                if (formName == "Login")
                {
                    Form_LogReg formLogin = new Form_LogReg();
                    formLogin.Show();
                    formLogin.Enabled = true;
                }
                else if (formName == "Client")
                {
                    Form_ClientSide formClient = new Form_ClientSide();
                    formClient.Show();
                    formClient.showClientProfile();
                    formClient.Enabled = true;
                }
                else if (formName == "Seller")
                {
                    Form_SellerSide formSeller = new Form_SellerSide();
                    formSeller.Show();
                    formSeller.showSellerProfile();
                    formSeller.Enabled = true;
                }
            }
        }

        private void btn_show1_Click(object sender, EventArgs e)
        {
            if (btn_show1.Text == "Show") { txt_password.PasswordChar = '\0'; btn_show1.Text = "Hide"; }
            else { txt_password.PasswordChar = '*'; btn_show1.Text = "Show"; }

        }

        private void btn_show2_Click(object sender, EventArgs e)
        {
            if (btn_show2.Text == "Show") { txt_cpassword.PasswordChar = '\0'; btn_show2.Text = "Hide"; }
            else { txt_cpassword.PasswordChar = '*'; btn_show2.Text = "Show"; }
        }

        #region Functions
        private void reset_txt()
        {
            if (string.IsNullOrWhiteSpace(txt_password.Text)) { txt_password.Text = "Password"; txt_password.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_cpassword.Text)) { txt_cpassword.Text = "Confirm Password"; txt_cpassword.ForeColor = SystemColors.ButtonShadow; }
        }
        #endregion

        #region Enters
        private void txt_password_Enter(object sender, EventArgs e) { reset_txt(); txt_password.ForeColor = Color.Black; if (txt_password.Text == "Password") { txt_password.Text = ""; } }
        private void txt_cpassword_Enter(object sender, EventArgs e) { reset_txt(); txt_cpassword.ForeColor = Color.Black; if (txt_cpassword.Text == "Confirm Password") { txt_cpassword.Text = ""; } }
        #endregion

        #region Validation
        #endregion
    }
}

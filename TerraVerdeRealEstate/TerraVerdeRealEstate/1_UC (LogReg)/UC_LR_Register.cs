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
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.IO;


namespace TerraVerdeRealEstate.UC__LogReg_
{
    public partial class UC_LR_Register : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VAR
        static Image userDP = null;
        static string gender = "";
        static string picbase64 = "";
        static int atype = 3;
        static bool legalage = false;
        static bool pnum = false;
        static bool validemail = false;
        static bool existingemail = true;
        static bool existingusername = true;
        static bool pass = false;
        static bool cpass = false;
        #endregion
        public UC_LR_Register()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        #region Enters
        private void txt_fname_Enter(object sender, EventArgs e) { reset_txt(); txt_fname.ForeColor = Color.Black; if (txt_fname.Text == "First Name") { txt_fname.Text = ""; } }
        private void txt_mname_Enter(object sender, EventArgs e) { reset_txt(); txt_mname.ForeColor = Color.Black; if (txt_mname.Text == "Middle Name") { txt_mname.Text = ""; } }
        private void txt_lname_Enter(object sender, EventArgs e) { reset_txt(); txt_lname.ForeColor = Color.Black; if (txt_lname.Text == "Last Name") { txt_lname.Text = ""; } }
        private void txt_address_Enter(object sender, EventArgs e) { reset_txt(); txt_address.ForeColor = Color.Black; if (txt_address.Text == "Address") { txt_address.Text = ""; } }
        private void txt_pnum_Enter(object sender, EventArgs e) { reset_txt(); txt_pnum.ForeColor = Color.Black; if (txt_pnum.Text == "Phone Number") { txt_pnum.Text = ""; } }
        private void txt_email_Enter(object sender, EventArgs e) { reset_txt(); txt_email.ForeColor = Color.Black; if (txt_email.Text == "Email Address") { txt_email.Text = ""; } }
        private void txt_username_Enter(object sender, EventArgs e) { reset_txt(); txt_username.ForeColor = Color.Black; if (txt_username.Text == "Username") { txt_username.Text = ""; } }
        private void txt_pass_Enter(object sender, EventArgs e) { reset_txt(); txt_pass.ForeColor = Color.Black; if (txt_pass.Text == "Password") { txt_pass.Text = ""; } }
        private void txt_cpass_Enter(object sender, EventArgs e) { reset_txt(); txt_cpass.ForeColor = Color.Black; if (txt_cpass.Text == "Confirm Password") { txt_cpass.Text = ""; } }
        private void txt_bdate_Enter(object sender, EventArgs e) { reset_txt(); }

        #endregion

        #region CheckChanged
        private void rb_male_CheckedChanged(object sender, EventArgs e) { reset_txt(); gender = "Male"; }
        private void rb_female_CheckedChanged(object sender, EventArgs e) { reset_txt(); gender = "Female"; }
        private void rb_others_CheckedChanged(object sender, EventArgs e) { reset_txt(); gender = "Others"; }
        private void rb_client_CheckedChanged(object sender, EventArgs e) { reset_txt(); atype = 1; }
        private void rb_seller_CheckedChanged(object sender, EventArgs e) { reset_txt(); atype = 2; }
        #endregion

        #region TextChanged
        private void txt_pass_TextChanged(object sender, EventArgs e) { txt_pass.PasswordChar = '*'; }

        private void txt_cpass_TextChanged(object sender, EventArgs e) { txt_cpass.PasswordChar = '*'; }
        #endregion

        #region Validation
        private void lbl_fname_Validating(object sender, CancelEventArgs e)
        {
            if (txt_fname.Text == "First Name") { e.Cancel = true; txt_fname.Focus(); error_fname.SetError(lbl_fname, "This field is required!"); }
            else { e.Cancel = true; error_fname.SetError(lbl_fname, null); }
        }
        private void lbl_mname_Validating(object sender, CancelEventArgs e)
        {
            if (txt_mname.Text == "Middle Name") { e.Cancel = true; txt_mname.Focus(); error_mname.SetError(lbl_mname, "This field is required!"); }
            else { e.Cancel = true; error_mname.SetError(lbl_mname, null); }
        }
        private void lbl_lname_Validating(object sender, CancelEventArgs e)
        {
            if (txt_lname.Text == "Last Name") { e.Cancel = true; txt_lname.Focus(); error_lname.SetError(lbl_lname, "This field is required!"); }
            else { e.Cancel = true; error_lname.SetError(lbl_lname, null); }
        }
        private void lbl_bdate_Validating(object sender, CancelEventArgs e)
        {
            if (legalage == false) { e.Cancel = true; txt_bdate.Focus(); error_bdate.SetError(lbl_bdate, "You must be 18 and above!"); }
            else { e.Cancel = true; error_bdate.SetError(lbl_bdate, null); }
        }
        private void lbl_gender_Validating(object sender, CancelEventArgs e)
        {
            if (gender == "") { e.Cancel = true; gender_group.Focus(); error_gender.SetError(lbl_gender, "This field is required!"); }
            else { e.Cancel = true; error_gender.SetError(lbl_gender, null); }
        }
        private void lbl_address_Validating(object sender, CancelEventArgs e)
        {
            if (txt_address.Text == "Address") { e.Cancel = true; txt_address.Focus(); error_address.SetError(lbl_address, "This field is required!"); }
            else { e.Cancel = true; error_address.SetError(lbl_address, null); }
        }
        private void lbl_pnum_Validating(object sender, CancelEventArgs e)
        {
            if (txt_pnum.Text == "Phone Number") { e.Cancel = true; txt_pnum.Focus(); error_pnum.SetError(lbl_pnum, "This field is required!"); }
            else if (pnum == false) { e.Cancel = true; txt_pnum.Focus(); error_pnum.SetError(lbl_pnum, "Must be in correct format: 09xxxxxxxxx"); }
            else { e.Cancel = true; error_pnum.SetError(lbl_pnum, null); }
        }
        private void lbl_email_Validating(object sender, CancelEventArgs e)
        {
            if (txt_email.Text == "Email Address") { e.Cancel = true; txt_email.Focus(); error_email.SetError(lbl_email, "This field is required!"); }
            else if (validemail == false) { e.Cancel = true; txt_email.Focus(); error_email.SetError(lbl_email, "Must be a valid email address"); }
            else if (existingemail == true && atype >= 3) { e.Cancel = true; txt_email.Focus(); error_email.SetError(lbl_email, "Select account type first"); }
            else if (existingemail == true) { e.Cancel = true; txt_email.Focus(); error_email.SetError(lbl_email, "Email is already taken"); }
            else { e.Cancel = true; error_email.SetError(lbl_email, null); }
        }
        private void lbl_username_Validating(object sender, CancelEventArgs e)
        {
            if (txt_username.Text == "Username") { e.Cancel = true; txt_username.Focus(); error_username.SetError(lbl_username, "This field is required!"); existingusername = true; }
            else if (txt_username.Text.Length < 6) { e.Cancel = true; txt_username.Focus(); error_username.SetError(lbl_username, "Username length must be 6+ character"); existingusername = true; }
            else if (existingusername == true) { e.Cancel = true; txt_username.Focus(); error_username.SetError(lbl_username, "Username is already taken"); }
            else { e.Cancel = true; error_username.SetError(lbl_username, null); }
        }
        private void lbl_pass_Validating(object sender, CancelEventArgs e)
        {
            if (txt_pass.Text == "Password") { e.Cancel = true; txt_pass.Focus(); error_password.SetError(lbl_pass, "This field is required!"); pass = false; }
            else if (txt_pass.Text.Length < 8) { e.Cancel = true; txt_pass.Focus(); error_password.SetError(lbl_pass, "Password length must be 8+ characters"); pass = false; }
            else { e.Cancel = true; error_password.SetError(lbl_pass, null); pass = true; }
        }
        private void lbl_cpass_Validating(object sender, CancelEventArgs e)
        {
            if (txt_cpass.Text == "Confirm Password") { e.Cancel = true; txt_cpass.Focus(); error_cpass.SetError(lbl_cpass, "This field is required!"); cpass = false; }
            else if (txt_pass.Text != txt_cpass.Text) { e.Cancel = true; txt_cpass.Focus(); error_cpass.SetError(lbl_cpass, "Passwords do not match"); cpass = false; }
            else { e.Cancel = true; error_cpass.SetError(lbl_cpass, null); cpass = true; }
        }
        private void lbl_accounttype_Validating(object sender, CancelEventArgs e)
        {
            if (atype >= 3) { e.Cancel = true; usertype_group.Focus(); error_atype.SetError(lbl_accounttype, "This field is required!"); }
            else { e.Cancel = true; error_atype.SetError(lbl_accounttype, null); }
        }
        #endregion

        #region Functions
        private void reset_txt()
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text)) { txt_fname.Text = "First Name"; txt_fname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_mname.Text)) { txt_mname.Text = "Middle Name"; txt_mname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_lname.Text)) { txt_lname.Text = "Last Name"; txt_lname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_address.Text)) { txt_address.Text = "Address"; txt_address.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_pnum.Text)) { txt_pnum.Text = "Phone Number"; txt_pnum.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_email.Text)) { txt_email.Text = "Email Address"; txt_email.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_username.Text)) { txt_username.Text = "Username"; txt_username.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_pass.Text)) { txt_pass.Text = "Password"; txt_pass.ForeColor = SystemColors.ButtonShadow; txt_pass.PasswordChar = '\0'; }
            if (string.IsNullOrWhiteSpace(txt_cpass.Text)) { txt_cpass.Text = "Confirm Password"; txt_cpass.ForeColor = SystemColors.ButtonShadow; txt_cpass.PasswordChar = '\0'; }
        }

        private void clearVar() {
            userDP = null;
            gender = "";
            picbase64 = "";
            atype = 3;
            legalage = false;
            pnum = false;
            validemail = false;
            existingemail = true;
            existingusername = true;
            pass = false;
            cpass = false;
        }

        private bool isLegalAge(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            if (DateTime.Now.Month < birthdate.Month || (DateTime.Now.Month == birthdate.Month && DateTime.Now.Day < birthdate.Day)) { age = age - 1; }
            return age >= 18;
        }

        private bool validateNumber()
        {
            string phoneNumber = txt_pnum.Text.Trim();
            return phoneNumber.Length == 11 && phoneNumber.StartsWith("09");
        }

        private bool validateEmail()
        {
            string emailAddress = txt_email.Text.Trim();
            return Regex.IsMatch(emailAddress, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        private void isEmailExist()
        {
            int rowCount = 0;
            string emailSQL = "";
            if (atype == 1) { emailSQL = "SELECT COUNT(*) FROM client WHERE CLIENT_EMAIL='" + txt_email.Text + "'"; }
            else if (atype == 2) { emailSQL = "SELECT COUNT(*) FROM seller WHERE SELLER_EMAIL='" + txt_email.Text + "'"; }

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open(); ;
                MySqlCommand countCmd = new MySqlCommand(emailSQL, conn);
                rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
                if (rowCount > 0) { existingemail = true; }
                else { existingemail = false; }
            }
            conn.Close();

        }

        private void welcomeEmail()
        {
            string fromMail = "terraverde.corp@gmail.com";
            string fromPassword = "pkcqnkbtvzyzouki";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail, "TerraVerde");
            message.Subject = "Account Creation";
            message.To.Add(new MailAddress(txt_email.Text));
            message.Body = "Hello <b>" + txt_username.Text + "</b>, <br><br> Welcome to Terra Verde! Thank you for registering with us. We're delighted to have you on board for all your property buying and selling needs. <br><br>Happy browsing!";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

        private void isUsernameExist()
        {
            int rowCount = 0;
            sql = "SELECT COUNT(*) FROM user WHERE USERNAME='" + txt_username.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open(); ;
                MySqlCommand countCmd = new MySqlCommand(sql, conn);
                rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
                if (rowCount > 0) { existingusername = true; }
                else { existingusername = false; }
            }
            conn.Close();

        }

        private void getImage()
        {
            if (userDP == null)
            {
                userDP = Properties.Resources.default_avatar;

                using (MemoryStream ms = new MemoryStream())
                {
                    userDP.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                    picbase64 = Convert.ToBase64String(ms.ToArray());
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    userDP.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                    picbase64 = Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private void User_table(int max)
        {
            string query1 = "INSERT INTO client (CLIENT_FN, CLIENT_MN, CLIENT_LN, CLIENT_ADDRESS, CLIENT_PHONE_NUMBER, CLIENT_DOB, GENDER, CLIENT_EMAIL, CLIENT_IMAGE, USER_ID) VALUES (@txt_fname, @txt_mname, @txt_lname, @txt_address, @txt_pnum, @txt_bdate, @gender, @txt_email, @user_img, @maxUserId); INSERT INTO verification (USER_ID, VERIFICATION_STATUS) VALUES (@maxUserId, @verificationStatus)";
            using (MySqlCommand command = new MySqlCommand(query1, conn))
            {
                command.Parameters.AddWithValue("@txt_fname", txt_fname.Text); 
                command.Parameters.AddWithValue("@txt_mname", txt_mname.Text); 
                command.Parameters.AddWithValue("@txt_lname", txt_lname.Text); 
                command.Parameters.AddWithValue("@txt_address", txt_address.Text);
                command.Parameters.AddWithValue("@txt_pnum", txt_pnum.Text);
                command.Parameters.AddWithValue("@txt_bdate", txt_bdate.Value.Date);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@txt_email", txt_email.Text);
                command.Parameters.AddWithValue("@user_img", picbase64);
                command.Parameters.AddWithValue("@maxUserId", max);
                command.Parameters.AddWithValue("@verificationStatus", "Not Verified");
                command.ExecuteNonQuery();
            }
        }

        private void Seller_table(int max)
        {
            string query1 = "INSERT INTO seller (SELLER_FN, SELLER_MN, SELLER_LN, SELLER_ADDRESS, SELLER_PHONE_NUMBER, SELLER_DOB, GENDER, SELLER_EMAIL, SELLER_IMAGE, USER_ID) VALUES (@txt_fname, @txt_mname, @txt_lname, @txt_address, @txt_pnum, @txt_bdate, @gender, @txt_email, @user_img, @maxUserId); INSERT INTO verification (USER_ID, VERIFICATION_STATUS) VALUES (@maxUserId, @verificationStatus)";
            using (MySqlCommand command = new MySqlCommand(query1, conn))
            {
                command.Parameters.AddWithValue("@txt_fname", txt_fname.Text);  
                command.Parameters.AddWithValue("@txt_mname", txt_mname.Text); 
                command.Parameters.AddWithValue("@txt_lname", txt_lname.Text);
                command.Parameters.AddWithValue("@txt_address", txt_address.Text);
                command.Parameters.AddWithValue("@txt_pnum", txt_pnum.Text);
                command.Parameters.AddWithValue("@txt_bdate", txt_bdate.Value.Date);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@txt_email", txt_email.Text);
                command.Parameters.AddWithValue("@user_img", picbase64);
                command.Parameters.AddWithValue("@maxUserId", max);
                command.Parameters.AddWithValue("@verificationStatus", "Not Verified");
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region MainCode
        private void btn_GoBacktoLogin_Click(object sender, EventArgs e)
        {
            //This is the code to fucking access a UC's parent form, wherein the panelcontainer of the UC resides. Use this code.
            UC_LR_Login uc = new UC_LR_Login();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelcontainer_LogReg", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelcontainer_LogReg", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            reset_txt();
            using (OpenFileDialog uploadImg = new OpenFileDialog())
            {
                uploadImg.Filter = "choose image(*.jpg;*.png;)|*.jpg;*.png";
                if (uploadImg.ShowDialog() == DialogResult.OK)
                {
                    userDP = Image.FromFile(uploadImg.FileName);
                    img_dp.Image = userDP;
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            reset_txt();
            legalage = isLegalAge(txt_bdate.Value); 
            pnum = validateNumber();
            validemail = validateEmail(); if (validemail == true && atype < 3) { isEmailExist(); }
            isUsernameExist();
            getImage();
            ValidateChildren(ValidationConstraints.Enabled);

            if (!(txt_fname.Text == "First Name" || txt_mname.Text == "Middle Name" || txt_lname.Text == "Last Name" || txt_fname.Text == "First Name" || legalage == false || gender == "" || txt_address.Text == "Address" || pnum == false || existingemail == true || txt_username.Text == "Username" || txt_pass.Text == "Password" || txt_cpass.Text == "Confirm Password" || atype > 3 || existingusername == true || pass == false || cpass == false))
            {

                sql = "INSERT INTO user (USERNAME, PASSWORD, USER_TYPE) VALUES (@txt_username, @txt_pass, @atype)";
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@txt_username", txt_username.Text); 
                    command.Parameters.AddWithValue("@txt_pass", txt_pass.Text); 
                    command.Parameters.AddWithValue("@atype", atype);
                    command.ExecuteNonQuery();

                    string getmax = "SELECT MAX(USER_ID) FROM user";
                    if (atype == 1)
                    {
                        int maxUserId;

                        using (MySqlCommand command2 = new MySqlCommand(getmax, conn))
                        {
                            object result = command2.ExecuteScalar();

                            if (result != DBNull.Value && result != null)
                            {
                                maxUserId = Convert.ToInt32(result);
                            }
                            else
                            {
                                maxUserId = 1; 
                            }
                        }

                        User_table(maxUserId);

                    }
                    else if (atype == 2)
                    {
                        int maxSelerId;

                        using (MySqlCommand command2 = new MySqlCommand(getmax, conn))
                        {
                            object result = command2.ExecuteScalar();

                            if (result != DBNull.Value && result != null)
                            {
                                maxSelerId = Convert.ToInt32(result);
                            }
                            else
                            {
                                maxSelerId = 1;
                            }

                        }
                        Seller_table(maxSelerId);
                    }
                    MessageBox.Show("Registered Successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    welcomeEmail();
                    clearVar();
                }

                conn.Close();
                btn_GoBacktoLogin.PerformClick();
            }

        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

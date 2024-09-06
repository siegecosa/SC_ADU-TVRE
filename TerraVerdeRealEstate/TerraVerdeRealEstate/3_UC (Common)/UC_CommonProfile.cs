using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TerraVerdeRealEstate.UC__Common_
{
    public partial class UC_CommonProfile : UserControl
    {

        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VARIABLE
        static Image userDP;
        static int userType;
        static int userID;
        static string picbase64 = "";
        #endregion

        public UC_CommonProfile()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
            loadData();
            getImage();
        }

        #region Functions
        public void loadData()
        {
            userType = UC__LogReg_.UC_LR_Login.userType;
            userID = UC__LogReg_.UC_LR_Login.userID;

            if (userType == 1)
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();
                    sql = "SELECT c.CLIENT_FN, c.CLIENT_MN, c.CLIENT_LN, c.CLIENT_ADDRESS, c.CLIENT_PHONE_NUMBER, c.CLIENT_DOB, c.GENDER, u.USERNAME, c.CLIENT_EMAIL, c.CLIENT_IMAGE, v.VERIFICATION_STATUS FROM client AS c INNER JOIN user AS u ON c.USER_ID = u.USER_ID INNER JOIN verification AS v ON u.USER_ID = v.USER_ID WHERE c.USER_ID = " + userID; 
                    cmd = new MySqlCommand(sql, conn);

                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            txt_fname.Text = dr["CLIENT_FN"].ToString();
                            txt_mname.Text = dr["CLIENT_MN"].ToString();
                            txt_lname.Text = dr["CLIENT_LN"].ToString();
                            txt_address.Text = dr["CLIENT_ADDRESS"].ToString();
                            txt_pnum.Text = dr["CLIENT_PHONE_NUMBER"].ToString();
                            txt_bdate.Text = dr["CLIENT_DOB"].ToString();
                            txt_gender.Text = dr["GENDER"].ToString();
                            txt_username.Text = dr["USERNAME"].ToString();
                            txt_email.Text = dr["CLIENT_EMAIL"].ToString();

                            string base64String = dr["CLIENT_IMAGE"].ToString();
                            byte[] imgBLOB = Convert.FromBase64String(base64String);
                            using (MemoryStream ms = new MemoryStream(imgBLOB)) { userDP = Image.FromStream(ms); img_profile.Image = userDP; }

                            string vStatus = dr["VERIFICATION_STATUS"].ToString();
                            if (vStatus == "Not Verified") { progress_bar.Value = 0; btn_verify.Enabled = true; }
                            else if (vStatus == "Under Review") { progress_bar.Value = 50; btn_verify.Enabled = false; }
                            else if (vStatus == "Verified") { progress_bar.Value = 100; btn_verify.Enabled = false; }
                        }
                    }
                    conn.Close();
                }
            }
            
            else if (userType == 2)
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();
                    sql = "SELECT s.SELLER_FN, s.SELLER_MN, s.SELLER_LN, s.SELLER_ADDRESS, s.SELLER_PHONE_NUMBER, s.SELLER_DOB, s.GENDER, u.USERNAME, s.SELLER_EMAIL, s.SELLER_IMAGE, v.VERIFICATION_STATUS FROM seller AS s INNER JOIN user AS u ON s.USER_ID = u.USER_ID INNER JOIN verification AS v ON u.USER_ID = v.USER_ID WHERE s.USER_ID = " + userID;
                    cmd = new MySqlCommand(sql, conn);

                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            txt_fname.Text = dr["SELLER_FN"].ToString();
                            txt_mname.Text = dr["SELLER_MN"].ToString();
                            txt_lname.Text = dr["SELLER_LN"].ToString();
                            txt_address.Text = dr["SELLER_ADDRESS"].ToString();
                            txt_pnum.Text = dr["SELLER_PHONE_NUMBER"].ToString();
                            txt_bdate.Text = dr["SELLER_DOB"].ToString();
                            txt_gender.Text = dr["GENDER"].ToString();
                            txt_username.Text = dr["USERNAME"].ToString();
                            txt_email.Text = dr["SELLER_EMAIL"].ToString();

                            string base64String = dr["SELLER_IMAGE"].ToString();
                            byte[] imgBLOB = Convert.FromBase64String(base64String);
                            using (MemoryStream ms = new MemoryStream(imgBLOB)) { userDP = Image.FromStream(ms); img_profile.Image = userDP; }

                            string vStatus = dr["VERIFICATION_STATUS"].ToString();
                            if (vStatus == "Not Verified") { progress_bar.Value = 0; btn_verify.Enabled = true; }
                            else if (vStatus == "Under Review") { progress_bar.Value = 50; btn_verify.Enabled = false; }
                            else if (vStatus == "Verified") { progress_bar.Value = 100; btn_verify.Enabled = false; }
                        }
                    }
                    conn.Close();
                }
            }

            else if (userType == 0)
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();
                    sql = "SELECT a.ADMIN_FN, a.ADMIN_MN, a.ADMIN_LN, a.ADMIN_ADDRESS, a.ADMIN_PHONE_NUMBER, a.ADMIN_DOB, a.GENDER, u.USERNAME, a.ADMIN_EMAIL, a.ADMIN_IMAGE FROM admin AS a INNER JOIN user AS u ON a.USER_ID = u.USER_ID WHERE a.USER_ID = " + userID;
                    cmd = new MySqlCommand(sql, conn);

                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            txt_fname.Text = dr["ADMIN_FN"].ToString();
                            txt_mname.Text = dr["ADMIN_MN"].ToString();
                            txt_lname.Text = dr["ADMIN_LN"].ToString();
                            txt_address.Text = dr["ADMIN_ADDRESS"].ToString();
                            txt_pnum.Text = dr["ADMIN_PHONE_NUMBER"].ToString();
                            txt_bdate.Text = dr["ADMIN_DOB"].ToString();
                            txt_gender.Text = dr["GENDER"].ToString();
                            txt_username.Text = dr["USERNAME"].ToString();
                            txt_email.Text = dr["ADMIN_EMAIL"].ToString();

                            string base64String = dr["ADMIN_IMAGE"].ToString();
                            byte[] imgBLOB = Convert.FromBase64String(base64String);
                            using (MemoryStream ms = new MemoryStream(imgBLOB)) { userDP = Image.FromStream(ms); img_profile.Image = userDP; }
                        }
                    }
                    conn.Close();
                }
            }

        }

        void updateTable()
        {
            getImage();
            if (userType == 1)
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();
                    sql = "UPDATE client SET CLIENT_FN = @clientFN, CLIENT_MN = @clientMN, CLIENT_LN = @clientLN, CLIENT_ADDRESS = @clientAddress, CLIENT_PHONE_NUMBER = @clientPNum, CLIENT_DOB = @clientDOB, GENDER = @clientGender, CLIENT_EMAIL = @clientEmail, CLIENT_IMAGE = @clientImage WHERE USER_ID = @userID; UPDATE user SET USERNAME = @username WHERE USER_ID = @userID";

                    using (cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientFN", txt_fname.Text);
                        cmd.Parameters.AddWithValue("@clientMN", txt_mname.Text);
                        cmd.Parameters.AddWithValue("@clientLN", txt_lname.Text);
                        cmd.Parameters.AddWithValue("@clientAddress", txt_address.Text);
                        cmd.Parameters.AddWithValue("@clientPNum", txt_pnum.Text);
                        cmd.Parameters.AddWithValue("@clientDOB", txt_bdate.Value.Date);
                        cmd.Parameters.AddWithValue("@clientGender", txt_gender.Text);
                        cmd.Parameters.AddWithValue("@clientEmail", txt_email.Text);
                        cmd.Parameters.AddWithValue("@clientImage", picbase64);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                if (ParentForm != null && ParentForm is Form_ClientSide)
                {
                    Form_ClientSide parentForm = (Form_ClientSide)ParentForm;
                    parentForm.loadClientData();
                }
            }
            else if (userType == 2)
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();
                    sql = "UPDATE seller SET SELLER_FN = @sellerFN, SELLER_MN = @sellerMN, SELLER_LN = @sellerLN, SELLER_ADDRESS = @sellerAddress, SELLER_PHONE_NUMBER = @sellerPNum, SELLER_DOB = @sellerDOB, GENDER = @sellerGender, SELLER_EMAIL = @sellerEmail, SELLER_IMAGE = @sellerImage WHERE USER_ID = @userID; UPDATE user SET USERNAME = @username WHERE USER_ID = @userID";

                    using (cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@sellerFN", txt_fname.Text);
                        cmd.Parameters.AddWithValue("@sellerMN", txt_mname.Text);
                        cmd.Parameters.AddWithValue("@sellerLN", txt_lname.Text);
                        cmd.Parameters.AddWithValue("@sellerAddress", txt_address.Text);
                        cmd.Parameters.AddWithValue("@sellerPNum", txt_pnum.Text);
                        cmd.Parameters.AddWithValue("@sellerDOB", txt_bdate.Value.Date);
                        cmd.Parameters.AddWithValue("@sellerGender", txt_gender.Text);
                        cmd.Parameters.AddWithValue("@sellerEmail", txt_email.Text);
                        cmd.Parameters.AddWithValue("@sellerImage", picbase64);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                if (ParentForm != null && ParentForm is Form_SellerSide)
                {
                    Form_SellerSide parentForm = (Form_SellerSide)ParentForm;
                    parentForm.loadSellerData();
                }
                
            }

            else if (userType == 0)
            {
                using (conn = new MySqlConnection(connstr))
                {
                    conn.Open();
                    sql = "UPDATE admin SET ADMIN_FN = @adminFN, ADMIN_MN = @adminMN, ADMIN_LN = @adminLN, ADMIN_ADDRESS = @adminAddress, ADMIN_PHONE_NUMBER = @adminPNum, ADMIN_DOB = @adminDOB, GENDER = @adminGender, ADMIN_EMAIL = @adminEmail, ADMIN_IMAGE = @adminImage WHERE USER_ID = @userID; UPDATE user SET USERNAME = @username WHERE USER_ID = @userID";

                    using (cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adminFN", txt_fname.Text);
                        cmd.Parameters.AddWithValue("@adminMN", txt_mname.Text);
                        cmd.Parameters.AddWithValue("@adminLN", txt_lname.Text);
                        cmd.Parameters.AddWithValue("@adminAddress", txt_address.Text);
                        cmd.Parameters.AddWithValue("@adminPNum", txt_pnum.Text);
                        cmd.Parameters.AddWithValue("@adminDOB", txt_bdate.Value.Date);
                        cmd.Parameters.AddWithValue("@adminGender", txt_gender.Text);
                        cmd.Parameters.AddWithValue("@adminEmail", txt_email.Text);
                        cmd.Parameters.AddWithValue("@adminImage", picbase64);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                if (ParentForm != null && ParentForm is Form_AdminSide)
                {
                    Form_AdminSide parentForm = (Form_AdminSide)ParentForm;
                    parentForm.loadAdminData();
                }

            }
        }

        private void getImage()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                userDP.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Position = 0;
                picbase64 = Convert.ToBase64String(ms.ToArray());
            }
           
        }
        #endregion

        private void UC_CommonProfile_Load(object sender, EventArgs e)
        {
            if (userType == 0) 
            {
                lbl_status.Visible = false;
                lbl_status2.Visible = false;
                lbl_status3.Visible = false;
                progress_bar.Visible = false;
                btn_verify.Visible = false;
            }
            
            btn_profileedit.Enabled = true;
            btn_profilesave.Enabled = false;

            txt_fname.Enabled = false;
            txt_mname.Enabled = false;
            txt_lname.Enabled = false;
            txt_address.Enabled = false;
            txt_pnum.Enabled = false;
            txt_bdate.Enabled = false;
            txt_gender.Enabled = false;
            txt_username.Enabled = false;
            txt_email.Enabled = false;
            img_profile.Enabled = false;
        }

        private void btn_profileedit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit your profile details?", "Edit Profile Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Perform the save action
                btn_profileedit.Enabled = false;
                btn_profilesave.Enabled = true;

                if (progress_bar.Value == 0)
                {
                    txt_fname.Enabled = true;
                    txt_mname.Enabled = true;
                    txt_lname.Enabled = true;
                    txt_address.Enabled = true;
                    txt_bdate.Enabled = true;
                    txt_gender.Enabled = true;
                }
                txt_pnum.Enabled = true;
                txt_username.Enabled = true;
                txt_email.Enabled = true;
                img_profile.Enabled = true;
            }
        }

        private void btn_profilesave_Click(object sender, EventArgs e)
        {
            string[] fields = {
                txt_fname.Text,
                txt_mname.Text,
                txt_lname.Text,
                txt_address.Text,
                txt_pnum.Text,
                txt_username.Text,
                txt_email.Text
            };

            foreach (string field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (txt_gender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation for date picker (datetimepicker) can be added here
            DateTime selectedDate = txt_bdate.Value;
            DateTime eighteenYearsAgo = DateTime.Now.AddYears(-18);

            if (selectedDate > eighteenYearsAgo)
            {
                MessageBox.Show("Your age must be at least be 18 to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with your logic if all fields are valid
            DialogResult result = MessageBox.Show("Are you sure you want to save your new profile details?", "Save Profile Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Perform the save action
                btn_profileedit.Enabled = true;
                btn_profilesave.Enabled = false;

                txt_fname.Enabled = false;
                txt_mname.Enabled = false;
                txt_lname.Enabled = false;
                txt_address.Enabled = false;
                txt_pnum.Enabled = false;
                txt_bdate.Enabled = false;
                txt_gender.Enabled = false;
                txt_username.Enabled = false;
                txt_email.Enabled = false;
                img_profile.Enabled = false;
            }

            updateTable();

        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            if (userType == 1)
            {
                Form_OTPPass formOTPPass = new Form_OTPPass("Client");
                formOTPPass.Owner = this.ParentForm; // Set the parent form
                this.ParentForm.Enabled = false; // Disable the main form
                formOTPPass.Show();
            }
            else if (userType == 2)
            {
                Form_OTPPass formOTPPass = new Form_OTPPass("Seller");
                formOTPPass.Owner = this.ParentForm; // Set the parent form
                this.ParentForm.Enabled = false; // Disable the main form
                formOTPPass.Show();
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (userType == 1)
            {
                Form_Verification formVerification = new Form_Verification("Client");
                this.ParentForm.Enabled = false; // Disable the main form
                formVerification.Show();
                formVerification.TopMost = true;
            }
            else if (userType == 2)
            {
                Form_Verification formVerification = new Form_Verification("Seller");
                this.ParentForm.Enabled = false; // Disable the main form
                formVerification.Show();
                formVerification.TopMost = true;
            }
        }


        private void img_profile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog uploadImg = new OpenFileDialog())
            {
                uploadImg.Filter = "choose image(*.jpg;*.png;)|*.jpg;*.png";
                if (uploadImg.ShowDialog() == DialogResult.OK)
                {
                    userDP = Image.FromFile(uploadImg.FileName);
                    img_profile.Image = userDP;
                }
            }
        }



    }
}

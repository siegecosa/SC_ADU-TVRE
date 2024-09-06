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
using TerraVerdeRealEstate.UC__LogReg_;

namespace TerraVerdeRealEstate._2_UC__Admin_
{
    public partial class UC_A_Verify : UserControl
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

        //GLOBAL VAR
        static string messageContent;
        static Image userDP;
        static Image selfieImg;
        static Image frontIdImg;
        static Image backIdImg;

        static int userID;
        #endregion

        public UC_A_Verify()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
        }

        private void UC_A_Verify_Load(object sender, EventArgs e)
        {
            loadPendingVerification();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {


            updateTable("Verified");
            messageContent = "We are pleased to inform you that your verification request has been approved. We have verified the provided documentation and found it to be satisfactory.";
            emailMessage(txt_email.Text);
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {

            Form_RejectionReason formRejectionReason = new Form_RejectionReason(txt_email.Text);
            this.Enabled = false;
            formRejectionReason.FormClosed += (s, ev) => { this.Enabled = true; loadPendingVerification(); };
            formRejectionReason.Show();
            formRejectionReason.TopMost = true;
            messageContent = "We regret to inform you that your verification request has been rejected. We found some inconsistencies in the provided documentation. Please review the details provided and ensure that all required documents are submitted accurately.";
        }

        #region Functions
        public void emailMessage(string email)
        {
            string fromMail = "terraverde.corp@gmail.com";
            string fromPassword = "pkcqnkbtvzyzouki";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail, "TerraVerde");
            message.Subject = "Account Verification";
            message.To.Add(new MailAddress(email));
            message.Body = "Hello <b>" + txt_username.Text + "</b>, <br><br>" + messageContent + "<br><br>Thank you for your cooperation!";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);

        }

       public void loadPendingVerification()
{
    using (conn = new MySqlConnection(connstr))
    {
        conn.Open();
        sql = "SELECT u.USER_ID AS 'ID', CASE WHEN u.USER_TYPE=1 THEN 'Client' WHEN u.USER_TYPE=2 THEN 'Seller' END AS 'User Type' , CASE WHEN u.USER_TYPE=1 THEN CONCAT(c.CLIENT_FN, ' ', c.CLIENT_LN) WHEN u.USER_TYPE=2 THEN CONCAT(s.SELLER_FN, ' ', s.SELLER_LN) END AS 'Account Name', u.USERNAME AS' Username' FROM user u LEFT JOIN client c ON u.USER_ID = c.USER_ID LEFT JOIN seller s ON u.USER_ID = s.USER_ID INNER JOIN verification v ON u.USER_ID = v.USER_ID WHERE v.VERIFICATION_STATUS = 'Under Review'";
        da = new MySqlDataAdapter(sql, conn);
        dt.Clear();
        da.Fill(dt);
        dgv_pendingaccounts.DataSource = dt;
        
        // Check if the DataTable is empty
        if (dt.Rows.Count == 0)
        {
            btn_approve.Enabled = false;
            btn_reject.Enabled = false;
        }
        else
        {
            btn_approve.Enabled = true;
            btn_reject.Enabled = true;
        }
        
        conn.Close();
    }
}


        private void loadData()
        {
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                string queryFName = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_FN WHEN u.USER_TYPE=2 THEN S.SELLER_FN  END AS 'FN', ";
                string queryMName = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_MN WHEN u.USER_TYPE=2 THEN S.SELLER_MN  END AS 'MN', ";
                string queryLName = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_LN WHEN u.USER_TYPE=2 THEN S.SELLER_LN  END AS 'LN', ";
                string queryAddress = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_ADDRESS WHEN u.USER_TYPE=2 THEN S.SELLER_ADDRESS  END AS 'ADDRESS', ";
                string queryPNum = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_PHONE_NUMBER WHEN u.USER_TYPE=2 THEN S.SELLER_PHONE_NUMBER  END AS 'PHONE_NUMBER', ";
                string queryDOB = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_DOB WHEN u.USER_TYPE=2 THEN S.SELLER_DOB  END AS 'DOB', ";
                string queryGender = "CASE WHEN u.USER_TYPE=1 THEN c.GENDER WHEN u.USER_TYPE=2 THEN S.GENDER  END AS 'GENDER', ";
                string queryUsername = "u.USERNAME AS 'USERNAME', ";
                string queryEmail = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_EMAIL WHEN u.USER_TYPE=2 THEN S.SELLER_EMAIL  END AS 'EMAIL', ";
                string queryImage = "CASE WHEN u.USER_TYPE=1 THEN c.CLIENT_IMAGE WHEN u.USER_TYPE=2 THEN S.SELLER_IMAGE  END AS 'IMAGE', ";
                string queryVerficationImage = "v.SELFIE_IMAGE, v.FRONT_ID_IMAGE, v.BACK_ID_IMAGE ";

                sql = "SELECT " + queryFName + queryMName + queryLName + queryAddress + queryPNum + queryDOB + queryGender + queryUsername + queryEmail + queryImage + queryVerficationImage + " FROM user u LEFT JOIN client c ON u.USER_ID = c.USER_ID LEFT JOIN seller s ON u.USER_ID = s.USER_ID INNER JOIN verification v ON u.USER_ID = v.USER_ID WHERE u.USER_ID= " + userID + " AND v.VERIFICATION_STATUS = 'Under Review' ";

                cmd = new MySqlCommand(sql, conn);

                using (dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        txt_fname.Text = dr["FN"].ToString();
                        txt_mname.Text = dr["MN"].ToString();
                        txt_lname.Text = dr["LN"].ToString();
                        txt_address.Text = dr["ADDRESS"].ToString();
                        txt_pnum.Text = dr["PHONE_NUMBER"].ToString();
                        txt_bdate.Text = dr["DOB"].ToString();
                        txt_gender.Text = dr["GENDER"].ToString();
                        txt_username.Text = dr["USERNAME"].ToString();
                        txt_email.Text = dr["EMAIL"].ToString();

                        string base64String = dr["IMAGE"].ToString();
                        byte[] imgBLOB = Convert.FromBase64String(base64String);
                        using (MemoryStream ms = new MemoryStream(imgBLOB)) { userDP = Image.FromStream(ms); img_profile.Image = userDP; }

                        string selfieBase64String = dr["SELFIE_IMAGE"].ToString();
                        byte[] selfieImgBLOB = Convert.FromBase64String(selfieBase64String);
                        using (MemoryStream ms = new MemoryStream(selfieImgBLOB)) { selfieImg = Image.FromStream(ms); pb_selfie.Image = selfieImg; }

                        string frontIdBase64String = dr["FRONT_ID_IMAGE"].ToString();
                        byte[] frontIdImgBLOB = Convert.FromBase64String(frontIdBase64String);
                        using (MemoryStream ms = new MemoryStream(frontIdImgBLOB)) { frontIdImg = Image.FromStream(ms); pb_cardfront.Image = frontIdImg; }

                        string backIdBase64String = dr["BACK_ID_IMAGE"].ToString();
                        byte[] backIdImgBLOB = Convert.FromBase64String(backIdBase64String);
                        using (MemoryStream ms = new MemoryStream(backIdImgBLOB)) { backIdImg = Image.FromStream(ms); pb_cardback.Image = backIdImg; }
                    }
                }
                conn.Close();
            }
        }

        public void updateTable(string status)
        {
            using (MySqlConnection connUpdate = new MySqlConnection(connstr))
            {
                if (status == "Verified")
                {
                    connUpdate.Open();
                    sql = "UPDATE verification SET VERIFICATION_STATUS = @verficationStatus WHERE USER_ID = @userID AND VERIFICATION_STATUS = 'Under Review'";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(sql, connUpdate))
                    {
                        cmdUpdate.Parameters.AddWithValue("@verficationStatus", status);
                        cmdUpdate.Parameters.AddWithValue("@userID", userID);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                else
                {
                    connUpdate.Open();
                    string reason = Form_RejectionReason.reason;
                    sql = "UPDATE verification SET VERIFICATION_STATUS = @verficationStatus, REJECTION_REASON = @rejectionReason WHERE USER_ID = @userID; INSERT INTO verification (USER_ID, VERIFICATION_STATUS) VALUES (@userID, @verificationStatus)";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(sql, connUpdate))
                    {
                        cmdUpdate.Parameters.AddWithValue("@verficationStatus", "Rejected");
                        cmdUpdate.Parameters.AddWithValue("@rejectionReason", reason);
                        cmdUpdate.Parameters.AddWithValue("@userID", userID);
                        cmdUpdate.Parameters.AddWithValue("@verificationStatus", status);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                
            }
            loadPendingVerification();
        }
        #endregion

        private void dgv_pendingaccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_pendingaccounts.SelectedRows.Count > 0)
            {
                string id = dgv_pendingaccounts.SelectedRows[0].Cells["ID"].Value.ToString();
                userID = Convert.ToInt32(id);
            }
            loadData();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            UC_A_UserVerificationLogs uc = new UC_A_UserVerificationLogs();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_admin", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_admin", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }
    }
}

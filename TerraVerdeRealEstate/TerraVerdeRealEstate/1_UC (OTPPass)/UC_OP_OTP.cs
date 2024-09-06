using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate.UC__LogReg_;
using System.Threading;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace TerraVerdeRealEstate._1_UC__OTPPass_
{
    public partial class UC_OP_OTP : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VAR
        bool usernameExist = false;
        bool emailExist = false;
        bool isOTPcorrect;
        public static string otp;
        public static string email;
        public static string username;
        public static string formName;
        int seconds = 60;

        #endregion

        public UC_OP_OTP(string fromFormName)
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
            formName = fromFormName;
        }

        public static class BetterRandom
        {
            private static readonly ThreadLocal<System.Security.Cryptography.RandomNumberGenerator> crng = new ThreadLocal<System.Security.Cryptography.RandomNumberGenerator>(() => System.Security.Cryptography.RandomNumberGenerator.Create());
            private static readonly ThreadLocal<byte[]> bytes = new ThreadLocal<byte[]>(() => new byte[sizeof(int)]);
            public static int NextInt()
            {
                crng.Value.GetBytes(bytes.Value);
                return BitConverter.ToInt32(bytes.Value, 0) & int.MaxValue;
            }
            public static double NextDouble()
            {
                while (true)
                {
                    long x = NextInt() & 0x001FFFFF;
                    x <<= 31;
                    x |= (long)NextInt();
                    double n = x;
                    const double d = 1L << 52;
                    double q = n / d;
                    if (q != 1.0)
                        return q;
                }
            }
        }

        private void lbl_code_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_email.Text)) { emailChecker(); }
        }

        private void btn_submitotp_Click(object sender, EventArgs e)
        {

            if (otp == txt_code.Text) {
                UC_OP_PassReset uc = new UC_OP_PassReset(formName);
                uc.Dock = DockStyle.Fill;
                var panelcontainerParent = this.Parent as Panel;
                var formParent = panelcontainerParent.TopLevelControl as Form;
                ((Panel)formParent.Controls.Find("panelcontainer_OTPPass", true)[0]).Controls.Clear();
                ((Panel)formParent.Controls.Find("panelcontainer_OTPPass", true)[0]).Controls.Add(uc);
                uc.BringToFront();
                textboxClear();
            }
            else if (otp != txt_code.Text && !(string.IsNullOrEmpty(txt_code.Text) || txt_code.Text == "OTP Code")) {
                isOTPcorrect = false;
                reset_txt();
                txt_code.Clear();
            }

            ValidateChildren(ValidationConstraints.Enabled);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var formParent = this.FindForm();
            if (formParent != null)
            {
                formParent.Close();

                if (formName == "Login")
                {
                    Form_LogReg formLogin = Application.OpenForms["Form_LogReg"] as Form_LogReg;
                    if (formLogin != null)
                    {
                        formLogin.Enabled = true;
                        formLogin.loadLogin();
                        formLogin.Show();
                    }
                }
                else if (formName == "Client")
                {
                    Form_ClientSide formClient = Application.OpenForms["Form_ClientSide"] as Form_ClientSide;
                    if (formClient != null)
                    {
                        formClient.Enabled = true;
                        formClient.showClientProfile();
                        formClient.Show();
                    }
                }
                else if (formName == "Seller")
                {
                    Form_SellerSide formSeller = Application.OpenForms["Form_SellerSide"] as Form_SellerSide;
                    if (formSeller != null)
                    {
                        formSeller.Enabled = true;
                        formSeller.showSellerProfile();
                        formSeller.Show();
                    }
                }
            }
        }


        private void timer_code_Tick(object sender, EventArgs e)
        {
            lbl_code.ForeColor = Color.DimGray;
            lbl_code.Enabled = false;
            lbl_code.Text = "Sent (" + seconds.ToString("00") + "s)";
            seconds--;
            if (seconds == 0) { timer_code.Stop(); lbl_code.Text = "Send Code"; seconds = 60; lbl_code.ForeColor = Color.Black; lbl_code.Enabled = true;}
        }

        #region Functions
        void emailChecker()
        {
            conn.Open();
            sql = "SELECT c.CLIENT_EMAIL FROM client as c INNER JOIN user as u ON c.USER_ID = u.USER_ID WHERE u.USERNAME = @username";

            using (cmd = new MySqlCommand(sql, conn))
            {
                username = txt_username.Text;
                cmd.Parameters.AddWithValue("@username", username);
                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows) {
                        while (dr.Read())
                        {
                            string clientEmail = dr.GetString("CLIENT_EMAIL");
                            if (clientEmail == txt_email.Text) {
                                timer_code.Start();

                                email = txt_email.Text;
                                otp = (BetterRandom.NextInt() % 1000000).ToString("000000");
                                string fromMail = "terraverde.corp@gmail.com";
                                string fromPassword = "pkcqnkbtvzyzouki";

                                MailMessage message = new MailMessage();
                                message.From = new MailAddress(fromMail, "TerraVerde");
                                message.Subject = "Forget Password - One-Time Password";
                                message.To.Add(new MailAddress(email));
                                message.Body = "Hello " + username + ",<br><br>We received a request to reset your Terra Verde password. Enter the following password reset code: <b>" + otp + "</b>.<br><br>If you did not request a password reset, you can safely ignore this email.";
                                message.IsBodyHtml = true;

                                var smtpClient = new SmtpClient("smtp.gmail.com")
                                {
                                    Port = 587,
                                    Credentials = new NetworkCredential(fromMail, fromPassword),
                                    EnableSsl = true,
                                };

                                smtpClient.Send(message);
                                MessageBox.Show("One-Time Password has been sent to your email.");
                            }
                            else {
                                emailExist = false;
                            }
                        }
                    }
                    else {
                        usernameExist = false;
                    }
                }
                conn.Close();
            }
        }

        void textboxClear()
        {
            txt_username.Clear();
            txt_email.Clear();
            txt_code.Clear();
        }

        private void reset_txt()
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text)) { txt_username.Text = "Username"; txt_username.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_email.Text)) { txt_email.Text = "Email"; txt_email.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_code.Text)) { txt_code.Text = "OTP Code"; txt_code.ForeColor = SystemColors.ButtonShadow; }
        }
        #endregion

        #region Validation
        private void lbl_username_Validating(object sender, CancelEventArgs e)
        {
            if (txt_username.Text == "Username") { e.Cancel = true; txt_username.Focus(); error_username.SetError(lbl_username, "This field is required!"); }
            else if (usernameExist == false) { e.Cancel = true; txt_username.Focus(); error_username.SetError(lbl_username, "Username does not exist."); }
            else { e.Cancel = true; error_username.SetError(lbl_username, null); }
        }

        private void lbl_email_Validating(object sender, CancelEventArgs e)
        {
            if (txt_email.Text == "Email") { e.Cancel = true; txt_email.Focus(); error_email.SetError(lbl_email, "This field is required!"); }
            else if (emailExist == false) { e.Cancel = true; txt_email.Focus(); error_email.SetError(lbl_email, "Email does not match with your username."); }
            else { e.Cancel = true; error_email.SetError(lbl_email, null); }
        }

        private void lbl_entercode_Validating(object sender, CancelEventArgs e)
        {
            if (txt_code.Text == "OTP Code") { e.Cancel = true; txt_code.Focus(); error_otp.SetError(lbl_entercode, "This field is required!"); }
            else if (isOTPcorrect == false) { e.Cancel = true; txt_code.Focus(); error_otp.SetError(lbl_entercode, "Incorrect OTP."); }
            else { e.Cancel = true; error_otp.SetError(lbl_entercode, null); }
        }
        #endregion

        #region Enters
        private void txt_username_Enter(object sender, EventArgs e) { reset_txt(); txt_username.ForeColor = Color.Black; if (txt_username.Text == "Username") { txt_username.Text = ""; } }
        private void txt_email_Enter(object sender, EventArgs e) { reset_txt(); txt_email.ForeColor = Color.Black; if (txt_email.Text == "Email") { txt_email.Text = ""; } }
        private void txt_code_Enter(object sender, EventArgs e) { reset_txt(); txt_code.ForeColor = Color.Black; if (txt_code.Text == "OTP Code") { txt_code.Text = ""; } }
        #endregion


    }
}

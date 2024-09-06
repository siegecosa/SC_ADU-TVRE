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

namespace TerraVerdeRealEstate._3_UC__Profile_Verification_
{
    public partial class UC_PV_Page5 : UserControl
    {
        #region Declaration
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VARIABLE
        public static string formName;
        public static int userId;
        public static string frontId;
        public static string backId;
        public static string selfie;
        #endregion

        public UC_PV_Page5(string fromFormName)
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);
            formName = fromFormName;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            insertData();
            var formParent = this.FindForm();
            if (formParent != null)
            {
                formParent.Close();

                if (formName == "Client")
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
                else
                {
                    MessageBox.Show("Di pumapasok. The previous form did not get Enabled true");
                }
            }
        }

        #region Functions
        private void insertData()
        {
            userId = UC__LogReg_.UC_LR_Login.userID;
            frontId = UC_PV_Page2.frontIdBase64;
            backId = UC_PV_Page3.backIdBase64;
            selfie = UC_PV_Page4.selfieBase64;

            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                sql = "UPDATE verification SET SELFIE_IMAGE = @selfieImg, FRONT_ID_IMAGE = @frontIdImg, BACK_ID_IMAGE = @backIdImg, VERIFICATION_STATUS = @verificationStatus WHERE USER_ID = @userId";

                using (cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@selfieImg", selfie);
                    cmd.Parameters.AddWithValue("@frontIdImg", frontId);
                    cmd.Parameters.AddWithValue("@backIdImg", backId);
                    cmd.Parameters.AddWithValue("@verificationStatus", "Under Review");
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            UC__Common_.UC_CommonProfile profile = new UC__Common_.UC_CommonProfile();
            profile.loadData();
        }
        #endregion
    }
}

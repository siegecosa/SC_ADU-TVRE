using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate._2_UC__Client_;
using TerraVerdeRealEstate._2_UC__Seller_;
using TerraVerdeRealEstate.UC__Client_;
using TerraVerdeRealEstate.UC__LogReg_;
using TerraVerdeRealEstate.UC__Seller_;

namespace TerraVerdeRealEstate.UC__Small_Layouts_
{
    public partial class UC_IndividualProperties : UserControl
    {
        public UC_IndividualProperties(int prop_id)
        {
            InitializeComponent();
            int userId = UC__LogReg_.UC_LR_Login.userID; // Adjust this line as necessary

            string verificationStatus = CheckVerificationStatus(userId);

            if (verificationStatus == "Verified")
            {
                btn_buy.Enabled = true;
            }
            else if (verificationStatus == "Not Verified" || verificationStatus == "Rejected" || verificationStatus == "Under Review")
            {
                btn_buy.Enabled = false;
            }
            else
            {
                // Handle unexpected status
                // Optionally, you can set btn_buy.Enabled to false or true based on your default behavior
            }

            id = prop_id;

        }
        private int id;
        private string _propertyName;
        private string _propertyDesc;
        private string _propertyLocation;
        private string _propertyPrice;
        private string _propertyStatus;
        private Image _propertyImage;
        public static string passedBuyorRent;
        public static string sell;


        #region Properties

        [Category("Custom Props")]
        public string propertyName
        {
            get { return _propertyName; }
            set { _propertyName = value; lbl_propertyName.Text = value; }
        }

        [Category("Custom Props")]
        public string propertyDesc
        {
            get { return _propertyDesc; }
            set { _propertyDesc = value; lbl_desc.Text = value; }
        }

        [Category("Custom Props")]
        public string propertyLocation
        {
            get { return _propertyLocation; }
            set { _propertyLocation = value; lbl_location.Text = value; }
        }

        [Category("Custom Props")]
        public string propertyPrice
        {
            get { return _propertyPrice; }
            set { _propertyPrice = value; lbl_price.Text = value; }
        }

        [Category("Custom Props")]
        public string propertyStatus
        {
            get { return _propertyStatus; }
            set { _propertyStatus = value; btn_buy.Text = value; }
        }

        [Category("Custom Props")]
        public Image propertyImage
        {
            get { return _propertyImage; }
            set { _propertyImage = value; img_property.Image = value; }
        }
        #endregion

        private void btn_buy_Click(object sender, EventArgs e)
        {
            sell = null;
            UC_C_Properties.passBuyOrRent = "";


            Button clickedButton = sender as Button;
            passedBuyorRent = UC_C_Properties.passBuyOrRent;
            sell = UC_S_Properties.sell;
           
            if (clickedButton.Text == "My Property")
            {
                UC_S_Properties.sell = null;
                sell = null;
                UC_C_Properties.passBuyOrRent = "";
                //Console.WriteLine("Im In");
                UC_S_ViewMyProperty uc = new UC_S_ViewMyProperty(id);
                uc.Dock = DockStyle.Fill;
                var panelcontainerParent = this.Parent as Panel;
                var formParent = panelcontainerParent.TopLevelControl as Form;
                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
                uc.BringToFront();
                
            }

            else
            {
                
                if (clickedButton != null)
                {
                    UC_C_Properties.passBuyOrRent = clickedButton.Text;

                }

                if (UC_C_Properties.passBuyOrRent == "Buy")
                {
                    UC_C_BuyingProperty uc = new UC_C_BuyingProperty(id);
                    uc.Dock = DockStyle.Fill;
                    var panelcontainerParent = this.Parent as Panel;
                    var formParent = panelcontainerParent.TopLevelControl as Form;
                    ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
                    ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
                    uc.BringToFront();
                    UC_C_Properties.passBuyOrRent = "";
                }
                else if (UC_C_Properties.passBuyOrRent == "Rent")
                {
                    UC_C_RentingProperty uc = new UC_C_RentingProperty(id);
                    uc.Dock = DockStyle.Fill;
                    var panelcontainerParent = this.Parent as Panel;
                    var formParent = panelcontainerParent.TopLevelControl as Form;
                    ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
                    ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
                    uc.BringToFront();
                    UC_C_Properties.passBuyOrRent = "";
                }

           
            }

        }

        private void UC_IndividualProperties_Load(object sender, EventArgs e)
        {

        }


            private string CheckVerificationStatus(int userId)
            {
                string verificationStatus = "Pending"; // Default status
                string connstr = "server=localhost;user=root;password='';database=terraverde_db";

                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    string query = "SELECT VERIFICATION_STATUS FROM verification WHERE USER_ID = @UserId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                verificationStatus = result.ToString();
                            }
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error fetching verification status: " + ex.Message);
                        }
                    }
                }

                return verificationStatus;
            }



        private void lbl_location_Click(object sender, EventArgs e)
        {

        }

        private void lbl_propertyName_Click(object sender, EventArgs e)
        {

        }
    }
}

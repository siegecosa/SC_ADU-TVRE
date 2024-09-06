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

namespace TerraVerdeRealEstate._3_UC__Profile_Verification_
{
    public partial class UC_PV_Page1 : UserControl
    {

        public static string formName;
        static int userType;

        public UC_PV_Page1(string fromFormName)
        {
            InitializeComponent();
            formName = fromFormName;
            userType = UC_LR_Login.userType;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if (userType == 1)
            {
                UC_PV_Page2 uc = new UC_PV_Page2("Client");
                uc.Dock = DockStyle.Fill;
                var panelcontainerParent = this.Parent as Panel;
                var formParent = panelcontainerParent.TopLevelControl as Form;
                ((Panel)formParent.Controls.Find("panelcontainer_Verification", true)[0]).Controls.Clear();
                ((Panel)formParent.Controls.Find("panelcontainer_Verification", true)[0]).Controls.Add(uc);
                uc.BringToFront();
            }
            else if (userType == 2)
            {
                UC_PV_Page2 uc = new UC_PV_Page2("Seller");
                uc.Dock = DockStyle.Fill;
                var panelcontainerParent = this.Parent as Panel;
                var formParent = panelcontainerParent.TopLevelControl as Form;
                ((Panel)formParent.Controls.Find("panelcontainer_Verification", true)[0]).Controls.Clear();
                ((Panel)formParent.Controls.Find("panelcontainer_Verification", true)[0]).Controls.Add(uc);
                uc.BringToFront();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
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



        private void checkboxagree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxagree.Checked)
            {
                btn_proceed.Enabled = true;
            }
            else
            {
                btn_proceed.Enabled = false;
            }
        }
    }
}

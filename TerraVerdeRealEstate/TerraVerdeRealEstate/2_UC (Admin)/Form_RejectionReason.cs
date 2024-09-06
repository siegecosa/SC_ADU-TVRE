using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraVerdeRealEstate._2_UC__Admin_
{
    public partial class Form_RejectionReason : Form
    {
        public static string reason;
        public static string email;
        public Form_RejectionReason(string userEmail)
        {
            InitializeComponent();
            email = userEmail;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            reason = tb_rejectionreason.Text;
            if (!string.IsNullOrEmpty(reason))
            {
                UC_A_Verify verify = new UC_A_Verify();
                verify.updateTable("Not Verified");

                var formParent = this.FindForm();

                if (formParent != null)
                {
                    formParent.Close();
                }
            }
            else
            {
                MessageBox.Show("Please specify a reason.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

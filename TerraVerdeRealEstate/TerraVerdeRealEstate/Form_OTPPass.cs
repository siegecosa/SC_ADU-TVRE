using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate._1_UC__OTPPass_;
using TerraVerdeRealEstate.UC__Seller_;

namespace TerraVerdeRealEstate
{
    public partial class Form_OTPPass : Form
    {
        static string formName;
        public Form_OTPPass(string fromFormName)
        {
            InitializeComponent();
            formName = fromFormName;
        }

        private void Form_OTPPass_Load(object sender, EventArgs e)
        {
            UC_OP_OTP uc = new UC_OP_OTP(formName);
            uc.Dock = DockStyle.Fill;
            panelcontainer_OTPPass.Controls.Clear();
            panelcontainer_OTPPass.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}

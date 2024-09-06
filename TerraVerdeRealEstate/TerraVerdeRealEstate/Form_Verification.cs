using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVerdeRealEstate._3_UC__Profile_Verification_;
using TerraVerdeRealEstate.UC__LogReg_;

namespace TerraVerdeRealEstate
{
    public partial class Form_Verification : Form
    {
        static string formName;
        public Form_Verification(string fromFormName)
        {
            InitializeComponent();
            formName = fromFormName;
        }

        private void Form_Verification_Load(object sender, EventArgs e)
        {
            UC_PV_Page1 uc = new UC_PV_Page1(formName);
            uc.Dock = DockStyle.Fill;
            panelcontainer_Verification.Controls.Clear();
            panelcontainer_Verification.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}

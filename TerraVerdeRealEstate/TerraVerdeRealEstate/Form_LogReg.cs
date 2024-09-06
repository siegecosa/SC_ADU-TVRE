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

namespace TerraVerdeRealEstate
{
    public partial class Form_LogReg : Form
    {
        public Form_LogReg()
        {
            this.InitializeComponent();
        }

        private void Form_LogReg_Load(object sender, EventArgs e)
        {
            loadLogin();

        }

        public void loadLogin()
        {
            UC_LR_Login uc = new UC_LR_Login();
            uc.Dock = DockStyle.Fill;
            panelcontainer_LogReg.Controls.Clear();
            panelcontainer_LogReg.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraVerdeRealEstate.UC__Small_Layouts_
{
    public partial class UC_S_RecentClients : UserControl
    {
        public UC_S_RecentClients()
        {
            InitializeComponent();
        }

        private string _title;
        private string _subtitle;
        private Image _image;

        #region Card Properties

        [Category("Custom Props")]
        public string title
        {
            get { return _title; }
            set { _title = value; lbl_title.Text = value; }
        }

        [Category("Custom Props")]
        public string subtitle
        {
            get { return _subtitle; }
            set { _subtitle = value; lbl_subtitle.Text = value; }
        }

        [Category("Custom Props")]
        public Image image
        {
            get { return _image; }
            set { _image = value; circle_img.Image = value; }
        }
        #endregion
    }
}

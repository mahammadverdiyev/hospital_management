using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }


        private string _title;
        private string _subTitle;

        public string Title
        {
            get { return _title; }
            set { _title = value; controlTitle.Text = value; }
        }

        public string SubTitle
        {
            get { return _subTitle; }
            set { _subTitle = value; controlSubTitle.Text = value; }
        }

        private Image _icon;

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; controlIcon.Image = value; }
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}

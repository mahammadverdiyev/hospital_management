using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class ReservationListPage : Form
    {
        List<ListItem> reservationControls;

        public FlowLayoutPanel FlowLayout => flowLayoutPanel;


        public void RemoveReservationItemByPatientEmail(string email)
        {
            int index = 0;

            foreach(ListItem item in reservationControls)
            {
                if (item.ThirdTitle.Equals(email)) break;
                index++;
            }

            flowLayoutPanel.Controls.RemoveAt(index);
        }

        public ReservationListPage(List<ListItem> reservationControls)
        {
            this.reservationControls = reservationControls;
            InitializeComponent();
        }

        private void ReservationListPage_Load(object sender, EventArgs e)
        {
            reservationControls.ForEach(control=> 
            {
                control.Width = flowLayoutPanel.Width;
                flowLayoutPanel.Controls.Add(control);
            });
        }
    }
}

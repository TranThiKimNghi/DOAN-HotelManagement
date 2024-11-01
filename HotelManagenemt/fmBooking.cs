using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagenemt
{
    public partial class fmBooking : Form
    {
        public fmBooking()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmMHC_Load(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (ValidateBooking())
            {
                fmBookingDetails fmCTDP = new fmBookingDetails();
                fmCTDP.ShowDialog();
            }
        }
        private bool ValidateBooking()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập FullName!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập Phone!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpCO.Value <= dtpCI.Value)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fmRoomManagement fmBookingDetails = new fmRoomManagement();
            fmBookingDetails.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fmServiceDetils fmServiceDetils = new fmServiceDetils();
            fmServiceDetils.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}

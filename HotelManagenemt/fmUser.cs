using HotelManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagenemt
{
    public partial class fmUser : Form
    {
        public fmUser()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpassword.Text;

            // Tạo đối tượng UserService
            UserService userService = new UserService();

            // Gọi hàm từ đối tượng userService để kiểm tra đăng nhập
            bool isLoginSuccess = userService.Login(username, password);

            if (isLoginSuccess)
            {
                MessageBox.Show("Login successful!");
                // Tiếp tục các hành động sau khi đăng nhập thành công
                fmBooking fm = new fmBooking();
                fm.ShowDialog();

            }


            else
            {
                MessageBox.Show("Invalid username or password.");

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }
    }
}

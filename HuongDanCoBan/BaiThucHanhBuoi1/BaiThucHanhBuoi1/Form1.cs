using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // click đôi vào nút chương trình sẽ tự động tạo hàm sự kiện này
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNameCopy.Text = txtTen.Text;
        }

        private void txtNameCopy_TextChanged(object sender, EventArgs e)
        {
            txtNameCopy.Text = txtTen.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTen.Text;
            MessageBox.Show($"Xin Chào {tenDangNhap}. Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtNameCopy.Text = txtTen.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.BTTKForm
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = "22000";
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = "21000";
        }

        private void rbWite_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = "20000";
        }

        private void btnTtl_Click(object sender, EventArgs e)
        {
            int Pricecttl=int.Parse(txtPrice.Text) * int.Parse(txtAmount.Text);
            lbPricettl.Text = Pricecttl.ToString();
        }
    }
}

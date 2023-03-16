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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTtl_Click(object sender, EventArgs e)
        {
            int priceTtl = 0;
            foreach (var item in listBox2.Items) { 
                switch(item)
                {
                    case "Chuột":
                        priceTtl += 100000;
                        break;
                    case "Bàn phím":
                        priceTtl += 150000;
                        break;
                    case "Máy in":
                        priceTtl += 150000;
                        break;
                    case "USB Kingmax":
                        priceTtl += 150000;
                        break;
                    default:
                        break;
                }
                lbPricettl.Text = priceTtl + " Đồng";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

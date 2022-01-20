using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_box_so_a.Text);
            int b = Convert.ToInt32(txt_box_so_b.Text);
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            double thuong = a / b;
            lbl_ketqua_tong.Text = Convert.ToString(tong);
            lbl_ketqua_hieu.Text = Convert.ToString(hieu);
            lbl_ketqua_tich.Text = Convert.ToString(tich);
            lbl_ketqua_thuong.Text = Convert.ToString(thuong);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

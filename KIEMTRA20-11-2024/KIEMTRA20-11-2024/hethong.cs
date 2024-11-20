using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMTRA20_11_2024
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            frmdonhang frm = new frmdonhang();
            frm.Show();
            this.Hide();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class frmdonhang : Form
    {
        public frmdonhang()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();

        public void getData()
        {
            string query = "SELECT * FROM DONHANG"; // Kiểm tra lại tên bảng và cột
            DataTable dt = kn.laydulieu(query);

            if (dt.Rows.Count > 0)
            {
                tbDataDonHang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }

        public void clearText()
        {
            txtMaDH.Enabled = true;
            txtMaDH.Text = "";
            txtMaKH.Text = "";
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            //dateNgayNhap.Text = " ";
            txtTimKiem.Text = " ";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            string ngayMua = dateNgayNhap.Value.ToString("yyyy-MM-dd");
            string query = string.Format(
                "insert into DONHANG values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",
                    txtMaDH.Text,
                    txtMaKH.Text,
                    txtMaSP.Text,
                    txtSoLuong.Text,
                   ngayMua
            );
            bool kt = kn.thucthi(query);
            if (kt)
            {
                MessageBox.Show("Thêm thành công");
                getData();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string ngayMua = dateNgayNhap.Value.ToString("yyyy-MM-dd");
            string query = string.Format(
               "update  DONHANG set IDHD= N'{0}',IDKH = N'{1}', IDSP = N'{2}',SOLUONG = N'{3}',NGAYMUA = N'{4}'",
                   txtMaDH.Text,
                   txtMaKH.Text,
                   txtMaSP.Text,
                   txtSoLuong.Text,
                   ngayMua
           );
            bool kt = kn.thucthi(query);
            if (kt)
            {
                MessageBox.Show("Thanh cong");

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            // string ngayMua = dateNgayNhap.Value.ToString("yyyy-MM-dd");
            string query = string.Format(
               "delete from DONHANG where IDHD=N'{0}'",
                   txtMaDH.Text

           );
            bool kt = kn.thucthi(query);
            if (kt)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void button_lammoi_Click(object sender, EventArgs e)
        {
            getData();
            clearText();
        }

        private void tbDataDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaDH.Text = tbDataDonHang.Rows[r].Cells["IDHD"].Value.ToString();
                txtMaKH.Text = tbDataDonHang.Rows[r].Cells["IDKH"].Value.ToString();
                txtMaSP.Text = tbDataDonHang.Rows[r].Cells["IDSP"].Value.ToString();
                txtSoLuong.Text = tbDataDonHang.Rows[r].Cells["SOLUONG"].Value.ToString();
                //  dateNgayNhap.Text = tbDataDonHang.Rows[r].Cells["NGAYMUA"].Value.ToString();
                string ngayMuaText = tbDataDonHang.Rows[r].Cells["NGAYMUA"].Value.ToString();

                // Chuyển đổi với định dạng cụ thể (yyyy-MM-dd)
                if (DateTime.TryParseExact(ngayMuaText, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime ngayMua))
                {
                    dateNgayNhap.Value = ngayMua;
                }
                else
                {
                    MessageBox.Show("Dữ liệu ngày mua không hợp lệ!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
             "select *from DONHANG where IDHD = N'{0}'",
             txtTimKiem
                );
            DataTable dt = kn.laydulieu(query);
            tbDataDonHang.DataSource = dt;

        }

        private void frmdonhang_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}

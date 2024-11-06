using System.Data;

namespace qlsp_sql
{
    public partial class formSanPham : Form
    {

        public formSanPham()
        {
            InitializeComponent();
        }
        ConnectionSQL kn = new ConnectionSQL();
        public void getData()
        {
            string query = "select * from sanpham";
            DataSet ds = new DataSet();
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void clearText()
        {
            txtMaSP.Enabled = true;

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtTimKiem.Text = "";
            txtGia.Text = "";
            txtMoTa.Text = "";
            txtSoluong.Text = "";

            //txtLoaiSP.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string query = string.Format(
              "delete from SanPham where MaSP = '{0}'",
              txtMaSP.Text
          );
            if (kn.thucthi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                button5.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(

                txtMaSP.Text,
                txtTenSP.Text,
                txtMoTa.Text,
                float.Parse(txtGia.Text),
                int.Parse(txtSoluong.Text)
                );

                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSP.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập Teen sp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSP.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mo ta.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSP.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                float n;
                if (float.TryParse(txtMaSP.Text, out n))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSP.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSP.Focus();  // Đặt con trỏ vào ô này
                    return;
                }

                if (kn.thucthi(query) == true)
                {
                    MessageBox.Show("Theem moi thanh cong");
                    button5.PerformClick();
                }
                else
                {
                    MessageBox.Show("Theem moi loi");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("vui lòng nhap ");
            }
        }

        private void formSanPham_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format(
              "update sanpham set masp = N'{1}',tensp = N'{2}',mota = N'{3}',gia = N'{4}',soluong = N'{5}'" ,
                txtMaSP.Text,
                txtTenSP.Text,
                txtMoTa.Text,
                float.Parse(txtGia.Text),
                int.Parse(txtSoluong.Text)
              );
            if(kn.thucthi(query) == true)
            {
                MessageBox.Show("sua thanh cong");
                button5.PerformClick();
            }
        }
    }
}

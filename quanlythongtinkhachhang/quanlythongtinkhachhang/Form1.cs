using System.Runtime.Serialization;

namespace quanlythongtinkhachhang
{
    public partial class FormQLKH : Form
    {
        private List<khachhang> danhsachkh = new();
       
        private int nextId = 1;
        public FormQLKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // string makhachhang = txtMa.Text;
                string tenkhachhang = txtTen.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
              
                if (string.IsNullOrWhiteSpace(txtTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTen.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSDT.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDiaChi.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                string makhachhang = "KH" + nextId++;
                khachhang qlkh = new khachhang
                {
                    makhachhang = makhachhang,
                    tenkhachhang = tenkhachhang,
                    sdt = sdt,
                    diachi = diachi
                };
                danhsachkh.Add(qlkh);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhsachkh;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lonhg nhap dde xoa");
                return;
            }
            try
            {
                string selectedId = dataGridView1.CurrentRow.Cells["makhachhang"].Value.ToString();
                khachhang selectedKhachHang = danhsachkh.Find(kh => kh.makhachhang == selectedId);

                if (selectedKhachHang != null)
                {
                    danhsachkh.Remove(selectedKhachHang);
                    UpdateDataGridView();
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        private void UpdateDataGridView()
        {
            // Refresh the DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhsachkh;
        }

        private void ClearFields()
        {
            // Clear input fields after add/edit
            txtMa.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lonhg nhap dde xoa");
                    return;
                }
                try
                {
                    string selectedId = dataGridView1.CurrentRow.Cells["makhachhang"].Value.ToString();
                    khachhang selectedKhachHang = danhsachkh.Find(kh => kh.makhachhang == selectedId);

                    if (selectedKhachHang != null)
                    {
                        selectedKhachHang.tenkhachhang = txtTen.Text;
                        selectedKhachHang.sdt = txtSDT.Text;
                        selectedKhachHang.diachi = txtDiaChi.Text;

                        UpdateDataGridView();
                        ClearFields();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lonhg nhap dde xoa");
                return;
            }
            try
            {
                string selectedId = dataGridView1.CurrentRow.Cells["makhachhang"].Value.ToString();
                khachhang selectedKhachHang = danhsachkh.Find(kh => kh.makhachhang == selectedId);

                if (selectedKhachHang != null)
                {
                  
                    FormDichVu Form1 = new FormDichVu();
                    Form1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}

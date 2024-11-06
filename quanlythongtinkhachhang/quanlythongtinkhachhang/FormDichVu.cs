using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythongtinkhachhang
{

    public partial class FormDichVu : Form
    {
        private List<dichvu> danhSachDichVu = new List<dichvu>();
        int dvs = 1;

        public FormDichVu()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // string makhachhang = txtMa.Text;
                string tendv = txtTenDV.Text;
                string loaidv = cbxLoaiDV.SelectedIndex.ToString();
                float gia = float.Parse(txtGia.Text);

                if (string.IsNullOrWhiteSpace(txtTenDV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenDV.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbxLoaiDV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbxLoaiDV.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGia.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                string madichvu = "KH" + dvs++;
                dichvu qdvh = new dichvu
                {
                    madv = madichvu,
                    tendichvu = tendv,
                    loaidichvu = loaidv,
                    giadichvu = gia
                };
                danhSachDichVu.Add(qdvh);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSachDichVu;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            // Cấu hình DataGridView2 (nếu cần thiết)
            dataGridView2.Columns.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDataGridView()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachDichVu;
        }

        private void ClearFields()
        {

            txtTenDV.Text = "";
            cbxLoaiDV.SelectedIndex = -1;
            txtGia.Text = "";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lonhg nhap dde xoa");
                return;
            }
            try
            {
                string selectedId = dataGridView1.CurrentRow.Cells["madv"].Value.ToString();
                dichvu selectedDichVu = danhSachDichVu.Find(dv => dv.madv == selectedId);

                if (selectedDichVu != null)
                {
                    danhSachDichVu.Remove(selectedDichVu);
                    UpdateDataGridView();
                    ClearFields();
                }

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
                string selectedId = dataGridView1.CurrentRow.Cells["madv"].Value.ToString();
                dichvu selectedDichVu = danhSachDichVu.Find(dv => dv.madv == selectedId);

                if (selectedDichVu != null)
                {
                    UpdateDataGridView();
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Tính tổng số lượng dịch vụ và tổng tiền
                int soluong = danhSachDichVu.Count;  // Số lượng dịch vụ
                float gia = danhSachDichVu.Sum(dv => dv.giadichvu);  // Tổng tiền
                string madv = "KH" + dvs;

                List<object> result = new List<object>
        {
            new { soLuong = soluong, gia = gia }
        };

                // Cập nhật DataGridView2 với tổng số dịch vụ và tổng tiền
                dataGridView2.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTenDV.Clear();
            txtGia.Clear();
            cbxLoaiDV.SelectedIndex = -1;  // Đặt lại ComboBox về trạng thái chưa chọn

            // Xóa tất cả dữ liệu trong DataGridView
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }
    }
}

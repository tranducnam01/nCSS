
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace quanlySinhVien
{
    public partial class Form1 : Form
    {
        private List<quanlySinhVien> danhsachsinhvien = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = danhsachsinhvien;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int dem = dataGridView1.SelectedRows[0].Index;
                danhsachsinhvien.RemoveAt(dem);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhsachsinhvien;
                MessageBox.Show("đã xóa thành công");
            }
            else
            {
                MessageBox.Show("vui lòng chon 1 dòng đẻ xóa");
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = tbMaSv.Text;
                string tenSV = tbTenSV.Text;
                DateTime ngaySinh = DateTime.Parse(tbNgaySinh.Text);
                string diaChi = tbDiaChi.Text;
                string email = tbEmail.Text;
                string sdt = tbSDT.Text;
                string? sex = cbSex.SelectedItem?.ToString();
                string? khoa = cbKhoa.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(tbMaSv.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMaSv.Focus();  // Đặt con trỏ vào ô này
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbTenSV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbTenSV.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDiaChi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập Email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập Số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSDT.Focus();
                    return;
                }
                if (cbSex.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn Giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSex.Focus();
                    return;
                }
                if (cbKhoa.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn Khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbKhoa.Focus();
                    return;
                }
                quanlySinhVien sv = new quanlySinhVien
                {
                    MaSV = maSV,
                    TenSV = tenSV,
                    ngaysinh = ngaySinh,
                    DiaChi = diaChi,
                    email = email,
                    SDT = sdt,
                    Sex = sex,
                    Khoa = khoa
                };
                danhsachsinhvien.Add(sv);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhsachsinhvien;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Looix : " + ex.Message);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            tbMaSv.Clear();
            tbTenSV.Clear();
            tbNgaySinh.Clear();
            tbDiaChi.Clear();
            tbEmail.Clear();
            tbSDT.Clear();
            cbKhoa.Items.Clear();
            cbSex.Items.Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int dem = dataGridView1.SelectedRows[0].Index;

                if (dem >= 0 && dem < danhsachsinhvien.Count)
                {
                    quanlySinhVien quanlySinhVien = danhsachsinhvien[dem];


                    quanlySinhVien.MaSV = tbMaSv.Text;
                    quanlySinhVien.TenSV = tbTenSV.Text;
                    quanlySinhVien.ngaysinh = DateTime.Parse(tbNgaySinh.Text);
                    quanlySinhVien.DiaChi = tbDiaChi.Text;
                    quanlySinhVien.email = tbEmail.Text;
                    quanlySinhVien.SDT = tbSDT.Text;
                    string? sex = cbSex.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(sex))
                    {
                        MessageBox.Show("Vui lòng chọn loại sản phẩm");
                        return;
                    }
                    quanlySinhVien.Sex = sex;

                    string? Khoa = cbKhoa.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(Khoa))
                    {
                        MessageBox.Show("Vui lòng chọn khoa");
                        return;
                    }
                    quanlySinhVien.Khoa = Khoa;
                    //

                    //  dataGridView1.DataSource = null;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = danhsachsinhvien;

                    MessageBox.Show("cap nhap thanh cong");
                }
                else
                {
                    MessageBox.Show("khong tim thay ");
                }
            }
            else
            {
                MessageBox.Show("chon dong de cap nhap ");
            }

        }
    }
}

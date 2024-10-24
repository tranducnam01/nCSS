using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace quanlyssp
{
    public partial class Form1 : Form
    {
        private List<sanpham> danhsachsp = new();


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = danhsachsp;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = tbMaSP.Text;
                string tenSP = tbTenSP.Text;
                decimal donGia;
                if (!decimal.TryParse(tbGia.Text, out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ");
                    return;
                }
                string hinhAnh = tbHinhAnh.Text;
                string moTaNgan = tbMoTaNgan.Text;
                string moTaChiTiet = tbMoTaChiTiet.Text;
                string? loaiSP = cbLoaiSP.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(loaiSP))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm");
                    return;
                }
                sanpham sanPham = new sanpham
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DonGia = donGia,
                    HinhAnh = hinhAnh,
                    MoTaNgan = moTaNgan,
                    MoTaChiTiet = moTaChiTiet,
                    LoaiSP = loaiSP
                };
                danhsachsp.Add(sanPham);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhsachsp;

                tbMaSP.Clear();
                tbTenSP.Clear();
                tbGia.Clear();
                tbHinhAnh.Clear();
                tbMoTaNgan.Clear();
                tbMoTaChiTiet.Clear();
                cbLoaiSP.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);

            }
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbMaSP.Clear();
            tbTenSP.Clear();
            tbGia.Clear();
            tbHinhAnh.Clear();
            tbMoTaNgan.Clear();
            tbMoTaChiTiet.Clear();
            cbLoaiSP.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ số của dòng được chọn
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Kiểm tra nếu chỉ số hợp lệ trong danh sách sản phẩm
                if (selectedIndex >= 0 && selectedIndex < danhsachsp.Count)
                {
                    // Lấy sản phẩm hiện tại
                    sanpham sanPham = danhsachsp[selectedIndex];

                    // Cập nhật thông tin sản phẩm từ các textbox
                    sanPham.MaSP = tbMaSP.Text;
                    sanPham.TenSP = tbTenSP.Text;

                    // Kiểm tra và cập nhật đơn giá
                    decimal donGia;
                    if (!decimal.TryParse(tbGia.Text, out donGia))
                    {
                        MessageBox.Show("Đơn giá không hợp lệ");
                        return;
                    }
                    sanPham.DonGia = donGia;

                    sanPham.HinhAnh = tbHinhAnh.Text;
                    sanPham.MoTaNgan = tbMoTaNgan.Text;
                    sanPham.MoTaChiTiet = tbMoTaChiTiet.Text;

                    // Kiểm tra loại sản phẩm
                    string? loaiSP = cbLoaiSP.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(loaiSP))
                    {
                        MessageBox.Show("Vui lòng chọn loại sản phẩm");
                        return;
                    }
                    sanPham.LoaiSP = loaiSP;

                    // Cập nhật lại DataGridView sau khi sửa
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = danhsachsp;

                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm trong danh sách.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ số của dòng được chọn
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Xóa sản phẩm khỏi danh sách theo chỉ số được chọn
                danhsachsp.RemoveAt(selectedIndex);

                // Cập nhật lại DataGridView sau khi xóa
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhsachsp;

                // Thông báo thành công
                MessageBox.Show("Đã xóa sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox8.Text.ToLower(); // chuyển thành chữ thường để tìm kiếm không phân biệt chữ hoa/chữ thường

            // Tạo danh sách tạm thời để chứa kết quả tìm kiếm
            List<sanpham> searchResults = new List<sanpham>();

            // Lặp qua danh sách sản phẩm để tìm kiếm
            foreach (sanpham sp in danhsachsp)
            {
                // Tìm kiếm theo Mã SP, Tên SP hoặc Loại SP
                if (sp.MaSP.ToLower().Contains(searchKeyword) ||
                    sp.TenSP.ToLower().Contains(searchKeyword) ||
                    sp.LoaiSP.ToLower().Contains(searchKeyword))
                {
                    searchResults.Add(sp);
                }
            }

            // Kiểm tra nếu có kết quả tìm kiếm
            if (searchResults.Count > 0)
            {
                // Cập nhật DataGridView với kết quả tìm kiếm
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = searchResults;
            }
            else
            {
                // Nếu không có kết quả, hiển thị thông báo và làm mới DataGridView với danh sách đầy đủ
                MessageBox.Show("Không tìm thấy sản phẩm nào khớp với từ khóa tìm kiếm.");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhsachsp; // Hiển thị lại toàn bộ danh sách
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

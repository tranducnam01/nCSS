using System;
using System.Collections.Generic;
using System.Windows.Forms;
using kiemtra30_10_2024;

namespace kiemtra30_10_2024
{
    public partial class Form1 : Form
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        private List<Product> products = new List<Product>();  // Danh sách sản phẩm
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new DataGridViewImageColumn());

            // Tạo cột trong dataGridView1 khi form được tải
            dataGridView1.Columns.Add("Image", "Hình Ảnh");
            dataGridView1.Columns.Add("ProductName", "Tên Sản Phẩm");
            dataGridView1.Columns.Add("Price", "Giá");
            dataGridView1.Columns.Add("Quantity", "Số Lượng");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.Columns.Add("ProductName", "Tên Sản Phẩm"); // Đảm bảo tên cột là "ProductName"
            dataGridView2.Columns.Add("Price", "Giá");
            dataGridView2.Columns.Add("Quantity", "Số Lượng");
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm dữ liệu sản phẩm mẫu vào danh sách sản phẩm

            products.Add(new Product("anh", "Product A", 100.0m, 10));
            products.Add(new Product("anh2", "Product B", 150.0m, 5));
            products.Add(new Product("anh3", "Product C", 200.0m, 8));


            // Hiển thị các sản phẩm trong dataGridView1
            DisplayProductList();
        }

        private void DisplayProductList()
        {
            // Xóa các hàng hiện tại trước khi thêm mới
            dataGridView1.Rows.Clear();

            // Thêm từng sản phẩm từ danh sách vào dataGridView1
            foreach (var product in products)
            {
                // Tạo một hàng mới
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Thêm dữ liệu vào từng ô trong hàng
                row.Cells["Image"].Value = product.Image; ; // Đường dẫn hình ảnh
                row.Cells["ProductName"].Value = product.Name; // Tên sản phẩm
                row.Cells["Price"].Value = product.Price; // Giá
                row.Cells["Quantity"].Value = product.Quantity; // Số lượng
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateTotal()
        {
            float total = shoppingCart.CalculateTotal();
            tbTong.Text = total.ToString("");
            // Ensure tbTong is refreshed

        }
        private void jbThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hàng được chọn trong dataGridView1
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy sản phẩm từ hàng được chọn
                var selectedRow = dataGridView1.CurrentRow;
                string image = selectedRow.Cells["Image"].Value.ToString(); // Đường dẫn hình ảnh
                string name = selectedRow.Cells["ProductName"].Value.ToString(); // Tên sản phẩm
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value); // Giá

                // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
                var existingProduct = products.FirstOrDefault(p => p.Name == name);
                if (existingProduct != null)
                {
                    // Nếu đã có, tăng số lượng lên
                    existingProduct.Quantity++;
                }
                else
                {
                    // Tạo sản phẩm mới và thêm vào giỏ hàng nếu chưa có
                    products.Add(new Product(image, name, price, 1));
                }

                // Hiển thị giỏ hàng trong dataGridView2
                DisplayCart();
                UpdateTotal();

            }
            else
            {
                // Hiển thị thông báo nếu chưa chọn hàng
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayCart()
        {
            dataGridView2.Rows.Clear();

            // Thêm từng sản phẩm từ giỏ hàng vào dataGridView2
            foreach (var product in products)
            {
                // Tạo một hàng mới
                int rowIndex = dataGridView2.Rows.Add();
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                // Thêm dữ liệu vào từng ô trong hàng
                row.Cells["ProductName"].Value = product.Name; // Tên sản phẩm
                row.Cells["Price"].Value = product.Price; // Giá
                row.Cells["Quantity"].Value = product.Quantity; // Số lượng
            }

        }

        private void jbXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hàng được chọn trong dataGridView2
            if (dataGridView2.CurrentRow != null)
            {
                // Lấy chỉ số hàng được chọn
                int rowIndex = dataGridView2.CurrentRow.Index;

                // Xóa sản phẩm khỏi danh sách cartProducts
                products.RemoveAt(rowIndex);

                // Cập nhật lại giỏ hàng hiển thị
                DisplayCart();

                // Xóa thông tin trong các TextBox
              
                UpdateTotal();


            }
            else
            {
                // Hiển thị thông báo nếu chưa chọn hàng
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa khỏi giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
          
        }
 
        private void tbGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void tbTong_TextChanged(object sender, EventArgs e)
        {
          

        }
      
        private void jbThanhToan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa sạch giỏ hàng
                shoppingCart.Clear();
                DisplayCart(); // Cập nhật giỏ hàng
                tbTong.Text = "0"; // Đặt lại tổng giá trị đơn hàng về 0
                dataGridView2.Rows.Clear();
                MessageBox.Show("Đơn hàng đã được thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        static class Program
        {
            [STAThread]
            static void Main()

            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1()); // Khởi chạy form chính
            }
        }

        private void labelAnhSanPham_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

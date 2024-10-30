using System.Collections.Generic;
using System.Linq;

namespace kiemtra30_10_2024
{
    public class ShoppingCart
    {
        // Danh sách các sản phẩm trong giỏ hàng
        private List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        // Thêm sản phẩm vào giỏ hàng
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Xóa sản phẩm tại chỉ số cho trước
        public void RemoveProductAt(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                products.RemoveAt(index);
            }
        }

        // Lấy danh sách sản phẩm trong giỏ hàng
        public List<Product> GetProducts()
        {
            return products;
        }

        // Xóa tất cả sản phẩm trong giỏ hàng
        public void Clear()
        {
            products.Clear();
        }

        // Tính tổng giá trị đơn hàng
        public float CalculateTotal()
        {
            float total = 0;

            // Duyệt qua danh sách sản phẩm trong giỏ hàng và tính tổng
            foreach (var product in products)
            {
                total += product.Price * product.Quantity; // Giá * Số lượng
            }

            return total;
        }
    }
}


namespace kiemtra30_10_2024
{
    public class Product
    {
        // Các thuộc tính của sản phẩm
        public string Image { get; set; }
        public string Name { get; set; }
        public  float Price { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public Product(string image, string name, decimal price, int quantity)
        {
            Image = image;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
       

    }
}

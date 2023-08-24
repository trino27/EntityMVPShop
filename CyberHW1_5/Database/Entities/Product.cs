
using System.ComponentModel.DataAnnotations;


namespace CyberHW1_5.Database.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public long Number { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
        public double Price { get; set; }
        [MaxLength(256)]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Category? Category { get; set; }
        public List<Cart> Carts { get; set; }
        public List<KeyParams> KeyParams { get; set; }

        public Product(Guid productId, long number, string name, double price)
        {
            ProductId = productId;
            Number = number;
            Name = name;
            Price = price;
        }
       
        public Product(long number, string name, double price, 
            Category category, string? imagePath, string? description, List<Cart> carts, List<KeyParams> keyParams)
        {
            ProductId = Guid.NewGuid();
            this.Number = number;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Description = description;
            this.ImageUrl = imagePath;
            this.Carts = carts;
            this.KeyParams = keyParams;
        }
    }
}


using System.ComponentModel.DataAnnotations;

namespace CyberHW1_5.Database.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public long Number { get; set; }
        [MaxLength(32)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }

        public Category(string name, long number)
        {
            CategoryId = Guid.NewGuid();
            this.Name = name;
            this.Number = number;
        }
        public Category(string name, long number, List<Product>? products)
        {
            CategoryId = Guid.NewGuid();
            this.Name = name;
            this.Number = number;
            this.Products = products;
        }
    }
}

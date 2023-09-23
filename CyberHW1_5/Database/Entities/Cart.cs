using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ShopMVP.Database.Entities
{
    public class Cart
    {
        public Guid CartId { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Cart()
        {
            this.CartId = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }
        public Cart(User user, Product product) 
        {
            this.CartId = Guid.NewGuid();
            this.User = user;
            this.Product = product;
            CreatedDate = DateTime.UtcNow;
        }
    }
}

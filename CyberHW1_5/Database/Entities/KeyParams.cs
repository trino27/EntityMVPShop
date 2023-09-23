using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ShopMVP.Database.Entities
{
    public class KeyParams
    {
        public Guid KeyParamsId { get; set; }
        public Product? Product { get; set; }
        public KeyWord? KeyWord { get; set; }

        public KeyParams()
        {
            KeyParamsId = Guid.NewGuid();
        }
        public KeyParams(Product product, KeyWord keyWord) 
        {
            KeyParamsId = Guid.NewGuid();
            Product = product;
            KeyWord = keyWord;
        }
    }
}

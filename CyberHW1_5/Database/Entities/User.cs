using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CyberHW1_5.Database.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public long Number { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Login { get; set; }
        [MinLength(8)]
        [MaxLength(20)]
        public string Password { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        public List<Cart>? Cart { get; set; }

        public User(string name, string login, long number, string password, string phone)
        {
            UserId = Guid.NewGuid();
            Date = DateTime.Now;
            this.Name = name;
            this.Login = login;
            this.Number = number;
            this.Password = password;
            this.Phone = phone;
        }
        public User(string name, string login, long number, string password, string phone, List<Cart>? cart)
        {
            UserId = Guid.NewGuid();
            Date = DateTime.Now;
            this.Name = name;
            this.Login = login;
            this.Number = number;
            this.Password = password;
            this.Phone = phone;
            this.Cart = cart;
        }
    }
}






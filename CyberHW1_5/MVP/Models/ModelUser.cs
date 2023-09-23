using ShopMVP.Database;
using ShopMVP.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using static ShopMVP.Database.Entities.Error;

namespace ShopMVP.MVP.Models
{
    internal class ModelUser
    {
        private string ToPhoneDataFormat(string phone)
        {
            if (phone.StartsWith("+")) phone = phone.Remove(0, 1);
            phone = phone.Replace(" ", "");
            phone = phone.Replace("-", "");
            return phone;
        }

        public long GetLastUserNumber()
        {
            using (var context = new DataContext())
            {
                return context.users.Count();
            }
        }
        public List<(Guid id, string name, double price, DateTime? time)> LoadCategoryInfoToTableLayoutPanel(User currentUser)
        {
            List<(Guid id, string name, double price, DateTime? time)> res = new List<(Guid id, string name, double price, DateTime? time)>();

            using (var context = new DataContext())
            {
                List<Product> products = new List<Product>();
                List<Cart> carts = context.carts.Include(p => p.Product).
                    Where(c => c.User == currentUser).ToList();
                foreach (var cart in carts)
                {
                    products.Add(cart.Product);
                }
                int i = 0;
                foreach (var product in products)
                {
                    (Guid id, string name, double price, DateTime? time) add = (product.ProductId, product.Name, product.Price, carts[i].CreatedDate);
                    res.Add(add);
                }
            }
            return res;
        }
        public User LoadLastUser()
        {
            using (var context = new DataContext())
            {
                return context.users.FirstOrDefault(u => u.Number == context.users.Count() - 1);
            }
        }
        public User LoadUser(long x)
        {
            using (var context = new DataContext())
            {
                if (context.users.FirstOrDefault(u => u.Number == x) != null)
                {
                    return context.users.FirstOrDefault(u => u.Number == x);
                }
                else return context.users.FirstOrDefault(u => u.Number == 0);
            }
        }
        public User? LoadUser(string login, string password)
        {
            using (var context = new DataContext())
            {
                if (context.users.FirstOrDefault(u => u.Password == password && u.Login == login) != null)
                {
                    return context.users.FirstOrDefault(u => u.Password == password && u.Login == login);
                }
                else return null;
            }
        }
        public void AddUser(string name, string login, string password, string phone)
        {
            using (var context = new DataContext())
            {
                try
                {
                    context.users.Add(new User(name, login, Convert.ToInt64(context.users.Count()), password, ToPhoneDataFormat(phone)));
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "AddUser", StatusCode.Server));
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
        }
        public void DeleteUser(User userRemove)
        {
            long number = userRemove.Number;
            using (var context = new DataContext())
            {
                try
                {
                    context.users.Remove(userRemove);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "DeleteUser", StatusCode.Server));
                    context.SaveChanges();
                }
                var userList = context.users.Where(u => u.Number > number);
                foreach (var user in userList)
                {
                    user.Number--;
                }
                context.SaveChanges();
            }
        }
        public void UpdateUser(User userUpdate, string name, string login, string password, string phone)
        {
            phone = ToPhoneDataFormat(phone);

            using (var context = new DataContext())
            {
                try
                {
                    var user = context.users.FirstOrDefault(u => u.UserId == userUpdate.UserId);
                    if (user == null)
                    {
                        context.errors.Add(new Error("User not found", "UpdateUser", StatusCode.NotFound));
                        context.SaveChanges();
                    }
                    user.Name = name;
                    user.Login = login;
                    user.Password = password;
                    user.Phone = phone;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "UpdateUser", StatusCode.Server));
                    context.SaveChanges();
                }
            }
        }

        public bool IsString20(string str)
        {
            if (str.Length < 20) return true;
            else return false;
        }
        public bool IsUserExist(string login)
        {
            using (var context = new DataContext())
            {
                if (context.users.FirstOrDefault(u => u.Login == login) != null) return true;
                else return false;
            }
        }
        public bool IsSignInAllow(string login, string password)
        {
            using (var context = new DataContext())
            {
                if (context.users.FirstOrDefault(u => u.Login == login && u.Password == password) != null) return true;
                else return false;
            }
        }
        public bool IsUserDataEmpty()
        {
            using (var context = new DataContext())
            {
                return !context.users.Any();
            }
        }
        public bool IsInputEmpty(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || login == "Enter..."
                || string.IsNullOrEmpty(password) || password == "Enter...")
            {
                return true;
            }
            else return false;

        }
        public bool IsInputEmpty(string name, string login, string password, string phone)
        {
            if (string.IsNullOrEmpty(name) || name == "Enter..." || string.IsNullOrEmpty(login) || login == "Enter..."
                || string.IsNullOrEmpty(password) || password == "Enter..." || string.IsNullOrEmpty(phone) || phone == "Enter...")
            {
                return true;
            }
            else return false;

        }
        public bool IsPhoneInputCorrect(string phone)
        {
            phone = ToPhoneDataFormat(phone);
            Regex regex = new Regex(@"^\+?([0-9]{10}|[0-9]{12})$");
            return regex.IsMatch(phone);
        }
        public bool IsPasswordInputCorrect(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
            return regex.IsMatch(password);
        }
        public bool IsLoginUnique(string login)
        {
            using (var context = new DataContext())
            {
                return !context.users.Any(u => u.Login == login);
            }
        }
    }
}

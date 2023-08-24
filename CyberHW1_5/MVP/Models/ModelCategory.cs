using CyberHW1_5.Database;
using CyberHW1_5.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Logging;
using System.Collections.Generic;
using static CyberHW1_5.Database.Entities.Error;

namespace CyberHW1_5.MVP.Models
{
    internal class ModelCategory
    {
        public void DeleteCategory(Category currentCategory)
        {
            long number = currentCategory.Number;
            using (var context = new DataContext())
            {
                try
                {
                    context.categories.Remove(currentCategory);
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "DeleteCategory", StatusCode.Server));
                    context.SaveChanges();
                }
                var categoryList = context.categories.Where(u => u.Number > number);
                foreach (var category in categoryList)
                {
                    category.Number--;
                }
                context.SaveChanges();
            }
}
        public long GetLastCategoryNumber()
        {
            using (var context = new DataContext())
            {
                return context.categories.Count();
            };
        }
        public bool IsCategoryDataEmpty()
        {
            using (var context = new DataContext())
            {
                return !context.categories.Any();
            }
        }
        public Category LoadCategory(long x)
        {
            using (var context = new DataContext())
            {
                if (context.categories.FirstOrDefault(u => u.Number == x) != null)
                {
                    return context.categories.FirstOrDefault(u => u.Number == x);
                }
                else return context.categories.FirstOrDefault(u => u.Number == 0);
            }
        }
        public Category LoadLastCategory()
        {
            using (var context = new DataContext())
            {
                return context.categories.FirstOrDefault(u => u.Number == context.categories.Count() - 1);
            }
        }
        public List<(string id, string name)> LoadCategoryInfoToTableLayoutPanel(Category currentCategory)
        {
            List<(string id, string name)> res = new List<(string id, string name)>();

            using (var context = new DataContext())
            {
               List<Product> products = context.products.Include(p => p.Category)
                    .Where(p => p.Category == currentCategory).ToList();

                foreach(var product in products) 
                {
                    (string id, string name) add = (product.ProductId.ToString(), product.Name);
                    res.Add(add);
                }
            }
            return res;
        }

        public void AddCategory(string name)
        {
            using (var context = new DataContext())
            {
                try
                {
                    context.categories.Add(new Category(name, Convert.ToInt64(context.categories.Count())));
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "AddCategory", StatusCode.Server));
                    context.SaveChanges();
                }
            }
        }
        public bool IsInputEmpty(string name)
        {
            if (string.IsNullOrEmpty(name) || name == "Enter...")
            {
                return true;
            }
            else return false;
        }
        public bool IsNameUnique(string name)
        {
            using (var context = new DataContext())
            {
                return !context.categories.Any(u => u.Name == name);
            }
        }
        public bool IsCategoryEmpty(Category currentCategory)
        {
            if (currentCategory.Products.IsNullOrEmpty()) return true;
            else return false;
        }

        public void UpdateCategory(Category categoryUpdate, string name)
        {
            using (var context = new DataContext())
            {
                var category = context.categories.FirstOrDefault(u => u.CategoryId == categoryUpdate.CategoryId);
                if (category == null)
                {
                    context.errors.Add(new Error("Category not found", "UpdateCategory", StatusCode.NotFound));
                    context.SaveChanges();
                }
                else
                {
                    category.Name = name;
                    context.SaveChanges();
                }
            }
        }
    }
}

using CyberHW1_5.Database;
using CyberHW1_5.Database.Entities;
using Microsoft.EntityFrameworkCore;
using static CyberHW1_5.Database.Entities.Error;

namespace CyberHW1_5.MVP.Models
{
    public class ModelProduct
    {
        public void DeleteProduct(Product productRemove)
        {
            long number = productRemove.Number;
            using (var context = new DataContext())
            {
                try
                {
                    context.products.Remove(productRemove);
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "DeleteProduct", StatusCode.NotFound));
                    context.SaveChanges();
                }
                var productList = context.products.Where(p => p.Number > number);
                foreach (var product in productList)
                {
                    product.Number--;
                }
                context.SaveChanges();
            }
        }
        public string GetKeyWords(Product currentProduct)
        {
            string res = "";
            using (var context = new DataContext())
            {
                foreach (var key in context.keyParams.Include(kp => kp.KeyWord)
                    .Where(kp => kp.Product.ProductId == currentProduct.ProductId))
                {
                    res += "#" + key.KeyWord.Word + " ";
                }
            }
            return res;
        }
        public long GetLastProductNumber()
        {
            using (var context = new DataContext())
            {
                return context.products.Count();
            }
        }

        public Product LoadLastProduct()
        {
            using (var context = new DataContext())
            {
                return context.products
                        .Include(p => p.Category)
                        .Include(p => p.KeyParams)
                        .FirstOrDefault(p => p.Number == context.products.Count() - 1);
            }
        }
        public Product LoadProduct(long currentNumber)
        {
            using (var context = new DataContext())
            {
                if (context.products.FirstOrDefault(p => p.Number == currentNumber) != null)
                {
                    return context.products
                        .Include(p => p.Category)
                        .Include(p => p.KeyParams)
                        .FirstOrDefault(p => p.Number == currentNumber);
                }
                else return context.products
                        .Include(p => p.Category)
                        .Include(p => p.KeyParams)
                        .FirstOrDefault(p => p.Number == 0);
            }
        }
        public List<Product> LoadAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var context = new DataContext())
            {
                products.AddRange(context.products);
            }
            return products;
        }

        public List<KeyWord> RichTextBoxKeysToWord(RichTextBox richTextBox)
        {
            var words = new List<KeyWord>();
            string[] keys = richTextBox.Text.Split('#');
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] != "" && keys[i] != " ")
                {
                    words.Add(new KeyWord(keys[i]));
                }
            }
            return words;
        }
        private void AddKeyParamsToProduct(Product product, List<KeyWord> keyWords, DataContext context)
        {
            product.KeyParams = new List<KeyParams>();
            foreach (var key in keyWords)
            {
                var keyWord = context.keyWords.FirstOrDefault(kw => kw.Word == key.Word);
                if (keyWord != null)
                {
                    product.KeyParams.Add(new KeyParams(product, keyWord));
                }
            }
        }
        public void AddProduct(string name, string price, string category
            , string? imagePath, string? description, RichTextBox? KeyWords)
        {
            List<KeyWord> words = RichTextBoxKeysToWord(KeyWords);
            AddKeyWordToDatabase(words);
            if (imagePath == "") imagePath = null;

            using (var context = new DataContext())
            {
                try
                {
                    var currentCategory = context.categories.FirstOrDefault(c => c.Name == category);

                Product newProduct = new Product(Convert.ToInt64(context.products.Count()), name, Convert.ToDouble(price)
                    , currentCategory, imagePath, description, new List<Cart>(), new List<KeyParams>());


                AddKeyParamsToProduct(newProduct, words, context);
                context.products.Add(newProduct);
                currentCategory.Products.Add(newProduct);
                context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "AddProduct", StatusCode.NotFound));
                    context.SaveChanges();
                }
            }
        }
        public object[] GetCategoriesList()
        {
            Category[] categories;
            string[] categoryNames;
            using (var context = new DataContext())
            {
                categories = context.categories.ToArray();
                categoryNames = new string[categories.Length];

                for (int i = 0; i < categories.Length; i++)
                {
                    categoryNames[i] = categories[i].Name;
                }
            }
            return categoryNames;
        }

        public bool IsInputEmpty(string name, string price, object selectedItem)
        {
            if (string.IsNullOrEmpty(name) || name == "Enter..."
                || string.IsNullOrEmpty(price) || price == "Enter..." || selectedItem == null)
            {
                return true;
            }
            else return false;
        }
        public bool IsPriceInputCorrect(string price)
        {
            if (Convert.ToDouble(price) > 0) return true;
            else return false;
        }
        public bool IsProductDataEmpty()
        {
            using (var context = new DataContext())
            {
                return !context.products.Any();
            }
        }
        public void AddKeyWordToDatabase(List<KeyWord> KeyWords)
        {
            using (var context = new DataContext())
            {
                foreach (var key in KeyWords)
                {
                    if (context.keyWords.FirstOrDefault(w => w.Word == key.Word) != null)
                    {
                        context.keyWords.FirstOrDefault(w => w.Word == key.Word).Count++;
                    }
                    else
                    {
                        context.keyWords.Add(key);
                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product productUpdate, string name
            , string price, string category, string? imagePath, string? description, RichTextBox? KeyWords)
        {
            List<KeyWord> words = RichTextBoxKeysToWord(KeyWords);
            AddKeyWordToDatabase(words);

            using (var context = new DataContext())
            {
                Guid productId = productUpdate.ProductId;
                long productNumber = productUpdate.Number;

                context.products.Remove(productUpdate);

                var currentCategory = context.categories.FirstOrDefault(c => c.Name == category);

                Product product = new Product(productNumber, name, Convert.ToDouble(price),
                    currentCategory, imagePath, description, new List<Cart>(), new List<KeyParams>());

                product.ProductId = productId;
                product.Number = productNumber;

                AddKeyParamsToProduct(product, words, context);
                context.products.Add(product);
                currentCategory.Products.Add(product);
                context.SaveChanges();
            }
        }

        public List<Product> FilterProductsByCategories(object selectedItem)
        {
            List<Product> products = new List<Product>();
            using (var context = new DataContext())
            {
                string currentCategory = selectedItem as string;
                products = context.products.Include(p => p.Category)
                     .Where(p => p.Category.Name == currentCategory).ToList();
            }
            return products;
        }

        public List<Product> FilterProductsBySearch(string text)
        {
            List<Product> products = new List<Product>();
            var searchText = text.Split(" ");
            using (var context = new DataContext())
            {
                foreach (var product in context.products.Include(k => k.KeyParams)
                                                        .ThenInclude(k => k.KeyWord))
                {
                    foreach (var word in searchText)
                    {
                        string keyWord = word;
                        foreach (var key in product.KeyParams)
                        {
                            if (keyWord.EndsWith('.') || keyWord.EndsWith(',')
                            || keyWord.EndsWith('!') || keyWord.EndsWith('?')
                            || keyWord.EndsWith('/') || keyWord.EndsWith('\\')
                            || keyWord.EndsWith('|') || keyWord.EndsWith(')')
                            || keyWord.EndsWith('(') || keyWord.EndsWith('}')
                            || keyWord.EndsWith('{') || keyWord.EndsWith(']')
                            || keyWord.EndsWith('[') || keyWord.EndsWith('#'))
                            {
                                keyWord = keyWord.Substring(0, keyWord.Length - 1);
                            }
                            if (word == key.KeyWord.Word && !products.Contains(product))
                            {
                                products.Add(product);
                            }
                        }
                        if (product.Name.Contains(keyWord) && !products.Contains(product))
                        {
                            products.Add(product);
                        }
                    }
                }

            }
            return products;
        }

        public bool BuyProduct(User currentUser, Product product)
        {
            Cart cart;
            using (var context = new DataContext())
            {
                cart = new Cart(context.users.FirstOrDefault(c => c == currentUser), context.products.FirstOrDefault(p => p == product));
                try
                {
                    context.carts.Add(cart);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.errors.Add(new Error(ex.Message, "BuyProduct", StatusCode.NotFound));
                    context.SaveChanges();
                }
            }

            bool res;

            using (var context = new DataContext())
            {
                if (context.carts.Contains(cart))
                {
                    res = true;
                }
                else res = false;
            }
            return res;
        }
    }
}

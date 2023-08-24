using CyberHW1_5.Database.Entities;
using CyberHW1_5.Extensions;
using CyberHW1_5.MVP.Models;
using CyberHW1_5.MVP.Views;
using Microsoft.IdentityModel.Tokens;

namespace CyberHW1_5.MVP.Presenters
{
    internal class PresenterAdminProducts
    {
        ModelProduct model = null;
        ViewAdminProducts view = null;
        Product currentProduct;

        public PresenterAdminProducts(ViewAdminProducts form)
        {
            model = new ModelProduct();
            view = form;
            view.FormLoad += new EventHandler(FormLoad);

            view.SwapRight += new EventHandler(SwapRight);
            view.SwapLeft += new EventHandler(SwapLeft);

            view.AddProduct += new EventHandler(Add);
            view.UpdateProduct += new EventHandler(Update);
            view.DeleteProduct += new EventHandler(Delete);
            view.Back += new EventHandler(Back);

        }

        private void Back(object? sender, EventArgs e)
        {
            ViewAdminMenu back = new ViewAdminMenu();
            back.Show();
            this.view.Hide();
        }

        private void Output()
        {
            if (!model.IsProductDataEmpty() && currentProduct != null)
            {
                view.OutputId = currentProduct.ProductId.ToString();
                view.OutputName = currentProduct.Name;
                view.OutputPrice = currentProduct.Price.ToString();
                if (currentProduct.Category != null)
                {
                    view.OutputCategory = currentProduct.Category.Name;
                }
                else
                {
                    view.OutputCategory = "No Category";
                }
                if (currentProduct.KeyParams != null)
                {
                    view.OutputKeyWords = model.GetKeyWords(currentProduct);
                }
                view.OutputDescription = currentProduct.Description;
                if (!currentProduct.ImageUrl.IsNullOrEmpty())
                {
                    view.OutputPictureBox.ImageLocation = currentProduct.ImageUrl;
                }
            }
            else
            {
                EmptyDataOutput();
            }
        }
        private void EmptyDataOutput()
        {
            view.OutputId = "No Data";
            view.OutputName = "No Data";
            view.OutputPrice = "No Data";
            view.OutputCategory = "No Data";
            view.OutputKeyWords = "No Data";
            view.OutputDescription = "No Data";
            view.OutputPictureBox = null;
        }
        private void UpdateNumberLabel()
        {
            if (!model.IsProductDataEmpty() && currentProduct != null)
            {
                view.LabelNumber.LabelNumberUpdate(currentProduct.Number + 1, model.GetLastProductNumber());
            }
            else
            {
                view.LabelNumber.LabelNumberUpdate(0, model.GetLastProductNumber());
            }
        }

        private void Add(object? sender, EventArgs e)
        {
            ViewAdminProductsAdd addProduct = new ViewAdminProductsAdd();
            addProduct.ShowDialog();
            currentProduct = model.LoadLastProduct();
            UpdateNumberLabel();
            Output();

        }
        private void Delete(object? sender, EventArgs e)
        {
            if (!model.IsProductDataEmpty())
            {
                long currentNumber = currentProduct.Number;
                model.DeleteProduct(currentProduct);

                if (!model.IsProductDataEmpty())
                {
                    currentProduct = model.LoadProduct(currentNumber);
                    Output();
                }
                else
                {
                    EmptyDataOutput();
                }

                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Product");
            }
        }
        private void Update(object? sender, EventArgs e)
        {
            
            if (!model.IsProductDataEmpty())
            {
                ViewAdminProductsUpdate updateProduct = new ViewAdminProductsUpdate(currentProduct);
                updateProduct.ShowDialog();
                currentProduct = model.LoadProduct(currentProduct.Number);
                Output();
            }
            else
            {
                EmptyDataOutput();
            }
        }

        private void SwapLeft(object? sender, EventArgs e)
        {
            if (!model.IsProductDataEmpty())
            {
                if (currentProduct.Number == 0)
                {
                    currentProduct = model.LoadLastProduct();
                }
                else currentProduct = model.LoadProduct(currentProduct.Number - 1);

                Output();
                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Product");
            }
        }
        private void SwapRight(object? sender, EventArgs e)
        {
            if (!model.IsProductDataEmpty())
            {
                currentProduct = model.LoadProduct(currentProduct.Number + 1);

                Output();
                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Product");
            }
        }

        private void FormLoad(object? sender, EventArgs e)
        {
            if (!model.IsProductDataEmpty())
            {
                currentProduct = model.LoadProduct(0);

                UpdateNumberLabel();
                Output();
            }
            else
            {
                EmptyDataOutput();
            }
        }
    }
}

using CyberHW1_5.Database.Entities;
using CyberHW1_5.Extensions;
using CyberHW1_5.MVP.Models;
using CyberHW1_5.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CyberHW1_5.MVP.Presenters
{
    internal class PresenterShop
    {
        ModelProduct model = null;
        ViewShop view = null;

        List<GroupBox> GroupBoxProducts = new List<GroupBox>();
        List<Label> LabelNames = new List<Label>();
        List<Label> LabelPrices = new List<Label>();
        List<PictureBox> PictureBoxes = new List<PictureBox>();
        List<RichTextBox> RichTextBoxes = new List<RichTextBox>();

        List<Product> AllProducts = new List<Product>();

        int indexProduct = 0;
        int currentPage = 0;
        int maxNumberPages = 0;

        public PresenterShop(ViewShop form)
        {
            model = new ModelProduct();
            view = form;

            view.FormLoad += new EventHandler(FormLoad);

            view.SwapRight += new EventHandler(SwapRight);
            view.SwapLeft += new EventHandler(SwapLeft);

            view.Search += new EventHandler(Search);
            view.Filter += new EventHandler(Filter);
            view.Clean += new EventHandler(Clean);

            view.History += new EventHandler(History);
            view.Back += new EventHandler(Back);

            view.Button1 += new EventHandler(Button1Click);
            view.Button2 += new EventHandler(Button2Click);
            view.Button3 += new EventHandler(Button3Click);
            view.Button4 += new EventHandler(Button4Click);
            view.Button5 += new EventHandler(Button5Click);
            view.Button6 += new EventHandler(Button6Click);
            view.Button7 += new EventHandler(Button7Click);
            view.Button8 += new EventHandler(Button8Click);
            view.Button9 += new EventHandler(Button9Click);
            view.Button10 += new EventHandler(Button10Click);
            view.Button11 += new EventHandler(Button11Click);
            view.Button12 += new EventHandler(Button12Click);

            InitViewObjects();
        }

        private void Clean(object? sender, EventArgs e)
        {
            if (!model.IsProductDataEmpty())
            {
                HideProductSlots();
                AllProducts = model.LoadAllProducts();
                Output();
            }
        }

        private void Filter(object? sender, EventArgs e)
        {
            HideProductSlots();
            AllProducts = model.FilterProductsByCategories(view.CategoryComboBox.SelectedItem);
            Output();
        }
        private void Search(object? sender, EventArgs e)
        {
            HideProductSlots();
            AllProducts = model.FilterProductsBySearch(view.TextBoxSearch.Text);
            Output();
        }

        private void InitViewObjects()
        {
            GroupBoxProducts.Add(view.GroupBoxProduct1);
            GroupBoxProducts.Add(view.GroupBoxProduct2);
            GroupBoxProducts.Add(view.GroupBoxProduct3);
            GroupBoxProducts.Add(view.GroupBoxProduct4);
            GroupBoxProducts.Add(view.GroupBoxProduct5);
            GroupBoxProducts.Add(view.GroupBoxProduct6);
            GroupBoxProducts.Add(view.GroupBoxProduct7);
            GroupBoxProducts.Add(view.GroupBoxProduct8);
            GroupBoxProducts.Add(view.GroupBoxProduct9);
            GroupBoxProducts.Add(view.GroupBoxProduct10);
            GroupBoxProducts.Add(view.GroupBoxProduct11);
            GroupBoxProducts.Add(view.GroupBoxProduct12);

            LabelNames.Add(view.LabelProductName1);
            LabelNames.Add(view.LabelProductName2);
            LabelNames.Add(view.LabelProductName3);
            LabelNames.Add(view.LabelProductName4);
            LabelNames.Add(view.LabelProductName5);
            LabelNames.Add(view.LabelProductName6);
            LabelNames.Add(view.LabelProductName7);
            LabelNames.Add(view.LabelProductName8);
            LabelNames.Add(view.LabelProductName9);
            LabelNames.Add(view.LabelProductName10);
            LabelNames.Add(view.LabelProductName11);
            LabelNames.Add(view.LabelProductName12);

            LabelPrices.Add(view.LabelPrice1);
            LabelPrices.Add(view.LabelPrice2);
            LabelPrices.Add(view.LabelPrice3);
            LabelPrices.Add(view.LabelPrice4);
            LabelPrices.Add(view.LabelPrice5);
            LabelPrices.Add(view.LabelPrice6);
            LabelPrices.Add(view.LabelPrice7);
            LabelPrices.Add(view.LabelPrice8);
            LabelPrices.Add(view.LabelPrice9);
            LabelPrices.Add(view.LabelPrice10);
            LabelPrices.Add(view.LabelPrice11);
            LabelPrices.Add(view.LabelPrice12);

            PictureBoxes.Add(view.PictureBoxProduct1);
            PictureBoxes.Add(view.PictureBoxProduct2);
            PictureBoxes.Add(view.PictureBoxProduct3);
            PictureBoxes.Add(view.PictureBoxProduct4);
            PictureBoxes.Add(view.PictureBoxProduct5);
            PictureBoxes.Add(view.PictureBoxProduct6);
            PictureBoxes.Add(view.PictureBoxProduct7);
            PictureBoxes.Add(view.PictureBoxProduct8);
            PictureBoxes.Add(view.PictureBoxProduct9);
            PictureBoxes.Add(view.PictureBoxProduct10);
            PictureBoxes.Add(view.PictureBoxProduct11);
            PictureBoxes.Add(view.PictureBoxProduct12);

            RichTextBoxes.Add(view.RichTextBoxProductDescription1);
            RichTextBoxes.Add(view.RichTextBoxProductDescription2);
            RichTextBoxes.Add(view.RichTextBoxProductDescription3);
            RichTextBoxes.Add(view.RichTextBoxProductDescription4);
            RichTextBoxes.Add(view.RichTextBoxProductDescription5);
            RichTextBoxes.Add(view.RichTextBoxProductDescription6);
            RichTextBoxes.Add(view.RichTextBoxProductDescription7);
            RichTextBoxes.Add(view.RichTextBoxProductDescription8);
            RichTextBoxes.Add(view.RichTextBoxProductDescription9);
            RichTextBoxes.Add(view.RichTextBoxProductDescription10);
            RichTextBoxes.Add(view.RichTextBoxProductDescription11);
            RichTextBoxes.Add(view.RichTextBoxProductDescription12);
        }

        private void Button12Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 11]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button11Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 10]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button10Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 9]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button9Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 8]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button8Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 7]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button7Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
                AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 6]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button6Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 5]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button5Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 4]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button4Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 3]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button3Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
               AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 2]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button2Click(object? sender, EventArgs e)
        {
            if (model.BuyProduct(view.currentUser,
                AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count + 1]))
            {
                MessageBox.Show("Purchase successful");
            }
            else
            {
                MessageBox.Show("Something go wrong");
            }
        }
        private void Button1Click(object? sender, EventArgs e)
        {
            if(model.BuyProduct(view.currentUser,
                AllProducts[GroupBoxProducts.Count * currentPage - GroupBoxProducts.Count]))
            {
                MessageBox.Show("Purchase successful");
            }else
            {
                MessageBox.Show("Something go wrong");
            }
        }

        private void History(object? sender, EventArgs e)
        {
            ViewUserHistory history = new ViewUserHistory(view.currentUser);
            history.ShowDialog();
        }

        private void SwapLeft(object? sender, EventArgs e)
        {
            
            if (!model.IsProductDataEmpty())
            {
                HideProductSlots();

                if (currentPage != 1)
                {
                    currentPage--;
                }else
                {
                    currentPage = maxNumberPages;
                }

                indexProduct = currentPage * GroupBoxProducts.Count - GroupBoxProducts.Count;
                int border = currentPage * GroupBoxProducts.Count;
                int i = 0;

                while (AllProducts.Count > indexProduct && indexProduct < border)
                {
                    GroupBoxProducts[i].Visible = true;
                    LabelNames[i].Text = AllProducts[indexProduct].Name;
                    LabelPrices[i].Text = AllProducts[indexProduct].Price.ToString();
                    PictureBoxes[i].ImageLocation = AllProducts[indexProduct].ImageUrl;
                    RichTextBoxes[i].Text = AllProducts[indexProduct].Description;
                    indexProduct++;
                    i++;
                }
                
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
                HideProductSlots();
                if (currentPage != maxNumberPages)
                {
                    currentPage++;
                }
                else
                {
                    currentPage = 1;
                }

                indexProduct = currentPage * GroupBoxProducts.Count - GroupBoxProducts.Count;
                int border = currentPage * GroupBoxProducts.Count;
                int i = 0;

                while (AllProducts.Count > indexProduct && indexProduct < border)
                {
                    GroupBoxProducts[i].Visible = true;
                    LabelNames[i].Text = AllProducts[indexProduct].Name;
                    LabelPrices[i].Text = AllProducts[indexProduct].Price.ToString();
                    PictureBoxes[i].ImageLocation = AllProducts[indexProduct].ImageUrl;
                    RichTextBoxes[i].Text = AllProducts[indexProduct].Description;
                    indexProduct++;
                    i++;
                }

                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Product");
            }
        }
        private void UpdateNumberLabel()
        {
            if (!model.IsProductDataEmpty())
            {
                view.LabelNumber.LabelNumberUpdate(currentPage, maxNumberPages);
            }
            else
            {
                view.LabelNumber.LabelNumberUpdate(0, maxNumberPages);
            }
        }
        private void HideProductSlots()
        {
            foreach( var i in GroupBoxProducts ) 
            {
                i.Visible = false;
            }
        }

        private void FormLoad(object? sender, EventArgs e)
        {
            view.CategoryComboBox.Items.AddRange(model.GetCategoriesList());
            HideProductSlots();
            if (!model.IsProductDataEmpty())
            {
                AllProducts = model.LoadAllProducts();
                Output();
            }
            
        }
        private void Output()
        {
            int i = 0;
            indexProduct = 0;
            while (AllProducts.Count > indexProduct && indexProduct < GroupBoxProducts.Count)
            {
                GroupBoxProducts[i].Visible = true;
                LabelNames[i].Text = AllProducts[indexProduct].Name;
                LabelPrices[i].Text = AllProducts[indexProduct].Price.ToString();
                PictureBoxes[i].ImageLocation = AllProducts[indexProduct].ImageUrl;
                RichTextBoxes[i].Text = AllProducts[indexProduct].Description;
                i++;
                indexProduct++;
            }
            maxNumberPages = AllProducts.Count / GroupBoxProducts.Count + 1;
            currentPage = 1;
            UpdateNumberLabel();
        }
        private void Back(object? sender, EventArgs e)
        {
            ViewStart viewStart = new ViewStart();
            viewStart.Show();
            this.view.Hide();
        }
    }
}

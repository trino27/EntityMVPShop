using ShopMVP.Database.Entities;
using ShopMVP.Extensions;
using ShopMVP.Migrations;
using ShopMVP.MVP.Models;
using ShopMVP.MVP.Views;
namespace ShopMVP.MVP.Presenters
{
    internal class PresenterAdminProductsAdd
    {
        ModelProduct model = null;
        ViewAdminProductsAdd view = null;

        public PresenterAdminProductsAdd(ViewAdminProductsAdd form)
        {
            model = new ModelProduct();
            view = form;

            view.AddProduct += new EventHandler(AddProduct);
            view.AddCategory += new EventHandler(AddCategory);
            view.Back += new EventHandler(Back);

            view.ClearImage += new EventHandler(ClearImage);

            view.PriceTextChanged += new EventHandler(PriceTextChanged);

            view.NameEnter += new EventHandler(NameEnter);
            view.PathEnter += new EventHandler(PathEnter);
            view.PriceEnter += new EventHandler(PriceEnter);
            view.KeyWordsEnter += new EventHandler(KeyWordsEnter);

            view.NameLeave += new EventHandler(NameLeave);
            view.PathLeave += new EventHandler(PathLeave);
            view.PriceLeave += new EventHandler(PriceLeave);
            view.KeyWordsLeave += new EventHandler(KeyWordsLeave);

            view.Folder += new EventHandler(Folder);
            view.FormLoad += new EventHandler(FormLoad);
        }

        private void PriceTextChanged(object? sender, EventArgs e)
        {
            string input = "";
            for (int i = 0; i < view.InputPriceTextBox.Text.Length; i++)
            {
                if (char.IsDigit(view.InputPriceTextBox.Text[i]))
                {
                    input += view.InputPriceTextBox.Text[i];
                }
                switch (view.InputPriceTextBox.Text[i]) 
                {
                    case ',':
                        {
                            int count = input.Count(c => c == ',');
                            if (count == 0)
                            {
                                input += view.InputPriceTextBox.Text[i];
                            }
                        }
                        break;
                    case '.': 
                        {
                            int count = input.Count(c => c == ',');
                            if (count == 0)
                            {
                                input += ',';
                            }

                        }
                        break;
                    default: { } break;
                        
                }
            }
            view.InputPriceTextBox.Text = input;
            view.InputPriceTextBox.Select(view.InputPriceTextBox.Text.Length, 0);
        }

        private void ClearImage(object? sender, EventArgs e)
        {
            view.PictureBoxImage.Image = null;
            view.InputImagePathTextBox.Text = "";
        }

        private void FormLoad(object? sender, EventArgs e)
        {
            view.CategoryComboBox.Items.AddRange(model.GetCategoriesList());
        }

        private void Folder(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                view.PictureBoxImage.Image = Image.FromFile(openFileDialog.FileName);
                view.InputImagePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void AddCategory(object? sender, EventArgs e)
        {
            ViewAdminCategoriesAdd addCategory = new ViewAdminCategoriesAdd();
            addCategory.ShowDialog();
            view.CategoryComboBox.Items.Clear();
            view.CategoryComboBox.Items.AddRange(model.GetCategoriesList());
        }

        private void PathLeave(object? sender, EventArgs e)
        {
            if (File.Exists(view.InputImagePathTextBox.Text))
            {
                view.PictureBoxImage.Image = Image.FromFile(view.InputImagePathTextBox.Text);
            }
            else
            {
                MessageBox.Show("Image not found");
            }
            view.InputImagePathTextBox.TextBoxLeave();
        }
        private void PriceLeave(object? sender, EventArgs e)
        {
            view.InputPriceTextBox.TextBoxLeave();
        }
        private void KeyWordsLeave(object? sender, EventArgs e)
        {
            view.InputKeyWordsRichTextBox.Text = view.InputKeyWordsRichTextBox.Text.ToLower();
            view.InputKeyWordsRichTextBox.TextBoxKeyLeave();
        }
        private void NameLeave(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxLeave();
        }

        private void PathEnter(object? sender, EventArgs e)
        {
            view.InputImagePathTextBox.TextBoxEnter();
        }
        private void PriceEnter(object? sender, EventArgs e)
        {
            view.InputPriceTextBox.TextBoxEnter();
        }
        private void KeyWordsEnter(object? sender, EventArgs e)
        {
            view.InputKeyWordsRichTextBox.TextBoxKeyEnter();
        }
        private void NameEnter(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxEnter();
        }

        private void Back(object? sender, EventArgs e)
        {
            this.view.Close();
        }
        private void AddProduct(object? sender, EventArgs e)
        {
            if (IsInputNewProductCorrect())
            {
                model.AddProduct(view.InputNameTextBox.Text, view.InputPriceTextBox.Text, (string)view.CategoryComboBox.SelectedItem,
                    view.InputImagePathTextBox.Text, view.InputDescriptionRichTextBox.Text, view.InputKeyWordsRichTextBox);

                this.view.Close();
            }
        }
        private bool IsInputNewProductCorrect()
        {
            if (model.IsInputEmpty(view.InputNameTextBox.Text, view.InputPriceTextBox.Text,
                view.CategoryComboBox.SelectedItem))
            {
                MessageBox.Show("Fill in name, price and select category!");
                return false;
            }
            else if (model.IsPriceInputCorrect(view.InputPriceTextBox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Price input incorrectly!");
                return false;
            }
        }
    }
}


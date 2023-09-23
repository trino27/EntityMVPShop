using ShopMVP.Database.Entities;
using ShopMVP.Extensions;
using ShopMVP.MVP.Models;
using ShopMVP.MVP.Views;

namespace ShopMVP.MVP.Presenters
{
    internal class PresenterAdminCategories
    {
        ModelCategory model = null;
        ViewAdminCategories view = null;
        Category currentCategory;

        public PresenterAdminCategories(ViewAdminCategories form)
        {
            model = new ModelCategory();
            view = form;
            view.FormLoad += new EventHandler(FormLoad);

            view.SwapRight += new EventHandler(SwapRight);
            view.SwapLeft += new EventHandler(SwapLeft);

            view.Add += new EventHandler(Add);
            view.Update += new EventHandler(Update);
            view.Delete += new EventHandler(Delete);
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
            view.OutputId = currentCategory.CategoryId.ToString();
            view.OutputName = currentCategory.Name;
            LoadTableLayout();
        }
        private void EmptyDataOutput()
        {
            view.OutputId = "No Data";
            view.OutputName = "No Data";
        }
        private void UpdateNumberLabel()
        {
            if (!model.IsCategoryDataEmpty() && currentCategory != null)
            {
                view.LabelNumber.LabelNumberUpdate(currentCategory.Number + 1, model.GetLastCategoryNumber());
            }
            else
            {
                view.LabelNumber.LabelNumberUpdate(0, model.GetLastCategoryNumber());
            }
        }
        private void LoadTableLayout()
        {
            this.view.TableLayoutPanel.Controls.Clear();
            List<(string id, string name)> currentCategoryTable = this.model.LoadCategoryInfoToTableLayoutPanel(currentCategory);
            Label labelNumber = new Label();
            labelNumber.Text = "N";
            this.view.TableLayoutPanel.Controls.Add(labelNumber, 0, 0);

            Label labelId = new Label();
            labelId.Text = "id";
            this.view.TableLayoutPanel.Controls.Add(labelId, 1, 0);

            Label labelName = new Label();
            labelName.Text = "Name";
            this.view.TableLayoutPanel.Controls.Add(labelName, 2, 0);

            for (int i = 0; i < currentCategoryTable.Count; i++)
            {
                int rowIndex = this.view.TableLayoutPanel.RowCount++;
                Label labelNumberValue = new Label();
                labelNumberValue.Text = (i + 1).ToString(); 
                this.view.TableLayoutPanel.Controls.Add(labelNumberValue, 0, i + 1);

                Label labelIdValue = new Label();
                labelIdValue.Text = currentCategoryTable[i].id;
                this.view.TableLayoutPanel.Controls.Add(labelIdValue, 1, i + 1);

                Label labelNameValue = new Label();
                labelNameValue.Text = currentCategoryTable[i].name;
                this.view.TableLayoutPanel.Controls.Add(labelNameValue, 2, i + 1);
            }
        }

        private void Add(object? sender, EventArgs e)
        {
            ViewAdminCategoriesAdd addCategory = new ViewAdminCategoriesAdd();
            addCategory.ShowDialog();
            UpdateNumberLabel();
            Output();

        }
        private void Delete(object? sender, EventArgs e)
        {
            if (!model.IsCategoryDataEmpty())
            {
                if (model.IsCategoryEmpty(currentCategory))
                {
                    long currentNumber = currentCategory.Number;
                    model.DeleteCategory(currentCategory);

                    if (!model.IsCategoryDataEmpty())
                    {
                        currentCategory = model.LoadCategory(currentNumber);
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
                    MessageBox.Show("You can`t delete category  which contains products");
                }
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Category");
            }
        }
        private void Update(object? sender, EventArgs e)
        {
            if (!model.IsCategoryDataEmpty())
            {
                ViewAdminCategoriesUpdate updateCategory = new ViewAdminCategoriesUpdate(currentCategory);
                updateCategory.ShowDialog();
                currentCategory = model.LoadCategory(currentCategory.Number);
                Output();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Category");
            }
        }

        private void SwapLeft(object? sender, EventArgs e)
        {
            if (!model.IsCategoryDataEmpty())
            {
                if (currentCategory.Number == 0)
                {
                    currentCategory = model.LoadLastCategory();
                }
                else currentCategory = model.LoadCategory(currentCategory.Number - 1);

                Output();
                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Category");
            }
        }
        private void SwapRight(object? sender, EventArgs e)
        {
            if (!model.IsCategoryDataEmpty())
            {
                currentCategory = model.LoadCategory(currentCategory.Number + 1);

                Output();
                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 Category");
            }
        }

        private void FormLoad(object? sender, EventArgs e)
        {
            if (!model.IsCategoryDataEmpty())
            {
                currentCategory = model.LoadCategory(0);

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

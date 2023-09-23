using ShopMVP.Extensions;
using ShopMVP.MVP.Models;
using ShopMVP.MVP.Views;

namespace ShopMVP.MVP.Presenters
{
    internal class PresenterAdminCategoriesUpdate
    {
        ModelCategory model = null;
        ViewAdminCategoriesUpdate view = null;

        public PresenterAdminCategoriesUpdate(ViewAdminCategoriesUpdate form)
        {
            model = new ModelCategory();
            view = form;

            view.Back += new EventHandler(Back);

            view.NameEnter += new EventHandler(NameEnter);
            view.Update += new EventHandler(UpdateCategory);
            view.NameLeave += new EventHandler(NameLeave);
            view.FormLoad += new EventHandler(FormLoad);
        }

        private void FormLoad(object? sender, EventArgs e)
        {
            Output();
        }
        private void Output()
        {
            view.InputNameTextBox.Text = view.Category.Name;
        }
        private void NameLeave(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxLeave();
        }
        private void NameEnter(object? sender, EventArgs e)
        {
            view.InputNameTextBox.ForeColor = Color.Black;
            view.InputNameTextBox.TextBoxEnter();
        }

        private bool IsInputUpdateCategoryCorrect()
        {
            if (model.IsInputEmpty(view.InputNameTextBox.Text))
            {
                MessageBox.Show("Fill in all the fields!");
                return false;
            }
            else
            if (model.IsNameUnique(view.InputNameTextBox.Text)
                        || view.InputNameTextBox.Text == this.view.Category.Name)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login already in use");
                return false;
            }

        }

        private void UpdateCategory(object? sender, EventArgs e)
        {
            if (IsInputUpdateCategoryCorrect())
            {
                if (!model.IsCategoryDataEmpty())
                {
                    model.UpdateCategory(this.view.Category, view.InputNameTextBox.Text);
                    CategoryInputWaiting();
                    this.view.Close();
                }
                else
                {
                    MessageBox.Show("Category isn't exist");
                }
            }
        }
        private void Back(object? sender, EventArgs e)
        {
            this.view.Close();
        }

        private void CategoryInputWaiting()
        {
            view.InputNameTextBox.TextBoxWaiting();
        }
    }
}

using ShopMVP.Extensions;
using ShopMVP.MVP.Models;
using ShopMVP.MVP.Views;

namespace ShopMVP.MVP.Presenters
{
    internal class PresenterAdminCategoriesAdd
    {
        ModelCategory model = null;
        ViewAdminCategoriesAdd view = null;

        public PresenterAdminCategoriesAdd(ViewAdminCategoriesAdd form)
        {
            model = new ModelCategory();
            view = form;

            view.Add += new EventHandler(AddCategory);
            view.Back += new EventHandler(Back);

            view.NameEnter += new EventHandler(NameEnter);
            view.NameLeave += new EventHandler(NameLeave);
        }

        private void NameLeave(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxLeave();
        }
        private void NameEnter(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxEnter();
        }

        private void Back(object? sender, EventArgs e)
        {
            this.view.Close();
        }
        private void AddCategory(object? sender, EventArgs e)
        {
            if (IsInputNewCategoryCorrect())
            {
                model.AddCategory(view.InputNameTextBox.Text);

                this.view.Close();
            }
        }
        private bool IsInputNewCategoryCorrect()
        {
            if (model.IsInputEmpty(view.InputNameTextBox.Text))
            {
                MessageBox.Show("Fill in all the fields!");
                return false;
            }
            else if (model.IsNameUnique(view.InputNameTextBox.Text)) return true;
            else
            {
                MessageBox.Show("Category already exists");
                return false;
            }

        }
    }
}

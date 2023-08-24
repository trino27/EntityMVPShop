using CyberHW1_5.MVP.Models;
using CyberHW1_5.MVP.Views;

namespace CyberHW1_5.MVP.Presenters
{
    internal class PresenterAdminMenu
    {
        ModelUser model = null;
        ViewAdminMenu view = null;

        public PresenterAdminMenu(ViewAdminMenu form)
        {
            model = new ModelUser();
            view = form;

            view.Users += new EventHandler(LoadUsers);
            view.Products += new EventHandler(LoadProducts);
            view.Back += new EventHandler(Back);
            view.Categories += new EventHandler(LoadCategories);
        }

        private void LoadCategories(object? sender, EventArgs e)
        {
            ViewAdminCategories viewCategories = new ViewAdminCategories();
            viewCategories.Show();
            this.view.Hide();
        }

        private void Back(object? sender, EventArgs e)
        {
            ViewStart viewStart = new ViewStart();
            viewStart.Show();
            this.view.Hide();
        }

        private void LoadProducts(object? sender, EventArgs e)
        {
            ViewAdminProducts viewProd = new ViewAdminProducts();
            viewProd.Show();
            this.view.Hide();
        }

        private void LoadUsers(object? sender, EventArgs e)
        {
            ViewAdminUser User = new ViewAdminUser();
            User.Show();
            this.view.Hide();
        }
    }
}

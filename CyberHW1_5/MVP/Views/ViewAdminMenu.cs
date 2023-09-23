using ShopMVP.MVP.Presenters;
using System;
using System.Collections.Generic;

namespace ShopMVP.MVP.Views
{
    public partial class ViewAdminMenu : Form
    {
        public ViewAdminMenu()
        {
            InitializeComponent();
            new PresenterAdminMenu(this);
        }

        public event EventHandler Users = null;
        public event EventHandler Products = null;
        public event EventHandler Categories = null;

        public event EventHandler Back = null;

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Users.Invoke(sender, e);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Products.Invoke(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void ViewAdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewStart viewStart = new ViewStart();
            viewStart.Show();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            Categories.Invoke(sender, e);
        }
    }
}

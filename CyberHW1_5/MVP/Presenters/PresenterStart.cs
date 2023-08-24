 using CyberHW1_5.Database.Entities;
using CyberHW1_5.Extensions;
using CyberHW1_5.MVP.Models;
using CyberHW1_5.MVP.Views;

namespace CyberHW1_5.MVP.Presenters
{
    internal class PresenterStart
    {
        ModelUser model = null;
        ViewStart view = null;
       
        public PresenterStart(ViewStart form)
        {
            model = new ModelUser();
            view = form;

            view.SignUp += new EventHandler(SignUp);
            view.SignIn += new EventHandler(SignIn);

            view.LoginEnter += new EventHandler(LoginEnter);
            view.PasswordEnter += new EventHandler(PasswordEnter);

            view.LoginLeave += new EventHandler(LoginLeave);
            view.PasswordLeave += new EventHandler(PasswordLeave);

            view.Visible += new EventHandler(PasswordVisible);
            view.Admin += new EventHandler(LoadAdmin);
        }
        private void LoadAdmin(object? sender, EventArgs e)
        {
            ViewAdminMenu adminMenu = new ViewAdminMenu();
            adminMenu.Show();
            this.view.Hide();
        }

        private void PasswordVisible(object? sender, EventArgs e)
        {
            this.view.InputPasswordTextBox.UseSystemPasswordChar = !this.view.InputPasswordTextBox.UseSystemPasswordChar;
        }

        private void SignIn(object? sender, EventArgs e)
        {
            if(this.model.IsInputEmpty(this.view.InputLoginTextBox.Text, view.InputPasswordTextBox.Text)) 
            {
                MessageBox.Show("Fill in all the fields!");
            }else if(this.model.IsUserExist(this.view.InputLoginTextBox.Text))
            {
                if(this.model.IsSignInAllow(this.view.InputLoginTextBox.Text, this.view.InputPasswordTextBox.Text))
                {
                    User currentUser = model.LoadUser(this.view.InputLoginTextBox.Text, this.view.InputPasswordTextBox.Text);
                    if (currentUser != null)
                    {
                        ViewShop shop = new ViewShop(currentUser);
                        shop.Show();
                        this.view.Hide();
                    }else
                    {
                        MessageBox.Show("Something go wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Password wrong");
                }
            }
            else
            {
                MessageBox.Show("User isn't exist!");
            }
           
        }

        private void SignUp(object? sender, EventArgs e)
        {
            ViewRegistration registration = new ViewRegistration();
            registration.ShowDialog();
        }

        private void PasswordEnter(object? sender, EventArgs e)
        {
            view.InputPasswordTextBox.TextBoxEnter();
        }
        private void LoginEnter(object? sender, EventArgs e)
        {
            view.InputLoginTextBox.TextBoxEnter();
        }
        private void PasswordLeave(object? sender, EventArgs e)
        {
            view.InputPasswordTextBox.TextBoxLeave();
        }
        private void LoginLeave(object? sender, EventArgs e)
        {
            view.InputLoginTextBox.TextBoxLeave();
        }

    }
}

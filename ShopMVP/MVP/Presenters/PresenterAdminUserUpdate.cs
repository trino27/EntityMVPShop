using ShopMVP.Database.Entities;
using ShopMVP.Extensions;
using ShopMVP.MVP.Models;
using ShopMVP.MVP.Views;

namespace ShopMVP.MVP.Presenters
{
    internal class PresenterAdminUserUpdate
    {
        ModelUser model = null;
        ViewAdminUserUpdate view = null;

        public PresenterAdminUserUpdate(ViewAdminUserUpdate form)
        {
            model = new ModelUser();
            view = form;

            view.UpdateUser += new EventHandler(UpdateUser);
            view.Back += new EventHandler(Back);

            view.NameEnter += new EventHandler(NameEnter);
            view.LoginEnter += new EventHandler(LoginEnter);
            view.PasswordEnter += new EventHandler(PasswordEnter);
            view.PhoneEnter += new EventHandler(PhoneEnter);

            view.NameLeave += new EventHandler(NameLeave);
            view.LoginLeave += new EventHandler(LoginLeave);
            view.PasswordLeave += new EventHandler(PasswordLeave);
            view.PhoneLeave += new EventHandler(PhoneLeave);

            view.FormLoad += new EventHandler(LoadUser);
        }

        private void LoadUser(object? sender, EventArgs e)
        {
            Output();
        }
        private void Output()
        {
            view.InputNameTextBox.Text = this.view.User.Name;
            view.InputPhoneTextBox.Text = this.view.User.Phone;
            view.InputLoginTextBox.Text = this.view.User.Login;
            view.InputPasswordTextBox.Text = this.view.User.Password;
        }
        private void PhoneLeave(object? sender, EventArgs e)
        {
            view.InputPhoneTextBox.TextBoxLeave();
        }
        private void PasswordLeave(object? sender, EventArgs e)
        {
            view.InputPasswordTextBox.TextBoxLeave();
        }
        private void LoginLeave(object? sender, EventArgs e)
        {
            view.InputLoginTextBox.TextBoxLeave();
        }
        private void NameLeave(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxLeave();
        }

        private void PhoneEnter(object? sender, EventArgs e)
        {
            view.InputPhoneTextBox.ForeColor = Color.Black;
            view.InputPhoneTextBox.TextBoxEnter();
        }
        private void PasswordEnter(object? sender, EventArgs e)
        {
            view.InputPasswordTextBox.ForeColor = Color.Black;
            view.InputPasswordTextBox.TextBoxEnter();
        }
        private void LoginEnter(object? sender, EventArgs e)
        {
            view.InputLoginTextBox.ForeColor = Color.Black;
            view.InputLoginTextBox.TextBoxEnter();
        }
        private void NameEnter(object? sender, EventArgs e)
        {
            view.InputNameTextBox.ForeColor = Color.Black;
            view.InputNameTextBox.TextBoxEnter();
        }

        private bool IsInputUpdateUserCorrect()
        {
            if (model.IsInputEmpty(view.InputNameTextBox.Text, view.InputLoginTextBox.Text,
                view.InputPasswordTextBox.Text, view.InputPhoneTextBox.Text))
            {
                MessageBox.Show("Fill in all the fields!");
                return false;
            }
            else if (model.IsPhoneInputCorrect(view.InputPhoneTextBox.Text))
            {
                if (model.IsPasswordInputCorrect(view.InputPasswordTextBox.Text))
                {
                    if (model.IsLoginUnique(view.InputLoginTextBox.Text)
                        || view.InputLoginTextBox.Text == this.view.User.Login)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Login already in use");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Password input incorrectly!\nPassword should contains at least 8 symbols\n" +
                        "at least 1 number, 1 lower case letter and 1 upper");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Phone input incorrectly!\n +380990000000");
                return false;
            }
        }
        
        private void UpdateUser(object? sender, EventArgs e)
        {
            if (IsInputUpdateUserCorrect())
            {
                if (!model.IsUserDataEmpty())
                {
                    model.UpdateUser(this.view.User, view.InputNameTextBox.Text, view.InputLoginTextBox.Text,
                    view.InputPasswordTextBox.Text, view.InputPhoneTextBox.Text);

                    UserInputWaiting();
                    this.view.Close();
                }
                else
                {
                    MessageBox.Show("User isn't exist");
                }
            }
        }
        private void Back(object? sender, EventArgs e)
        {
            this.view.Close();
        }
        
        private void UserInputWaiting()
        {
            view.InputLoginTextBox.TextBoxWaiting();
            view.InputNameTextBox.TextBoxWaiting();
            view.InputPasswordTextBox.TextBoxWaiting();
            view.InputPhoneTextBox.TextBoxWaiting();
        }
    }
}

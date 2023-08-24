using CyberHW1_5.Database.Entities;
using CyberHW1_5.Extensions;
using CyberHW1_5.MVP.Models;
using CyberHW1_5.MVP.Views;

namespace CyberHW1_5.MVP.Presenters
{
    internal class PresenterAdminUserAdd
    {
        ModelUser model = null;
        ViewAdminUserAdd view = null;

        public PresenterAdminUserAdd(ViewAdminUserAdd form)
        {
            model = new ModelUser();
            view = form;

            view.AddUser += new EventHandler(AddUser);
            view.Back += new EventHandler(Back);

            view.NameEnter += new EventHandler(NameEnter);
            view.LoginEnter += new EventHandler(LoginEnter);
            view.PasswordEnter += new EventHandler(PasswordEnter);
            view.PhoneEnter += new EventHandler(PhoneEnter);

            view.NameLeave += new EventHandler(NameLeave);
            view.LoginLeave += new EventHandler(LoginLeave);
            view.PasswordLeave += new EventHandler(PasswordLeave);
            view.PhoneLeave += new EventHandler(PhoneLeave);
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
            view.InputPhoneTextBox.TextBoxEnter();
        }
        private void PasswordEnter(object? sender, EventArgs e)
        {
            view.InputPasswordTextBox.TextBoxEnter();
        }
        private void LoginEnter(object? sender, EventArgs e)
        {
            view.InputLoginTextBox.TextBoxEnter();
        }
        private void NameEnter(object? sender, EventArgs e)
        {
            view.InputNameTextBox.TextBoxEnter();
        }

        private void Back(object? sender, EventArgs e)
        {
            this.view.Close();
        }
        private void AddUser(object? sender, EventArgs e)
        {
            if (IsInputNewUserCorrect())
            {
                model.AddUser(view.InputNameTextBox.Text, view.InputLoginTextBox.Text,
                    view.InputPasswordTextBox.Text, view.InputPhoneTextBox.Text);

                this.view.Close();
            }
        }
        private bool IsInputNewUserCorrect()
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
                    if (model.IsLoginUnique(view.InputLoginTextBox.Text)) return true;
                    else
                    {
                        MessageBox.Show("Login already in use");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Password input incorrectly!\nPassword should contains 8-20 symbols\n" +
                        "at least 1 number, 1 lower case letter and 1 upper");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Phone input incorrectly!\n +380991234567");
                return false;
            }
        }
    }
}

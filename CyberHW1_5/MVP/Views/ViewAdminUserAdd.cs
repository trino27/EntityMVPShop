using ShopMVP.MVP.Presenters;
using System;
using System.Collections.Generic;

namespace ShopMVP.MVP.Views
{
    public partial class ViewAdminUserAdd : Form
    {
        public ViewAdminUserAdd()
        {
            InitializeComponent();
            new PresenterAdminUserAdd(this);

        }
        public TextBox InputNameTextBox
        {
            get { return textBoxInputName; }
            set { textBoxInputName = value; }
        }
        public TextBox InputLoginTextBox
        {
            get { return textBoxInputLogin; }
            set { textBoxInputLogin = value; }
        }
        public TextBox InputPasswordTextBox
        {
            get { return textBoxInputPassword; }
            set { textBoxInputPassword = value; }
        }
        public TextBox InputPhoneTextBox
        {
            get { return textBoxInputPhone; }
            set { textBoxInputPhone = value; }
        }

        public event EventHandler NameEnter = null;
        public event EventHandler LoginEnter = null;
        public event EventHandler PhoneEnter = null;
        public event EventHandler PasswordEnter = null;

        public event EventHandler NameLeave = null;
        public event EventHandler LoginLeave = null;
        public event EventHandler PasswordLeave = null;
        public event EventHandler PhoneLeave = null;

        public event EventHandler AddUser = null;
        public event EventHandler Back = null;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser.Invoke(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void textBoxInputLogin_Enter(object sender, EventArgs e)
        {
            LoginEnter.Invoke(sender, e);
        }

        private void textBoxInputLogin_Leave(object sender, EventArgs e)
        {
            LoginLeave.Invoke(sender, e);
        }

        private void textBoxInputName_Enter(object sender, EventArgs e)
        {
            NameEnter.Invoke(sender, e);
        }

        private void textBoxInputName_Leave(object sender, EventArgs e)
        {
            NameLeave.Invoke(sender, e);
        }
        private void textBoxInputPhone_Enter(object sender, EventArgs e)
        {
            PhoneEnter.Invoke(sender, e);
        }

        private void textBoxInputPhone_Leave(object sender, EventArgs e)
        {
            PhoneLeave.Invoke(sender, e);
        }

        private void textBoxInputPassword_Enter(object sender, EventArgs e)
        {
            PasswordEnter.Invoke(sender, e);
        }

        private void textBoxInputPassword_Leave(object sender, EventArgs e)
        {
            PasswordLeave.Invoke(sender, e);
        }
    }
}

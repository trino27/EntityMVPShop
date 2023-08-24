using CyberHW1_5.MVP.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberHW1_5.MVP.Views
{
    public partial class ViewRegistration : Form
    {
        public ViewRegistration()
        {
            InitializeComponent();
            new PresenterRegistration(this);
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
        public TextBox InputRepeatPasswordTextBox
        {
            get { return textBoxInputRepeatPassword; }
            set { textBoxInputRepeatPassword = value; }
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
        public event EventHandler RepeatPasswordEnter = null;

        public event EventHandler NameLeave = null;
        public event EventHandler LoginLeave = null;
        public event EventHandler PasswordLeave = null;
        public event EventHandler RepeatPasswordLeave = null;
        public event EventHandler PhoneLeave = null;

        public event EventHandler AddUser = null;
        public event EventHandler Back = null;

        public event EventHandler Visible = null;
        public event EventHandler RepeatVisible = null;

        private void buttonConfirm_Click(object sender, EventArgs e)
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

        private void checkBoxVisible1_CheckedChanged(object sender, EventArgs e)
        {
            Visible.Invoke(sender, e);
        }

        private void checkBoxVisible2_CheckedChanged(object sender, EventArgs e)
        {
            RepeatVisible.Invoke(sender, e);
        }

        private void textBoxInputRepeatPassword_Enter(object sender, EventArgs e)
        {
            RepeatPasswordEnter.Invoke(sender, e);
        }

        private void textBoxInputRepeatPassword_Leave(object sender, EventArgs e)
        {
            RepeatPasswordLeave.Invoke(sender, e);
        }
    }
}

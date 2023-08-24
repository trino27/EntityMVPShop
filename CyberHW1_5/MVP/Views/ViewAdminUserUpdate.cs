using CyberHW1_5.Database.Entities;
using CyberHW1_5.MVP.Presenters;

namespace CyberHW1_5.MVP.Views
{
    public partial class ViewAdminUserUpdate : Form
    {
        public User User { get; set; }
        public ViewAdminUserUpdate(User user)
        {
            InitializeComponent();
            new PresenterAdminUserUpdate(this);
            this.User = user;
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

        public event EventHandler FormLoad = null;
        public event EventHandler UpdateUser = null;
        public event EventHandler Back = null;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser.Invoke(sender, e);
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

        private void ViewAdminUserUpdate_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}

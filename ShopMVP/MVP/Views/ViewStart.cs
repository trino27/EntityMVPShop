using ShopMVP.MVP.Presenters;

namespace ShopMVP.MVP.Views
{
    public partial class ViewStart : Form
    {
        public ViewStart()
        {
            InitializeComponent();
            new PresenterStart(this);
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

        public event EventHandler LoginEnter = null;
        public event EventHandler PasswordEnter = null;

        public event EventHandler LoginLeave = null;
        public event EventHandler PasswordLeave = null;

        public event EventHandler SignUp = null;
        public event EventHandler SignIn = null;

        public event EventHandler Admin = null;
        public event EventHandler Visible = null;

        private void textBoxInputLogin_Enter(object sender, EventArgs e)
        {
            LoginEnter.Invoke(sender, e);
        }

        private void textBoxInputLogin_Leave(object sender, EventArgs e)
        {
            LoginLeave.Invoke(sender, e);
        }

        private void textBoxInputPassword_Enter(object sender, EventArgs e)
        {
            PasswordEnter.Invoke(sender, e);
        }

        private void textBoxInputPassword_Leave(object sender, EventArgs e)
        {
            PasswordLeave.Invoke(sender, e);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn.Invoke(sender, e);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp.Invoke(sender, e);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin.Invoke(sender, e);
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            Visible.Invoke(sender, e);
        }

        private void ViewStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

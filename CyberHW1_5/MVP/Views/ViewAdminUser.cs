using CyberHW1_5.MVP.Presenters;
using CyberHW1_5.MVP.Views;

namespace CyberHW1_5
{
    public partial class ViewAdminUser : Form
    {
        public ViewAdminUser()
        {
            InitializeComponent();
            new PresenterAdminUser(this);
        }

        public Label LabelNumber
        {
            get { return labelNumber; }
            set { labelNumber = value; }
        }

        public string OutputId
        {
            get { return labelOutID.Text; }
            set { labelOutID.Text = value; }
        }
        public string OutputName
        {
            get { return labelOutName.Text; }
            set { labelOutName.Text = value; }
        }
        public string OutputLogin
        {
            get { return labelOutLogin.Text; }
            set { labelOutLogin.Text = value; }
        }
        public string OutputDate
        {
            get { return labelOutDate.Text; }
            set { labelOutDate.Text = value; }
        }
        public string OutputPhone
        {
            get { return labelOutPhone.Text; }
            set { labelOutPhone.Text = value; }
        }
        public string OutputPassword
        {
            get { return labelOutPassword.Text; }
            set { labelOutPassword.Text = value; }
        }

        public TableLayoutPanel TableLayoutPanel
        {
            get { return tableLayoutPanel; }
            set { tableLayoutPanel = value; }
        }

        public event EventHandler FormLoad = null;

        public event EventHandler SwapRight = null;
        public event EventHandler SwapLeft = null;
        public event EventHandler Back = null;

        public event EventHandler AddUser = null;
        public event EventHandler UpdateUser = null;
        public event EventHandler DeleteUser = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            SwapRight.Invoke(sender, e);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            SwapLeft.Invoke(sender, e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser.Invoke(sender, e);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser.Invoke(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteUser.Invoke(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void ViewAdminUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewStart viewStart = new ViewStart();
            viewStart.Show();
        }
    }
}
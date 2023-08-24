using CyberHW1_5.Database.Entities;
using CyberHW1_5.MVP.Presenters;

namespace CyberHW1_5.MVP.Views
{
    public partial class ViewUserHistory : Form
    {
        public User currentUser;
        public ViewUserHistory(User user)
        {
            InitializeComponent();
            new PresenterUserHistory(this);
            currentUser = user;
        }

        public event EventHandler Back = null;
        public event EventHandler FormLoad = null;

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void ViewUserHistory_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}




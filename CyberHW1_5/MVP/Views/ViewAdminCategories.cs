using CyberHW1_5.MVP.Presenters;

namespace CyberHW1_5.MVP.Views
{
    public partial class ViewAdminCategories : Form
    {
        public ViewAdminCategories()
        {
            InitializeComponent();
            new PresenterAdminCategories(this);
        }
        private void ViewAdminProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewStart viewStart = new ViewStart();
            viewStart.Show();
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

        public TableLayoutPanel TableLayoutPanel
        {
            get { return tableLayoutPanelProduct; }
            set { tableLayoutPanelProduct = value; }
        }

        public event EventHandler SwapRight = null;
        public event EventHandler SwapLeft = null;
        public event EventHandler Back = null;

        public event EventHandler Add = null;
        public event EventHandler Update = null;
        public event EventHandler Delete = null;
        public event EventHandler FormLoad = null;

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
            Add.Invoke(sender, e);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Update.Invoke(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete.Invoke(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void ViewAdminCategories_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}

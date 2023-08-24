using CyberHW1_5.Database.Entities;
using CyberHW1_5.MVP.Presenters;

namespace CyberHW1_5.MVP.Views
{
    public partial class ViewAdminCategoriesUpdate : Form
    {
        public Category Category { get; set; }
        public ViewAdminCategoriesUpdate(Category currentCategory)
        {
            InitializeComponent();
            new PresenterAdminCategoriesUpdate(this);
            this.Category = currentCategory;
        }
        public TextBox InputNameTextBox
        {
            get { return textBoxInputName; }
            set { textBoxInputName = value; }
        }
        public event EventHandler NameEnter = null;
        public event EventHandler NameLeave = null;
        public event EventHandler Update = null;
        public event EventHandler Back = null;
        public event EventHandler FormLoad = null;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Update.Invoke(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }
        private void textBoxInputName_Enter(object sender, EventArgs e)
        {
            NameEnter.Invoke(sender, e);
        }
        private void textBoxInputName_Leave(object sender, EventArgs e)
        {
            NameLeave.Invoke(sender, e);
        }

        private void ViewAdminCategoriesUpdate_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}

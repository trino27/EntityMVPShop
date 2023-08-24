using CyberHW1_5.MVP.Presenters;

namespace CyberHW1_5.MVP.Views
{
    public partial class ViewAdminProductsAdd : Form
    {
        public ViewAdminProductsAdd()
        {
            InitializeComponent();
            new PresenterAdminProductsAdd(this);
        }
        public PictureBox PictureBoxImage
        {
            get { return pictureBoxImage; }
            set { pictureBoxImage = value; }
        }
        public System.Windows.Forms.TextBox InputNameTextBox
        {
            get { return textBoxInputName; }
            set { textBoxInputName = value; }
        }
        public System.Windows.Forms.TextBox InputPriceTextBox
        {
            get { return textBoxInputPrice; }
            set { textBoxInputPrice = value; }
        }
        public System.Windows.Forms.ComboBox CategoryComboBox
        {
            get { return comboBoxCategory; }
            set { comboBoxCategory = value; }
        }
        public System.Windows.Forms.TextBox InputImagePathTextBox
        {
            get { return textBoxInputImagePath; }
            set { textBoxInputImagePath = value; }
        }
        public RichTextBox InputKeyWordsRichTextBox
        {
            get { return richTextBoxInputKeyWords; }
            set { richTextBoxInputKeyWords = value; }
        }
        public RichTextBox InputDescriptionRichTextBox
        {
            get { return richTextBoxInputDescription; }
            set { richTextBoxInputDescription = value; }
        }

        public event EventHandler NameEnter = null;
        public event EventHandler PriceEnter = null;
        public event EventHandler PathEnter = null;
        public event EventHandler KeyWordsEnter = null;

        public event EventHandler NameLeave = null;
        public event EventHandler PriceLeave = null;
        public event EventHandler PathLeave = null;
        public event EventHandler KeyWordsLeave = null;
        public event EventHandler ClearImage = null;


        public event EventHandler PriceTextChanged = null;
        public event EventHandler Folder = null;
        public event EventHandler AddProduct = null;
        public event EventHandler AddCategory = null;
        public event EventHandler Back = null;
        public event EventHandler FormLoad = null;

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            Folder.Invoke(sender, e);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddProduct.Invoke(sender, e);
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

        private void textBoxInputPrice_Enter(object sender, EventArgs e)
        {
            PriceEnter.Invoke(sender, e);
        }

        private void textBoxInputPrice_Leave(object sender, EventArgs e)
        {
            PriceLeave.Invoke(sender, e);
        }

        private void textBoxInputImagePath_Enter(object sender, EventArgs e)
        {
            PathEnter.Invoke(sender, e);
        }

        private void textBoxInputImagePath_Leave(object sender, EventArgs e)
        {
            PathLeave.Invoke(sender, e);
        }

        private void richTextBoxInputKeyWords_Leave(object sender, EventArgs e)
        {
            KeyWordsLeave.Invoke(sender, e);
        }

        private void richTextBoxInputKeyWords_Enter(object sender, EventArgs e)
        {
            KeyWordsEnter.Invoke(sender, e);
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory.Invoke(sender, e);
        }

        private void ViewAdminProductsAdd_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }

        private void buttonClearImage_Click(object sender, EventArgs e)
        {
            ClearImage.Invoke(sender, e);
        }

        private void textBoxInputPrice_TextChanged(object sender, EventArgs e)
        {
            PriceTextChanged.Invoke(sender, e);
        }

        private void textBoxInputImagePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PathLeave.Invoke(sender, e);
            }
        }
    }
}

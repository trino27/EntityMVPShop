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
    public partial class ViewAdminProducts : Form
    {
        public ViewAdminProducts()
        {
            InitializeComponent();
            new PresenterAdminProducts(this);
        }

        public Label LabelNumber
        {
            get { return labelNumber; }
            set { labelNumber = value; }
        }
        public PictureBox OutputPictureBox
        {
            get { return pictureBoxProductImage; }
            set { pictureBoxProductImage = value; }
        }

        public string OutputId
        {
            get { return labelOutProductID.Text; }
            set { labelOutProductID.Text = value; }
        }
        public string OutputName
        {
            get { return labelOutProductName.Text; }
            set { labelOutProductName.Text = value; }
        }
        public string OutputPrice
        {
            get { return labelOutProductPrice.Text; }
            set { labelOutProductPrice.Text = value; }
        }
        public string OutputCategory
        {
            get { return labelOutCategory.Text; }
            set { labelOutCategory.Text = value; }
        }
        public string OutputKeyWords
        {
            get { return richTextBoxProductKeyWords.Text; }
            set { richTextBoxProductKeyWords.Text = value; }
        }
        public string OutputDescription
        {
            get { return richTextBoxProductDescription.Text; }
            set { richTextBoxProductDescription.Text = value; }
        }

        public event EventHandler FormLoad = null;

        public event EventHandler SwapRight = null;
        public event EventHandler SwapLeft = null;
        public event EventHandler Back = null;

        public event EventHandler AddProduct = null;
        public event EventHandler UpdateProduct = null;
        public event EventHandler DeleteProduct = null;

        private void ViewAdminProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewStart viewStart = new ViewStart();
            viewStart.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            SwapLeft.Invoke(sender, e);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            SwapRight.Invoke(sender, e);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct.Invoke(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct.Invoke(sender, e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProduct.Invoke(sender, e);
        }

        private void ViewAdminProducts_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}

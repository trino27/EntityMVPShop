using ShopMVP.MVP.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMVP.MVP.Views
{
    public partial class ViewAdminCategoriesAdd : Form
    {
        public ViewAdminCategoriesAdd()
        {
            InitializeComponent();
            new PresenterAdminCategoriesAdd(this);
        }

        public TextBox InputNameTextBox
        {
            get { return textBoxInputName; }
            set { textBoxInputName = value; }
        }

        public event EventHandler NameEnter = null;
        public event EventHandler NameLeave = null;

        public event EventHandler Add = null;
        public event EventHandler Back = null;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add.Invoke(sender, e);
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
    }
}

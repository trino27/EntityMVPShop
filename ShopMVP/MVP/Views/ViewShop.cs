using ShopMVP.Database.Entities;
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
    public partial class ViewShop : Form
    {
        public User currentUser;
        public ViewShop(User user)
        {
            InitializeComponent();
            new PresenterShop(this);
            currentUser = user;
        }

        public RichTextBox RichTextBoxProductDescription1
        {
            get { return richTextBoxProductDescription1; }
            set { richTextBoxProductDescription1 = value; }
        }
        public RichTextBox RichTextBoxProductDescription2
        {
            get { return richTextBoxProductDescription2; }
            set { richTextBoxProductDescription2 = value; }
        }
        public RichTextBox RichTextBoxProductDescription3
        {
            get { return richTextBoxProductDescription3; }
            set { richTextBoxProductDescription3 = value; }
        }
        public RichTextBox RichTextBoxProductDescription4
        {
            get { return richTextBoxProductDescription4; }
            set { richTextBoxProductDescription4 = value; }
        }
        public RichTextBox RichTextBoxProductDescription5
        {
            get { return richTextBoxProductDescription5; }
            set { richTextBoxProductDescription5 = value; }
        }
        public RichTextBox RichTextBoxProductDescription6
        {
            get { return richTextBoxProductDescription6; }
            set { richTextBoxProductDescription6 = value; }
        }
        public RichTextBox RichTextBoxProductDescription7
        {
            get { return richTextBoxProductDescription7; }
            set { richTextBoxProductDescription7 = value; }
        }
        public RichTextBox RichTextBoxProductDescription8
        {
            get { return richTextBoxProductDescription8; }
            set { richTextBoxProductDescription8 = value; }
        }
        public RichTextBox RichTextBoxProductDescription9
        {
            get { return richTextBoxProductDescription9; }
            set { richTextBoxProductDescription9 = value; }
        }
        public RichTextBox RichTextBoxProductDescription10
        {
            get { return richTextBoxProductDescription10; }
            set { richTextBoxProductDescription10 = value; }
        }
        public RichTextBox RichTextBoxProductDescription11
        {
            get { return richTextBoxProductDescription11; }
            set { richTextBoxProductDescription11 = value; }
        }
        public RichTextBox RichTextBoxProductDescription12
        {
            get { return richTextBoxProductDescription12; }
            set { richTextBoxProductDescription12 = value; }
        }

        public GroupBox GroupBoxProduct1
        {
            get { return groupBoxProductSlot1; }
            set { groupBoxProductSlot1 = value; }
        }
        public GroupBox GroupBoxProduct2
        {
            get { return groupBoxProductSlot2; }
            set { groupBoxProductSlot2 = value; }
        }
        public GroupBox GroupBoxProduct3
        {
            get { return groupBoxProductSlot3; }
            set { groupBoxProductSlot3 = value; }
        }
        public GroupBox GroupBoxProduct4
        {
            get { return groupBoxProductSlot4; }
            set { groupBoxProductSlot4 = value; }
        }
        public GroupBox GroupBoxProduct5
        {
            get { return groupBoxProductSlot5; }
            set { groupBoxProductSlot5 = value; }
        }
        public GroupBox GroupBoxProduct6
        {
            get { return groupBoxProductSlot6; }
            set { groupBoxProductSlot6 = value; }
        }
        public GroupBox GroupBoxProduct7
        {
            get { return groupBoxProductSlot7; }
            set { groupBoxProductSlot7 = value; }
        }
        public GroupBox GroupBoxProduct8
        {
            get { return groupBoxProductSlot8; }
            set { groupBoxProductSlot8 = value; }
        }
        public GroupBox GroupBoxProduct9
        {
            get { return groupBoxProductSlot9; }
            set { groupBoxProductSlot9 = value; }
        }
        public GroupBox GroupBoxProduct10
        {
            get { return groupBoxProductSlot10; }
            set { groupBoxProductSlot10 = value; }
        }
        public GroupBox GroupBoxProduct11
        {
            get { return groupBoxProductSlot11; }
            set { groupBoxProductSlot11 = value; }
        }
        public GroupBox GroupBoxProduct12
        {
            get { return groupBoxProductSlot12; }
            set { groupBoxProductSlot12 = value; }
        }

        public PictureBox PictureBoxProduct1
        {
            get { return pictureBoxProduct1; }
            set { pictureBoxProduct1 = value; }
        }
        public PictureBox PictureBoxProduct2
        {
            get { return pictureBoxProduct2; }
            set { pictureBoxProduct2 = value; }
        }
        public PictureBox PictureBoxProduct3
        {
            get { return pictureBoxProduct3; }
            set { pictureBoxProduct3 = value; }
        }
        public PictureBox PictureBoxProduct4
        {
            get { return pictureBoxProduct4; }
            set { pictureBoxProduct4 = value; }
        }
        public PictureBox PictureBoxProduct5
        {
            get { return pictureBoxProduct5; }
            set { pictureBoxProduct5 = value; }
        }
        public PictureBox PictureBoxProduct6
        {
            get { return pictureBoxProduct6; }
            set { pictureBoxProduct6 = value; }
        }
        public PictureBox PictureBoxProduct7
        {
            get { return pictureBoxProduct7; }
            set { pictureBoxProduct7 = value; }
        }
        public PictureBox PictureBoxProduct8
        {
            get { return pictureBoxProduct8; }
            set { pictureBoxProduct8 = value; }
        }
        public PictureBox PictureBoxProduct9
        {
            get { return pictureBoxProduct9; }
            set { pictureBoxProduct9 = value; }
        }
        public PictureBox PictureBoxProduct10
        {
            get { return pictureBoxProduct10; }
            set { pictureBoxProduct10 = value; }
        }
        public PictureBox PictureBoxProduct11
        {
            get { return pictureBoxProduct11; }
            set { pictureBoxProduct11 = value; }
        }
        public PictureBox PictureBoxProduct12
        {
            get { return pictureBoxProduct12; }
            set { pictureBoxProduct12 = value; }
        }

        public Label LabelProductName1
        {
            get { return labelProductName1; }
            set { labelProductName1 = value; }
        }
        public Label LabelProductName2
        {
            get { return labelProductName2; }
            set { labelProductName2 = value; }
        }
        public Label LabelProductName3
        {
            get { return labelProductName3; }
            set { labelProductName3 = value; }
        }
        public Label LabelProductName4
        {
            get { return labelProductName4; }
            set { labelProductName4 = value; }
        }
        public Label LabelProductName5
        {
            get { return labelProductName5; }
            set { labelProductName5 = value; }
        }
        public Label LabelProductName6
        {
            get { return labelProductName6; }
            set { labelProductName6 = value; }
        }
        public Label LabelProductName7
        {
            get { return labelProductName7; }
            set { labelProductName7 = value; }
        }
        public Label LabelProductName8
        {
            get { return labelProductName8; }
            set { labelProductName8 = value; }
        }
        public Label LabelProductName9
        {
            get { return labelProductName9; }
            set { labelProductName9 = value; }
        }
        public Label LabelProductName10
        {
            get { return labelProductName10; }
            set { labelProductName10 = value; }
        }
        public Label LabelProductName11
        {
            get { return labelProductName11; }
            set { labelProductName11 = value; }
        }
        public Label LabelProductName12
        {
            get { return labelProductName12; }
            set { labelProductName12 = value; }
        }

        public Label LabelPrice1
        {
            get { return labelPrice1; }
            set { labelPrice1 = value; }
        }
        public Label LabelPrice2
        {
            get { return labelPrice2; }
            set { labelPrice2 = value; }
        }
        public Label LabelPrice3
        {
            get { return labelPrice3; }
            set { labelPrice3 = value; }
        }
        public Label LabelPrice4
        {
            get { return labelPrice4; }
            set { labelPrice4 = value; }
        }
        public Label LabelPrice5
        {
            get { return labelPrice5; }
            set { labelPrice5 = value; }
        }
        public Label LabelPrice6
        {
            get { return labelPrice6; }
            set { labelPrice6 = value; }
        }
        public Label LabelPrice7
        {
            get { return labelPrice7; }
            set { labelPrice7 = value; }
        }
        public Label LabelPrice8
        {
            get { return labelPrice8; }
            set { labelPrice8 = value; }
        }
        public Label LabelPrice9
        {
            get { return labelPrice9; }
            set { labelPrice9 = value; }
        }
        public Label LabelPrice10
        {
            get { return labelPrice10; }
            set { labelPrice10 = value; }
        }
        public Label LabelPrice11
        {
            get { return labelPrice11; }
            set { labelPrice11 = value; }
        }
        public Label LabelPrice12
        {
            get { return labelPrice12; }
            set { labelPrice12 = value; }
        }

        public Label LabelNumber
        {
            get { return labelTableNumber; }
            set { labelTableNumber = value; }
        }

        public ComboBox CategoryComboBox
        {
            get { return comboBoxCategory; }
            set { comboBoxCategory = value; }
        }

        public TextBox TextBoxSearch
        {
            get { return textBoxSearch; }
            set { textBoxSearch = value; }
        }

        public event EventHandler FormLoad = null;

        public event EventHandler SwapRight = null;
        public event EventHandler SwapLeft = null;
        public event EventHandler Back = null;

        public event EventHandler History = null;
        public event EventHandler Filter = null;
        public event EventHandler Search = null;
        public event EventHandler Clean = null;

        public event EventHandler Button1 = null;
        public event EventHandler Button2 = null;
        public event EventHandler Button3 = null;
        public event EventHandler Button4 = null;
        public event EventHandler Button5 = null;
        public event EventHandler Button6 = null;
        public event EventHandler Button7 = null;
        public event EventHandler Button8 = null;
        public event EventHandler Button9 = null;
        public event EventHandler Button10 = null;
        public event EventHandler Button11 = null;
        public event EventHandler Button12 = null;

        private void ViewShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back.Invoke(sender, e);
        }

        private void ViewShop_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            History.Invoke(sender, e);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter.Invoke(sender, e);
        }

        private void buttonProductBuy1_Click(object sender, EventArgs e)
        {
            Button1.Invoke(sender, e);
        }

        private void buttonProductBuy2_Click(object sender, EventArgs e)
        {
            Button2.Invoke(sender, e);
        }

        private void buttonProductBuy3_Click(object sender, EventArgs e)
        {
            Button3.Invoke(sender, e);
        }

        private void buttonProductBuy4_Click(object sender, EventArgs e)
        {
            Button4.Invoke(sender, e);
        }

        private void buttonProductBuy5_Click(object sender, EventArgs e)
        {
            Button5.Invoke(sender, e);
        }

        private void buttonProductBuy6_Click(object sender, EventArgs e)
        {
            Button6.Invoke(sender, e);
        }

        private void buttonProductBuy7_Click(object sender, EventArgs e)
        {
            Button7.Invoke(sender, e);
        }

        private void buttonProductBuy8_Click(object sender, EventArgs e)
        {
            Button8.Invoke(sender, e);
        }

        private void buttonProductBuy9_Click(object sender, EventArgs e)
        {
            Button9.Invoke(sender, e);
        }

        private void buttonProductBuy10_Click(object sender, EventArgs e)
        {
            Button10.Invoke(sender, e);
        }

        private void buttonProductBuy11_Click(object sender, EventArgs e)
        {
            Button11.Invoke(sender, e);
        }

        private void buttonProductBuy12_Click(object sender, EventArgs e)
        {
            Button12.Invoke(sender, e);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            SwapLeft.Invoke(sender, e);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            SwapRight.Invoke(sender, e);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search.Invoke(sender, e);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            Clean.Invoke(sender, e);
        }
    }
}

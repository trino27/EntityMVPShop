namespace CyberHW1_5.MVP.Views
{
    partial class ViewAdminProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            labelNumber = new Label();
            buttonRight = new Button();
            buttonBack = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonLeft = new Button();
            buttonUpdate = new Button();
            labelOutProductPrice = new Label();
            labelProductPrice = new Label();
            labelOutCategory = new Label();
            labelCategory = new Label();
            labelOutProductName = new Label();
            labelProductName = new Label();
            labelOutProductID = new Label();
            labelProductId = new Label();
            pictureBoxProductImage = new PictureBox();
            labelProductKey = new Label();
            richTextBoxProductKeyWords = new RichTextBox();
            labelProductDescription = new Label();
            richTextBoxProductDescription = new RichTextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(labelNumber);
            groupBox1.Controls.Add(buttonRight);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonLeft);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Location = new Point(6, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 252);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // labelNumber
            // 
            labelNumber.FlatStyle = FlatStyle.Popup;
            labelNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.Location = new Point(6, 13);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(258, 25);
            labelNumber.TabIndex = 45;
            labelNumber.Text = "0/0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRight
            // 
            buttonRight.BackColor = Color.BurlyWood;
            buttonRight.BackgroundImageLayout = ImageLayout.None;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRight.Location = new Point(136, 41);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(128, 42);
            buttonRight.TabIndex = 3;
            buttonRight.Text = ">>>>";
            buttonRight.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRight.UseVisualStyleBackColor = false;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Peru;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 187);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(258, 43);
            buttonBack.TabIndex = 44;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Orange;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(6, 137);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(258, 44);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add Product";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Orange;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(6, 89);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 42);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = Color.BurlyWood;
            buttonLeft.BackgroundImageLayout = ImageLayout.None;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLeft.Location = new Point(6, 41);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(128, 42);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "<<<<";
            buttonLeft.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLeft.UseVisualStyleBackColor = false;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Orange;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(136, 89);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(128, 42);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelOutProductPrice
            // 
            labelOutProductPrice.BackColor = Color.Tan;
            labelOutProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutProductPrice.Location = new Point(12, 159);
            labelOutProductPrice.Name = "labelOutProductPrice";
            labelOutProductPrice.Size = new Size(258, 26);
            labelOutProductPrice.TabIndex = 38;
            labelOutProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProductPrice
            // 
            labelProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductPrice.Location = new Point(12, 137);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(258, 26);
            labelProductPrice.TabIndex = 37;
            labelProductPrice.Text = "Price";
            labelProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutCategory
            // 
            labelOutCategory.BackColor = Color.Tan;
            labelOutCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutCategory.Location = new Point(12, 211);
            labelOutCategory.Name = "labelOutCategory";
            labelOutCategory.Size = new Size(258, 26);
            labelOutCategory.TabIndex = 32;
            labelOutCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            labelCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(12, 185);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(258, 26);
            labelCategory.TabIndex = 31;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutProductName
            // 
            labelOutProductName.BackColor = Color.Tan;
            labelOutProductName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutProductName.Location = new Point(12, 111);
            labelOutProductName.Name = "labelOutProductName";
            labelOutProductName.Size = new Size(258, 26);
            labelOutProductName.TabIndex = 30;
            labelOutProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            labelProductName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.Location = new Point(12, 85);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(258, 26);
            labelProductName.TabIndex = 29;
            labelProductName.Text = "Product Name";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutProductID
            // 
            labelOutProductID.BackColor = Color.Tan;
            labelOutProductID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutProductID.Location = new Point(12, 59);
            labelOutProductID.Name = "labelOutProductID";
            labelOutProductID.Size = new Size(258, 26);
            labelOutProductID.TabIndex = 28;
            labelOutProductID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProductId
            // 
            labelProductId.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductId.Location = new Point(12, 19);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(258, 26);
            labelProductId.TabIndex = 27;
            labelProductId.Text = "Product ID";
            labelProductId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.Anchor = AnchorStyles.None;
            pictureBoxProductImage.BackColor = SystemColors.AppWorkspace;
            pictureBoxProductImage.Location = new Point(223, 22);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(265, 274);
            pictureBoxProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProductImage.TabIndex = 39;
            pictureBoxProductImage.TabStop = false;
            // 
            // labelProductKey
            // 
            labelProductKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelProductKey.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductKey.Location = new Point(204, 27);
            labelProductKey.Name = "labelProductKey";
            labelProductKey.Size = new Size(315, 26);
            labelProductKey.TabIndex = 40;
            labelProductKey.Text = "KeyWords";
            labelProductKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxProductKeyWords
            // 
            richTextBoxProductKeyWords.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxProductKeyWords.Enabled = false;
            richTextBoxProductKeyWords.Location = new Point(6, 56);
            richTextBoxProductKeyWords.Name = "richTextBoxProductKeyWords";
            richTextBoxProductKeyWords.Size = new Size(697, 64);
            richTextBoxProductKeyWords.TabIndex = 41;
            richTextBoxProductKeyWords.Text = "";
            // 
            // labelProductDescription
            // 
            labelProductDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelProductDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductDescription.Location = new Point(204, 123);
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size(315, 26);
            labelProductDescription.TabIndex = 42;
            labelProductDescription.Text = "Description";
            labelProductDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxProductDescription
            // 
            richTextBoxProductDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxProductDescription.Enabled = false;
            richTextBoxProductDescription.Location = new Point(6, 153);
            richTextBoxProductDescription.Name = "richTextBoxProductDescription";
            richTextBoxProductDescription.Size = new Size(697, 181);
            richTextBoxProductDescription.TabIndex = 43;
            richTextBoxProductDescription.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(labelProductId);
            groupBox2.Controls.Add(labelOutProductID);
            groupBox2.Controls.Add(labelProductName);
            groupBox2.Controls.Add(labelOutProductName);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(labelProductPrice);
            groupBox2.Controls.Add(labelOutProductPrice);
            groupBox2.Controls.Add(labelCategory);
            groupBox2.Controls.Add(labelOutCategory);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 656);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.PaleGoldenrod;
            groupBox3.Controls.Add(richTextBoxProductDescription);
            groupBox3.Controls.Add(labelProductDescription);
            groupBox3.Controls.Add(richTextBoxProductKeyWords);
            groupBox3.Controls.Add(labelProductKey);
            groupBox3.Location = new Point(3, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(712, 340);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.BackColor = Color.Ivory;
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(pictureBoxProductImage);
            groupBox4.Location = new Point(282, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(718, 659);
            groupBox4.TabIndex = 46;
            groupBox4.TabStop = false;
            // 
            // ViewAdminProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 656);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Name = "ViewAdminProducts";
            Text = "ViewAdminProducts";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewAdminProducts_FormClosed;
            Load += ViewAdminProducts_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button buttonRight;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonLeft;
        private Button buttonUpdate;
        private Label labelOutProductPrice;
        private Label labelProductPrice;
        private Label labelOutCategory;
        private Label labelCategory;
        private Label labelOutProductName;
        private Label labelProductName;
        private Label labelOutProductID;
        private Label labelProductId;
        private PictureBox pictureBoxProductImage;
        private Label labelProductKey;
        private RichTextBox richTextBoxProductKeyWords;
        private Label labelProductDescription;
        private RichTextBox richTextBoxProductDescription;
        private Button buttonBack;
        private Label labelNumber;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
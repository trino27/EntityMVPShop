namespace CyberHW1_5.MVP.Views
{
    partial class ViewAdminProductsAdd
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
            buttonAdd = new Button();
            buttonBack = new Button();
            richTextBoxInputDescription = new RichTextBox();
            labelProductDescription = new Label();
            richTextBoxInputKeyWords = new RichTextBox();
            labelProductKey = new Label();
            labelProductPrice = new Label();
            labelImage = new Label();
            labelCategory = new Label();
            labelProductName = new Label();
            textBoxInputName = new TextBox();
            textBoxInputPrice = new TextBox();
            pictureBoxImage = new PictureBox();
            buttonFolder = new Button();
            labelImagePath = new Label();
            textBoxInputImagePath = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            comboBoxCategory = new ComboBox();
            buttonAddCategory = new Button();
            buttonClearImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Orange;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(276, 466);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(258, 44);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add Product";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonUpdate_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Peru;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 466);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(264, 43);
            buttonBack.TabIndex = 45;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // richTextBoxInputDescription
            // 
            richTextBoxInputDescription.Location = new Point(14, 297);
            richTextBoxInputDescription.Name = "richTextBoxInputDescription";
            richTextBoxInputDescription.Size = new Size(258, 152);
            richTextBoxInputDescription.TabIndex = 54;
            richTextBoxInputDescription.Text = "";
            // 
            // labelProductDescription
            // 
            labelProductDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductDescription.Location = new Point(14, 268);
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size(258, 26);
            labelProductDescription.TabIndex = 53;
            labelProductDescription.Text = "Description";
            labelProductDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxInputKeyWords
            // 
            richTextBoxInputKeyWords.ForeColor = Color.Gray;
            richTextBoxInputKeyWords.Location = new Point(14, 203);
            richTextBoxInputKeyWords.Name = "richTextBoxInputKeyWords";
            richTextBoxInputKeyWords.Size = new Size(258, 64);
            richTextBoxInputKeyWords.TabIndex = 52;
            richTextBoxInputKeyWords.Text = "#key...";
            richTextBoxInputKeyWords.Enter += richTextBoxInputKeyWords_Enter;
            richTextBoxInputKeyWords.Leave += richTextBoxInputKeyWords_Leave;
            // 
            // labelProductKey
            // 
            labelProductKey.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductKey.Location = new Point(12, 174);
            labelProductKey.Name = "labelProductKey";
            labelProductKey.Size = new Size(258, 26);
            labelProductKey.TabIndex = 51;
            labelProductKey.Text = "KeyWords";
            labelProductKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProductPrice
            // 
            labelProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductPrice.Location = new Point(14, 64);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(258, 26);
            labelProductPrice.TabIndex = 50;
            labelProductPrice.Text = "Price";
            labelProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelImage
            // 
            labelImage.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelImage.Location = new Point(276, 9);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(258, 26);
            labelImage.TabIndex = 49;
            labelImage.Text = "Image";
            labelImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            labelCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(14, 119);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(258, 26);
            labelCategory.TabIndex = 48;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            labelProductName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.Location = new Point(12, 9);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(258, 26);
            labelProductName.TabIndex = 47;
            labelProductName.Text = "Product Name";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputName
            // 
            textBoxInputName.ForeColor = Color.Gray;
            textBoxInputName.Location = new Point(14, 38);
            textBoxInputName.Name = "textBoxInputName";
            textBoxInputName.Size = new Size(256, 23);
            textBoxInputName.TabIndex = 56;
            textBoxInputName.Text = "Enter...";
            textBoxInputName.TextAlign = HorizontalAlignment.Center;
            textBoxInputName.Enter += textBoxInputName_Enter;
            textBoxInputName.Leave += textBoxInputName_Leave;
            // 
            // textBoxInputPrice
            // 
            textBoxInputPrice.ForeColor = Color.Gray;
            textBoxInputPrice.Location = new Point(14, 93);
            textBoxInputPrice.Name = "textBoxInputPrice";
            textBoxInputPrice.Size = new Size(256, 23);
            textBoxInputPrice.TabIndex = 57;
            textBoxInputPrice.Text = "Enter...";
            textBoxInputPrice.TextAlign = HorizontalAlignment.Center;
            textBoxInputPrice.TextChanged += textBoxInputPrice_TextChanged;
            textBoxInputPrice.Enter += textBoxInputPrice_Enter;
            textBoxInputPrice.Leave += textBoxInputPrice_Leave;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackColor = Color.MistyRose;
            pictureBoxImage.Location = new Point(278, 38);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(256, 256);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 59;
            pictureBoxImage.TabStop = false;
            // 
            // buttonFolder
            // 
            buttonFolder.BackColor = Color.DarkOrange;
            buttonFolder.FlatStyle = FlatStyle.Flat;
            buttonFolder.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFolder.Location = new Point(278, 355);
            buttonFolder.Name = "buttonFolder";
            buttonFolder.Size = new Size(256, 44);
            buttonFolder.TabIndex = 60;
            buttonFolder.Text = "Open Folder";
            buttonFolder.UseVisualStyleBackColor = false;
            buttonFolder.Click += buttonFolder_Click;
            // 
            // labelImagePath
            // 
            labelImagePath.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelImagePath.Location = new Point(276, 297);
            labelImagePath.Name = "labelImagePath";
            labelImagePath.Size = new Size(258, 26);
            labelImagePath.TabIndex = 61;
            labelImagePath.Text = " Image path";
            labelImagePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputImagePath
            // 
            textBoxInputImagePath.Enabled = false;
            textBoxInputImagePath.ForeColor = Color.Gray;
            textBoxInputImagePath.Location = new Point(278, 326);
            textBoxInputImagePath.Name = "textBoxInputImagePath";
            textBoxInputImagePath.Size = new Size(256, 23);
            textBoxInputImagePath.TabIndex = 62;
            textBoxInputImagePath.TextAlign = HorizontalAlignment.Center;
            textBoxInputImagePath.Enter += textBoxInputImagePath_Enter;
            textBoxInputImagePath.KeyPress += textBoxInputImagePath_KeyPress;
            textBoxInputImagePath.Leave += textBoxInputImagePath_Leave;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(14, 148);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(220, 23);
            comboBoxCategory.TabIndex = 63;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.BackColor = Color.Snow;
            buttonAddCategory.FlatStyle = FlatStyle.Popup;
            buttonAddCategory.Location = new Point(239, 148);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(33, 23);
            buttonAddCategory.TabIndex = 64;
            buttonAddCategory.Text = "+";
            buttonAddCategory.UseVisualStyleBackColor = false;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonClearImage
            // 
            buttonClearImage.BackColor = Color.DarkOrange;
            buttonClearImage.FlatStyle = FlatStyle.Flat;
            buttonClearImage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearImage.Location = new Point(278, 405);
            buttonClearImage.Name = "buttonClearImage";
            buttonClearImage.Size = new Size(256, 44);
            buttonClearImage.TabIndex = 65;
            buttonClearImage.Text = "Clear Image";
            buttonClearImage.UseVisualStyleBackColor = false;
            buttonClearImage.Click += buttonClearImage_Click;
            // 
            // ViewAdminProductsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(549, 520);
            Controls.Add(buttonClearImage);
            Controls.Add(buttonAddCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxInputImagePath);
            Controls.Add(labelImagePath);
            Controls.Add(buttonFolder);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBoxInputPrice);
            Controls.Add(textBoxInputName);
            Controls.Add(richTextBoxInputDescription);
            Controls.Add(labelProductDescription);
            Controls.Add(richTextBoxInputKeyWords);
            Controls.Add(labelProductKey);
            Controls.Add(labelProductPrice);
            Controls.Add(labelImage);
            Controls.Add(labelCategory);
            Controls.Add(labelProductName);
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ViewAdminProductsAdd";
            Text = "ViewAdminProductsAdd";
            Load += ViewAdminProductsAdd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonBack;
        private RichTextBox richTextBoxInputDescription;
        private Label labelProductDescription;
        private RichTextBox richTextBoxInputKeyWords;
        private Label labelProductKey;
        private Label labelProductPrice;
        private Label labelImage;
        private Label labelCategory;
        private Label labelProductName;
        private TextBox textBoxInputName;
        private TextBox textBoxInputPrice;
        private PictureBox pictureBoxImage;
        private Button buttonFolder;
        private Label labelImagePath;
        private TextBox textBoxInputImagePath;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox comboBoxCategory;
        private Button buttonAddCategory;
        private Button buttonClearImage;
    }
}
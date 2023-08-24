namespace CyberHW1_5.MVP.Views
{
    partial class ViewAdminProductsUpdate
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
            labelProductName = new Label();
            textBoxInputName = new TextBox();
            labelProductPrice = new Label();
            textBoxInputPrice = new TextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            buttonAddCategory = new Button();
            labelProductKey = new Label();
            richTextBoxInputKeyWords = new RichTextBox();
            labelProductDescription = new Label();
            richTextBoxInputDescription = new RichTextBox();
            labelImage = new Label();
            pictureBoxImage = new PictureBox();
            labelImagePath = new Label();
            textBoxInputImagePath = new TextBox();
            buttonFolder = new Button();
            buttonClearImage = new Button();
            buttonBack = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // labelProductName
            // 
            labelProductName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.Location = new Point(12, 9);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(258, 26);
            labelProductName.TabIndex = 48;
            labelProductName.Text = "Product Name";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputName
            // 
            textBoxInputName.ForeColor = Color.Gray;
            textBoxInputName.Location = new Point(12, 38);
            textBoxInputName.Name = "textBoxInputName";
            textBoxInputName.Size = new Size(258, 23);
            textBoxInputName.TabIndex = 57;
            textBoxInputName.Text = "Enter...";
            textBoxInputName.TextAlign = HorizontalAlignment.Center;
            textBoxInputName.Enter += textBoxInputName_Enter;
            textBoxInputName.Leave += textBoxInputName_Leave;
            // 
            // labelProductPrice
            // 
            labelProductPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductPrice.Location = new Point(12, 64);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(258, 26);
            labelProductPrice.TabIndex = 58;
            labelProductPrice.Text = "Price";
            labelProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputPrice
            // 
            textBoxInputPrice.ForeColor = Color.Gray;
            textBoxInputPrice.Location = new Point(12, 93);
            textBoxInputPrice.Name = "textBoxInputPrice";
            textBoxInputPrice.Size = new Size(258, 23);
            textBoxInputPrice.TabIndex = 59;
            textBoxInputPrice.Text = "Enter...";
            textBoxInputPrice.TextAlign = HorizontalAlignment.Center;
            textBoxInputPrice.TextChanged += textBoxInputPrice_TextChanged;
            textBoxInputPrice.Enter += textBoxInputPrice_Enter;
            textBoxInputPrice.Leave += textBoxInputPrice_Leave;
            // 
            // labelCategory
            // 
            labelCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(12, 119);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(256, 26);
            labelCategory.TabIndex = 60;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 148);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(220, 23);
            comboBoxCategory.TabIndex = 64;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(235, 147);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(35, 24);
            buttonAddCategory.TabIndex = 65;
            buttonAddCategory.Text = "+";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // labelProductKey
            // 
            labelProductKey.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductKey.Location = new Point(10, 174);
            labelProductKey.Name = "labelProductKey";
            labelProductKey.Size = new Size(258, 26);
            labelProductKey.TabIndex = 66;
            labelProductKey.Text = "KeyWords";
            labelProductKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxInputKeyWords
            // 
            richTextBoxInputKeyWords.ForeColor = Color.Gray;
            richTextBoxInputKeyWords.Location = new Point(12, 203);
            richTextBoxInputKeyWords.Name = "richTextBoxInputKeyWords";
            richTextBoxInputKeyWords.Size = new Size(258, 64);
            richTextBoxInputKeyWords.TabIndex = 67;
            richTextBoxInputKeyWords.Text = "#key...";
            richTextBoxInputKeyWords.Enter += richTextBoxInputKeyWords_Enter;
            richTextBoxInputKeyWords.Leave += richTextBoxInputKeyWords_Leave;
            // 
            // labelProductDescription
            // 
            labelProductDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductDescription.Location = new Point(12, 270);
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size(258, 26);
            labelProductDescription.TabIndex = 68;
            labelProductDescription.Text = "Description";
            labelProductDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxInputDescription
            // 
            richTextBoxInputDescription.Location = new Point(12, 299);
            richTextBoxInputDescription.Name = "richTextBoxInputDescription";
            richTextBoxInputDescription.Size = new Size(258, 152);
            richTextBoxInputDescription.TabIndex = 69;
            richTextBoxInputDescription.Text = "";
            // 
            // labelImage
            // 
            labelImage.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelImage.Location = new Point(276, 9);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(258, 26);
            labelImage.TabIndex = 70;
            labelImage.Text = "Image";
            labelImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(276, 38);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(256, 256);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 71;
            pictureBoxImage.TabStop = false;
            // 
            // labelImagePath
            // 
            labelImagePath.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelImagePath.Location = new Point(276, 299);
            labelImagePath.Name = "labelImagePath";
            labelImagePath.Size = new Size(258, 26);
            labelImagePath.TabIndex = 72;
            labelImagePath.Text = " Image path";
            labelImagePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputImagePath
            // 
            textBoxInputImagePath.ForeColor = Color.Gray;
            textBoxInputImagePath.Location = new Point(276, 328);
            textBoxInputImagePath.Name = "textBoxInputImagePath";
            textBoxInputImagePath.Size = new Size(258, 23);
            textBoxInputImagePath.TabIndex = 73;
            textBoxInputImagePath.Text = "Enter...";
            textBoxInputImagePath.TextAlign = HorizontalAlignment.Center;
            textBoxInputImagePath.Enter += textBoxInputImagePath_Enter;
            textBoxInputImagePath.Leave += textBoxInputImagePath_Leave;
            // 
            // buttonFolder
            // 
            buttonFolder.BackColor = Color.SkyBlue;
            buttonFolder.FlatStyle = FlatStyle.Flat;
            buttonFolder.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFolder.Location = new Point(276, 357);
            buttonFolder.Name = "buttonFolder";
            buttonFolder.Size = new Size(258, 44);
            buttonFolder.TabIndex = 74;
            buttonFolder.Text = "Open Folder";
            buttonFolder.UseVisualStyleBackColor = false;
            buttonFolder.Click += buttonFolder_Click;
            // 
            // buttonClearImage
            // 
            buttonClearImage.BackColor = Color.SkyBlue;
            buttonClearImage.FlatStyle = FlatStyle.Flat;
            buttonClearImage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearImage.Location = new Point(276, 407);
            buttonClearImage.Name = "buttonClearImage";
            buttonClearImage.Size = new Size(258, 44);
            buttonClearImage.TabIndex = 75;
            buttonClearImage.Text = "Clear Image";
            buttonClearImage.UseVisualStyleBackColor = false;
            buttonClearImage.Click += buttonClearImage_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.SteelBlue;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 457);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(258, 43);
            buttonBack.TabIndex = 76;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DeepSkyBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(276, 456);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(258, 44);
            buttonUpdate.TabIndex = 77;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ViewAdminProductsUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(545, 513);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonBack);
            Controls.Add(buttonClearImage);
            Controls.Add(buttonFolder);
            Controls.Add(textBoxInputImagePath);
            Controls.Add(labelImagePath);
            Controls.Add(pictureBoxImage);
            Controls.Add(labelImage);
            Controls.Add(richTextBoxInputDescription);
            Controls.Add(labelProductDescription);
            Controls.Add(richTextBoxInputKeyWords);
            Controls.Add(labelProductKey);
            Controls.Add(buttonAddCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(textBoxInputPrice);
            Controls.Add(labelProductPrice);
            Controls.Add(textBoxInputName);
            Controls.Add(labelProductName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAdminProductsUpdate";
            Text = "ViewAdminProductsUpdate";
            Load += ViewAdminProductsUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProductName;
        private TextBox textBoxInputName;
        private Label labelProductPrice;
        private TextBox textBoxInputPrice;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Button buttonAddCategory;
        private Label labelProductKey;
        private RichTextBox richTextBoxInputKeyWords;
        private Label labelProductDescription;
        private RichTextBox richTextBoxInputDescription;
        private Label labelImage;
        private PictureBox pictureBoxImage;
        private Label labelImagePath;
        private TextBox textBoxInputImagePath;
        private Button buttonFolder;
        private Button buttonClearImage;
        private Button buttonBack;
        private Button buttonUpdate;
    }
}
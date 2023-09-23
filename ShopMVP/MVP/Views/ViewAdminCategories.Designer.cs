namespace ShopMVP.MVP.Views
{
    partial class ViewAdminCategories
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
            buttonBack = new Button();
            groupBoxMenu = new GroupBox();
            labelNumber = new Label();
            buttonRight = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonLeft = new Button();
            buttonUpdate = new Button();
            labelOutName = new Label();
            labelName = new Label();
            labelOutID = new Label();
            labelID = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanelProduct = new TableLayoutPanel();
            groupBoxMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Peru;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 186);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(264, 46);
            buttonBack.TabIndex = 39;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = Color.Tan;
            groupBoxMenu.Controls.Add(buttonBack);
            groupBoxMenu.Controls.Add(labelNumber);
            groupBoxMenu.Controls.Add(buttonRight);
            groupBoxMenu.Controls.Add(buttonAdd);
            groupBoxMenu.Controls.Add(buttonDelete);
            groupBoxMenu.Controls.Add(buttonLeft);
            groupBoxMenu.Controls.Add(buttonUpdate);
            groupBoxMenu.Location = new Point(7, 149);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(279, 238);
            groupBoxMenu.TabIndex = 27;
            groupBoxMenu.TabStop = false;
            // 
            // labelNumber
            // 
            labelNumber.FlatStyle = FlatStyle.Popup;
            labelNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.Location = new Point(6, 12);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(264, 24);
            labelNumber.TabIndex = 40;
            labelNumber.Text = "0/0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRight
            // 
            buttonRight.BackColor = Color.Bisque;
            buttonRight.BackgroundImageLayout = ImageLayout.None;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRight.Location = new Point(142, 39);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(128, 42);
            buttonRight.TabIndex = 3;
            buttonRight.Text = ">>>>";
            buttonRight.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRight.UseVisualStyleBackColor = false;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Orange;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(6, 135);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(264, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add Category";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Orange;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(6, 87);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 42);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = Color.Bisque;
            buttonLeft.BackgroundImageLayout = ImageLayout.None;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLeft.Location = new Point(6, 39);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(130, 42);
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
            buttonUpdate.Location = new Point(142, 87);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(128, 42);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelOutName
            // 
            labelOutName.BackColor = Color.DarkSeaGreen;
            labelOutName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutName.Location = new Point(20, 99);
            labelOutName.Name = "labelOutName";
            labelOutName.Size = new Size(259, 26);
            labelOutName.TabIndex = 30;
            labelOutName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(20, 71);
            labelName.Name = "labelName";
            labelName.Size = new Size(259, 26);
            labelName.TabIndex = 29;
            labelName.Text = "Category";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutID
            // 
            labelOutID.BackColor = Color.DarkSeaGreen;
            labelOutID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutID.Location = new Point(20, 45);
            labelOutID.Name = "labelOutID";
            labelOutID.Size = new Size(259, 26);
            labelOutID.TabIndex = 28;
            labelOutID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            labelID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(21, 19);
            labelID.Name = "labelID";
            labelID.Size = new Size(258, 26);
            labelID.TabIndex = 26;
            labelID.Text = "Category ID";
            labelID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(groupBoxMenu);
            groupBox1.Controls.Add(labelOutName);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(labelOutID);
            groupBox1.Controls.Add(labelName);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 722);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanelProduct
            // 
            tableLayoutPanelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelProduct.ColumnCount = 3;
            tableLayoutPanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelProduct.Location = new Point(298, 6);
            tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            tableLayoutPanelProduct.RowCount = 1;
            tableLayoutPanelProduct.RowStyles.Add(new RowStyle());
            tableLayoutPanelProduct.Size = new Size(699, 705);
            tableLayoutPanelProduct.TabIndex = 32;
            // 
            // ViewAdminCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1009, 722);
            Controls.Add(tableLayoutPanelProduct);
            Controls.Add(groupBox1);
            Name = "ViewAdminCategories";
            Text = "ViewAdminCategories";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewAdminProducts_FormClosed;
            Load += ViewAdminCategories_Load;
            groupBoxMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBoxMenu;
        private Button buttonRight;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonLeft;
        private Button buttonUpdate;
        private Label labelOutName;
        private Label labelName;
        private Label labelOutID;
        private Label labelID;
        private Label labelNumber;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanelProduct;
    }
}
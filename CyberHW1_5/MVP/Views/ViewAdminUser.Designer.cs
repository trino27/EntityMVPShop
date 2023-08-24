namespace CyberHW1_5
{
    partial class ViewAdminUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLeft = new Button();
            labelID = new Label();
            groupBoxOut = new GroupBox();
            groupBoxMenu = new GroupBox();
            buttonBack = new Button();
            buttonRight = new Button();
            buttonAdd = new Button();
            labelNumber = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            labelOutPhone = new Label();
            labelPhone = new Label();
            labelOutPassword = new Label();
            labelPassword = new Label();
            labelOutDate = new Label();
            labelData = new Label();
            labelOutLogin = new Label();
            labelLogin = new Label();
            labelOutName = new Label();
            labelName = new Label();
            labelOutID = new Label();
            tableLayoutPanelProduct = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel = new TableLayoutPanel();
            groupBoxOut.SuspendLayout();
            groupBoxMenu.SuspendLayout();
            tableLayoutPanelProduct.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = Color.NavajoWhite;
            buttonLeft.BackgroundImageLayout = ImageLayout.None;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLeft.Location = new Point(7, 59);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(126, 42);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "<<<<";
            buttonLeft.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLeft.UseVisualStyleBackColor = false;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // labelID
            // 
            labelID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(12, 19);
            labelID.Name = "labelID";
            labelID.Size = new Size(258, 26);
            labelID.TabIndex = 3;
            labelID.Text = "User ID";
            labelID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxOut
            // 
            groupBoxOut.AutoSize = true;
            groupBoxOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxOut.BackColor = Color.DarkSeaGreen;
            groupBoxOut.Controls.Add(groupBoxMenu);
            groupBoxOut.Controls.Add(labelOutPhone);
            groupBoxOut.Controls.Add(labelPhone);
            groupBoxOut.Controls.Add(labelOutPassword);
            groupBoxOut.Controls.Add(labelPassword);
            groupBoxOut.Controls.Add(labelOutDate);
            groupBoxOut.Controls.Add(labelData);
            groupBoxOut.Controls.Add(labelOutLogin);
            groupBoxOut.Controls.Add(labelLogin);
            groupBoxOut.Controls.Add(labelOutName);
            groupBoxOut.Controls.Add(labelName);
            groupBoxOut.Controls.Add(labelOutID);
            groupBoxOut.Controls.Add(labelID);
            groupBoxOut.Dock = DockStyle.Left;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(279, 598);
            groupBoxOut.TabIndex = 7;
            groupBoxOut.TabStop = false;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = Color.DarkSeaGreen;
            groupBoxMenu.Controls.Add(buttonBack);
            groupBoxMenu.Controls.Add(buttonRight);
            groupBoxMenu.Controls.Add(buttonAdd);
            groupBoxMenu.Controls.Add(labelNumber);
            groupBoxMenu.Controls.Add(buttonDelete);
            groupBoxMenu.Controls.Add(buttonLeft);
            groupBoxMenu.Controls.Add(buttonUpdate);
            groupBoxMenu.Location = new Point(3, 336);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(270, 259);
            groupBoxMenu.TabIndex = 8;
            groupBoxMenu.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Peru;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 204);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(261, 46);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonRight
            // 
            buttonRight.BackColor = Color.NavajoWhite;
            buttonRight.BackgroundImageLayout = ImageLayout.None;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRight.Location = new Point(141, 58);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(126, 42);
            buttonRight.TabIndex = 3;
            buttonRight.Text = ">>>>";
            buttonRight.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRight.UseVisualStyleBackColor = false;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.YellowGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(6, 152);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(261, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add User";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelNumber
            // 
            labelNumber.FlatStyle = FlatStyle.Popup;
            labelNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.Location = new Point(6, 31);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(267, 24);
            labelNumber.TabIndex = 24;
            labelNumber.Text = "0/0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Khaki;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(7, 104);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(126, 42);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.YellowGreen;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(141, 104);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(126, 42);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelOutPhone
            // 
            labelOutPhone.BackColor = Color.DarkSeaGreen;
            labelOutPhone.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutPhone.Location = new Point(12, 151);
            labelOutPhone.Name = "labelOutPhone";
            labelOutPhone.Size = new Size(258, 26);
            labelOutPhone.TabIndex = 23;
            labelOutPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPhone
            // 
            labelPhone.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.Location = new Point(12, 123);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(258, 26);
            labelPhone.TabIndex = 22;
            labelPhone.Text = "Phone";
            labelPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutPassword
            // 
            labelOutPassword.BackColor = Color.DarkSeaGreen;
            labelOutPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutPassword.Location = new Point(12, 255);
            labelOutPassword.Name = "labelOutPassword";
            labelOutPassword.Size = new Size(258, 26);
            labelOutPassword.TabIndex = 21;
            labelOutPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(12, 229);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(258, 26);
            labelPassword.TabIndex = 20;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutDate
            // 
            labelOutDate.BackColor = Color.DarkSeaGreen;
            labelOutDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutDate.Location = new Point(12, 307);
            labelOutDate.Name = "labelOutDate";
            labelOutDate.Size = new Size(258, 26);
            labelOutDate.TabIndex = 19;
            labelOutDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelData
            // 
            labelData.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelData.Location = new Point(12, 281);
            labelData.Name = "labelData";
            labelData.Size = new Size(258, 26);
            labelData.TabIndex = 18;
            labelData.Text = "Registration date";
            labelData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutLogin
            // 
            labelOutLogin.BackColor = Color.DarkSeaGreen;
            labelOutLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutLogin.Location = new Point(12, 203);
            labelOutLogin.Name = "labelOutLogin";
            labelOutLogin.Size = new Size(258, 26);
            labelOutLogin.TabIndex = 17;
            labelOutLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            labelLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(12, 177);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(258, 26);
            labelLogin.TabIndex = 16;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutName
            // 
            labelOutName.BackColor = Color.DarkSeaGreen;
            labelOutName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutName.Location = new Point(12, 97);
            labelOutName.Name = "labelOutName";
            labelOutName.Size = new Size(258, 26);
            labelOutName.TabIndex = 15;
            labelOutName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(12, 71);
            labelName.Name = "labelName";
            labelName.Size = new Size(258, 26);
            labelName.TabIndex = 14;
            labelName.Text = "Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutID
            // 
            labelOutID.BackColor = Color.DarkSeaGreen;
            labelOutID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutID.Location = new Point(11, 45);
            labelOutID.Name = "labelOutID";
            labelOutID.Size = new Size(259, 26);
            labelOutID.TabIndex = 13;
            labelOutID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelProduct
            // 
            tableLayoutPanelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelProduct.ColumnCount = 3;
            tableLayoutPanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProduct.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanelProduct.Location = new Point(0, 0);
            tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            tableLayoutPanelProduct.RowCount = 1;
            tableLayoutPanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProduct.Size = new Size(200, 100);
            tableLayoutPanelProduct.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(44, 94);
            tableLayoutPanel1.TabIndex = 33;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Location = new Point(285, 12);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(640, 574);
            tableLayoutPanel.TabIndex = 33;
            // 
            // ViewAdminUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(937, 598);
            Controls.Add(tableLayoutPanel);
            Controls.Add(groupBoxOut);
            MaximizeBox = false;
            Name = "ViewAdminUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewAdminUser_FormClosed;
            Load += Form1_Load;
            groupBoxOut.ResumeLayout(false);
            groupBoxMenu.ResumeLayout(false);
            tableLayoutPanelProduct.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLeft;
        private Label labelID;
        private GroupBox groupBoxOut;
        private GroupBox groupBoxMenu;
        private Button buttonRight;
        private Label labelOutID;
        private Label labelOutDate;
        private Label labelData;
        private Label labelOutLogin;
        private Label labelLogin;
        private Label labelOutName;
        private Label labelName;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label labelOutPhone;
        private Label labelPhone;
        private Label labelOutPassword;
        private Label labelPassword;
        private Label labelNumber;
        private Button buttonBack;
        private Button buttonAdd;
        private TableLayoutPanel tableLayoutPanelProduct;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel;
    }
}
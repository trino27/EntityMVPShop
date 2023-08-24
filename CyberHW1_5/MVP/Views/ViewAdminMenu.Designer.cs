namespace CyberHW1_5.MVP.Views
{
    partial class ViewAdminMenu
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
            buttonUsers = new Button();
            groupBoxMenu = new GroupBox();
            buttonCategories = new Button();
            buttonBack = new Button();
            buttonProducts = new Button();
            groupBoxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.LightCoral;
            buttonUsers.FlatStyle = FlatStyle.Popup;
            buttonUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsers.Location = new Point(6, 10);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(188, 35);
            buttonUsers.TabIndex = 0;
            buttonUsers.Text = "Users";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.Anchor = AnchorStyles.None;
            groupBoxMenu.AutoSize = true;
            groupBoxMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxMenu.BackColor = Color.MistyRose;
            groupBoxMenu.Controls.Add(buttonCategories);
            groupBoxMenu.Controls.Add(buttonBack);
            groupBoxMenu.Controls.Add(buttonProducts);
            groupBoxMenu.Controls.Add(buttonUsers);
            groupBoxMenu.Location = new Point(256, 136);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(200, 190);
            groupBoxMenu.TabIndex = 1;
            groupBoxMenu.TabStop = false;
            // 
            // buttonCategories
            // 
            buttonCategories.BackColor = Color.LightCoral;
            buttonCategories.FlatStyle = FlatStyle.Popup;
            buttonCategories.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategories.Location = new Point(6, 92);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(188, 35);
            buttonCategories.TabIndex = 3;
            buttonCategories.Text = "Categories";
            buttonCategories.UseVisualStyleBackColor = false;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.OrangeRed;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 133);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(188, 35);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = Color.LightCoral;
            buttonProducts.FlatStyle = FlatStyle.Popup;
            buttonProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProducts.Location = new Point(6, 51);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(188, 35);
            buttonProducts.TabIndex = 1;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // ViewAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(725, 450);
            Controls.Add(groupBoxMenu);
            Name = "ViewAdminMenu";
            Text = "ViewAdminMenu";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewAdminMenu_FormClosed;
            groupBoxMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUsers;
        private GroupBox groupBoxMenu;
        private Button buttonBack;
        private Button buttonProducts;
        private Button buttonCategories;
    }
}
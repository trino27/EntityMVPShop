namespace ShopMVP.MVP.Views
{
    partial class ViewAdminCategoriesAdd
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
            textBoxInputName = new TextBox();
            labelInputName = new Label();
            buttonBack = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // textBoxInputName
            // 
            textBoxInputName.ForeColor = Color.Gray;
            textBoxInputName.Location = new Point(12, 38);
            textBoxInputName.Name = "textBoxInputName";
            textBoxInputName.Size = new Size(258, 23);
            textBoxInputName.TabIndex = 27;
            textBoxInputName.Text = "Enter...";
            textBoxInputName.TextAlign = HorizontalAlignment.Center;
            textBoxInputName.Enter += textBoxInputName_Enter;
            textBoxInputName.Leave += textBoxInputName_Leave;
            // 
            // labelInputName
            // 
            labelInputName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInputName.Location = new Point(12, 9);
            labelInputName.Name = "labelInputName";
            labelInputName.Size = new Size(258, 26);
            labelInputName.TabIndex = 26;
            labelInputName.Text = "Category Name";
            labelInputName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Tan;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 67);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(98, 40);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.PapayaWhip;
            buttonAdd.BackgroundImageLayout = ImageLayout.None;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(116, 67);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 40);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // ViewAdminCategoriesAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(282, 124);
            Controls.Add(textBoxInputName);
            Controls.Add(labelInputName);
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAdminCategoriesAdd";
            Text = "ViewAdminCategoriesAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputName;
        private Label labelInputName;
        private Button buttonBack;
        private Button buttonAdd;
    }
}
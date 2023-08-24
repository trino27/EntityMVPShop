namespace CyberHW1_5.MVP.Views
{
    partial class ViewAdminCategoriesUpdate
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
            buttonUpdate = new Button();
            textBoxInputName = new TextBox();
            labelInputName = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.SteelBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(1, 67);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(98, 40);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DeepSkyBlue;
            buttonUpdate.BackgroundImageLayout = ImageLayout.None;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(105, 67);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(154, 40);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxInputName
            // 
            textBoxInputName.ForeColor = Color.Gray;
            textBoxInputName.Location = new Point(1, 38);
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
            labelInputName.Location = new Point(1, 9);
            labelInputName.Name = "labelInputName";
            labelInputName.Size = new Size(258, 26);
            labelInputName.TabIndex = 26;
            labelInputName.Text = "New Category Name";
            labelInputName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewAdminCategoriesUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(265, 117);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxInputName);
            Controls.Add(labelInputName);
            Name = "ViewAdminCategoriesUpdate";
            Text = "ViewAdminCategoriesUpdate";
            Load += ViewAdminCategoriesUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonUpdate;
        private TextBox textBoxInputName;
        private Label labelInputName;
    }
}
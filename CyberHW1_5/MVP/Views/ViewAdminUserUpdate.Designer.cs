namespace ShopMVP.MVP.Views
{
    partial class ViewAdminUserUpdate
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
            groupBoxInput = new GroupBox();
            textBoxInputPhone = new TextBox();
            labelInputPhone = new Label();
            textBoxInputPassword = new TextBox();
            labelInputPassword = new Label();
            textBoxInputLogin = new TextBox();
            textBoxInputName = new TextBox();
            labelInputLogin = new Label();
            labelInputName = new Label();
            buttonBack = new Button();
            buttonUpdate = new Button();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInput
            // 
            groupBoxInput.AutoSize = true;
            groupBoxInput.BackColor = SystemColors.InactiveBorder;
            groupBoxInput.Controls.Add(textBoxInputPhone);
            groupBoxInput.Controls.Add(labelInputPhone);
            groupBoxInput.Controls.Add(textBoxInputPassword);
            groupBoxInput.Controls.Add(labelInputPassword);
            groupBoxInput.Controls.Add(textBoxInputLogin);
            groupBoxInput.Controls.Add(textBoxInputName);
            groupBoxInput.Controls.Add(labelInputLogin);
            groupBoxInput.Controls.Add(labelInputName);
            groupBoxInput.Location = new Point(1, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(281, 256);
            groupBoxInput.TabIndex = 13;
            groupBoxInput.TabStop = false;
            // 
            // textBoxInputPhone
            // 
            textBoxInputPhone.ForeColor = Color.Gray;
            textBoxInputPhone.Location = new Point(12, 101);
            textBoxInputPhone.Name = "textBoxInputPhone";
            textBoxInputPhone.Size = new Size(258, 23);
            textBoxInputPhone.TabIndex = 28;
            textBoxInputPhone.Text = "Enter...";
            textBoxInputPhone.TextAlign = HorizontalAlignment.Center;
            textBoxInputPhone.Enter += textBoxInputPhone_Enter;
            textBoxInputPhone.Leave += textBoxInputPhone_Leave;
            // 
            // labelInputPhone
            // 
            labelInputPhone.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInputPhone.Location = new Point(12, 72);
            labelInputPhone.Name = "labelInputPhone";
            labelInputPhone.Size = new Size(258, 26);
            labelInputPhone.TabIndex = 27;
            labelInputPhone.Text = "Phone";
            labelInputPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputPassword
            // 
            textBoxInputPassword.ForeColor = Color.Gray;
            textBoxInputPassword.Location = new Point(12, 211);
            textBoxInputPassword.Name = "textBoxInputPassword";
            textBoxInputPassword.Size = new Size(258, 23);
            textBoxInputPassword.TabIndex = 26;
            textBoxInputPassword.Text = "Enter...";
            textBoxInputPassword.TextAlign = HorizontalAlignment.Center;
            textBoxInputPassword.Enter += textBoxInputPassword_Enter;
            textBoxInputPassword.Leave += textBoxInputPassword_Leave;
            // 
            // labelInputPassword
            // 
            labelInputPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInputPassword.Location = new Point(12, 182);
            labelInputPassword.Name = "labelInputPassword";
            labelInputPassword.Size = new Size(258, 26);
            labelInputPassword.TabIndex = 25;
            labelInputPassword.Text = "Password";
            labelInputPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInputLogin
            // 
            textBoxInputLogin.ForeColor = Color.Gray;
            textBoxInputLogin.Location = new Point(12, 156);
            textBoxInputLogin.Name = "textBoxInputLogin";
            textBoxInputLogin.Size = new Size(258, 23);
            textBoxInputLogin.TabIndex = 24;
            textBoxInputLogin.Text = "Enter...";
            textBoxInputLogin.TextAlign = HorizontalAlignment.Center;
            textBoxInputLogin.Enter += textBoxInputLogin_Enter;
            textBoxInputLogin.Leave += textBoxInputLogin_Leave;
            // 
            // textBoxInputName
            // 
            textBoxInputName.ForeColor = Color.Gray;
            textBoxInputName.Location = new Point(12, 46);
            textBoxInputName.Name = "textBoxInputName";
            textBoxInputName.Size = new Size(258, 23);
            textBoxInputName.TabIndex = 23;
            textBoxInputName.Text = "Enter...";
            textBoxInputName.TextAlign = HorizontalAlignment.Center;
            textBoxInputName.Enter += textBoxInputName_Enter;
            textBoxInputName.Leave += textBoxInputName_Leave;
            // 
            // labelInputLogin
            // 
            labelInputLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInputLogin.Location = new Point(12, 127);
            labelInputLogin.Name = "labelInputLogin";
            labelInputLogin.Size = new Size(258, 26);
            labelInputLogin.TabIndex = 22;
            labelInputLogin.Text = "Login";
            labelInputLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInputName
            // 
            labelInputName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInputName.Location = new Point(12, 17);
            labelInputName.Name = "labelInputName";
            labelInputName.Size = new Size(258, 26);
            labelInputName.TabIndex = 20;
            labelInputName.Text = "Name";
            labelInputName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.SteelBlue;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(1, 265);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(121, 40);
            buttonBack.TabIndex = 17;
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
            buttonUpdate.Location = new Point(128, 265);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(154, 40);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ViewAdminUserUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 312);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdate);
            Controls.Add(groupBoxInput);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAdminUserUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminUpdateUser";
            Load += ViewAdminUserUpdate_Load;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInput;
        private TextBox textBoxInputPhone;
        private Label labelInputPhone;
        private TextBox textBoxInputPassword;
        private Label labelInputPassword;
        private TextBox textBoxInputLogin;
        private TextBox textBoxInputName;
        private Label labelInputLogin;
        private Label labelInputName;
        private Button buttonBack;
        private Button buttonUpdate;
    }
}
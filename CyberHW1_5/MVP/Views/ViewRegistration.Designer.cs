namespace ShopMVP.MVP.Views
{
    partial class ViewRegistration
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
            buttonBack = new Button();
            checkBoxVisible2 = new CheckBox();
            buttonConfirm = new Button();
            checkBoxVisible1 = new CheckBox();
            textBoxInputRepeatPassword = new TextBox();
            labelRepeatPassword = new Label();
            textBoxInputPhone = new TextBox();
            labelInputPhone = new Label();
            textBoxInputPassword = new TextBox();
            labelInputPassword = new Label();
            textBoxInputLogin = new TextBox();
            textBoxInputName = new TextBox();
            labelInputLogin = new Label();
            labelInputName = new Label();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInput
            // 
            groupBoxInput.Anchor = AnchorStyles.None;
            groupBoxInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInput.BackColor = Color.DarkSeaGreen;
            groupBoxInput.Controls.Add(buttonBack);
            groupBoxInput.Controls.Add(checkBoxVisible2);
            groupBoxInput.Controls.Add(buttonConfirm);
            groupBoxInput.Controls.Add(checkBoxVisible1);
            groupBoxInput.Controls.Add(textBoxInputRepeatPassword);
            groupBoxInput.Controls.Add(labelRepeatPassword);
            groupBoxInput.Controls.Add(textBoxInputPhone);
            groupBoxInput.Controls.Add(labelInputPhone);
            groupBoxInput.Controls.Add(textBoxInputPassword);
            groupBoxInput.Controls.Add(labelInputPassword);
            groupBoxInput.Controls.Add(textBoxInputLogin);
            groupBoxInput.Controls.Add(textBoxInputName);
            groupBoxInput.Controls.Add(labelInputLogin);
            groupBoxInput.Controls.Add(labelInputName);
            groupBoxInput.Location = new Point(250, 41);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(287, 406);
            groupBoxInput.TabIndex = 14;
            groupBoxInput.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.OliveDrab;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 358);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(258, 33);
            buttonBack.TabIndex = 17;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // checkBoxVisible2
            // 
            checkBoxVisible2.AutoSize = true;
            checkBoxVisible2.Location = new Point(222, 245);
            checkBoxVisible2.Name = "checkBoxVisible2";
            checkBoxVisible2.Size = new Size(59, 19);
            checkBoxVisible2.TabIndex = 32;
            checkBoxVisible2.Text = "visible";
            checkBoxVisible2.UseVisualStyleBackColor = true;
            checkBoxVisible2.CheckedChanged += checkBoxVisible2_CheckedChanged;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.PaleGreen;
            buttonConfirm.BackgroundImageLayout = ImageLayout.None;
            buttonConfirm.FlatStyle = FlatStyle.Popup;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(12, 312);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(258, 40);
            buttonConfirm.TabIndex = 16;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // checkBoxVisible1
            // 
            checkBoxVisible1.AutoSize = true;
            checkBoxVisible1.Location = new Point(222, 190);
            checkBoxVisible1.Name = "checkBoxVisible1";
            checkBoxVisible1.Size = new Size(59, 19);
            checkBoxVisible1.TabIndex = 31;
            checkBoxVisible1.Text = "visible";
            checkBoxVisible1.UseVisualStyleBackColor = true;
            checkBoxVisible1.CheckedChanged += checkBoxVisible1_CheckedChanged;
            // 
            // textBoxInputRepeatPassword
            // 
            textBoxInputRepeatPassword.ForeColor = Color.Gray;
            textBoxInputRepeatPassword.Location = new Point(12, 266);
            textBoxInputRepeatPassword.Name = "textBoxInputRepeatPassword";
            textBoxInputRepeatPassword.Size = new Size(258, 23);
            textBoxInputRepeatPassword.TabIndex = 30;
            textBoxInputRepeatPassword.Text = "Enter...";
            textBoxInputRepeatPassword.TextAlign = HorizontalAlignment.Center;
            textBoxInputRepeatPassword.UseSystemPasswordChar = true;
            textBoxInputRepeatPassword.Enter += textBoxInputRepeatPassword_Enter;
            textBoxInputRepeatPassword.Leave += textBoxInputRepeatPassword_Leave;
            // 
            // labelRepeatPassword
            // 
            labelRepeatPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRepeatPassword.Location = new Point(12, 237);
            labelRepeatPassword.Name = "labelRepeatPassword";
            labelRepeatPassword.Size = new Size(258, 26);
            labelRepeatPassword.TabIndex = 29;
            labelRepeatPassword.Text = "Repeat Password";
            labelRepeatPassword.TextAlign = ContentAlignment.MiddleCenter;
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
            textBoxInputPassword.UseSystemPasswordChar = true;
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
            labelInputName.Location = new Point(12, 14);
            labelInputName.Name = "labelInputName";
            labelInputName.Size = new Size(258, 26);
            labelInputName.TabIndex = 20;
            labelInputName.Text = "Name";
            labelInputName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 555);
            Controls.Add(groupBoxInput);
            Name = "ViewRegistration";
            Text = "ViewRegistration";
            WindowState = FormWindowState.Maximized;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInput;
        private TextBox textBoxInputRepeatPassword;
        private Label labelRepeatPassword;
        private TextBox textBoxInputPhone;
        private Label labelInputPhone;
        private TextBox textBoxInputPassword;
        private Label labelInputPassword;
        private TextBox textBoxInputLogin;
        private TextBox textBoxInputName;
        private Label labelInputLogin;
        private Label labelInputName;
        private Button buttonBack;
        private Button buttonConfirm;
        private CheckBox checkBoxVisible2;
        private CheckBox checkBoxVisible1;
    }
}
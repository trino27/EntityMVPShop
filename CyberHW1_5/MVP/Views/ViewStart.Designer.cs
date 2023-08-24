namespace CyberHW1_5.MVP.Views
{
    partial class ViewStart
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
            buttonAdmin = new Button();
            checkBoxVisible = new CheckBox();
            textBoxInputPassword = new TextBox();
            textBoxInputLogin = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            buttonSignIn = new Button();
            buttonSignUp = new Button();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInput
            // 
            groupBoxInput.Anchor = AnchorStyles.None;
            groupBoxInput.AutoSize = true;
            groupBoxInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInput.BackColor = Color.DarkSeaGreen;
            groupBoxInput.BackgroundImageLayout = ImageLayout.None;
            groupBoxInput.Controls.Add(buttonAdmin);
            groupBoxInput.Controls.Add(checkBoxVisible);
            groupBoxInput.Controls.Add(textBoxInputPassword);
            groupBoxInput.Controls.Add(textBoxInputLogin);
            groupBoxInput.Controls.Add(labelPassword);
            groupBoxInput.Controls.Add(labelLogin);
            groupBoxInput.Controls.Add(buttonSignIn);
            groupBoxInput.Controls.Add(buttonSignUp);
            groupBoxInput.FlatStyle = FlatStyle.Flat;
            groupBoxInput.Location = new Point(277, 97);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(249, 266);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.PapayaWhip;
            buttonAdmin.FlatStyle = FlatStyle.Popup;
            buttonAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdmin.Location = new Point(60, 218);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(129, 26);
            buttonAdmin.TabIndex = 29;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // checkBoxVisible
            // 
            checkBoxVisible.AutoSize = true;
            checkBoxVisible.Location = new Point(184, 129);
            checkBoxVisible.Name = "checkBoxVisible";
            checkBoxVisible.Size = new Size(59, 19);
            checkBoxVisible.TabIndex = 28;
            checkBoxVisible.Text = "visible";
            checkBoxVisible.UseVisualStyleBackColor = true;
            checkBoxVisible.CheckedChanged += checkBoxVisible_CheckedChanged;
            // 
            // textBoxInputPassword
            // 
            textBoxInputPassword.ForeColor = Color.Gray;
            textBoxInputPassword.Location = new Point(6, 103);
            textBoxInputPassword.Name = "textBoxInputPassword";
            textBoxInputPassword.Size = new Size(237, 23);
            textBoxInputPassword.TabIndex = 27;
            textBoxInputPassword.Text = "Enter...";
            textBoxInputPassword.TextAlign = HorizontalAlignment.Center;
            textBoxInputPassword.UseSystemPasswordChar = true;
            textBoxInputPassword.Enter += textBoxInputPassword_Enter;
            textBoxInputPassword.Leave += textBoxInputPassword_Leave;
            // 
            // textBoxInputLogin
            // 
            textBoxInputLogin.ForeColor = Color.Gray;
            textBoxInputLogin.Location = new Point(6, 48);
            textBoxInputLogin.Name = "textBoxInputLogin";
            textBoxInputLogin.Size = new Size(237, 23);
            textBoxInputLogin.TabIndex = 25;
            textBoxInputLogin.Text = "Enter...";
            textBoxInputLogin.TextAlign = HorizontalAlignment.Center;
            textBoxInputLogin.Enter += textBoxInputLogin_Enter;
            textBoxInputLogin.Leave += textBoxInputLogin_Leave;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(60, 74);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(129, 26);
            labelPassword.TabIndex = 21;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            labelLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(60, 19);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(129, 26);
            labelLogin.TabIndex = 4;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.Wheat;
            buttonSignIn.FlatStyle = FlatStyle.Popup;
            buttonSignIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignIn.Location = new Point(60, 154);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(129, 26);
            buttonSignIn.TabIndex = 1;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.Wheat;
            buttonSignUp.FlatStyle = FlatStyle.Popup;
            buttonSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(60, 186);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(129, 26);
            buttonSignUp.TabIndex = 0;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // ViewStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInput);
            Name = "ViewStart";
            Text = "ViewStart";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewStart_FormClosed;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox groupBoxInput;
        private Button buttonSignIn;
        private Button buttonSignUp;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxInputLogin;
        private TextBox textBoxInputPassword;
        private Button buttonAdmin;
        private CheckBox checkBoxVisible;
    }
}
using System;

namespace ShopMVP.Extensions
{
    internal static class TextBoxExtension
    {
        public static TextBox TextBoxLeave(this TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Enter...";
                textBox.ForeColor = Color.Gray;
            }
            return textBox;
        }
        public static TextBox TextBoxEnter(this TextBox textBox)
        {
            if (textBox.Text == "Enter...")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            return textBox;
        }
        public static TextBox TextBoxWaiting(this TextBox textBox)
        {
            textBox.Text = "Enter...";
            textBox.ForeColor = Color.Gray;
            return textBox;
        }
    }
}

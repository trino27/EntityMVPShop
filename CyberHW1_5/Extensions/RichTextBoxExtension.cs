using System;
using System.Windows.Forms;

namespace CyberHW1_5.Extensions
{
    internal static class RichTextBoxExtension
    {
        public static RichTextBox TextBoxKeyLeave(this RichTextBox richTextBox)
        {
            if (richTextBox.Text == "")
            {
                richTextBox.Text = "#key...";
                richTextBox.ForeColor = Color.Gray;
            }
            else
            {
                richTextBox.Text = richTextBox.Text.Replace(" ", "");
                string[] keys = richTextBox.Text.Split('#');
                for(int i = 0; i < keys.Length; i++) 
                {
                    if (keys[i].EndsWith('.') || keys[i].EndsWith(',')
                        || keys[i].EndsWith('!') || keys[i].EndsWith('?')
                        || keys[i].EndsWith('/') || keys[i].EndsWith('\\')
                        || keys[i].EndsWith('|') || keys[i].EndsWith(')')
                        || keys[i].EndsWith('(') || keys[i].EndsWith('}')
                        || keys[i].EndsWith('{') || keys[i].EndsWith(']')
                        || keys[i].EndsWith('[') || keys[i].EndsWith('#'))
                    {
                        keys[i] = keys[i].Substring(0, keys[i].Length - 1);
                    }
                    keys[i] = "#" + keys[i];
                }
                richTextBox.Text = "";
                foreach (string key in keys) 
                {
                        richTextBox.Text += key;
                }
                richTextBox.Text = richTextBox.Text.Replace("##", "#");
            }
            return richTextBox;
        }
        public static RichTextBox TextBoxKeyEnter(this RichTextBox richTextBox)
        {
            if (richTextBox.Text == "#key...")
            {
                richTextBox.Text = "";
                richTextBox.ForeColor = Color.Black;
            }
            return richTextBox;
        }
        public static RichTextBox TextBoxKeyWaiting(this RichTextBox richTextBox)
        {
            richTextBox.Text = "#key...";
            richTextBox.ForeColor = Color.Gray;
            return richTextBox;
        }
    }
}

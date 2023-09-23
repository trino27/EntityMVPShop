using System;


namespace ShopMVP.Extensions
{
    internal static class LabelExtension
    {
        public static Label LabelNumberUpdate(this Label label, long currentNumber, long maxNumber)
        {
            label.Text = $"{currentNumber}/{maxNumber}";
            return label;
        }
    }
}

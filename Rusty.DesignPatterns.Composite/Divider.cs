using System;

namespace Rusty.DesignPatterns.Composite
{
    public static class Divider
    {
        public static decimal[] Divide(decimal totalAmount, int dividedBy)
        {
            decimal[] arrValues = new decimal[dividedBy];
            while (dividedBy > 0)
            {
                decimal amount = Math.Round(totalAmount / dividedBy, 2);
                arrValues[dividedBy - 1] = amount;
                totalAmount -= amount;
                dividedBy--;
            }

            return arrValues;
        }
    }
}
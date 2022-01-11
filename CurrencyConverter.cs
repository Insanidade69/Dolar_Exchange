using System;
using System.Globalization;

namespace Dolar_Exchange
{
    internal class CurrencyConverter
    {
        public static double Iof = 6.0;

        public static double BuyDolar(double amount, double quote)
        {
            double total = amount * quote;
            return total + total * Iof / 100.0;
        }
    }
}

using System;
using System.Globalization;

namespace Dolar_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the dolar exchange rate?");
            Console.Write("Quote US$ ");
            double quote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("What amount u want buy?");
            Console.Write("US$ ");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result = CurrencyConverter.BuyDolar(quote, amount);

            Console.WriteLine("Value to pay R$ {0}", result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
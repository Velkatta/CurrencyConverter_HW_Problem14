using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            double costToConvert = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            double bgn = 1.0;
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "USD")
                {
                    Console.WriteLine("{0:f2}" , costToConvert / usd);
                }
                else if (secondCurrency == "EUR")
                {
                    Console.WriteLine("{0:f2}" , costToConvert / eur);
                }
                else if (secondCurrency == "GBP")
                {
                    Console.WriteLine("{0:f2}" , costToConvert / gbp);
                }
                else if ((secondCurrency != "USD") && (secondCurrency != "EUR") && (secondCurrency != "GBP"))
                {
                    Console.WriteLine("Wrong currency");
                }
            }
            else if (firstCurrency == "USD")
            {
                if (secondCurrency == "BGN")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * usd);
                }
                else if (secondCurrency == "EUR")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * usd);
                }
                else if (secondCurrency == "GBP")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * usd);
                }
                else if ((secondCurrency != "BGN") && (secondCurrency != "EUR") && (secondCurrency != "GBP"))
                {
                    Console.WriteLine("Wrong currency");
                }
            }
            else if (firstCurrency == "EUR")
            {
                if (secondCurrency == "BGN")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * eur);
                }
                else if (secondCurrency == "USD")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * usd);
                }
                else if (secondCurrency == "GBR")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * gbp);
                }
                else if ((secondCurrency != "BGN") && (secondCurrency != "USD") && (secondCurrency != "GBP"))
                {
                    Console.WriteLine("Wrong currency");
                }
            }
            else if (firstCurrency == "GBP")
            {
                if (secondCurrency == "BGN")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * gbp);
                }
                else if (secondCurrency == "USD")
                {
                    Console.WriteLine("{0:f2}" , costToConvert * usd);
                }
                else if (secondCurrency == "EUR")
                {
                    Console.WriteLine("{0:f2}", costToConvert * eur);
                }
                else if ((secondCurrency != "BGN") && (secondCurrency != "USD") && (secondCurrency != "EUR"))
                {
                    Console.WriteLine("Wrong currency");
                }
            }
            else
            {
                Console.WriteLine("Wrong curency");
            }
        }
    }
}

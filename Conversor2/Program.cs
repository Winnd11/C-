using System;

namespace Conversor2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a currency to convert");
        Console.WriteLine("1 = $USD\n2 = ¥JPY\n3 = €EUR");
        string currency1 = Console.ReadLine();

        Console.WriteLine("Enter a value");
        string value = Console.ReadLine();

        int currencyInt1 = Int32.Parse(currency1);
        int currencyInt2 = Int32.Parse(value);

        Convert(currencyInt1, currencyInt2);
    }

    static void Convert(int currencyInt1, int currencyInt2)
    {
        switch (currencyInt1)
        {
            case 1:
                CurrencyClass usd = new CurrencyClass("$", "USD", 5.58);
                usd.Count(currencyInt2);
                break;
            case 2:
                CurrencyClass jpy = new CurrencyClass("¥", "JPY", 0.035);
                jpy.Count(currencyInt2);
                break;
            case 3:
                CurrencyClass eur = new CurrencyClass("€", "EUR", 6);
                eur.Count(currencyInt2);
                break;
        }
    }
}

class CurrencyClass
{
    string symbol;
    string acronym;
    double value;

    public CurrencyClass(string symbol, string acronym, double value)
    {
        this.symbol = symbol;
        this.acronym = acronym;
        this.value = value;
    }

    public void Count(int result)
    {
        double cont = value * result;
        Console.WriteLine($"R${cont} = {symbol}{result}");
    }
}

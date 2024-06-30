using System;

namespace Conversor;

class Program
{
    static void Main(string[] args)
    {
        string currency = "$/USD";

        Console.WriteLine($"Choose a currency // Current currency {currency}");
        Console.WriteLine("1 = R$/BRA /// 2 = ¥/YEN");

        string choice = Console.ReadLine();
        CurrencyChoice(choice);
    }

    static void CurrencyChoice(string choice)
    {
        Console.WriteLine("Chioce a value");
        string value1 = Console.ReadLine();
        int result = Int32.Parse(value1);

        CurrencyClass real = new CurrencyClass("R$", "BRA", 5);

        real.AccountCurrency(result);
    }
}

class CurrencyClass
{
    string symbol;
    string acronym;
    int value;

    public CurrencyClass(string symbol, string acronym, int value)
    {
        this.symbol = symbol;
        this.acronym = acronym;
        this.value = value;
    }

    public void AccountCurrency(int result)
    {
        Console.WriteLine(value * result);
    }
}
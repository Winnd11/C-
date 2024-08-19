using System;
using System.ComponentModel.Design;

namespace Calculator;

class Program
{
    static void Main(string[] arg)
    {
        Commands();
    }

    static void Commands()
    {
        Console.WriteLine("1 = Plus + // 2 = Minus - // 3 = Multiply * // 4 = Divide");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                plus();
                break;
            case "2":
                minus();
                break;
            case "3":
                times();
                break;
            case "4":
                divide();
                break;
        }
    }

    static void plus()
    {
        int numberOne = Convert.ToInt32(Console.ReadLine());
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numberOne + numberTwo);
    }

    static void minus()
    {
        int numberOne = Convert.ToInt32(Console.ReadLine());
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numberOne - numberTwo);
    }
    static void times()
    {
        int numberOne = Convert.ToInt32(Console.ReadLine());
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numberOne * numberTwo);
    }

    static void divide()
    {
        try
        {
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberOne / numberTwo);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("is not possible to divide by zero");
        }

    }
}
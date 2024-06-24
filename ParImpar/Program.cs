using System;

namespace parImpar;

class Program
{
    static void Main(string[] args)
    {
        int result = 11 % 2;

        Console.WriteLine(result);

        if (result == 0)
        {
            Console.WriteLine("par");
        }
        else
        {
            Console.WriteLine("impar");
        }
    }
}

using System;

namespace boolean;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("how old are you?");
        int ageOption = Convert.ToInt32(Console.ReadLine());

        bool age = ageOption >= 18;

        if (age == true)
        {
            Console.WriteLine("you are of legal age");
        } else
        {
            Console.WriteLine("you are a minor");
        }
    }
}
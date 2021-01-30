using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe a: ");
            string line1 = Console.ReadLine();
            int a = int.Parse(line1);

            Console.Write("Podaj liczbe b: ");
            string line2 = Console.ReadLine();
            int b = int.Parse(line2);

            Console.Write("Podaj liczbe c: ");
            string line3 = Console.ReadLine();
            int c = int.Parse(line3);

            if(a > b)
            {
                if(a > c)
                {
                    Console.Write("Najwieksza liczba jest: " + a +"");
                   
                }else
                    Console.Write("Najwieksza liczba jest: " + c + "");

            }else
                if(b > c)
            {
                Console.Write("Najwieksza liczba jest: " + b + "");
            }else
                Console.Write("Najwieksza liczba jest: " + c + "");
        }
    }
}

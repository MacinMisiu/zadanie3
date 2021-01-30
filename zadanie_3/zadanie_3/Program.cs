using System;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj temperature: ");
            string line = Console.ReadLine();
            int temp = int.Parse(line);

            if (temp <= 0)
            {
                Console.Write(+temp + "°C - zamarzajaca woda");
            }
            else
            if (temp >= 0 && temp <= 10)
            {
                Console.Write(+temp + "°C - bardzo zimna woda");
            }
            else
            if (temp >= 10 && temp <= 20)
            {
                Console.Write(+temp + "°C - letnia woda");
            }
            else
            if(temp >= 20 && temp <= 40)
            {
                Console.Write(+temp + "°C - ciepła woda");
            }
            else
            if(temp >= 40 && temp <= 100)
            {
                Console.Write(+temp + "°C - gorąca woda");
            }
            else
            if(temp >= 100)
            {
                Console.Write(+temp + "°C - wrzaca woda");
            }
        }
    }
}

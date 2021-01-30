using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj miare kata a: ");
            string line = Console.ReadLine();
            int a = int.Parse(line);

            Console.Write("Podaj miare kata b: ");
            string line1 = Console.ReadLine();
            int b = int.Parse(line1);

            Console.Write("Podaj miare kata c: ");
            string line2 = Console.ReadLine();
            int c = int.Parse(line2);

            if (a > 0 && b > 0 && c > 0)
            {
                if ((a < 90 && b < 90 && c < 90) && (a + b + c == 180) && a != b && b != c && a != c) //trojkat ostrokatny
                {
                    Console.Write("Jest to to trojkat ostrokatny. ");
                }
                else
                if ((a == 90 || b == 90 || c == 90) && a + b + c == 180) //trojkat prostokatny
                {
                    Console.Write("Jest to to trojkat prostokatny. ");
                }
                else
                if ((a > 90 || b > 90 || c > 90) && (a + b + c == 180) && (a != b && a != c && b != c))  //trojkat rozwartokatny
                {
                    Console.Write("Jest to to trojkat rozwartokatny. ");
                }
                else
                if ((a == b && b == c && a == c) && a + b + c == 180) //trojkat rownoboczny
                {
                    Console.Write("Jest to to trojkat rownoboczny. ");
                }
                else
                if ((a == b || a == c || b == c) && a + b + c == 180) //trojakt rownoramienny
                {
                    Console.Write("Jest to to trojkat rownoramienny. ");
                }
                else
                if(a + b + c > 180)
                {
                    Console.Write("Taki trojkat nie istnieje! ");
                }

                   
                

            }







        }
    }
}

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz swoje imie: ");
            string imie = Console.ReadLine();

            Console.WriteLine("Witaj " + imie);

            int wiek=1;
            //wiek = int.Parse(Console.ReadLine());
            bool result_wiek = false;

            while (result_wiek!=true)
            {
                Console.Write("Wpisz swój wiek: ");
                result_wiek = int.TryParse(Console.ReadLine(), out wiek);

                if (wiek<0)
                {
                    result_wiek = false;
                }
                else if (wiek>120)
                {
                    result_wiek = false;
                }

                if (result_wiek)
                {

                }
                else
                {
                    Console.WriteLine("Podales zly wiek");
                }
            }




            if (wiek > 17)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Jesteś pełnoletni");
            }
            else
            {
                Console.WriteLine("Jesteś zbyt młody");
            }









            Console.ReadKey();
        }

    }
}

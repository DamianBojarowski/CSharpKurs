using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string imie0 = args[0];
            //string imie1 = args[1];
            //Console.WriteLine("Witaj " + imie0 + " i ty " + imie1);
            //Console.WriteLine("Dzisiejsza data: " + DateTime.Now);
            int cyfra = 0;
            foreach (var imie in args)
            {
                
                cyfra = cyfra + 1;
                Console.WriteLine("Witaj " + imie);
                Console.WriteLine("Jesteś " + cyfra);
                
            }

        }
    }

}

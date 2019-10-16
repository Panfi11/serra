using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la temperatura serra");
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura > 18)
            {
                Console.WriteLine("la temperatura è nella norma");
            }
            else if (temperatura < 18 && temperatura > 5)
            {
                Console.WriteLine("la serra è in pericolo");
            }
            else
            {
                Console.WriteLine("la serra subira vari sanni");
            }
            Console.ReadLine();
        }
    }
}

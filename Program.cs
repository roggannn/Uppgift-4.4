using System;

namespace sak
{
    class Program
    {
        static void Main(string[]args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                string svar = Console.ReadLine();
                if (svar == "3")
                {
                    Console.WriteLine("Avslutar programmet...");
                    break;
                }
                else if (svar == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Skriv in ett tal som du vill dividera");
                    double tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in ett till tal som du vill dividera med " + tal1);
                    double tal2 = double.Parse(Console.ReadLine());

                    double kvot = tal1 / tal2;

                    Console.WriteLine("Dividerar vi " + tal1 + " och " + tal2 + " så får vi kvotet = " + kvot + ".");
                    break;
                }
                else if (svar == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Skriv in ett tal som du vill subtrahera");
                    double tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in ett till tal som du vill subtrahera med " + tal1);
                    double tal2 = double.Parse(Console.ReadLine());

                    double skillnad = tal1 - tal2;

                    Console.WriteLine("Subtraherar vi " + tal1 + " med " + tal2 + " så får vi skillnaden = " + skillnad + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Skriv in 1,2 eller 3.");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random().Next(101);
            int count = 0;

            while (true)
            {
                count++;
                Console.WriteLine("Odgadnij liczbę z zakresu 0-100:");

                var number = GetNumber();
                CheckNumber(number);


                if (number < random)
                {
                    Console.WriteLine("Twoja liczba jest mniejsza od szukanej. Spróbuj ponownie.");
                    continue;
                }

                if (number > random)
                {
                    Console.WriteLine("Twoja liczba jest większa od szukanej. Spróbuj ponownie.");
                    continue;
                }

                Console.WriteLine($"Gratulacje! Odgadłaś liczbę po {count} próbie.");
                break;
            }

        }

        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Podano nieprawidłową wartość.");
                result = -1;
            }

            return result;
        }

        private static void CheckNumber(int number)
        {
            if (number < 0 || number > 100)
                Console.WriteLine("Podana liczba jest spoza dopuszczalnego zakresu.Spróbuj jeszcze raz");
        }


    }
}

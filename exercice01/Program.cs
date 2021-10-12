using System;

namespace exercice1
{
    class Program
    {
        public static void premier(int number)
        {
            int i = 2;
            while ((number % i != 0) && (i < Math.Sqrt(number)))
            {
                i++;
            }
            if (number % i == 0)
                Console.WriteLine("Ce nombre est premier!");
            else
                Console.WriteLine("Ce nombre n'est pas premier!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enterz un nombre!");
            int number = Convert.ToInt32(Console.ReadLine());
            premier(number);
        }
    }
}

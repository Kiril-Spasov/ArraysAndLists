using System;
using System.Collections.Generic;

namespace exersise03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You have already entered {0}, enter another number", number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}

using System;
using System.Collections.Generic;

namespace exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5];

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
                for (var j = 0; j < i; j++)
                {
                    if (number == numbers[j])
                    {
                        Console.WriteLine("Error (number already exists), enter another number");
                        i--;
                    }
                }

            }

            Array.Sort(numbers);

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}

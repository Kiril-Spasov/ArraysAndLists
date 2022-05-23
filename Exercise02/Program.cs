using System;
using System.Collections.Generic;

namespace exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = array.Length; i > 0; i--)
            {
                array[array.Length - i] = name[i - 1];
            }

            var reversed = new string(array);
            Console.WriteLine("Your reversed name is: {0}", reversed);
            
        }
    }
}

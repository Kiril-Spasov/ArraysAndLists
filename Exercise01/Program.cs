using System;
using System.Collections.Generic;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var friends = new List<string>();

            while (true)
            {
                Console.WriteLine("Pls enter name or HIT enter to exit");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                friends.Add(input);
                
            }
            if (friends.Count > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post", friends[0], friends[1], (friends.Count-2));
            }
            else if (friends.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", friends[0], friends[1]);
            }
            else if (friends.Count == 1)
            {
                Console.WriteLine("{0} likes your post", friends[0]);
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}

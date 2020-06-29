using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public static class IndicesAndRangesDemo
    {
        public static void Demo()
        {
            var places = new string[] { "first", "second", "third", "fourth", "fifth" };
            // places[0] = "first"
            // places[4] = "fifth"
            // places[places.Length -1] = "fifth"

            // But there is easier way
            // "carrot" means 1 from the end (the last index) ^1 = last item
            Console.WriteLine($"The last item in the list is { places[^1] }");
            Console.WriteLine($"The second to last item in the list is { places[^2] }");

            Console.WriteLine();

            Console.WriteLine("Places 2 and 3 - [2..4] indicates index position 2 (item 3) up until 4 (not including it)" );
            foreach (var item in places[2..4]) // places[2] inclusive up to places[4] exclusive [2,4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Places 1,2 and 3 - [1..^1] indicates index position 1 (item 2) up until the last item (not including it)");
            foreach (var item in places[1..^1])  // places[1] inclusive up to the last position exclusive [1,lastPosition)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Places 0,1,2 and 3 - [..^1] indicates everything up until the last item (not including it)");
            foreach (var item in places[..^1])  // places[0] inclusive up to the last position exclusive [0,lastPosition)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Places 1,2,3 and 4 - [1..] indicates index position 1 (item 2) through the end of the string");
            foreach (var item in places[1..])  // places[1] inclusive up to the last position inclusive [0,lastPosition]
            {
                Console.WriteLine(item);
            }

        }
    }
}

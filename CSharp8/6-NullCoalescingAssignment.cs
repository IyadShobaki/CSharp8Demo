using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public static class NullCoalescingAssignmentDemo
    {
        public static void Demo()
        {
            var example = new ListDemo();

            // Without using Null Coalescing Assignment
            //if (example.LuckyNumbers == null)
            //{
            //    example.LuckyNumbers = new List<int>();
            //}

            // we can use Not Null check but it will not do anything if its null
            //example?.LuckyNumbers?.Add(16);  

            // With using Null Coalescing Assignment. If its null will instantiate 
            // a new List<int>
            example.LuckyNumbers ??= new List<int>();


            example.LuckyNumbers.Add(15);

            foreach (var item in example.LuckyNumbers)
            {
                Console.WriteLine($"Lucky Number: { item }");
            }
        }
    }
    public class ListDemo
    {
        public List<int> LuckyNumbers { get; set; }

        //public ListDemo()
        //{
        //    LuckyNumbers = new List<int> { 21 };
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public interface IShoppingCart
    {
        // We can create a static methods and fields inside the interface 
        // Avoid create them as possible
        public static void SetDefaultName(string name)
        {
            defaultName = name;
        }
        private static string defaultName = "default";
        // A method with default implementation (this better than create another interface
        // and multi implement interfaces
        void CalculateSubTotal()
        {
            //Console.WriteLine("This is the default IShoppingCart implementation of CalculateSubTotal");
            Console.WriteLine($"This is the { defaultName } IShoppingCart implementation of CalculateSubTotal");
        }
        void CalculateTotal();
    }
    public interface ISubTotal
    {
        void CalculateSubTotal()
        {
            Console.WriteLine("This is the default ISubTotal implementation of CalculateSubTotal");
        }
    }
    public class ShoppingCart : IShoppingCart, ISubTotal
    {
        // We can implemetn CalculateSubTotal() if we want.
        public void CalculateTotal()
        {
            Console.WriteLine("This is CalculateTotal in the ShoppingCart class");
        }
    }
    public class BetterShoppingCart : IShoppingCart
    {
        // Override the default method
        public void CalculateSubTotal()
        {
            Console.WriteLine("This is the BetterShoppingCart implementation of CalculateSubTotal");
        }
        //public BetterShoppingCart()
        //{
        //    IShoppingCart.SetDefaultName("DefaultBetterShoppingCart");
        //}
        public void CalculateTotal()
        {
            Console.WriteLine("This is CalculateTotal in the BetterShoppingCart class");
        }
    }
}

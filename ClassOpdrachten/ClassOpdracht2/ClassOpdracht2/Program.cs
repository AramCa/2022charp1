using System;
using System.Runtime.CompilerServices;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak hier een variable aan met type ShopGreeter
            ShopGreeter aram= new ShopGreeter();
            //roep de function greetcustomer aan


            aram.GreetCustomer();
        }
    }
}
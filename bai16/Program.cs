using System;

namespace generic_example
{
    class Program
    {
        static void Swap(ref int x,ref int y){
            int t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 45;

            System.Console.WriteLine($"a = {a}, b = {b}");

            Swap(ref a, ref b);
            System.Console.WriteLine($"a = {a}, b = {b}");

        }
    }
}

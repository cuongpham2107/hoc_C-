

using System;
using System.Linq;
using MyLib;


namespace bai23
{
    //extension methed
    //lớp tĩnh static

    static class Abc
    {
        public static void Print(this string s,  ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
            
        }
    }
    public class Program
    {
       
        
        public static void Main(string[] args)
        {
            // string s = "Xin chào các bạn";
            // s.Print(ConsoleColor.Yellow);
            // Print(s, ConsoleColor.Green);
            // Print(s, ConsoleColor.Red);

            // "Xin".Print(ConsoleColor.Blue);
            // "Chao".Print(ConsoleColor.Yellow);
            // "Cac ban".Print(ConsoleColor.Red);

            double a = 2.5;
            Console.WriteLine(a.BinhPhuong());
            Console.WriteLine(a.CanBacHai());
            Console.WriteLine(a.Sin());
            Console.WriteLine(a.Cos());
            

        }
    }   
}
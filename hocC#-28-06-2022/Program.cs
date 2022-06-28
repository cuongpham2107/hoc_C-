using System;

namespace CS_28
{   
    class Product
    {
        public Product()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Brand
    {
        public Brand()
        {

        }
         public override string ToString()
        {
            return base.ToString();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello World");
            Product product = new Product();
            Brand brand = new Brand();
        }
    }
} 
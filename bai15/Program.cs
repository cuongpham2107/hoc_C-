using System;
using MyNameSpace;
using MyNameSpace.Abc;
using Product;

namespace Example
{
    public class Program{
        public static void Main( string[] args){
        //    Class1.Xinchao();
        //    Class2.Xinchao();
        Sanpham sanpham = new Sanpham();
        sanpham.name = "Iphone 12 promax";
        sanpham.price = 32000000;

        Console.WriteLine($"{sanpham.GetInfo()}");

        }

    }
    
}

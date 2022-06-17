using System;

namespace Product
{
    public class Sanpham{
        public string name { get; set; }    
        public int price { get; set; }

        public string GetInfo(){
            return $"{name} / {price}";
        }
    }
}
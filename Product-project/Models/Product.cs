
using System;

namespace Product_project.Models
{
    public class Product
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private byte[] _image;
        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private int _quantity;
        public int Quantity
        {
            get { return _quantit; }
            set { _quanti = value; }
        }
        
        
    }
}
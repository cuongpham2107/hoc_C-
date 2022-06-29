
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
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private DateTime _created_at;
        public DateTime Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        
        public Product(int _id, string _name, double _price, string _image, int _quantity, DateTime _created_at){
            Id = _id;
            Name = _name;
            Price = _price;
            Image = _image;
            Quantity = _quantity;
            Created_at = _created_at;
        }
        
    }
}
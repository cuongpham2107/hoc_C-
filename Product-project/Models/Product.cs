
using System;

namespace Product_project.Models
{
    public class Product
    {
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set 
            {
                if(value >= 1)
                    _id = value;
            }
        }
        
        private string _name = "Iphone 12 promax";
        public string Name
        {
            get { return _name; }
            set 
            {
                if(!string.IsNullOrEmpty(value))_name = value;
            }
        }
        private int _price = 20000000;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _image = "1.jpg";
        public string Image
        {
            get 
            { 
                return _image; 
            }
            set 
            { 
                if(System.IO.File.Exists(value))  _image = value ;//Nhận đường dẫn đúng
            }
        }
        public string ImageName
        {
            get 
            { 
                return System.IO.Path.GetFileName(_image);//trả lại file ngắn gọn
            }
        }
        private int _quantity = 1;
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

    }
}
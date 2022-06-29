
using System;



namespace Product_project.Views
{
    using Models;
    public class ProductSingleView
    {
        protected Product Model;//Biến này để lưu trữ thông tin cuốn sách cần hiển thị

        public ProductSingleView(Product model)
        {
            Model = model;
        }

        public void Render(){
            if(Model == null){
                WriteLine("No Product Found. Sorry!", ConsoleColor.Red);
                return;
            }
            
            WriteLine(" Product Detail Information!",ConsoleColor.Green);

            Console.WriteLine($"Ten san pham: {Model.Name}, Gia san pham: {Model.Price}, Hinh anh: {Model.Image}, So luong: {Model.Quantity}");
            
        }
        
        protected void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        
    }
}
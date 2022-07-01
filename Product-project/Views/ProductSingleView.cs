
using System;



namespace Product_project.Views
{
    using Framework;
    using global::Framework;
    using Models;
    internal class ProductSingleView : ViewBase
    {
        //protected Product Model;
        //Biến này để lưu trữ thông tin cuốn sách cần hiển thị

        public ProductSingleView(Product model) : base(model) 
        {
            
        }

        public void Render(){
            if(Model == null){
                ViewHelp.WriteLine("No Product Found. Sorry!", ConsoleColor.Red);
                return;
            }

            ViewHelp.WriteLine(" Product Detail Information!",ConsoleColor.Green);
            var model = Model as Product; 
            Console.WriteLine($"Ten san pham: {model.Name}, Gia san pham: {model.Price}, Hinh anh: {model.Image}, So luong: {model.Quantity}");
            
        }
        
       
        public void RenderToFile(string path)
        {
            ViewHelp.WriteLine($"Lưu dữ liệu vào file'{path}'");
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Model);
            System.IO.File.WriteAllText(path, json);
            ViewHelp.WriteLine("Done!");
        }


    }
}
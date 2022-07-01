using System;
using Framework;

namespace Product_project.Views
{
	using Models;
    using Product_project.Framework;
    using System.Text;

    internal class ProductListView : ViewBase
	{
		//mảng của các object kiểu Product
		//protected Product[] Model;
		/// <summary>
		/// Hàm tạo
		/// </summary>
		/// <param name="model">Danh sách object kiểu Product</param>
		public ProductListView(Product[] model) : base(model)
        {
            
        }
		/// <summary>
		/// In danh sách ra console
		/// </summary>
		public void Render()
        {
			Console.OutputEncoding = Encoding.UTF8;
			if (((Product[])Model).Length == 0)
            {
				ViewHelp.WriteLine("Không có sản phẩm nào", ConsoleColor.Red);
				return;
            }
			Console.ForegroundColor = ConsoleColor.Green;
			ViewHelp.WriteLine("Danh sách sản phẩm", ConsoleColor.Blue);
			Console.ForegroundColor = ConsoleColor.Yellow;
			foreach(Product item in Model as Product[])
            {
				ViewHelp.Write($"[{item.Id}]", ConsoleColor.Yellow);
				Console.WriteLine($" - {item.Name} - {item.Price} - {item.Image} - {item.Quantity} - {item.Created_at}");
            }
			Console.ResetColor();

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


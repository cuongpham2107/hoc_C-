using System;
using Framework;

namespace Product_project.Views
{
	using Models;
    using Product_project.Framework;
    using System.Text;

    internal class ProductUpdateView : ViewBase
	{
		//protected Product Model;

		public ProductUpdateView(Product model) : base(model)
		{
			
		}
		public void Render()
        {
			Console.OutputEncoding = Encoding.UTF8;
			ViewHelp.WriteLine("UPDATE BOOK INFORMATION", ConsoleColor.Green);
			var model = Model as Product;
			var name = ViewHelp.InputString("Ten san pham: ", model.Name);
			var image = ViewHelp.InputString("Hinh anh san pham: ", model.Image);
			var price = ViewHelp.InputInt("Giá san pham: ", model.Price);
			var quantity = ViewHelp.InputInt("Số lượng sản phẩm: ", model.Quantity);

		}
		
		
	}
}


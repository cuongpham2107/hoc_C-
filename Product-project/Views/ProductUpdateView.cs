using System;
using Framework;

namespace Product_project.Views
{
	using Models;
	class ProductUpdateView
	{
		protected Product Model;

		public ProductUpdateView(Product model)
		{
			Model = model;
		}
		public void Render()
        {
			ViewHelp.WriteLine("UPDATE BOOK INFORMATION", ConsoleColor.Green);
			//var name = ViewHelp("Ten san pham", Model.Name);
		
			//var image = ViewHelp.InputString("Publisher", Model.Image);
			
		}
		
		
	}
}


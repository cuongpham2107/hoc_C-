using  System;

namespace Product_project.Controllers
{
    using Models;
    using Views;
    public class ProductController
    {
        public void Single(int id)
        {
            Product model = new Product(1, "Iphone 12 promax", 24000000, "iphone12promax.jpg", 1, DateTime.Now );
            
            ProductSingleView view = new ProductSingleView(model);

            view.Render();
        }

        public void Create()
        {
            ProductCreateView view = new ProductCreateView();

            view.Render();
        }
    }
}
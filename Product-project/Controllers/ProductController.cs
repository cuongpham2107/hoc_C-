using  System;

namespace Product_project.Controllers
{
    using Models;
    using Views;
    public class ProductController
    {
        public void Single(int id)
        {
            Product model = new Product();
            
            ProductSingleView view = new ProductSingleView(model);

            view.Render();
        }

        public void Create()
        {
            ProductCreateView view = new ProductCreateView();

            view.Render();
        }
        public void List()
        {
            
        }
        public void Update(int id)
        {
            var model = new Product();
            var view = new ProductUpdateView(model);
            view.Render();
        }
    }
}
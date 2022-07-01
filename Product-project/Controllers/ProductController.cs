using  System;

namespace Product_project.Controllers
{
    using Models;
    using Views;
    using DataServices;
    public class ProductController
    {
        protected Repository Repository;
        public ProductController(SimpleDataAccess context)
        {
            Repository = new Repository(context);
        }
        /// <summary>
        /// Ghép nối dữ liệu 1 san phẩn với giao diện hiển thị 1 san phẩm
        /// </summary>
        /// <param name="id"></param>
        public void Single(int id, string path="")
        {
            //Lấy dữ liệu qua repository
            var model = Repository.Select(id);
            //Khởi tạo view
            ProductSingleView view = new ProductSingleView(model);
            //Gọi phương thức Render để thực sự hiển thị ra màn hình
            if (!string.IsNullOrEmpty(path))
            {
                view.RenderToFile(path);
                return;
            }
            view.Render();
        }
        /// <summary>
        /// kích hoạt chức năng nhập dữ liệu cho 1 san phẩm
        /// </summary>
        public void Create()
        {
            ProductCreateView view = new ProductCreateView();//khởi tạo object

            view.Render();//Hiển thị ra màn hình
        }
        /// <summary>
        /// kích hoạt chức năng hiển thị danh sách
        /// </summary>
        public void List(string path="")
        {
            //lấy dữ liệu qua repository
            var model = Repository.Select();
            //Khởi tạo view
            ProductListView view = new ProductListView(model);//khởi tạo object
            if (!string.IsNullOrEmpty(path))
            {
                view.RenderToFile(path);
                return;
            }
            
            view.Render();//Hiển thị ra màn hình

        }
        /// <summary>
        /// Kích hoạt chức năng cập nhập
        /// </summary>
        /// <param name="id"></param>
        public void Update(int id)
        {
            //lấy dữ liệu qua repository
           var model = Repository.Select(id);

            var view = new ProductUpdateView(model);//khởi tạo object

            view.Render();//Hiển thị ra màn hình
        }
    }
}
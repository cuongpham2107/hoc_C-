
using System;
using System.Text;
namespace Product
{
    using Framework;
    using Product_project.Controllers;
    using Product_project.DataServices;

    internal class Program
    {
        private static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            var context = new SimpleDataAccess();

            ProductController controller = new ProductController(context);

            Router r = Router.Instance;

            r.Register("about", About);
            r.Register("help", Help);
            r.Register(
                router: "create",
                action: p => controller.Create(),
                help: "[create]\r\n Nhập sách mới"
                );
            r.Register(
                router: "update", 
                action: p=> controller.Update(p["id"].ToInt()),
                help: "[update ? id = <value>]\r\n Tìm và cập nhập sản phẩm"
                );
            r.Register(
                router: "list",
                action: p => controller.List(),
                help: "[list]\r\n Hiển thị tất cả sách"
                );
            r.Register(
                router: "single",
                action: p => controller.Single(p["id"].ToInt()),
                help: "[single ? id = <value>]\r\n Hiển thị một cuốn sách theo id"
                );
            r.Register(
                router: "list file",
                action: p => controller.List(p["path"]),
                help: "[list file ? path = <value>]\r\n Hiển thị tất cả Sản phẩm"
                );
            r.Register(
                router: "single file",
                action: p => controller.Single(p["id"].ToInt(),p["path"]),
                help: "[single file ? id = <value> & path = <value>]"
                );

            while (true)
            {
                ViewHelp.Write("#Request >>> ",ConsoleColor.Green);

                string request = Console.ReadLine();

                Router.Instance.Forward(request);

                Console.WriteLine();
            }
        }
        private static void About(Parameter parameter)
        {
            ViewHelp.WriteLine("Product manager version 1.0", ConsoleColor.Green);
            ViewHelp.WriteLine("by cuongpham2107@#gmail.com", ConsoleColor.Magenta);
        }
        private static void Help(Parameter parameter)
        {
            if(parameter == null)
            {
                ViewHelp.WriteLine("Supperted Commands: ", ConsoleColor.Green);
                ViewHelp.WriteLine(Router.Instance.GetRoutes(), ConsoleColor.Yellow);
                ViewHelp.WriteLine("type: help ? cmd = <command> to get command details ", ConsoleColor.Cyan);
                return;
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            var command = parameter["cmd"].ToLower();
            ViewHelp.WriteLine(Router.Instance.GetHelp(command));
        }
    }
}

using System;

namespace Product
{
    using Product_project.Controllers;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ProductController controller = new ProductController();
            while (true)
            {
                    Console.Write("Request > ");
                    var request = Console.ReadLine();
                    switch (request.ToLower())
                    {
                        case "single":
                            controller.Single(1);
                            break;
                        case "create":
                            controller.Create();
                            break;
                         case "list":
                            controller.List();
                            break;
                        case "update":
                            controller.Update(1);
                            break;
                        default:
                            Console.WriteLine($"Unknown Command");
                       
                            break;
                    }
                    
            }

        }
    }
}
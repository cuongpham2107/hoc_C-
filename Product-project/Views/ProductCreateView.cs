using System;

namespace Product_project.Views
{
    public class ProductCreateView
    {
        public ProductCreateView()
        {

        }

        public void Render()
        {
            WriteLine("Create a new Product", ConsoleColor.Green);

            WriteLine("Ten san pham: ", ConsoleColor.Magenta);
            string? name = Console.ReadLine();

            WriteLine("Gia san pham: ", ConsoleColor.Magenta);
            double price = double.Parse(Console.ReadLine());

            WriteLine("Hinh anh san pham: ", ConsoleColor.Magenta);
            string? image = Console.ReadLine();

            WriteLine("So luong san pham: ", ConsoleColor.Magenta);
            int? quantity = int.Parse(Console.ReadLine());

            WriteLine("Thoi gian tao: ", ConsoleColor.Magenta);
            DateTime created_at = DateTime.Now;

            Console.WriteLine();
        }

        private void WriteLine( string message, ConsoleColor color,bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if(resetColor)
                Console.ResetColor();
        }
    }
}
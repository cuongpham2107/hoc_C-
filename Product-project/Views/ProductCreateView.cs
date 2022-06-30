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
            string name = InputString("Ten san pham:");
            int price = InputInt("Gia san pham:");
            string image =  InputString("Hinh anh san pham:");
            int quantity =InputInt("So luong san pham:");
            DateTime created_at = DateTime.Now;
            Console.WriteLine();
        }

        private static void WriteLine( string message, ConsoleColor color,bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if(resetColor)
                Console.ResetColor();
        }
        private static int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);
                var result = int.TryParse(str, out int i);
                if(result == true)
                {
                    return i;
                }
            }
        }
        private static string InputString(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            WriteLine($"{label}", labelColor, false);
            Console.ForegroundColor = valueColor;
            string value = Console.ReadLine();
            Console.ResetColor();
            return value;
        }
    }
}
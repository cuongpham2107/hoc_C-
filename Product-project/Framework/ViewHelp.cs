
using System;


namespace Framework
{
	public static class ViewHelp
	{
		/// <summary>
        /// Xuất thông tin ra console với mấu sắc(WriteLine)
        /// </summary>
        /// <param name="massage">Thông tin cần xuất</param>
        /// <param name="color">mầu chữ</param>
        /// <param name="resetColor">trả lại mầu sắc mặc định</param>
		public static void WriteLine(string massage, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(massage);
            if (resetColor)
                Console.ResetColor();
        }
        /// <summary>
        /// Xuất thông tin ra console với mầu sắc (Write)
        /// </summary>
        /// <param name="massage">Thông tin cần xuất </param>
        /// <param name="color">Mầu chữ</param>
        /// <param name="resetColor">Trả lại mầu mặc định</param>
        public static void Write(string massage, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.Write(massage);
            if (resetColor)
                Console.ResetColor();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="oldValue"></param>
        /// <param name="labelColor"></param>
        /// <param name="valueColor"></param>
        /// <returns></returns>
        public static string InputString(string label, string oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}", labelColor);
            WriteLine(oldValue, ConsoleColor.Yellow);
            Write("New Value >> ", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string newValue = Console.ReadLine();
            return string.IsNullOrEmpty(newValue.Trim()) ? oldValue : newValue;
        }
        public static int InputInt(string label, int oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}:", labelColor);
            WriteLine($"{oldValue}", ConsoleColor.Yellow);
            Write("New value >>", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                return oldValue;
            if (str.ToInt(out int i))
                return i;
            return oldValue;
        }
    }

}

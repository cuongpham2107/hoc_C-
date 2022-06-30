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
        public static int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);//phương thức tĩnh gọi phương thức tĩnh khác trong cùng class
                var result = int.TryParse((string?)str, out int i);
                if(result == true)
                {
                    return i;
                }    

            }
        }
        /// <summary>
        /// Cập nhập giá trị kiểu string. Nếu ấn enter  mà không nhập dữ liệu sẽ trả lại giá trị trị cũ
        /// </summary>
        /// <param name="label">dòng thông báo</param>
        /// <param name="oldValue">Giá trị gốc</param>
        /// <param name="labelColor">Màu chữ thông báo</param>
        /// <param name="valueColor">Màu chữ dữ liệu</param>
        /// <returns></returns>
        private static object InputString(string label,string oldValue, ConsoleColor labelColor = ConsoleColor.Magenta , ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}: ", labelColor, false);
            WriteLine(oldValue, ConsoleColor.Yellow);
            Write("New Value >> ", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string newValue = Console.ReadLine();
            return string.IsNullOrEmpty(newValue.Trim()) ? oldValue :newValue;
        }

        
       
	}

}

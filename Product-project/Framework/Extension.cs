using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public static class Extension
    {
        /// <summary>
        /// Biến đổi từ chuỗi sang số nguyên
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
        /// <summary>
        /// Biến đổi từ chuỗi sang số nguyên
        /// </summary>
        /// <param name="value"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool ToInt(this string value, out int i)
        {
            return int.TryParse(value, out i);
        }
        /// <summary>
        /// Biến đổi chuỗi Y,y,True,true,sang true
        /// Các chuỗi khác thành false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBool(this string value)
        {
            var v = value.ToLower();
            if (v == "y" || v == "true")
                return true;
            return false;
        }
        public static string ToString(this bool value, string format)
        {
            if (format == "y/n")
                return value ? "Yes" : "No";
            if (format == "c/k")
                return value ? "Có" : "Không";
            return value ? "True" : "False";
        }


    }
}

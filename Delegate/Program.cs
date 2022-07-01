using System;

namespace ConsoleApp
{
    /* khai báo kiểu delegate MathFunction:
        -kiểu này có mô tả là (double) -> double
        -nghĩa là có thể gán bất kỳ hàm nào "nhận biến kiểu double, trả về kiểu double" cho biến thuộc kiểu MathFunction
    */
    internal delegate double MathFunction(double x);
    //giả lập về việc vẽ đồ thị hàm số
    internal class Graph
    {
        /*Khai báo property thuộc kiểu MathFunction.
        MathFunction được sử dụng như những kiểu dữ liệu thông thường
        */
        public MathFunction Function {get;set;}
        /*phương thức này có 1 tham số đầu vào là kiểu delegate MathFunction.
        Kiểu delegate làm tham số không khác gì kiểu dữ liệu bình thường
        */
        public void Render(MathFunction function, double[] range)
        {
            //có thể gán biến thuộc kiểu delegate như bình thường
            Function = function;
            //vì 
        }
    }

}
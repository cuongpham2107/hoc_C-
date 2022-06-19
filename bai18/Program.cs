using System;

namespace bai18
{

    class Program{
        static void Main(string[] args)
        {
            //từ khoá null , nullable
            //null sử dụng cho biến kiểu tham chiếu

            //khai báo kiểu tham trị nhận giá trị null

            int? age;
            age = null; 
            age =100;
            if(age != null){
                int _age = (int)age;//ép kiểu age sang kiểu int
                System.Console.WriteLine(_age);
            }

        }
    }
}
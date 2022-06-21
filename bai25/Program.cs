using System;
using static MyException.ExceptionEmpty;

namespace bai25
{
    // cơ chế bắt lỗi phát sinh chương trình kết thúc đột ngột
    class Program{
        static void Register(string name, int age)
        {
            //Vd 1: 
            // if(string.IsNullOrEmpty(name))//Nếu khác null khác rỗng == IsNullOrEmpty
            // {
            //     Exception exception = new Exception("Tên phai khac rỗng");
            //     throw exception;
            // }
            // Console.WriteLine($"Xin chao {name} ({age})");


            // VD:2
            if(string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();

            }
            if(age < 18 || age > 100)
            {
                throw new AgeException(age);
            }
            Console.WriteLine($"Xin chao {name} ({age})");
            
                
        }
        public static void Main(string[] args)
        {
            try{
                Register("Pham Manh Cuong", 15);
            }
            catch(NameEmptyException nee)
            {
                Console.WriteLine(nee.Message);
                
            }
            catch(AgeException age)
            {
                Console.WriteLine(age.Message);
                age.Detail();
                
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                
            }

            // Register("" ,20);
        //     int a = 5;
        //     int b = 4;

        //     //Exception
        //     try
        //     {
        //         //các lệnh
        //         var c = a / b; 
        //         //phát sinh đối tượng lớp Exception, kế thừa Exception
        //         int[] i = {1,2};
        //         var x = i[5];
        //         Console.WriteLine(c);
        //     }
        //     catch(DivideByZeroException e)
        //     {
        //         Console.WriteLine(e.Message);
               
                
                
        //         Console.WriteLine("Phép chia có lỗi");
                
        //     }
        //     catch(Exception e1)
        //     {
        //         Console.WriteLine(e1.Message);
        //         Console.WriteLine(e1.StackTrace);
        //         Console.WriteLine(e1.GetType().Name);
                
                
        //     }
        //     Console.WriteLine("Kết thúc chương trình");
            
           
            // string path = null;
            // try{
            //     string s = File.ReadAllText(path);
            //     Console.WriteLine(s);
            // }
            // catch(FileNotFoundException fnfe){
            //     Console.WriteLine(fnfe.Message);
            //     Console.WriteLine($"File không tồn tại");
                
                
            // }
            // catch(ArgumentException ane){
            //     Console.WriteLine(ane.Message);
            //     Console.WriteLine($"Đường đãn file phải khác null");
            // }
            // catch(Exception e){
            //     Console.WriteLine(e.Message);
                
            // }
            // Console.WriteLine("Kết thúc chương trình");

            
        }

    }
}
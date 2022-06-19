using System;


//delegate (Type) bien = phuongthuc
namespace CS_Delegate
{
    public delegate void ShowLog(string message); 
    public class Program{
        static void Info(string s)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            
            
            System.Console.WriteLine(s);
            System.Console.ResetColor();
        }
        static void Warning(string s)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            
            
            System.Console.WriteLine(s);
            System.Console.ResetColor();
        }
        static int Tong(int a, int b) => a+b;
        static int Hieu(int a, int b) => a-b;

        static void TinhTong(int a, int b, ShowLog log)
        {
            int kq = a +b;

            log?.Invoke($"Tong la {kq}");
        }
        static void TinhHieu(int a, int b, ShowLog log)
        {
            int kq = a  - b;

            log?.Invoke($"Hieu la {kq}");
        }
        // delegate int Kieu1();
        static void Main(string[] args){
            // ShowLog? log = null; // +=


            // log = Info;

            // // log("Xin chao");

            // log?.Invoke("Xinchao abc");

            // log = Warning;
            // log("Hoc ve delegate");
            // log += Info;
            // log += Warning;

            // log?.Invoke("Xin chao cac bạn");
            
            //Action, Func : Delegate ~ gereric

            // Action action;              //~delegate void Kieu()    
            // Action<string, int> action1;//~delegate void Kieu(string s, int i)

            // Action<string>action2;//~delegate void Kieu(string s)

            // action2 = Warning;
            // action2 += Info;
            // action2?.Invoke("Thong bao tu Action ");

            // //sử dụng Func Phải có kiểu trả về
            // Func<int> f1;                   //~delegate int Kieu();;
            // Func<string, double, string> f2;//~delegate string Kieu(string s, double s);

            //VD
            Func<int, int, int> tinhtoan;

            int a= 5;
            int b= 10;
            tinhtoan = Tong;
            System.Console.WriteLine($"Tong la {tinhtoan(a, b)}");


            TinhTong(4,5,Info);
            TinhHieu(4,5,Warning);


        }
    }
}
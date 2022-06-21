
using System;

namespace bai22
{
    public delegate void SuKienNhapSo(int x);
    /*
        publisher -> class - phát sự kiện
        subsriber -> class - nhân sự kiện
    */

    //publisher
    class UserInput
    {
        //khai báo với event
        // public event SuKienNhapSo suKienNhapSo ;
        
        //~delegate void KIEU(object? sender, EventArgs args)
        public event EventHandler sukiennhapso;

        class Dulieunhap : EventArgs
        {
            public int data{get;set;}
            public Dulieunhap(int x) => data = x;
        }
        
        public void Input(){
           do
            {
                Console.WriteLine("Nhap vao so nguyen:");
                string s = Console.ReadLine();
                int i  = Int32.Parse(s);
                //phát đi sự kiện
                // suKienNhapSo?.Invoke(i);//không sử dụng EventHandler
                sukiennhapso?.Invoke(this , new Dulieunhap(i));


            }
           while(true);
        }
    }

    //subsriber
    class TinCan
    {
        public void Subsriber(UserInput input){
            input.sukiennhapso += Can;
        }

        //~delegate void KIEU(object? sender, EventArgs args)
        public void Can(object sender, EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int i = dulieunhap.data;
            Console.WriteLine($"Can ban 2 cua {i} la {Math.Sqrt(i)}");
        }
    }

    class BinhPhuong
    {
         public void Subsriber(UserInput input){
            input.sukiennhapso += TinhBinhPhuong;
            // phép toán += đăng ký nhận sự kiện
            // phép toán -= huỷ đăng ký nhận sự kiện
        }

         //~delegate void KIEU(object? sender, EventArgs args)
        public void TinhBinhPhuong(object sender, EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int i = dulieunhap.data;
            Console.WriteLine($"Binh phuong cua {i} la {i * i}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine();
                Console.WriteLine("Thoát ứng dụng");
            };
            //publisher
            UserInput userInput = new UserInput();

            userInput.sukiennhapso += (sender, e) => {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                Console.WriteLine($"Bạn vừa nhập so:" + dulieunhap.data);
                
            };
           
            //subsriber
            TinCan tinhCan = new TinCan();
            tinhCan.Subsriber(userInput);

            //subsriber
            BinhPhuong binhPhuong = new BinhPhuong();
            binhPhuong.Subsriber(userInput);


            userInput.Input();
           
            
        }
    }
}
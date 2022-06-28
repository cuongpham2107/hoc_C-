using System;

namespace ATM
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            
            // Console.WriteLine($"Nhap Ten cua ban : ");
            // string name = Console.ReadLine();
            
            // Console.WriteLine($"Nhap Tuoi cua ban : ");
            // int age = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Nhap Đia Chi cua ban : ");
            // string address = Console.ReadLine();
            string Password = "12345678";
            double ToTal = 100000000;
            bool IsLogin = false;
            double amount = default;

            Console.WriteLine($"<------Xin chao ban den voi cay ATM ! ------>");
            Console.WriteLine($"1. Dang nhap tai khoan");
            Console.WriteLine($"2. Kiem tra thong tin tai khoan");
            Console.WriteLine($"3. Rut tien");
            Console.WriteLine($"4. Nap tien vao tai khoan");
            Console.WriteLine($"5. Thoat");
            while(true){
                Console.WriteLine($"Xin moi ban chon yeu cau:");
                int option  = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Xin moi ban nhap mat khau:");
                        string p =  Console.ReadLine();

                        if(String.Compare(p, Password) == 0){
                            IsLogin = true;
                            Console.WriteLine($"Ban da dang nhap thanh cong");

                        }else{
                            Console.WriteLine($"Sai Mat khau vui long nhap lai");
                        }
                        break;
                    case 2:
                        if(IsLogin == true){
                            Console.WriteLine($"So tien trong tai khoan cua ban la: {ToTal.ToString("N")}");
                        }else{
                            Console.WriteLine($"Ban chua dang nhap tai khoan");  
                        } 
                        break;
                    case 3:
                        if(IsLogin == true)
                        {
                            Console.WriteLine($"Nhap So Tien Ban Muon Rut: ");
                            amount =double.Parse(Console.ReadLine());
                            if(amount > 0 && amount <= ToTal){
                                Console.WriteLine($"Ban da rut : {amount.ToString("N")}");
                                ToTal = ToTal - amount;
                            }else{
                                Console.WriteLine($"So tien ban nhap khong hop le"); 
                            }
                        }
                        else{
                            Console.WriteLine($"Ban chua dang nhap tai khoan");
                        }
                        break;
                    case 4:
                        if(IsLogin == true){
                            Console.WriteLine($"Nhap So Tien Ban Muon Nap: ");
                            amount =double.Parse(Console.ReadLine());
                            if(amount > 0){
                                Console.WriteLine($"Ban nap la : {amount.ToString("N")}");
                                ToTal = ToTal + amount;
                            }
                            else{
                                Console.WriteLine($"So tien ban nhap khong hop le"); 
                            }
                        }else{
                            Console.WriteLine($"Ban chua dang nhap tai khoan");  
                        } 
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            
            


            //Console.WriteLine($"Ban Ten: {name}, {age} tuoi, o {address}");
            


        }
    }
}
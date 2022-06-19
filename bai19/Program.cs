using System.Text.RegularExpressions;
using System;

namespace bai19
{
    //1. virtual method
    //2. abstract lớp trìu tượng

    //3. Interface 

    abstract class Product{
        protected double Price{ get; set;} //phương thức này có thể bị định nghĩa lại, hoặc bị ghi đè ở lớp kế thừa


        // //phương thức này có thể bị định nghĩa lại, hoặc bị ghi đè ở lớp kế thừa
        // public virtual void ProductInfo()
        // {
        //     System.Console.WriteLine($"Giá san phẩm {Price}");
        // }

        public abstract void ProductInfo();
        



        public void Test()=>ProductInfo();
    }

    class Iphone : Product{
        public Iphone() => Price = 500;
        
        //tương tự
        // public Iphone()
        // {
        //     Price = 500;
        // }

        //override cho biết phương thức này sẽ ghi đè  public virtual void ProductInfo(), việc này chúng ta gọi là nạp chồng phương thức
        public override void ProductInfo()
        {
            System.Console.WriteLine("Điện thoại Iphone");  
            System.Console.WriteLine($"Gia san pham {Price}");

            // base.ProductInfo();
            //gọi cả phương thứ được định nghĩa ở lớp cơ sở
        }
    }


    interface IHinhHoc 
    {
        public double TinhChuVi();

        public double TinhDienTinh();


    }

    class HinhChuNhat : IHinhHoc, Giaodien2, Giaodien3
    {
        public HinhChuNhat( double _a, double _b){
            a = _a;
            b = _b;
        }
        public double a {get; set;}
        public double b { get; set; }

        public double TinhChuVi(){
            return (a + b)*2;
        }
        public double TinhDienTinh(){
            return a * b;
        } 
    }
    class HinhTron : IHinhHoc{
        public double r {get ; set ;}
        public HinhTron( double _r) => r = _r;

        public double TinhChuVi() => 2 * r *Math.PI; 
        public double TinhDienTinh() => Math.PI * r * r;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Nạp chồng phương thức virtual-override
            // Iphone i = new Iphone();
            // i.Test();

            // Product p = new Product();

            // HinhChuNhat h = new HinhChuNhat(5, 10);

            HinhTron t = new HinhTron(5);
            
            System.Console.WriteLine($"Diện tính là: {t.TinhDienTinh()}, Chu Vi là: {t.TinhChuVi()}");
            
        }
    }
}
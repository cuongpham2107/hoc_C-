

// using System;
// using System.Linq;

// namespace Cs_Lambda
// {

//     /*
//     Lambda - bieu thuc vo danh funcion
//     1) 
//     (int a, int b) => bieu_thuc;


//     2)
//     (int a, int b)=> {
//         cac bieu_thuc;
//         return bieu_thuc_tra_ve;
//     }
//     */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // 1)
//             //VD:1
//             // Action<string> thongbao;
//             // thongbao = (string s) => Console.WriteLine(s); //delegate void Kieu(string s) == Action<string>

//             // for (int i = 0; i < 10; i++)
//             // {
//             //     thongbao?.Invoke("Xinchao");
//             // }

//             //VD:2
//             // Action thongbao;
//             // thongbao = () => System.Console.WriteLine("Xin chao cac ban");
//             // thongbao?.Invoke();

//             //VD:3
//             // Action<string> xinchao;
//             // xinchao = (string s)=>System.Console.WriteLine(s);
//             // xinchao?.Invoke("Xin chào");

//             //VD4:

//             // Action<string, string> xinchao;
//             // xinchao = (mgs, name) => {
//             //     System.Console.ForegroundColor = ConsoleColor.Yellow;
//             //      Console.WriteLine(mgs+ " " + name);
//             //      System.Console.ResetColor();
//             // };
           
//             // xinchao?.Invoke("Xin chào", "Pham Manh Cuong");
//             //  xinchao?.Invoke("Xin chào", "Hoàng thị thúy quỳnh");


            



//             // 2)
//             Func<int, int,int> tinhtoan;

//             tinhtoan = (int a, int b) => 
//             {
//                 int kq = a + b;

//                 return kq;
//             };
//             System.Console.WriteLine(tinhtoan.Invoke(5,6));
//         }
//     }
// }

using System;
using System.Linq;

namespace Lambda
{   
    public class Program
    {
        static void Main(string[] args){
            int[] mang = {1,2,3,4,5,6,7,8,9};

            //Vd 1:
            // var kq = mang.Select((int x) => { 
            //     return Math.Sqrt(x);
            // });
            // foreach (var item in kq)
            // {
            //     System.Console.WriteLine(item);
            // }


            // VD:2
            // mang.ToList().ForEach(
            //     (int x) => {
            //         if(x % 2 != 0){
            //             System.Console.WriteLine(x);
            //         }

            //     }
            // );

            // VD3:

           var kq =  mang.Where(
                (int x) => {
                    return x % 4 == 0;
                }
            );
            foreach (var item in kq)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
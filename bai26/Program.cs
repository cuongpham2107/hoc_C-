using System;
using System.Collections.Generic;

namespace bai26
{
    public class Program
    {
        //List 
        #region 
        // public static void Main(string[] args)
        // {
        //     List<int> ds1 = new List<int>() {7, 8, 9};

        //     ds1.Add(1);
        //     ds1.Add(2);
        //     ds1.AddRange(new int[] {2,3,4});

        //     // Console.WriteLine(ds1.Count);
        //     // Console.WriteLine(ds1[3]);//truy cap phan tu thu nhat
        //     // Console.WriteLine(ds1.Count - 1);//truy cap phan tu cuoi cung
            
        //     ds1.Insert( 0 , 10);//Insert phan tu vao danh sach
        //     //ds1.InsertRange();//Insert nhom phan tu vao danh sach
            

            
        //     ds1.Add(9);
        //     ds1.Add(9);
        //     ds1.Add(9);

        //     ds1.RemoveAt(2);//xoa vi tri phan tu trong danh sach
            
        //     ds1.Remove(9);//xoa di phan tu 9 dau tien ma no bat gap
        //     ds1.Remove(9);//tiep tuc xoa phan tu 9 thu hai
        //     //ds1.RemoveAll();//xoa het cac han tu trong danh sach hoac ds1.Clear();

        //     var n = ds1.Find(
        //         (e) => {
        //             return e > 5 ;

        //         }//delegate
        //     );//tra ve phan tu dau tien ma no tim thay
        //     Console.WriteLine(n);
            
        //     var results = ds1.FindAll(
        //         (e) => {
        //             // return e > 5 ;
        //             return e % 3 == 0;
        //         }
        //     );
        //     foreach (var item in results)
        //     {
        //         Console.WriteLine(item);
                
        //     }
            
        //     // foreach (var item in ds1)
        //     // {
        //     //     Console.WriteLine(item);
                
        //     // }
            

        //     // List<string> ds2;


        // }
        #endregion
        


        class Product
        {
            public string Name { get; set; }
            
            public double Price { get; set; }
            public int  ID { get; set; }
            public string Origin { get; set; }
            
            
            
            
        }
        //List
        #region 
        // public static void Main(string[] args)
        // {
        //     List<Product> products = new List<Product>(){
        //         new Product() {
        //             Name = "Iphone X" , Price = 1000, Origin="China", ID = 1
        //         },
        //         new Product() {
        //             Name = "Iphone 11" , Price = 2000, Origin="Japan", ID = 2
        //         },
        //         new Product() {
        //             Name = "Iphone 12" , Price = 3000, Origin="Vietnam", ID = 3
        //         },
        //         new Product() {
        //             Name = "Iphone 13" , Price = 4000, Origin="China", ID = 4
        //         },

        //     };

        //     //Japan
        //     var a = products.Find(
        //         (a) => {
        //             return a.Origin == "Japan";
        //         }
        //     );
        //     if(a != null){
        //          Console.WriteLine($"San pham san xuat tai Japan");
        //         Console.WriteLine($"{a.Name}  - {a.Price} - {a.Origin} ");
        //     }
        //     else{
        //         Console.WriteLine($"Khong ton tai san pham");
                
        //     }
        //     //<= 2000

        //     var b = products.FindAll(
        //         (b) => {
        //             return b.Price <= 2000 ;
        //         }
        //     );
        //     if(b != null){
        //          Console.WriteLine($"Danh sach san pham nho hon 2000");
        //         foreach (var item in b)
        //         {
                    
        //              Console.WriteLine($"{item.Name}  - {item.Price} - {item.Origin} ");
        //         }
               
        //     }
        //     else{
        //         Console.WriteLine($"Khong ton tai san pham");
                
        //     }

        //     //Tim tat ca cac san pham bat dau bang chu "S"
        //     var c = products.FindAll(
        //         (c) => {
        //             return c.Origin.StartsWith("C");//Tim tat ca cac san pham co Origin bat dau bang chu C
        //         }
        //     );
        //     if(c != null){
        //         Console.WriteLine($"Danh sach san pham co Origin bat dau bang chu C");
        //         foreach (var item in c)
        //         {
        //              Console.WriteLine($"{item.Name}  - {item.Price} - {item.Origin} ");
                    
        //         }
        //     }
        //     else{
        //         Console.WriteLine($"Khong ton tai san pham");
        //     }


        //     products.Sort(
        //         (p1, p2) => {
        //             if(p1.Price == p2.Price)
        //                 return 0;
        //             if(p1.Price < p2.Price)
        //                 return 1;
        //             return -1;
        //         }
        //     );
        //     Console.WriteLine($"-----------Sap xep----------");
            
        //     foreach (var item in products)
        //     {
        //         Console.WriteLine($"{item.Name}  - {item.Price} - {item.Origin} ");
        //     }
            
        // }
        #endregion
    

        //SortedList => key/value
        //tang toc do truy cap tim kiem theo key

        //truy cap den cac key nham tang toc do truy van
        #region 
        public static void Main(string[] args)
        {
            SortedList<string, Product> products = new SortedList<string, Product>();

            products["sanpham1"] = new Product(){
                Name="Iphone", Price = 10000, Origin = "China"
            };
            products["sanpham2"] = new Product(){
                Name="Iphone X", Price = 20000, Origin = "Vietnam"
            };

            products["sanpham3"] = new Product(){
                Name="Iphone 11", Price = 30000, Origin = "Japan"
            };

            products["sanpham4"] = new Product(){
                Name="Iphone 12", Price = 40000, Origin = "China"
            };

            products.Add("sanpham5", new Product(){
                Name="Iphone 13", Price = 50000, Origin = "China"
            });

            //  VD:1   
            // var p = products["sanpham2"];

            //  Console.WriteLine($"{p.Name}  - {p.Price} - {p.Origin} ");

            // var keys = products.Keys;
            // var values = products.Values;

            // foreach (var item in keys)
            // {
            //     var product = products[item];
            //     Console.WriteLine(product.Name);
                
            // }

            // VD:2
            foreach (KeyValuePair<string, Product> item in products)
            {
                var key = item.Key;
                var val = item.Value;
                Console.WriteLine($"{key} - {val.Name}");
                
            }
            products.Remove("sanpham1");
            products.RemoveAt(0);
            

            products.Clear();


        }
        #endregion
    }
}
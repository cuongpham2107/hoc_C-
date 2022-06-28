using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public decimal? Amount { get; set; }
        public int Brand { get; set; }

        public Product(int id, string name, double price, string[] colors, decimal amount, int brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Colors = colors;
            Amount = amount;
            Brand = brand;
        }
        public override string ToString() => $" {Id}    {Name}    {Price}   {Brand}     {string.Join(",",Colors)}   {Amount}";
    }
    public class Brand
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var brands = new List<Brand>()
            {
                new Brand{ID = 1, Name = "Apple",Desc = "Apple"},
                new Brand{ID = 2, Name = "SamSung" , Desc = "SamSung"},
                new Brand{ID = 3, Name = "Nokia" , Desc = "Nokia"}
            };

            var products = new List<Product>()
            {
                new Product( 1, "Iphone 12 ProMax",       19000000,new string[]{"Xám", "Xanh"},             12, 1),
                new Product( 2, "SamSung Note 20 ",       30000000,new string[]{"Xanh", "Đen"},              12, 2),
                new Product( 3, "Nokia 12 ",              20000000,new string[]{"Đen", "Xanh"},             12, 3),
                new Product( 4, "Iphone 13 ProMax",       20000000,new string[]{"Xám", "Nâu"},              12, 1),
                new Product( 5, "Iphone 12 ",             20000000,new string[]{"Đen", "Xám", "Vàng"},      12, 4),
                new Product( 6, "Iphone 11 ",             20000000,new string[]{"Xám", "Xanh","Vàng"},      12, 4),
                new Product( 7, "Iphone X ",              20000000,new string[]{"Xám", "Xanh","Vàng"},      12, 1),
                new Product( 8, "SamSung Galaxy 22 + ",   10000000,new string[]{"Xám", "Xanh"},             12, 2),
            };
            
            #region  Select
            // var query =     from p in products 
            //                 where p.Price == 20000000 
            //                 select p;

            // foreach (var item in query)
            // {
            //     Console.WriteLine($"{item}");
                
            // }     

            
            // var kq =  products.Select(
            //     (p) => {
            //         return new {
            //             Ten = p.Name,
            //             Price = p.Price,

            //         };
            //     }
            // );       

            // foreach (var item in kq)
            // {
            //     Console.WriteLine($"{item}");
                
            // } 
            #endregion
        
            #region  Where
            // var kq = products.Where(
            //     (p) => {
            //         // return p.Name.Contains("phone");//trả về phần tử có chuỗi tr trong Name
            //         // return p.Price >= 20000000 && p.Price <=25000000;
            //         return p.Brand == 1;
            //     }
            // );
            // foreach (var item in kq)
            // {
            //      Console.WriteLine($"{item}");
                
            // }
            #endregion
        
            #region  SelectMany //lấy tất cả các phần tử trong mảng con Product{ colors {} }
            // var kq = products.SelectMany(
            //     (p) => {
            //         return p.Colors;
            //     }
            // );
            // foreach (var item in kq)
            // {
            //     Console.WriteLine($"{item}");
                
            // }
            #endregion
        
            #region  Min, Max, Sum, Average == Giá trị trung bình

            // int[] numbers = {1,2,3,4,5,6,7,8,9};

            // Console.WriteLine($"{numbers.Where(n => n % 2 == 0).Max()}");
            
            // var kq = products
            #endregion
        
            #region Jion
            // var kq = products.Join(
            //     brands,
            //     p => p.Brand, 
            //     b => b.ID , 
            //     (p, b)=>{
            //         return new {
            //             Ten = p.Name,
            //             ThuongHieu = b.Name,
            //         };
            // });
            // foreach (var item in kq)
            // {
            //     Console.WriteLine($"{item}");
                
            // }
            /*
            Kq:
            { Ten = Iphone 12 ProMax, ThuongHieu = Apple }
            { Ten = SamSung Note 20 , ThuongHieu = SamSung }
            { Ten = Nokia 12 , ThuongHieu = Nokia }
            { Ten = Iphone 13 ProMax, ThuongHieu = Apple }
            { Ten = Iphone X , ThuongHieu = Apple }
            { Ten = SamSung Galaxy 22 + , ThuongHieu = SamSung }
            */
            #endregion
           
            #region GroupJion
            // var kq = brands.GroupJoin(
            //     products, 
            //     b => b.ID, 
            //     p => p.Brand,
            //     (brands, pros) => {
            //         return new {
            //             ThuongHieu = brands.Name,
            //             Cacsanpham = pros,
            //         };
            //     });
            // foreach (var item in kq)
            // {
            //     Console.WriteLine($"{item.ThuongHieu}");
            //     foreach (var p in item.Cacsanpham)
            //     {
            //         Console.WriteLine($"{p}");   
            //     } 
            // }
            /*
            Kq: 
            Apple
                1 Iphone 12 ProMax 20000000 1 Xám,Xanh 12
                4 Iphone 13 ProMax 20000000 1 Xám,Nâu 12
                7 Iphone X  20000000 1 Xám,Xanh,Vàng 12
            SamSung
                2 SamSung Note 20  30000000 2 Xám,Den 12
                8 SamSung Galaxy 22 +  10000000 2 Xám,Xanh 12
            Nokia
                3 Nokia 12  20000000 3 Den,Xanh 12
            */
            #endregion
        
            #region Take == lấy 3 phần tử đầu tiên
            // products.Take(3).ToList().ForEach(p => Console.WriteLine(p));
            #endregion
        
            #region Skip == bỏ qua 2 phần tử đầu tiên
            // products.Skip(2).ToList().ForEach(p=>Console.WriteLine($"{p}"));
            #endregion
        
            #region OrderBy(Tăng dần) / OrderByDescending (Giảm dần)
            // products.OrderBy(p => p.Price).ToList().ForEach(p=>Console.WriteLine($"{p}"));
            // products.OrderByDescending(p => p.Price).ToList().ForEach(p=>Console.WriteLine($"{p}"));
            #endregion

            #region Reverse
            // int[] numbers = {1,2,3,4,5,6,7,8,9};
            // Reverse đảo người chuỗi numbers
            // numbers.Reverse().ToList().ForEach(n => Console.WriteLine($"{n}"));
            #endregion

            #region GroupBy == nhóm các sản phẩm
            // Console.WriteLine($"Nhóm theo giá sản phẩm");
            
            // var kq = products.GroupBy(p => p.Price);
            // foreach (var group in kq)
            // {

            //     Console.WriteLine($"{group.Key}");
            //     foreach (var item in group)
            //     {
            //         Console.WriteLine($"{item}");
            //     }
                
            // }

            // Console.WriteLine($"Nhóm theo Brands");
            // var kq_brand = products.GroupBy(p=>p.Brand);
            // foreach (var group in kq_brand)
            // {
            //     Console.WriteLine($"{group.Key}");
            //     foreach (var item in group)
            //     {
            //         Console.WriteLine(item);
                    
            //     }
            // }
            
            #endregion

            #region Distinct == loại bỏ các phần tử có cùng giá trị
            // products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(mau => Console.WriteLine($"{mau}"));
            #endregion

            #region Single / SingeOrDefault == thoả mãn điều khiện thì trả về phần tử

            // var p = products.Single(p => p.Price == 30000000);
            // Console.WriteLine($"{p}");
            //nếu có nhiều phần tử cùng giá hoặc không tìm thấy thì sẽ bị lỗi 
            /*
            single và singleOrDefault khác nhau là singleOrDefault không tìm thấy thì sẽ trả về null 
            */
            // var p = products.SingleOrDefault(p=>p.Price == 20000000);
            // if(p != null)
            // {
            //     Console.WriteLine($"{p}");
            // }
            // else
            // {
            //     Console.WriteLine($"không tìm thấy sản phẩm ");
            // }
            #endregion

            #region Any sẽ trả về true hoặc fales nếu thoả mãm điều kiện logic nào đó
            // var p = products.Any(p=>p.Price == 30000001);
            // Console.WriteLine($"{p}");
            #endregion
             
            #region All sẽ trả về true nếu tất cả sản phẩm thoả mãn điều kiện và ngược lại
            // var p = products.All(p=>p.Price >= 10000000);
            // Console.WriteLine($"{p}");
            
            #endregion

            #region Count đếm các sản phẩm nếu thoả mãn điều kiện
            // var p = products.Count(p => p.Price >= 20000000);
            // Console.WriteLine($"{p}");
            

            #endregion

            #region VD In ra ten san phẩm, tên thương hiệu, có giá (20000000 - 30000000) và giá giảm dần
            // Console.WriteLine($"VD 1: ");
            
            // products.Where(p=>p.Price >= 20000000 && p.Price <= 30000000)
            //         .OrderByDescending(p=> p.Price)
            //         .Join(brands, p => p.Brand, b=> b.ID,
            //             (sanpham, thuonghieu) => {
            //                 return new {
            //                     TenSP = sanpham.Name,
            //                     TenTH = thuonghieu.Name,
            //                     Gia = sanpham.Price,
            //                 };
            //             }
            //         ).ToList().ForEach(info => {
            //             Console.WriteLine($"{info.TenSP , 15} {info.TenTH , 15} {info.Gia , 10}");
            //             //{info.TenTH , 15} lấy ra TenTH và trình bày trong khoảng 15 kí tự
            //         });

            /*
                1) Xác định nguồn dữ liệu: from tenphantu in IEnumerables: mảng, danh sách"LIST",
                    ... where, orderby,...
                2) Lấy dữ liệu: select, group by, ...
            */

            // var query = from p in products select p.Name;
            //cách 1:
            // query.ToList().ForEach(name => Console.WriteLine(name));
            //cách 2:
            // foreach (var item in query)
            // {
            //     Console.WriteLine(item);
                
            // }
            #endregion

            #region API Linq

            #endregion

            #region Truy vấn Linq
            // var qr = from a in products 
            //                 select 
            //                     // $"{a.Name} + {a.Price}";
            //                     new{
            //                         Ten = a.Name,
            //                         Gia = a.Price,
            //                         Abc = "ahsdjkbasld"
            //                     };

            // qr.ToList().ForEach(p => Console.WriteLine($"{p}"));

            // var query = from product in products
            //                         select new {
            //                             Ten = product.Name,
            //                             Gia = product.Price,

            //                         };
            //     query.ToList().ForEach(abc => Console.WriteLine($"{abc}"));
            #endregion

            #region Lọc dữ liệu với mệnh đề Where
            // var qr = from product in products
            //         where product.Price == 20000000 
            //         select new {
            //             Ten = product.Name,
            //             Gia = product.Price,
                        
            //         };
            // qr.ToList().ForEach(abc =>
            // {
            //     Console.WriteLine($"{abc.Ten}    -    {abc.Gia}");
            // });        
            #endregion

            #region mệnh đề Form trong Linq
            // var qr = from product in products
            //             from color in product.Colors

            //             where product.Price >= 20000000 && color == "Xanh"
            //             select new {
            //                 Ten = product.Name,
            //                 Gia = product.Price,
            //                 Cacmau = product.Colors,
            //             };

            // qr.ToList().ForEach(abc =>
            // {
            //     Console.WriteLine($"{abc.Ten} - {abc.Gia} - {string.Join(',',abc.Cacmau)}");
                
              

            // });        
            #endregion

            #region Sắp xếp với mệnh đề orderBy 
            // var qr = from product in products 
            //             from color in product.Colors
            //             where product.Price >= 20000000 && color == "Xanh"
            //             orderby product.Price ascending
            //             select new {
            //                 Ten = product.Name,
            //                 Gia = product.Price,
            //                 Cacmau = product.Colors,
            //             };
            //     qr.ToList().ForEach(abc => {
            //         Console.WriteLine($"{abc.Ten} - {abc.Gia} - {string.Join(',', abc.Cacmau)}");
                    
            //     });

            #endregion

            #region Nhóm kết quả với groupBy 
            
            // var query = from p in products 
            //             group p by p.Price into gp
            //             orderby gp.Key
            //             select gp;

            // query.ToList().ForEach(gr => {
            //     Console.WriteLine(gr.Key);
            //     gr.ToList().ForEach(p => Console.WriteLine(p));
                
            // });
            #endregion

            #region Biến trong Linq, Từ khoá let
            //Đối tượng:
            //Giá
            //Các sản phẩm
            //Số lượng

            // var query = from p in products
            //             group p by p.Price into gr
            //             orderby gr.Key
            //             let sl = "So luong là:" + gr.Count()
            //             select new {
            //                 Gia = gr.Key,
            //                 Cacsanpham = gr.ToList(),
            //                 Soluong = sl,
            //             };
            // query.ToList().ForEach(i => {
            //     Console.WriteLine(i.Gia);
            //     Console.WriteLine(i.Soluong);
            //     i.Cacsanpham.ForEach(p=>Console.WriteLine(p));
            // });
            #endregion

            #region Kết hợp với Join

            //in ra nhưng sản phẩm có thương hiệu
            // var kq = from p in products 
            //         join b in brands on p.Brand equals b.ID 
            //         select new {
            //             Ten = p.Name,
            //             Gia = p.Price,
            //             ThuongHieu = b.Name,
            //         };
            // kq.ToList().ForEach(o=>{
            //     Console.WriteLine($"{ o.Ten } {o.Gia} {o.ThuongHieu}");             
            // });

            //in ra cả những sản phẩm không có thương hiệu
            var kq1 = from p in products
                        join b in brands on p.Brand equals b.ID into T
                        from b in T.DefaultIfEmpty()
                        select new {
                            Ten = p.Name,
                            Gia = p.Price,
                            ThuongHieu = b != null ? b.Name : "No Brand",
                        };
            kq1.ToList().ForEach(a => {
                Console.WriteLine($"{ a.Ten ,10} {a.ThuongHieu,15}    {a.Gia,5}");  
            });
            #endregion



        }
    }
}
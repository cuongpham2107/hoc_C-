using System.Reflection;
using System;

namespace bai32
{
    class Program
    {

        //Type => class, struct, ..., int , bool,...
        //Attribute
        //Reflection: Lấy thôbng tin về kiểu dữ liệu, thời điểm thực thi
        // public static void Main(string[] args)
        // {
        //     // int a;
        //     // Type t1 = typeof(int);
        //     // var t2 = typeof(string);
        //     // var t3 = typeof(Array);


        //     int[] a = {1,2,3,4};

        //     Type t = a.GetType();
        //     Console.WriteLine(t.FullName);
        //     Console.WriteLine($"-----------Các thuộc tính-----------");
            
        //     t.GetProperties().ToList().ForEach(
        //         (PropertyInfo  o) => {
        //             Console.WriteLine(o.Name);
                    
        //         }
        //     );
        //     Console.WriteLine($"-----------Các trường dữ liệu-----------");
            
        //     t.GetFields().ToList().ForEach(
        //         (FieldInfo  o) => {
        //             Console.WriteLine(o.Name);
                    
        //         }
        //     );

        //     Console.WriteLine($"-----------Các phương thức-----------");
            
        //     t.GetMethods().ToList().ForEach(
        //         (MethodInfo  o) => {
        //             Console.WriteLine(o.Name);
                    
        //         }
        //     );
        // }

        /*
        Mô tả:
            -Thông tin chi tiêts
        */

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
        class MotaAttribute : Attribute
        {
            public string Thongtinchitiet{get;set;}
            public MotaAttribute(string _Thongtinchitiet){
                Thongtinchitiet = _Thongtinchitiet;
            }
        }
        [Mota("Lớp chứa thông tin vê User trên hệ thống")]
        class User
        {
            [Mota("Tên người dùng")]
            public string Name { get; set; }
            [Mota("Dữ liệu tuổi")]
            public int Age { get; set; }
            [Mota("Số điện thoại")]
            public string PhoneNumber { get; set; }
            [Mota("Địa chỉ email")]
            public string Email { get; set; }
            public void PrintInfo()=>Console.WriteLine(Name);   
        }
        public static void Main(string[] args)
        {
            User user = new User(){
                Name = "Pham Manh Cuong",
                Age = 23,
                PhoneNumber = "0984 559 557",
                Email = "cuongpham2107@gmail.com",
            };
            // var properties = user.GetType().GetProperties();

            // foreach (PropertyInfo item in properties)
            // {
            //     string name = item.Name;
            //     var value = item.GetValue(user);
            //     Console.WriteLine($"{name} : {value}");
                
            // }
            var  p = user.GetType().GetProperties();
            foreach (PropertyInfo pt in p)
            {
                foreach (var attr in pt.GetCustomAttributes(false))
                {
                    MotaAttribute mota = attr as MotaAttribute;
                    if(mota != null){
                        var value = pt.GetValue(user);
                        var name = pt.Name;
                        Console.WriteLine($"({name}){mota.Thongtinchitiet} : {value}");
                        
                    }
                }
            }
        }
    }


}
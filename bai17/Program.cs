using System;
using System.Linq;

namespace Anonymous_example{
    class   Program
    {
        class SinhVien{
            public string HoTen { get; set; }   
            public int NamSinh { get; set; }    
            public string NoiSinh { get; set; }
        }
        //Anonymous = kiểu dữ liệu vô danh
        //Object - thuộc tính - chi doc
        //new {thuoc tinh = gia tri, thuoc tinh 2 = gia tri 2}
        static void Main(string[] args)
        {
            // <------Anonymous------->
            //VD 1:
            // var sanpham = new {
            //     Ten = "Sting",
            //     NamSx = 2022,
            //     Gia = 10000,
            // };

            // System.Console.WriteLine(sanpham.Ten);
            // System.Console.WriteLine(sanpham.Gia);
            // System.Console.WriteLine(sanpham. NamSx);
            

             //VD 2:
            // List<SinhVien> cacSinhvien = new List<SinhVien>(){
            //     new SinhVien(){HoTen = "Nam",NamSinh = 2000, NoiSinh="Ninh Binh"},
            //     new SinhVien(){HoTen = "Cuong",NamSinh = 2000, NoiSinh="Ninh Binh"},
            //     new SinhVien(){HoTen = "Quynh",NamSinh = 2000, NoiSinh="Ninh Binh"},
            //     new SinhVien(){HoTen = "Hinh",NamSinh = 2000, NoiSinh="Ninh Binh"}
            // };

            // var ketqua = from sv in cacSinhvien
            //             // where sv.NamSinh <= 2001
            //             where sv.HoTen.Contains("a")
            //             select new {
            //                 Ten = sv.HoTen,
            //                 Ns = sv.NoiSinh,
            //             };
            // foreach(var sinhvien in ketqua){
            //     System.Console.WriteLine(sinhvien.Ten + " - " + sinhvien.Ns);
            // }

            // <------End Anonymous------->

            
            // <------Dynamic kieu du lieu dong------->

           Student abc = new Student();
           PrintInfo(abc);
        }
        static void PrintInfo(dynamic obj){
            obj.Name = "Pham Manh Cuong";
            obj.Hello();
        }
        class Student
        {
            public string Name { get; set; }
            public void Hello()=> System.Console.WriteLine(Name);
        }

    }
}

using System.IO;
using System;


namespace bai28
{
    /* - DriveInfo: cung cap thong tin ve 1 o dia nao do
        + DriveType : kiểu ổ đĩa
        + VolumeLabel : nhãn đĩa
        + DriveFormat : chuỗi định dạng
        + TotalFreeSpace : Số byte còn trống
        + TotalSize : Kick thước của ổ đĩa
    */

    /*
        Directory ~ Thu muc
    */

    public class Program
    {   
        //DriveInfo
        #region 
        // public static void Main(string[] args)
        // {
        //     // string file = @"C:\";
        //     // DriveInfo drive = new DriveInfo(file);

        //     // Console.WriteLine($"Drive: {drive.Name}");
        //     // Console.WriteLine($"Drive Type: {drive.DriveType}");
        //     // Console.WriteLine($"Label: {drive.VolumeLabel}");
        //     // Console.WriteLine($"Format: {drive.DriveFormat}");
        //     // Console.WriteLine($"Size: {drive.TotalSize}");
        //     // Console.WriteLine($"Free: {drive.TotalFreeSpace}");

        //     var drives =  DriveInfo.GetDrives();

        //     foreach (var drive in drives)
        //     {
        //         Console.WriteLine($"Drive: {drive.Name}");
        //         Console.WriteLine($"Drive Type: {drive.DriveType}");
        //         Console.WriteLine($"Label: {drive.VolumeLabel}");
        //         Console.WriteLine($"Format: {drive.DriveFormat}");
        //         Console.WriteLine($"Size: {drive.TotalSize}");
        //         Console.WriteLine($"Free: {drive.TotalFreeSpace}");
        //         Console.WriteLine($"-----------------------------");
                
        //     }


        // }
        #endregion
    
        //Directory
        #region 
        public static void Main(string[] args)
        {
            // string path = "Abc";

            // Directory.CreateDirectory(path);//tạo thư mục
            // Directory.Delete(path);//Xoá thưc mục

            // if(Directory.Exists(path))
            // {
            //     Console.WriteLine($"{path} - ton tai");
            // }
            // else
            // {
            //     Console.WriteLine($"{path} - khong ton tai");
            // }

            string path = "obj";
            

            var files = Directory.GetFiles(path);//lấy tất cả các file ở đường dẫn path
            var directories = Directory.GetDirectories(path);//Lấy tất cả các thư mục con
            Console.WriteLine($"Cac file trong thuc muc");
            foreach (var item in files)
            {
                Console.WriteLine($"{item}");
                
            }
            Console.WriteLine($"-----------------");
            Console.WriteLine($"Cac Folder trong thuc muc");
            foreach (var item in directories)
            {
                Console.WriteLine($"{item}");
            }
        }

        static void ListFileDirectory(string path)
        {
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[]
        }
        #endregion
    }
}
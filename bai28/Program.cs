
using System.Text;
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
        // public static void Main(string[] args)
        // {
            // VD1: đọc thông tin file từ ở đĩa
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



            // VD2: Làm việc với Directory
            // string path = "obj";
            

            // var files = Directory.GetFiles(path);//lấy tất cả các file ở đường dẫn path
            // var directories = Directory.GetDirectories(path);//Lấy tất cả các thư mục con
            // Console.WriteLine($"Cac file trong thuc muc");
            // foreach (var item in files)
            // {
            //     Console.WriteLine($"{item}");
                
            // }
            // Console.WriteLine($"-----------------");
            // Console.WriteLine($"Cac Folder trong thuc muc");
            // foreach (var item in directories)
            // {
            //     Console.WriteLine($"{item}");
            // }

        //     string path = "obj";
        //     ListFileDirectory(path);
        // }

        // static void ListFileDirectory(string path)
        // {
        //     String[] directories = System.IO.Directory.GetDirectories(path);
        //     String[] files = System.IO.Directory.GetFiles(path);
        //     foreach (var file in files)
        //     {
        //         Console.WriteLine($"{file}");
        //     }
        //     Console.WriteLine($"-----------------------------");
            
        //     foreach (var directory in directories)
        //     {
        //         Console.WriteLine($"{directory}");
        //         ListFileDirectory(directory);
        //         // Đệ quy để thực hiện duyệt tiếp tất các các thu mục có trong thu mục con
        //     }
        // }
        #endregion
    
        //Path
        #region 
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine(Path.DirectorySeparatorChar);

        //     // var path = Path.Combine("C:", "xampp","htdoc","env.txt");//nối chuỗi thành đường dẫn đến file
            
        //     var path = @"C:\xampp\htdoc\env.txt";
        //     path = Path.ChangeExtension(path, "");//chuyển phần mở rộng env.txt thành env.
        //     var pathRandom = Path.GetRandomFileName();//trả về 1 tên file ngẫu nhiên
        //     Console.WriteLine(pathRandom);

        //     var pathTemp = Path.GetTempFileName();//tạo ra file tạo cps thể lưu trữ dữ liệu tạm thời
        //     Console.WriteLine(pathTemp);
            
            
        //     Console.WriteLine(path);
        //     Console.WriteLine(Path.GetDirectoryName(path));//trả về đường dẫn đến thư mục env.txt
        //     Console.WriteLine(Path.GetExtension(path));//trả về phần mở rộng => .txt
        //     Console.WriteLine(Path.GetFileName(path));//trả về tên file
        //     Console.WriteLine(Path.GetFullPath(path));//trả về đường dẫn đầy đủ
            
            
            
                        
            
        // }
        #endregion
    
        //File
        #region 
        // public static void Main(string[] args)
        // {
        //     string filename = "123.txt";

            // string content = "Xin chào các bạn 2022";
            // File.WriteAllText(filename,content);

            // File.AppendAllText(filename,content);//Nội dung file cũ được dữ lại và thêm nội dung mới

            // string content = File.ReadAllText(filename);//đọc nội dung của File
            // Console.WriteLine($"{content}");

            // File.Move(filename, "123.txt");//đổi tên file cũ thành tên mới

            // File.Copy(filename, "345.txt");//copy  và tạo file mới

        //     File.Delete(filename);//xoá file
            
        // }
        #endregion
    
        //FileStream
        /*
            - Biểu diễn các dự liệu ra vào tuần tự
            - Lớp ra vào tuần tự
        */
        #region 
        // public static void Main(string[] args)
        // {
        //     string path = "data.dat";
            
        //     using var stream = new FileStream(path: path, FileMode.OpenOrCreate);

        //     //lưu dữ liệu

        //     byte[] buffer = {1,2,3};
        //     int offset = 0 ;//là offset đầu tiên bắt dầu
        //     int count = 3 ; 
        //     stream.Write(buffer, offset, count);

        //     //đọc dữ liệu
        //    int  sobytedocduoc =  stream.Read(buffer, offset, count);
        //    Console.WriteLine($"{sobytedocduoc}");

        //    //int, double, => bytes
        //    int abc = 1;
        //    var bytes_abc = BitConverter.GetBytes(abc);

        //    //bytes => int, double ..
        //    BitConverter.ToInt32(bytes_abc, 0);


        //    //string => bytes
        //     string s = "ABC";
        //     var bytes_s = Encoding.UTF8.GetBytes(s);

        //     //Bytes => string

        //     Encoding.UTF8.GetString(bytes_s, 0 , 10);
           
        // }
        #endregion
    

        //Thực hành
        #region 
        class Product
        {
            public int ID {get; set;}
            public double Price {get;set;}
            public string Name { get; set; }
            
            public void Save(Stream stream)
            {
                // int -> 4 byte 
                var bytes_id = BitConverter.GetBytes(ID);
                stream.Write(bytes_id, 0, 4);


                //double -> 8 byte
                var bytes_price = BitConverter.GetBytes(Price);
                stream.Write(bytes_price, 0, 8);

                //string -> 
                var bytes_name = Encoding.UTF8.GetBytes(Name);
                var bytes_length = BitConverter.GetBytes(bytes_name.Length);
                stream.Write(bytes_name, 0, 4);
                stream.Write(bytes_name, 0 , bytes_name.Length);
            }
            public void Restore(Stream stream)
            {
                var bytes_id = new byte[4];
                stream.Read(bytes_id,0 ,4);
                ID = BitConverter.ToInt32(bytes_id,0);



                var bytes_price = new byte[8];
                stream.Read(bytes_price,0 ,8);
                Price = BitConverter.ToDouble(bytes_price,0);


                var bytes_length = new byte[4];
                stream.Read(bytes_length, 0 ,4);
                int leng = BitConverter.ToInt32(bytes_length,0);
                var bytes_name = new byte[leng];
                stream.Read(bytes_name, 0 , leng);
                Name = Encoding.UTF8.GetString(bytes_name,0,leng);
            }
        }
        public static void Main(string[] args)
        {
            string path = "data.dat";
            // using var stream = new FileStream(path: path, FileMode.Create);//Lưu trữ


            //Thực hiện lưu trữ
            // Product product = new Product()
            // {
            //     ID = 10,
            //     Price = 12345,
            //     Name = "San pham abc"
            // };
            // product.Save(stream);


            //Thực hiện phục hồi
            using var stream = new FileStream(path: path, FileMode.Open);//Đọc dữ liệu
            Product product = new Product();

            product.Restore(stream);

            Console.WriteLine($"{product.ID} - {product.Name} - {product.Price} ");
            

        }
        #endregion
    }
}
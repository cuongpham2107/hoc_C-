using System;

namespace bai27
{
    public class Program
    {
        //Queue - vao truoc ra truoc hoac vao sau ra sau
        #region 
        // public static void Main(string[] args)
        // {
        //     Queue<string> cachoso = new Queue<string>();


        //     cachoso.Enqueue("ho so 1");//them thanh phan vao hang doi
        //     cachoso.Enqueue("ho so 2");//them thanh phan vao hang doi
        //     cachoso.Enqueue("ho so 3");//them thanh phan vao hang doi
            
        //     foreach (var hs in cachoso)
        //     {
        //         Console.WriteLine(hs);
                
        //     }
        //     //
        //     var hoso = cachoso.Dequeue();//loai bo thanh phan xep hang dau tien cua hang doi
        //     Console.WriteLine($"Xu ly ho so: {hoso} - con lai {cachoso.Count} ");

        //     hoso = cachoso.Dequeue();//loai bo thanh phan xep hang dau tien cua hang doi
        //     Console.WriteLine($"Xu ly ho so: {hoso} - con lai {cachoso.Count} ");

        //     hoso = cachoso.Dequeue();//loai bo thanh phan xep hang dau tien cua hang doi
        //     Console.WriteLine($"Xu ly ho so: {hoso} - con lai {cachoso.Count} ");
            

        // }
        #endregion
        //Stack C
        //vao sau ra truoc hoac vao truoc ra sau
        #region
        // public static void Main(string[] args)
        // {
        //     Stack<string> hanghoa = new Stack<string>();

        //     hanghoa.Push("mat hang 1");
        //     hanghoa.Push("mat hang 2");
        //     hanghoa.Push("mat hang 3");
        //     foreach (var item in hanghoa)
        //     {
        //         Console.WriteLine($"Hang hoa: {item}");
                
        //     }

        //     var mathang = hanghoa.Pop();
        //     Console.WriteLine($"Boc do: {mathang}");

        //     mathang = hanghoa.Pop();
        //     Console.WriteLine($"Boc do: {mathang}");

        //     mathang = hanghoa.Pop();
        //     Console.WriteLine($"Boc do: {mathang}");
        // }
        #endregion
        //LinkedList - danh sach lien ket
        #region 
        // public static void Main(string[] args)
        // {
        //     LinkedList<string> cacbaihoc = new LinkedList<string>();

        //     var bh1 = cacbaihoc.AddFirst("Bai hoc 1");//Them vao dau not
        //     var bh3 = cacbaihoc.AddLast("Bai hoc 3");//Them vao cuoi not

        //     //Cach 1:
        //     // cacbaihoc.AddAfter(bh1, "Bai hoc 2");
        //     //chen vao sau not ("bh1", "du lieu can chen")
        //     //Cach 2:
        //     LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "Bai hoc 2");

        //     cacbaihoc.AddLast("Bai hoc 4");//Them vao cuoi not
        //     cacbaihoc.AddLast("Bai hoc 5");//Them vao cuoi not


        //     // foreach (var item in  cacbaihoc)
        //     // {
        //     //     Console.WriteLine($"cac bai hoc : {item}");
                
        //     // }

        //     // var node = bh2;
        //     // Console.WriteLine(node.Value);

        //     // node = node.Next;//node phai sau 
        //     // Console.WriteLine(node.Value);
        //     // node = node.Next;//node phai sau 
        //     // Console.WriteLine(node.Value);

        //     // node = node.Previous;//node phai truoc
        //     // Console.WriteLine(node.Value);
        //     // node = node.Previous;//node phai truoc
        //     // if(node != null)
        //     // Console.WriteLine(node.Value);



        //     var node = cacbaihoc.Last;//node cuoi cung

        //     while(node != null){
        //         Console.WriteLine(node.Value);
        //         node = node.Previous;
        //     }

        //     // var node = cacbaihoc.First;//node dau tien

        //     // while(node != null){
        //     //     Console.WriteLine(node.Value);
        //     //     node = node.Next;
        //     // }//ddem tu node dau tien den node cuoi cung
            
            
            




        // }
        #endregion
        
        //Dictionary tuong tu nhu SortedList nhung ap dung cho cap du lieu lon
        #region 
        // public static void Main(string[] args)
        // {
        //     Dictionary<string, int> sodem = new Dictionary<string, int>()//string kieu thu thi, int kieu gia tri luu chu

        //     {
        //         ["one"] = 1,//key va value
        //         ["tow"] = 2,
        //     };

        //     //them hoac cap nhat
        //     sodem["three"] = 3;// su dung indexer
        //     sodem.Add("four", 4);

        //     // var keys = sodem.Keys;
        //     // foreach (var k in keys)
        //     // {
        //     //     var value = sodem[k];
        //     //     Console.WriteLine($"{k} = {value}");
                
        //     // }
        //     foreach (KeyValuePair<string, int> item in sodem)
        //     {
        //         Console.WriteLine($"{item.Key} -> {item.Value} ");
                
        //     }
        // }
        #endregion
        
        //HashSet
        //chua danh sach tap hop cac phan tu khong duoc trung nhau ve gia tri
        #region 
        public static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>(){1,2,3,4,5,6};
            HashSet<int> set2 = new HashSet<int>(){8,9,1,2,3,7};


            // set1.Add(11);
            // set1.Remove(6);

            // set1.UnionWith(set2);//phep hop
            set1.IntersectWith(set2);//phep giao
            foreach (var item in set1)
            {
                Console.WriteLine($"{item}");
                //1,2,3
                
            }

        }
        #endregion
    }
}
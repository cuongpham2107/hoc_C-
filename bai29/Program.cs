

using System.Threading.Tasks;
using System.Threading;
using System;

namespace bai29
{
    //Asynchronous (multi thread)

    class Program
    {
        static void DoSomeThing(int seconds, string msg, ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} ... Start");
                Console.ResetColor();
            }



            for (int i = 1; i <= seconds; i++)
            {
                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{msg,10} {i,2}");
                    Console.ResetColor();
                }

                Thread.Sleep(1000);
            }

            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} ... End");
                Console.ResetColor();
            }


        }

        static async Task Task2()
        {
            Task t2 = new Task(
                () => {
                    Console.WriteLine($"-------------");
                    DoSomeThing(10, "T2", ConsoleColor.Green);
                }//delegate
            );//() => {}
            t2.Start();
            await t2;// ~  t2.Wait();
            // t2.Wait();//khi thực thi Wait ở đây đã phá vỡ quy tắc chạy song song của Asynchronous

            Console.WriteLine($"T2 đã hoàn thành");
            
            // return t2;
        }
        static async Task Task3()
        {
            Task t3 = new Task(
            (object ob) => {
                string tentacvu = (string)ob;
                DoSomeThing(4, tentacvu, ConsoleColor.Yellow);
            }, "T3");//(Object ob) => {}

            t3.Start();

            await t3;

            // t3.Wait();
            
            Console.WriteLine($"T3 đã hoàn thành");

            // return t3;
        }
        //async || await

        /* 
        Hàm ví dụ về Task

        static async Task Abc()
        {
            // Task task = new Task(() => {
            //     //...Cac chi thi
            // });
            // task.Start();
            // await task;
            //...

            await File.WriteAllTextAsync("1.txt", "agsdjhgasd");
            //...
        }
        */

        static async Task Abc()
        {
            Task<string> task = new Task<string>(
                () => {
                    //...Các chỉ thị
                    return new object();
                }
            );
            task.Start();
            var kq = await task;
            return kq;
        }
        static async Task<string> Task4()
        {
            Task<string> t4 = new Task<string>(
                 () => {
                    DoSomeThing(10, "T4", ConsoleColor.Green);
                    return "Return from T4";
                }//() => { return string; }
            );
            t4.Start();
            var kq = await t4;
            Console.WriteLine($"T4 hoàn thành");
            return kq;
        }
        static async Task<string> Task5()
        {
            Task<string> t5 = new Task<string>(
                (object ob) => {
                    string t =  (string)ob;
                    DoSomeThing(4, t, ConsoleColor.Yellow);
                    return $"Return from {t}";
                },"T5"
            );
            t5.Start();
            string kq = await t5;
             Console.WriteLine($"T5 hoàn thành");
            return kq;
        }
        public static async Task Main(string[] args)
        {
            #region  synchronous == lập trình đồng bộ
            // Console.WriteLine($"-------------");
            // DoSomeThing(5, "T1", ConsoleColor.Red);
            //  Console.WriteLine($"-------------");
            // DoSomeThing(10, "T2", ConsoleColor.Green);
            //  Console.WriteLine($"-------------");
            // DoSomeThing(4, "T3", ConsoleColor.Yellow);
            #endregion

            #region Asynchronous == lập trình bất đồng bộ
            /*
            -Chạy song song nhiều tác vụ đồng thời
            +Task
            +Task<T>
            */
            // Task t2 = new Task(
            //     () =>
            //     {
            //         Console.WriteLine($"-------------");
            //         DoSomeThing(10, "T2", ConsoleColor.Green);
            //     }//delegate
            // );//() => {}

            // Task t3 = new Task(
            //     (object ob) =>
            //     {
            //         string tentacvu = (string)ob;
            //         DoSomeThing(4, tentacvu, ConsoleColor.Yellow);
            //     }, "T3");//(Object ob) => {}
            // t2.Start();//Thread riêng
            // t3.Start();//Thread riêng
            // DoSomeThing(5, "T1", ConsoleColor.Red);//Thread riêng


            // //Cách 1: t2.Wait();
            // // t2.Wait();//phải chắc chắn thực hiện xong tác vụ mới thực hiện tiếp
            // // t3.Wait();//phải chắc chắn thực hiện xong tác vụ mới thực hiện tiếp

            // //Cách 2: 
            // Task.WaitAll(t2, t3);

            // Console.WriteLine($"Press any key!");
            // Console.ReadLine();

            #endregion

            #region Task
            // Task t2 = Task2();
            // Task t3 = Task3();
            // DoSomeThing(6, "T1", ConsoleColor.Magenta);

            // // Task.WaitAll(t2,t3);
            // await t2;
            // await t3;
            // Console.WriteLine($"Press any key!");
            // Console.ReadLine();
            #endregion

            #region Task<T> //có thể trả về chuỗi
            // Task<string> t4 = new Task<string>(
            //     () => {
            //         DoSomeThing(10, "T4" ,ConsoleColor.Green);
            //         return "Return from t4";
            //     }
            // );//delegate này không tham số () => { return string; }


            // Task<string> t5 = new Task<string>(
            //     (object ob) => {
            //         string t = (string)ob;
            //         DoSomeThing(4, t ,ConsoleColor.Yellow);
            //         return "Return from T5";

            //     },"T5"
            // );//delegate này  (object ob) => { return string; }
            Task<string> t4 = Task4();
            Task<string> t5 = Task5();
            // t4.Start();
            // t5.Start();
            DoSomeThing(6, "T1", ConsoleColor.Magenta);

            // Task.WaitAll(t4,t5);
            

            var kq4 =  await t4;
            var kq5 =   await t5;

            Console.WriteLine(kq4);
            Console.WriteLine(kq5);

            Console.WriteLine($"Press any key!");
            Console.ReadLine();

            #endregion
            /*
            -không được khởi chạy Task 2 lần 
            */
        }
    }
}
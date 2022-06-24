
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Threading;
using System;


namespace Async
{
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
        static async Task<string> GetWeb(string url)
        {
            HttpClient httpClient = new HttpClient();
            Console.WriteLine($"Bat dau tai");
            
            HttpResponseMessage kq =  await httpClient.GetAsync(url);
             Console.WriteLine($"Bat dau doc noi dung");
            string content =  await kq.Content.ReadAsStringAsync();
             Console.WriteLine($"Hoan thanh");
            return content;
        }
        public static async Task Main(string[] args)
        {
            var task = GetWeb("http://netflix.kennatech.vn/");
            
            DoSomeThing(6, "T1", ConsoleColor.Magenta);
            var content =  await task;
            Console.WriteLine(content);
            Console.ReadLine();   

        }
   }
    
}
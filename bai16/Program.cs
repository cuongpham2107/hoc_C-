namespace generic_example{
    class Program{
        class Sanpham<A>
        {
            A ID;
            public void SetID(A _id){
                this.ID = _id;
            }
            public void PrintInfo(){
                System.Console.WriteLine($"ID = {this.ID}");
            }
        }

        static void Main(string[] args){
            // Sanpham<int> sanpham1 = new Sanpham<int>();
            // sanpham1.SetID(123);
            // sanpham1.PrintInfo();
            

            // Sanpham<string> sanpham2 = new Sanpham<string>();
            // sanpham2.SetID("abc123");
            // sanpham2.PrintInfo();
            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();

            Stack<int> stack = new Stack<int>();//vào sau ra trước

            Queue<int> queue = new Queue<int>();//vào trước ra trước



        }
    }
}
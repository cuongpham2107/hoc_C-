namespace MyException
{
    public class ExceptionEmpty
    {
        public class NameEmptyException : Exception
        {
            public NameEmptyException() : base("Tên phải khác rỗng")
            {

            }
        }
        public class AgeException : Exception
        {
            public int age{get ; set;}
            public AgeException( int _age) : base("Tuổi không phù hợp")
            {
                age = _age;
            }

            public void Detail(){
                Console.WriteLine($"Tuoi bang = {age}, không nằm trong khoảng(18 - 100)");
                
            }
        }
    }
}
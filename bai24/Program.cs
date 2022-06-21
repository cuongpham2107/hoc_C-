using System;

namespace bai24 
{   
    class CountNumber
    {
        public static int number = 0;
        public static void Info(){
            Console.WriteLine("So lan truy cap: " + number);
            
        }
        public void Count()
        {
            //number ++
            CountNumber.number++;

        }
    }
    class Student
    {
        public readonly string name;//Chỉ đọc, không được phép gán giá trị cho nó, tuy nhiên trong phương thức khởi tạo được phép gán

        public Student(string _name)
        {
            this.name = _name;
        }

    }
    
    class Vector
    {
        double x;
        double y;

        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public void Info()
        {
            Console.WriteLine($"x = {x}, y = {y}");
            
        }
        // vector + vector = vector

        public static Vector operator+(Vector v1, Vector v2)
        {
            // return new Vector(v1.x +v2.x, v1.y + v2.y);

            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            Vector v = new Vector(x ,y);
            return v;

        }
         public static Vector operator+(Vector v1, double value)
        {
            // return new Vector(v1.x +v2.x, v1.y + v2.y);

            double x = v1.x + value;
            double y = v1.y + value;
            Vector v = new Vector(x ,y);
            return v;

        }
        public double this[int i]
        {
            get
            {
                switch(i)
                {
                    case 0:
                        return x;
                      
                    case 1:
                        return y;
                     
                     default:
                        throw new Exception("Chỉ số sai");
                    break;
                }
            }
            set
            {
                switch(i){
                    case 0: // x
                        x = value;
                    break;
                    case 1:
                        y = value;
                    break;
                    default:
                        throw new Exception("Chỉ số sai");
                    break;

                }
            }
        }
        public double this[string s ]
        {
            get
            {
                switch(s)
                {
                    case "toadox":
                        return x;
                      
                    case "toadoy":
                        return y;
                     
                     default:
                        throw new Exception("Chỉ số sai");
                    break;
                }
            }
            set
            {
                switch(s){
                    case "toadox": // x
                        x = value;
                    break;
                    case "toadoy":
                        y = value;
                    break;
                    default:
                        throw new Exception("Chỉ số sai");
                    break;

                }
            }
        }
    }
    class Program
    {   
        public static void Main(string[] args)
        {
            #region Phương thức tĩnh
            // CountNumber.Info();
            // Console.WriteLine(CountNumber.number);
            // CountNumber c1 = new CountNumber();
            // CountNumber c2 = new CountNumber();
            // c1.Count();
            // c1.Count();
            // CountNumber.Info();



            // Student s = new Student("Pham Manh Cuong");

            // // s.name = "Phạm Mạnh Cường"; //tại vì có readonly nên chỉ có thể đọc
            // Console.WriteLine(s.name);
            #endregion

            #region Quá tải toán tử
            // Vector v1 = new Vector(2,3);
            // Vector v2 = new Vector(1,1);

            // //(x1, y1) + (x2, y2) = (x1 + x2, y1 + y2)
            // var v3 = v1 + v2;
            // var v4 = v1 + 10;
           
           
            // v3.Info();
            // v4.Info();
            #endregion

            #region Quá tải toán tử
               Vector v = new Vector(2,3);
            //    v[0] ~ x
            //    v[1] ~ y

            // v["toadox"] ~ x
            // v["toadoy"] ~ y
            v[0] = 5;
            v[1] =6;
            v.Info();
            Console.WriteLine(v[3]);

            v["toadox"] = 10;
            v["toadoy"] = 20;
            v.Info();
            
            #endregion
            
        }
    }
}
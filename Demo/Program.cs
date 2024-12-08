namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 04 Variable Declaration and Comments
            //// single line comment
            ///* multi  
            // * line
            // * comment
            // */
            //int Number = 10;
            //Console.WriteLine("the number is"+Number);
            //Console.WriteLine($"the number is{Number}");
            //Console.WriteLine("the number ={0} {1}",Number,"Ahmed");

            #endregion

            #region Part 11 ValueType Vs ReferenceType [Code]
            //value type
            //int x;
            ///delcare for variable for type"intger"
            ///clr will allocate 4 unitilized bytes in stack.
            ///int in c# keyword
            // x = 5;

            // Int32 y = 10;

            ///delcare for variable for type"intger"
            ///clr will allocate 4 unitilized bytes in stack.
            ///int 32:bcl
            //y = x;
            //x++;
            //Console.WriteLine($"y={y}"); //5
            //Console.WriteLine($"x={x}"); //6

            ////ref type

            //point p1;
            ////delcare for ref type point , refer to default value of the ref
            ////this ref p1 can refer to an object of type point or another type inheriting from point
            //// clr will allocate 4 bytes in stack for ref p1
            //// clr will allocate 0 bytes in heap

            //p1 = new point();
            ////new
            /////1.allocate rq number of bytes for object at heap
            /////2.initilize the allocated bytes with the defualt vaules
            /////call the user def consturter
            /////return the address of the allocated ob to the ref p1

            //Console.WriteLine(p1.X);//1 cause that's the def else it will be 0
            //point p2 = new point() { X = 5, Y = 10 };
            //p2 = p1;
            //p2.X = 10;
            //Console.WriteLine(p1.X);
            #endregion

            #region Part 14 Object [Methods]
            //point p1 = new point() { X = 5, Y = 10 };
            //point p2 = new point() { X = 5, Y = 10 };
            //Console.WriteLine(p1.ToString()); //return demo.point
            //Console.WriteLine(p1.GetHashCode); // return hash code
            //Console.WriteLine(p1.Equals(p2)); 
            //Console.WriteLine(p2.GetType()); //return namespace.typename :demo.point (we cant override it)

            #endregion

            #region Part 15 Object [Coding Example]

            // object o;
            //declare for ref type of object ,refer for def value 
            //this ref o can refer to an instance from type object or any type
            //clr will allocate  unintialized 4 bytes in stack for the ref o
            //clr will allocate 0 bytes in heap.
            //o=new object();
            //o=new string("ahmed");

            //////boxing
            ////o = 10;
            ////o = 5.5;
            ////o = true;
            ////o = new DateTime();
            ////o = new DateOnly();
            ////o = new TimeOnly ();
            ////o = 6;

            ////int Number = (int)o; //unboxing

            ////parent = child
            //o=new point();
            //string name =(string)o;
            ////child=child parent





            #endregion

            #region Part 16 Fractions and Discard
            //float x = 10.5f;
            //double y = 10.5;
            //decimal z = 10.5m;
            ////discard
            //long number = 1000_000_00;
            //Console.WriteLine($"{number:c}");
            #endregion

            #region Part 17 Implicit Casting Vs Explicit Casting
            ////int x = 10; 
            ////long y = x;  //impiclt casting
            ////Console.WriteLine(y);//10
            //long x = 1000000000;
            //checked
            //{
            //    int y = x.GetType() ==typeof(int)? (int)x:0; //explicit casting =unsafe
            //    unchecked
            //    {
            //        Console.WriteLine(y); //10
            //                              }

            //    }

            //int x = 10;
            //double y = x; //impilict casting
            //Console.WriteLine(y); //10

            //double x = 5.5;
            //int y=(int)x; // explict casting 
            //Console.WriteLine(y); //5
            #endregion

            #region Part 18 Parse and Convert 
            //conver ==> class with a set of methods 
            //Console.Write("enter you name");
            //string? name =Console.ReadLine();
            //Console.Write("enter your age");
            //int age2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your salary");
            //decimal salary = decimal.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.Beep(1944,2000);
            //Console.WriteLine($"your name is{name}");
            //Console.WriteLine($"your age is{age2}");
            //Console.WriteLine($"your salary is{salary}");
            ////parse is a  method used for casting from string to caller datatype
            //decimal salary2 = decimal.Parse(Console.ReadLine()??"0");
            //Console.WriteLine(salary2);
            #endregion

            #region Part 19 TryParse

            ///string x = "abosalah";
            ///int y=Convert.ToInt32(x); //error
            ///Console.WriteLine(y);

            ///string x = "true";
            ///bool y=bool.Parse(x);
            ///Console.WriteLine(y); //true
            ///x = "hamada";
            ///y = bool.Parse(x);
            ///Console.WriteLine(y);//error

            ///string x = "10";
            ///         int y;
            ///     bool isparsed= int.TryParse(x, out  y);
            ///   Console.WriteLine(isparsed);

            #endregion

            #region Part 20 Operators
            ///int x = 10; //unary
            ///prefix
            ///Console.WriteLine(++x);
            ///postfix
            ///Console.WriteLine(x++);
            ///

            ///int x=6,y=5;
            ///Console.WriteLine(x==y);
            ///Console.WriteLine(x!=y);
            ///Console.WriteLine(x>y);
            ///Console.WriteLine(x<y);
            ///Console.WriteLine(x<=y);

            ///Console.WriteLine(!false);
            ///Console.WriteLine(false&&true);
            ///Console.WriteLine(false|| true);
            ///

            ///int x=10 , y=20 ;
            ///string msg = x > y ? "x is more than y" : "x is less than y";

            #endregion

            #region Part 21 Operators Priority [Precedence] and Associtivity

            /*
             1.prefix
            2.round ()
            3. * % /
            4. + -
             
             */
            //int eq = 4 + 3 * 8;
            //Console.WriteLine(eq); //28
            ///int a = 20, b = 10, c = 15, d = 5, e ;
            ///e=(a+b)*c/d;
            ///e=((a+b)*c)/d;
            ///e=(a+b)*(c/d);
            ///e=a+(b*c)/d;

            #endregion


        }

    }
}

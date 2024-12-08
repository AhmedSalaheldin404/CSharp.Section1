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
            int x;
            ///delcare for variable for type"intger"
            ///clr will allocate 4 unitilized bytes in stack.
            ///int in c# keyword
            x = 5;

            Int32 y = 10;

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

            object o;
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


        }

    }
}

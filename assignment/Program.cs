using System.ComponentModel;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program that allows the user to enter a number then print it.
            //Console.Write("Please enter a number ");
            //int number=int.Parse(Console.ReadLine());
            //Console.WriteLine($"your number is: {number} ");
            #endregion

            #region Q2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //Console.WriteLine("enter a string to convert to an integer:");

            //string input = Console.ReadLine();
            //int.TryParse(input, out int result);
            //Console.WriteLine($"Result: {result}");
            ////if i put non numeric char such as hello  resault will be :0

            #endregion

            #region Q3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //Console.WriteLine("enter the first number:");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter the second number:");
            //float num2 = float.Parse(Console.ReadLine());
            //float result = num1 / num2;

            //Console.WriteLine($"The result of dividing {num1} by {num2} is: {result}");
            ////if we write 10.5 and 5.5 the result will be 1.9999
            ////if we write 10 and 0 the result will be  infinity
            ////if we write 0 and 0 the result will be nan
            #endregion

            #region Q4.Write C# program that Extract a substring from a given string
            //Console.WriteLine("Enter the main string:");
            //string mainString = Console.ReadLine();

            //Console.WriteLine("Enter the starting position:");
            //int startPosition = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the length :");
            //int length = int.Parse(Console.ReadLine());

            //string result = string.Format("{0}", mainString.Substring(startPosition, length));

            //Console.WriteLine($"Extracted substring: {result}");
            #endregion

            #region Q5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1 = 5;
            //int num2 = 10;
            //num1 = num2;
            //num2 += 2;
            //Console.WriteLine(num2); //12
            //Console.WriteLine(num1); //10
            //in value type when we assign one to another it only take a copy of the value and if you change the orinial it won't affect the secont var

            #endregion

            #region Q6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //test t1=new test();
            //t1.name = "ahmed";
            //test t2=t1 ;
            //t1.name = "mona";
            //Console.WriteLine($"t1 name is {t1.name}");
            //Console.WriteLine($"t2 name is {t2.name}");
            //both outputs will be mona because in reference type the var t1 or t2 will be in stack and ref to the heap with the data but when we assign the t2 to t1 now both of them ref to the same data so if you change one of them both will be affected

            #endregion
        }
    }
}

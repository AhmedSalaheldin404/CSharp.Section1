using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Q7.Write C# program that take two string variables and print them as one variable
            //Console.WriteLine("Enter the first string:");
            //string str1 = Console.ReadLine();

            //Console.WriteLine("Enter the second string:");
            //string str2 = Console.ReadLine();

            //string result = str1 + str2;
            //Console.WriteLine($"the result is {result}");
            #endregion

            #region Q8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //decimal amount, rateofinterest, time, Interest;
            //Console.WriteLine("please enter the amount");
            // amount=decimal.Parse(Console.ReadLine());
            //Console.WriteLine("please enter the rateofinterest");
            //rateofinterest = decimal.Parse(Console.ReadLine()); 
            //Console.WriteLine("please enter the time");
            //time = decimal.Parse(Console.ReadLine());
            //Interest = (amount * rateofinterest * time) / 100;
            //Console.WriteLine($"The formula for simple interest is Interest :{Interest} ");





            #endregion

            #region Q9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.WriteLine("Enter your weight in kilograms:");
            //double weight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your height in meters:");
            //double height = double.Parse(Console.ReadLine());
            //double bmi = weight / (height * height);

            //Console.WriteLine($"Your Body Mass Index (BMI) is: {bmi:F2}");
            #endregion

            #region Q10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //Console.WriteLine("Enter the temperature in degrees:");
            //int temperature = int.Parse(Console.ReadLine());
            //string result = (temperature < 10) ? "Just Cold" :(temperature > 30) ? "Just Hot" : "Just Good";
            //Console.WriteLine($"The temperature is: {result}");
            #endregion

            #region Q11.Write a program that takes the date from the user and displays it in various formats using string interpolation. Ex: Today’s date : 20 , 11 , 2001Today's date : 20 / 11 / 2001Today's date : 20 – 11 – 2001
            //Console.WriteLine("Enter the day:");
            //int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the month:");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the year:");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today's date : {day}, {month}, {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} – {month} – {year}");

            #endregion

            #region  Q12.What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            ////answer :  C) The event is on 06/14/2024
            #endregion

            #region Q13.Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            ////answer: F)A value 1 will be assigned to d.
            #endregion

            #region Q14.Which of the following is the correct output for the C# code given below?

            //  Console.WriteLine(13 / 2 + " " + 13 % 2);
            //answer : d) 6 1
            #endregion


            #region Q15.What will be the output of the C# code given below?
            int num = 1, z = 5;


            //if (!(num <= 0))
              //  Console.WriteLine(++num + z++ + " " + ++z);
            //else
              //  Console.WriteLine(--num + z-- + " " + --z);
            //answer : D)7 7

            #endregion
        }

    }
}

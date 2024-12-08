namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program that allows the user to enter a number then print it.
            Console.Write("Please enter a number ");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine($"your number is: {number} ");
            #endregion
        }
    }
}

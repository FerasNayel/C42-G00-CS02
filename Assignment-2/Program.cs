namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-	Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Please Enter a Number: ");
            int number  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            #endregion
        }
    }
}

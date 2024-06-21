using System.ComponentModel;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-	Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Please Enter a Number: ");
            //int number  = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number);
            #endregion

            #region  2 - Write C# program that Convert a string to an integer, but the string contains non-numeric characters.And mention what will happen 

            //Console.WriteLine("Enter Input: ");

            //string Input = Console.ReadLine();

            //int Output;

            //if (int.TryParse(Input , out Output))
            //{
            //    Console.WriteLine($"The Result = {Output}");
            //}
            //else
            //{
            //    Console.WriteLine("Can't Convert Non-numeric characters");
            //}

            //If The String contains only numeric charachters it will be converted to integer
            //If The String contains non-numeric characters it will not be converted
            #endregion

            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float number1 = 30.28F , number2 = 50.5F;
            //float Sum = number1 + number2;
            //Console.WriteLine(Sum);//80.78
            //float Difference = number2 - number1;
            //Console.WriteLine(Difference);//20.22
            //float Multiplication = number1 * number2;
            //Console.WriteLine(Multiplication);//1529.14
            //float Division = number2 / number1;//1.6677675
            //Console.WriteLine(Division);


            #endregion

            #region 4-	Write C# program that Extract a substring from a given string.

            //Console.WriteLine("Enter Text: ");
            //string name = "Hello World!";

            //int charPosition = name.IndexOf("W");

            //string lastChar = name.Substring(charPosition);

            //Console.WriteLine(lastChar);
            #endregion

            #region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int X = 5; int Y = 10;
            //Y = X;
            //X++;
            //Console.WriteLine(X);
            #endregion

            #region 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            Value V1;
            V1 = new Value();
            Value V2 = new Value();
            V2 = V1;
            V2.x = 5;
            Console.WriteLine(V1.x);//5
            #endregion
            

        }
    }
}

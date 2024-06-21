using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //Value V1;
            //V1 = new Value();
            //Value V2 = new Value();
            //V2 = V1;
            //V2.x = 5;
            //Console.WriteLine(V1.x);//5
            #endregion

            #region 7 - Write C# program that take two string variables and print them as one variable 

            //Console.WriteLine("Enter your First Name:");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("Enter your Last Name:");
            //string LastName = Console.ReadLine();
            //string FullName = FirstName + " " +  LastName;
            //Console.WriteLine($"Your Full Name is {FullName}");
            #endregion

            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.WriteLine("Enter Principal Amount");
            //double Principal_Amount =Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter rate of interest");
            //double Rate_Of_Interest =Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Time");
            //double Time =Convert.ToDouble(Console.ReadLine());
            //double Interest = (Principal_Amount * Rate_Of_Interest * Time)/100;
            //Console.WriteLine($"Interest = {Interest}");
            #endregion

            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.WriteLine("Enter Your Weight");
            //decimal Weight = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"Your Weight = {Weight} KG ");
            //Console.WriteLine("Enter Your Height");
            //decimal Height = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"Your Height = {Height} cm ");
            //decimal BMI = Weight / (Height *  Height);
            //Console.WriteLine($"Your BMI is {BMI} ");
            #endregion

            #region 10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //Console.WriteLine("Enter Temperature");
            //double Temp = Convert.ToDouble(Console.ReadLine());

            //string Status = Temp < 10 ? "Just Cold" : Temp > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine($"Status = {Status}");
            #endregion

            #region 11-	Write a program that takes the date from user and displays it in various formats using string interpolation. Ex: Today’s date : 20 , 11 , 2001 Today's date : 20 / 11 / 2001 Today's date : 20 – 11 – 2001

            //Console.WriteLine("Enter Day");
            //int Day = int.Parse( Console.ReadLine());
            //Console.WriteLine("Enter Month");
            //int Month = int.Parse( Console.ReadLine());
            //Console.WriteLine("Enter Year");
            //int Year = int.Parse( Console.ReadLine());
            //Console.WriteLine($"Today's Date : {Day} , {Month} , {Year}");
            //Console.WriteLine($"Today's Date : {Day} / {Month} / {Year}");
            //Console.WriteLine($"Today's Date : {Day} - {Month} - {Year}");

            #endregion

            #region 12-	 What is the output of the following C# code?

            //c) The Event is on 06/14/2024
            #endregion

            #region 13-	Which of the following statements is correct about the C#.NET code snippet given below?

            //f) A value 1 will be assigned to d.
            #endregion
        }
    }
}

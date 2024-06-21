using System.Drawing;
using System.Runtime.CompilerServices;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaration
            //int Id = 10;
            //Console.WriteLine(Id);
            #endregion

            #region Value Type 
            //int X;
            ////CLR Will Allocate 4 Uninitialized Bytes At STACK
            ////int : C# Keyword
            //X = 5;

            //Int32 Y = 10;
            ////CLR Will Allocate 4 Uninitialized Bytes At STACK
            //// Int32 : BCL

            //Y = X; //5

            //X++; //6

            //Console.WriteLine(Y);
            #endregion


            #region Refererence Type
            //Point P1;
            /////Declare For Reference OF Type "Point" , Refering To NULL
            /////This Reference "P1" Can Refer To An Object From Type "Point" Or Another Type "Inheriting From Point"
            /////CLR Will Allocate 4 Uninitialized Bytes At STACK
            /////CLR Will Allocate 0 Bytes At HEAP

            //P1 = new Point(); //Has 2 References (P1 , P2)
            ///new
            /// 1. Allocate Required Number of Bytes in HEAP (Object Size + CLR Overhead Variables)
            /// 2. Initialize (Cross Out) Allocated Bytes With Default Value Of Its Datatype
            /// 3. Call User-Defined Constructor If Exists
            /// 4. Assign The Refernce To Allocated Object

            ////Point P2 = new Point(); //Unreachable Object

            ////P2 = P1;

            ////P2.X = 10;

            ////Console.WriteLine(P1.x); 
            #endregion



            #region Fractions And Discard
            //float X = 5.3F;
            //double Y = 4.34;
            //decimal Z = 9943.4M;

            //Discard => Just For Readability
            //    long Number = 100_000_000_000; 
            #endregion

            #region Implicit Casting Vs Explicit Casting
            ///int X = 8;
            ///long Y = (long) X; //Implicit Casting (Safe Casting)  
            ///Console.WriteLine(Y);

            //long X = 8;
            //X = 546313246564;
            //int Y = X.GetType() == typeof(int) ? (int)X  : 0;
            //Console.WriteLine(Y);

            ///checked
            ///{
            ///    int Y = (int)X; //Explicit Casting (Unsafe Casting) 

            ///    unchecked
            ///    {
            ///        Console.WriteLine(Y);
            ///    }

            ///}

            #endregion


            #region Convert And Parse

            #region Convert
            // Convert : Is a Class Containing ASet Of Methods used for Casting From Datatype to Another
            //Console.WriteLine("Please Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "NA";

            //Console.WriteLine("Please Enter Your Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(500 , 5);

            //Console.WriteLine("Your Name is " + Name);
            //Console.WriteLine("Your Age is " + Age);
            //Console.WriteLine("Your Salary is " + Salary);

            #endregion

            #region Parse

            //Parse : Is a Method used for Casting from String to the Caller Dataype
            //Console.WriteLine("Please Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "NA";

            //Console.WriteLine("Please Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal Salary = Decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(500, 5);

            //Console.WriteLine("Your Name is " + Name);
            //Console.WriteLine("Your Age is " + Age);
            //Console.WriteLine("Your Salary is " + Salary);


            #endregion

            //string X = "5";

            //X = "Ahmed";

            //int Y = int.Parse(X);

            //Console.WriteLine(Y);


            //string X = "true";

            //X = "Hamada";

            //bool flag = Convert.ToBoolean(X);
            //Console.WriteLine(flag);
            #endregion

            #region Try Parse
            //string X = "10";

            //int Y;

            //bool flag =  int.TryParse(X, out Y); //If Casting Failed , No Exception Will Be Thrown
            //Console.WriteLine(flag); //true
            //Console.WriteLine(Y); //10

            #endregion

            #region Operators

            #region Unary Operator
            //Unary Operators 
            //int X = 10;

            ////1. ++

            ////1.1 Prefix (Increment and then Print)
            //Console.WriteLine(++X); //Print 11
            ////1.2 Postfix (Print and then Increment )
            //Console.WriteLine(X++); //Print 10

            ////2. --

            ////1.1 Prefix (Decrement and then Print)
            //Console.WriteLine(--X); //Print 9
            ////1.2 Postfix (Print and then Decrement )
            //Console.WriteLine(X--); //Print 10


            #endregion

            #region Binary Operators
            //Binary Operators => Works on Two Operands (Variables)
            //int Sum, Mul, Div, Sub, Mod;
            //int Num1 = 2 , Num2 = 6;

            //Sum = Num1 + Num2;
            //Sub = Num2 - Num1;
            //Mul = Num1 * Num2;
            //Div = Num1 / Num2;
            //Mod = Num2 % Num1;

            #endregion

            #region Assignment Operator

            //int X;
            //X = 4;
            //X += 4; // X = X + 2
            //X -= 4; // X = X - 2
            //X *= 4; // X = X * 2
            //X /= 4; // X = X / 2
            //X %= 4; // X = X % 2
            //#endregion

            #endregion

            #region Relational Operators

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y); // Equal
            //Console.WriteLine(X != Y); // Not Equal
            //Console.WriteLine(X > Y); // More Than
            //Console.WriteLine(X < Y); // Less Than
            //Console.WriteLine(X >= Y); // More Than or Equal
            //Console.WriteLine(X <= Y); //Less Than or Equal
            #endregion

            #region Logical Operators

            //Console.WriteLine(!false);
            //Console.WriteLine(!false && true); // Short Circuit
            //Console.WriteLine(true || false);
            //Console.WriteLine(4 < 5 && 7 < 9);
            #endregion

            #region Bitwise Operator
            Console.WriteLine(~0);
            Console.WriteLine(false & true); // Long Circuit
            Console.WriteLine(true | false);
            #endregion

            #region Ternary Operator

            //int X = 10, Y = 5;
            //string Message = X > Y ? "X is more than Y": X < Y? "X is less than Y": "X equals Y";
            //Console.WriteLine(Message);
            ////if (X > Y)
            //{
            //    Message = "X is more than Y";
            //}
            //else if (Y > X)
            //{
            //    Message = "Y is more than X";
            //}
            #endregion

            #region Operators Periority and Associtivity
            //1. Unary Operator (Prefix)
            //2. Round Braces ()
            //1. * / % 
            //1. + -
            //int Equation = 4 + 3 * 8;

            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int Equation;

            //Equation = (a + b) * c / d; // ( 30 * 15) / 5
            //Equation = ((a + b) * c) / d; // ( 30 * 15) / 5 
            //Equation = (a + b) * (c / d); // (30) * (15/5)
            //Equation = a + (b * c) / d; // 20 + (150/5)
            #endregion


            #endregion


        }
    }
}

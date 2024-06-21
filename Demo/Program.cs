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

            #region Convert
            // Convert : Is a Class Containing ASet Of Methods used for Casting From Datatype to Another
            Console.WriteLine("Please Enter Your Name: ");
            string Name = Console.ReadLine() ?? "NA";

            Console.WriteLine("Please Enter Your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Your Salary: ");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            Console.Beep(500 , 5);

            Console.WriteLine("Your Name is " + Name);
            Console.WriteLine("Your Age is " + Age);
            Console.WriteLine("Your Salary is " + Salary);

            #endregion


            #endregion

        }
    }
}

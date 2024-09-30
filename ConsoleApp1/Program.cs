using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPoint
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
            string str = "5";
            int a = int.Parse(str);
            Console.WriteLine(a+2);

            string str1 = "5,7";
            double b = double.Parse(str1);
            Console.WriteLine(b + 2);
            */ //parsing strings
            /*
             * 
             * 
             * operator is a construction of PL which allows to do smthng on some data
             * operator called operator cuz it operate on data
             * data that changed by operator called operand
             * operators can be unary binary and ternary
             * math operations are binary
             * unarity binarity or ternarity of operator depends on amount of operands for it processing
             * 1 - unar
             * 2 - binar
             * 3 and more - ternar
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */ // base operators theory
            /*
            basic math operators:
            + ; - ; * ; / ; % ;
            math operations priority works same as in math
            (* / %) then ( + - ) you can change priority by bracets()

            if operators have same priority they go from left to right
             */ // math operators
            // many progects in one solution

            int a, b, c;
            a = 100; b = 15; c = 6; 
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine((double)b / a); //operation of type conversion
            Console.WriteLine(a % b);

            Console.WriteLine(a + b +c +5); //for compiler dosent matter is it variable or hard num it still Int32 or etc.
            int result = a + b + 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.classes
{
    class calc
    {
        
        public string[] operations = { "+", "-", "/", "*" };



        public static double Add(double a, double b)
        {
           double result = a + b;
            return result;
        }

        public static double Sub(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public static double Mult(double a, double b)
        {
            double result = a * b;
            return result;

        }

        public static double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }

        public static double NoErr(string s)
        {
            bool noMistakes = Double.TryParse(s, out double num);
            while (!noMistakes)
            {
                Console.Write("Please Enter a valid number.");
                noMistakes = Double.TryParse(Console.ReadLine(), out num);
            }
            return num;

        }


        public static string validOperations(string s , string[] arr)
        {
            string[] operations = { "+", "-", "/", "*" };
            while (!operations.Contains(s))
            {
                Console.WriteLine("Please enter a valid operation");
                s = Console.ReadLine();
            }
            return s;
            

        }

        public static void Calculate(double num1, double num2, string inputSign, string[] signs)
        {
            double result;
            if (inputSign == signs[0])
            {
                result = Add(num1, num2);
                Console.WriteLine("The Addition of your two numbers is: " + result);
            }

            else if (inputSign == signs[1])
            {
                result = calc.Sub(num1, num2);
                Console.WriteLine("The Subtraction of your two numbers is: " + result);
            }

            else if (inputSign == signs[2])
            {
                result = calc.Mult(num1, num2);
                Console.WriteLine("The multiplication of your two numbers is: " + result);
            }

            else if (inputSign == signs[3])
            {
                result = calc.Divide(num1, num2);
                Console.WriteLine("The division of your two numbers is: " + result);
            }
            
        }
        
       














    }
}

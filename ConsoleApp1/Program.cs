using System;
using ConsoleApp1.classes;

namespace ConsoleApp1.classes
{
    class Program
    {
        static void Main(string[] args)
        {
        

           
            string[] signs = new string[4] { "+", "-", "*", "/" };
            double num1, num2;

            Console.WriteLine("My Calculator!");

            Console.WriteLine("Enter your first number: ");
            string n1 = Console.ReadLine();
            num1 = calc.NoErr(n1);


            Console.WriteLine("Enter your Second number: ");
            string n2 = Console.ReadLine();
            num2 = calc.NoErr(n2);

         

            Console.WriteLine("Enter the sign of your operator: ");
            string inputSign = Console.ReadLine();
            inputSign = calc.validOperations(inputSign, signs);
            calc.Calculate(num1, num2, inputSign,signs);

            

            Console.WriteLine("Write Yes if you want to restart your application.");

            string yesNo = Console.ReadLine();
            if (yesNo == "yes")
            {

            }


        }
    }
}


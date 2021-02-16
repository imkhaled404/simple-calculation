using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculation
{
    public class cal
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static int Sub(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total;
        }

        public static int mul(int num1, int num2)
        {
            int total;
            total = num1 * num2;
            return total;
        }

        public static int div(int num1, int num2)
        {
            int total;
            total = num1 / num2;
            return total;
        }

        public static int mod(int num1, int num2)
        {
            int total;
            total = num1 % num2;
            return total;
        }

        public static void Main()
        {
            Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Enter First number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Secound number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe summation of two numbers is : {0} \n", Sum(number1, number2));
            Console.WriteLine("\nThe substraction of two numbers is : {0} \n", Sub(number1, number2));
            Console.WriteLine("\nThe Multiplication of two numbers is : {0} \n", mul(number1, number2));
            Console.WriteLine("\nThe divition of two numbers is : {0} \n", div(number1, number2));
            Console.WriteLine("\nThe modulus of two numbers is : {0} \n", mod(number1, number2));
            Console.ReadLine();
        }
    }
}



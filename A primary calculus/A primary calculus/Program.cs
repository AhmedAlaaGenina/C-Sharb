using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_primary_calculus
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, sum;
            Console.WriteLine("please enter the frist number : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the seconed number : ");
            num2 = Convert.ToDouble(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("the sum is :" + sum);
            Console.ReadKey();
        }
    }
}

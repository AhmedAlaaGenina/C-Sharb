using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_the_nearest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            double num1=Convert.ToDouble( Console.ReadLine());
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine("your number is : "+num2);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your age :            \"form in 1998-01-04\"");
            DateTime birthday;
            birthday = Convert.ToDateTime(Console.ReadLine());
            double year =Convert.ToDouble( DateTime.Now.Subtract(birthday).TotalDays) / 360;
            double day = Convert.ToDouble(DateTime.Now.Subtract(birthday).TotalDays) ;
            double hour = Convert.ToDouble(DateTime.Now.Subtract(birthday).TotalHours) ;
            double min = Convert.ToDouble(DateTime.Now.Subtract(birthday).TotalMinutes) ;
            double sec = Convert.ToDouble(DateTime.Now.Subtract(birthday).TotalSeconds) ;
            Console.WriteLine("your Age : " + year + " years");
            Console.WriteLine("your Age : " + day + " days");
            Console.WriteLine("your Age : " + hour + " hours");
            Console.WriteLine("your Age : " + min + " minte");
            Console.WriteLine("your Age : " + sec + " second");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Time a = new Time(9, 35);
            Console.WriteLine(a);

            Time b = new Time(18, 5);
            Console.WriteLine(b);

            Time c = new Time(28, 500);
            Console.WriteLine(c);
            Console.WriteLine();

            //change the format of the output
            Time.SetTimeFormat("Mil");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();

            //change the format of the output
            Time.SetTimeFormat("24Hour");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();

            //change the format of the output
            Time.SetTimeFormat("12Hour");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c); 

        }
    }
}

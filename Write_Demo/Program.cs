using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Write_Demo
{
    class Program
    {
        static void Main(string[] args)
        {//Step-2
            using (TextWriter writer = new StreamWriter("info.txt"))
            {
                //Step-3
                writer.WriteLine("SHAFIQ-UR-REHMAN");
                writer.WriteLine("Software Eng Tech Co-Op");
                writer.WriteLine("SETAS");

            }
        }
    }
}

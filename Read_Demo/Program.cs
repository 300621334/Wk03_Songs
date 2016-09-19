using System;
//Step-1
using System.IO;

namespace Read_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //step-2

            //verbatim = @ means dont "PROCESS" string as it is & ignore escape-character back-slash. Bcoz back-slash says next char has a special meaning. We want \ in our path to be literal.
            using (TextReader reader = new StreamReader(@"H:\Comp-123 - C#\Projects\wk03\Write_Demo\bin\Debug\info.txt"))
            {
                //step-3
                string line = reader.ReadLine();
                int counter = 0;
                while(line != null)
                {
                Console.WriteLine("#{0} {1}", counter++, line);
                line = reader.ReadLine();
                }
            //reader.Close() not needed since it's inside "using" construct.
            }
        }
    }
}

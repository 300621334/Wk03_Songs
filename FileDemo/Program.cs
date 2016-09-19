using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Step I : Add the necessary using statement; a namespace IO=input-output:
using System.IO;

namespace FileDemo
{
    class Program
    {
        //Step II : add system.IO namespace

        //Step III : decalare & ini obj for writing  <> declare & ini obj for 

        //Step IV : perform write op <> perform Read operation

        //Step V : close file/stream writer.Close(); <> close stream reader.Close();



        static void Main(string[] args)
        {
            //Step-2
            using (TextWriter writer = new StreamWriter("info.txt"))
            {
                //Step-3
                writer.WriteLine("SHAFIQ-UR-REHMAN");
                writer.WriteLine("Software Eng Tech Co-Op");
                writer.WriteLine("SETAS");
                
            }

            //step-4 - close the file (not necessary if using "using" construct - garbage collector takes it)







 //           //create a list to store the medal objects
 //List<Medal> medals = new List<Medal>();
 //medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false);
 //medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false);
 //medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false);
 //medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false);
 //medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true);
 //medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true);
 //medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false);
 //medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false);
 //medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false);
 //medals.Add(new Medal("Sidney Crosby ", "Ice Hockkey", "Gold", 2014, false);
 //medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false);
 //medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false);
 //medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false);
 //medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false);

 ////write all the medals to file
 
 ////write only the names of all the medal holder to file
 
 //// write all the gold medals to file
 
 //// write all the medals in 2012 to file
 
 //// write all the world record medals to file
 

        }
    }
}

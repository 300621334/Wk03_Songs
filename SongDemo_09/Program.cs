using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDemo_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

            Library.LoadSongs(@"D:\songs4.txt");
            Console.WriteLine("\n\nAll songs");
            Console.WriteLine("{0, -20}{1, -40}{2, -10}{3, -10}", "Artist", "Title", "Duration", "Genre");
            Console.WriteLine("======              =====                                   ========  =====");
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine("\n\n{0} songs", genre);
            Console.WriteLine("{0, -20}{1, -40}{2, -10}{3, -10}", "Artist", "Title", "Duration", "Genre");
            Console.WriteLine("======              =====                                   ========  =====");
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine("\n\nSongs by {0}", artist);
            Console.WriteLine("{0, -20}{1, -40}{2, -10}{3, -10}", "Artist", "Title", "Duration", "Genre");
            Console.WriteLine("======              =====                                   ========  =====");
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine("\n\nSongs more than {0}mins", length);
            Console.WriteLine("{0, -20}{1, -40}{2, -10}{3, -10}", "Artist", "Title", "Duration", "Genre");
            Console.WriteLine("======              =====                                   ========  =====");
            Library.DisplaySongs(length);

        }
    }
}

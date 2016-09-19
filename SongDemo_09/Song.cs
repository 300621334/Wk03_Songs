using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongDemo_09
{
    //Enum be able to see by everyone so outside song
    public enum SongGenre 
    {
        Unclassified,
        Pop,
        Rock,
        Metal,
        Country,
        Soul,
        Blues
        //no comma for last one
    }
    public class Song
        //Acts as record of songs:
    {
        public string Title { get; private set; }
        public string Artist { get; private set;}
        public double Length { get; private set; }
        public SongGenre Genre { get; private set;}
        
        

        public Song(string title, string artist, double length, SongGenre genre)
        {
            Artist = artist;
            Genre = genre;
            Length = length;
            Title = title;


            /*if length was provided as a string &genre was also provided as a string then we'll do sth like below:
            public Song(string title, string artist, string length, string genre). Squigly line under genre will go away if change "SongGenre" in params with "string".*/

            //Artist = artist;
            //Genre = (SongGenre)Enum.Parse(typeof(SongGenre), genre);
            //Length = Convert.ToDouble(length);
            //Title = title;
        }

        public override string ToString()
        {
            //return "Artist:"+ Artist +"     Song:"+ Title+"     Duration:"+Length+"     Genre:"+Genre;
            return string.Format("{0, -20}{1, -40}{2, -10}{3, -10}", Artist, Title, Length, Genre);
        } 

    }

    public class Library
    //This is the front end of the application. All the members are static
    {
        private static List<Song> songs = new List<Song>();

        public static void DisplaySongs()
        {
            foreach(Song x in songs)
            { Console.WriteLine(x); }
        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song x in songs)
            { 
                if(x.Length > longerThan)
                {
                Console.WriteLine(x); 
                }
            }
        }
        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song x in songs)
            { if(x.Genre == genre)
                {
                Console.WriteLine(x); 
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song x in songs)
            { 
                if(x.Artist == artist)
                {
                Console.WriteLine(x); 
                }
            }
        }
        public static void LoadSongs(string fileName)
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                string line="", title = "", artist = "";
                double length = 0;
                SongGenre genre = SongGenre.Unclassified;
                while(line != null)
                {
                    title = reader.ReadLine();
                    if (title==null) { break; } //reach end of txt.file gives "null" w dont convert to double/Enum & give err. So "break" before reaching conversion expression.
                    artist = reader.ReadLine();
                    length = Convert.ToDouble(reader.ReadLine());
                    //(SongGenre) casts "object" instance of Enum into a "SongGenre" type.!!! Enum.Parse converts string into an obj.
                    //we need to pass string representation of an Enum enumerated ABOVE under namespace>> reader returns string from txt file that is EXACTLY one of enumerated list.
                    genre = (SongGenre)Enum.Parse(typeof(SongGenre), reader.ReadLine());

                    songs.Add(new Song(title, artist, length, genre));
                }
                //int counter = 0;
                ////title = reader.ReadLine();
                ////artist = reader.ReadLine();
                ////length = reader.ReadLine();
                ////genre = reader.ReadLine();
                //while (line != null) 
                //{

                //    for (int i = 0; i < 4; i++)
                //    {
                //        line = reader.ReadLine();
                //        counter++;
                //        if (line == null)
                //        { break; }
                //            switch (counter % 4)
                //            {
                //                case 1:
                //                    title = line;
                //                    break;
                //                case 2:
                //                    artist = line;
                //                    break;
                //                case 3:
                //                    length = Convert.ToDouble(line);
                //                    break;
                //                case 0:
                //                    genre = (SongGenre)Enum.Parse(typeof(SongGenre), line);
                //                    break;
                //                    //while() on top(NOT do-while) bcoz "null" cannot be converted into Enum in Case 0; & hence err.
                //            }

                //    }
                //    if (line == null)
                //    { break; }
                //    songs.Add(new Song(title, artist, length, genre));
                //}

            }
        }
    }

}

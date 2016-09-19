using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDemo
{
    public class Time
    {
        //fields: static coz we want FORMAT of displaying time to saty same no matter how many times we instantiate class.
        private static string TIME_FORMAT;

        //properties
        private int Hour {get; set;}
        private int Minute {get; set;}

        //constructor
        public Time(int hours, int minutes)
        {
            int addToHr = 0;
            if(minutes > 60)
            {
                Minute = minutes % 60;
                addToHr = minutes / 60;
            }
            else
            {
                Minute = minutes;
            }

            Hour = hours + addToHr;

            if(hours > 24)
            {
                Hour = Hour / 24;
            }
        }

        //method to set FORMAT of how time will display. It's static only a static can access static-field TIME_FORMAT. 
        //say options are "mil", "24" "12".
        public static void SetTimeFormat(string time_format) 
        {
            TIME_FORMAT = time_format;
        }

        //string override - takes guide from TIME_FORMAT on how to display time
        public override string ToString()
        {
            string result = "";
            switch(TIME_FORMAT)
            {
                case "Mil":
                    result = string.Format("{0:d2}{1:d2}", Hour, Minute);
                    break;
                case "24Hour":
                    result = string.Format("{0:d2}:{1:d2}", Hour, Minute);
                    break;
                case "12Hour":
                    if (Hour < 12)
                        result = string.Format("{0}:{1:d2} PM", Hour, Minute);
                    else
                        result = string.Format("{0}:{1:d2} AM", Hour-12, Minute);
                    break;
            }




            //if (TIME_FORMAT == "Mil")
            //{
            //    result = string.Format("{0}{1}", Hour, Minute);
            //}
            //if (TIME_FORMAT == "24Hour")
            //{
            //    result = string.Format("{0} : {1}", (Hour < 10) ? ("0" + Hour) : (Hour + ""), (Minute < 10) ? ("0" + Minute) : (Minute + ""));
            //}
            //if (TIME_FORMAT == "12Hour")
            //{
            //    int hr = 0;
            //    if(Hour > 12)
            //    {
            //        hr = Hour - 12;
            //    }
            //    else
            //    {
            //        hr = Hour;
            //    }
            //    result = string.Format("{0} : {1}", hr, Minute);
            //}
            return result;
        }


    }
}

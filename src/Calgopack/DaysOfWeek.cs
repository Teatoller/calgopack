using System;

namespace Calgopack
{
    class WeekDays
    {
        string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
        public void Days()
        {
            /* 
              print each instance of item in array with foreach loop
            */
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

        }
        public void AmendArray(int index, string args)
        {
            daysOfWeek[index] = args;
        }

    }
}

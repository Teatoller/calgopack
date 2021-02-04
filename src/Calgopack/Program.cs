using System;

namespace Calgopack
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enumerate the days of the week */
            // WeekDays days = new WeekDays();
            // days.Days();


            /* Interact with the terminal to choose a day */
            SelectAday aDay = new SelectAday();
            aDay.Aday();

        }
    }
}

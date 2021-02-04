using System;

namespace Calgopack
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enumerate the days of the week */
            // WeekDays days = new WeekDays();
            // days.AmendArray(5, "black Friday");
            // days.Days();


            /* Interact with the terminal to choose a day */
            // SelectAday aDay = new SelectAday();
            // aDay.Aday();

            /* Instantiate an array, populate it and output its elements */
            // MyArray elements = new MyArray();
            // elements.ArrayConcept();

            /* Instantiate a two dimentional array, and output its elements */
            var y = new TwoDimArray();
            y.TwoDimArrayConcept();

        }
    }
}

using System;

namespace Calgopack
{
    class SelectAday
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
        public void Aday()
        {

            Console.WriteLine("Which day of the week do you want to display?");
            System.Console.WriteLine("e.g Monday= 0, etc");
            int daychosen = int.Parse(Console.ReadLine());
            string day = daysOfWeek[daychosen];
            System.Console.WriteLine($"That day is {day}");

        }
    }
}

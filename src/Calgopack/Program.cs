using System;

namespace Calgopack
{
    class Program
    {
        static void Main(string[] args)
        {

            // async array of strings
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            /* 
              print each instance of item in array with foreach loop
            */
            // foreach (string day in daysOfWeek)
            // {
            //     Console.WriteLine(day);
            // }

            // Print with for loop
            // for (int i = 0; i < daysOfWeek.Length; i++)
            // {
            //     Console.WriteLine(daysOfWeek[i]);
            // }

            // print with do loop
            // int index = 0;

            // do
            // {
            //     Console.WriteLine(daysOfWeek[index]);
            //     index++;
            // } while (index < daysOfWeek.Length);


            // Print with while loop
            int index = 0;
            while (index < daysOfWeek.Length)
            {
                Console.WriteLine(daysOfWeek[index]);
                index++;
            }

        }
    }
}

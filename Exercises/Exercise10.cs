using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise10 : Exercise
    {
        /// <task_description>
        /// 10.	Write a program that prints the next 20 leap years.
        /// </task_description>
        public override void ExerciseRun()
        {
            var date = DateTime.Today;
            Console.WriteLine("The next 20 leap years are:");
            int[] next20LeapYears = ReturnNext20LeapYears(date);
            foreach (int year in next20LeapYears)
            {
                Console.WriteLine(year);
            }
            
        }
        public static bool CurrentYearIsLeap (DateTime currentDateTime)
        {
            DateTime lastDayOfYear = new DateTime(currentDateTime.Year, 12, 31);
            bool isLeap;
            isLeap = lastDayOfYear.DayOfYear == 366;
            return isLeap;
        }

        public static int [] ReturnNext20LeapYears (DateTime date)
        {
            while (!CurrentYearIsLeap(date))
            {
                date = new DateTime(date.Year + 1,  date.Month, date.Day);
            }
            int nearrestLeapYear = date.Year;
            int[] next20LeapYears = new int[20];

            for (int i=0; i<20;i++)
            {
                next20LeapYears[i] = nearrestLeapYear;
                nearrestLeapYear += 4;
            }
            return next20LeapYears;
        }

               

    }
}

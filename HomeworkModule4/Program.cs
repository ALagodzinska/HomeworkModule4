using System;

namespace HomeworkModule4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MonthTask

            Console.WriteLine("Input year: ");
            string Year = Console.ReadLine();
            int intYear = int.Parse(Year);

            Console.WriteLine("Input month: ");
            string Month = Console.ReadLine();


            string January = "January";
            int IntJanMonth = 31;

            string February = "February";
            int IntFebMonth1 = 28;
            int IntFebMonth2 = 29;
            
            string March = "March";
            int IntMarchMonth = 31;

            string April = "April";
            int IntAprilMonth = 30;

            string May = "May";
            int IntMayMonth = 31;

            string June = "June";
            int IntJuneMonth = 30;

            string July = "July";
            int IntJulyMonth = 31;

            string August = "August";
            int IntAugMonth = 31;

            string September = "September";
            int IntSepMonth = 30;

            string October = "October";
            int IntOctoberMonth = 31;

            string November = "November";
            int IntNovMonth = 30;

            string December = "December";
            int IntDecMonth = 31;


            if (Month == January)
            {
                Console.WriteLine($"Day number in {January}: {IntJanMonth}");
            }
            else if (Month == February)
            {
                if (intYear % 4 != 0)
                {
                    Console.WriteLine($"Day number in {February}: {IntFebMonth1}");
                }
                else
                {
                    Console.WriteLine($"Day number in {February}: {IntFebMonth2}");
                }
            }
            else if (Month == March)
            {
                Console.WriteLine($"Day number in {March}: {IntMarchMonth}");
            }
            else if (Month == April)
            {
                Console.WriteLine($"Day number in {April}: {IntAprilMonth}");
            }
            else if (Month == May)
            {
                Console.WriteLine($"Day number in {May}: {IntMayMonth}");
            }
            else if (Month == June)
            {
                Console.WriteLine($"Day number in {June}: {IntJuneMonth}");
            }
            else if (Month == July)
            {
                Console.WriteLine($"Day number in {July}: {IntJulyMonth}");
            }
            else if (Month == August)
            {
                Console.WriteLine($"Day number in {August}: {IntAugMonth}");
            }
            else if (Month == September)
            {
                Console.WriteLine($"Day number in {September}: {IntSepMonth}");
            }
            else if (Month == October)
            {
                Console.WriteLine($"Day number in {October}: {IntOctoberMonth}");
            }
            else if (Month == November)
            {
                Console.WriteLine($"Day number in {November}: {IntNovMonth}");
            }
            else if (Month == December)
            {
                Console.WriteLine($"Day number in {December}: {IntDecMonth}");
            }
            else
            {
                Console.WriteLine("Incorect month!");
            }
            Console.ReadLine();

            #endregion

            #region Menu - Driven Program


            #endregion

            
        }
    }
}

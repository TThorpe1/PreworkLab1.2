using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "y";
            while (userChoice.ToLower()=="y")

            {
                Console.WriteLine("\nLet's calculate the duration betweem two dates in Days, Hours and Minutes!");
                //Gather information from user
                Console.WriteLine("\nPlease enter the greater date in the following format:  mm/dd/yyyy");
                DateTime userDate1;
                DateTime userDate2;
                //Validation
                if (DateTime.TryParse(Console.ReadLine(), out userDate1))

                {
                    Console.WriteLine("\nAwsome! One more time");
                }
                else
                {
                    Console.WriteLine("\nPlease format date as follows:  mm/dd/yyyy");
                    continue;
                }
                {
                    Console.WriteLine("\nPlease enter the lesser date in the following format: mm/dd/yyyy");
                }
                
                //Validation
                if (DateTime.TryParse(Console.ReadLine(), out userDate2))
                {
                    //Convert date and display difference
                    TimeSpan difference = userDate1.Subtract(userDate2);
                    Console.WriteLine("\nThose dates are " + difference.TotalDays + " day[s] apart, "
                                                         + difference.TotalHours + " hour[s] apart, and "
                                                         + difference.TotalMinutes + " minute[s] apart");

                }
                else
                {
                    Console.WriteLine("\nYou have entered an incorrect format, let's start over!");
                    continue;

                }
                Console.WriteLine("\nDo you want to play again \"(y/n)\"?");
                userChoice = Console.ReadLine();

            }
        }
    }
}

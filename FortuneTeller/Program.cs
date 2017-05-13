using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect user info and declare variables.


            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter. SMH - Bye Felicia!");
                return;
            }

            Console.WriteLine(firstName + ", what's your last name?");
            string lastName = Console.ReadLine();
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter. SMH - Bye Felicia!");
                return;
            }

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of the month that you were born in?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine(firstName + ", what is your favorite ROYGBIV color? Enter \"Help\" if you don't understand.");
            string colorInput = Console.ReadLine();
            string colorSelect = colorInput.ToLower();
            //Check for help needed
            if (colorSelect == "help")
            {
                Console.WriteLine("-------- Help --------\nROYGBIV stands for Red, Orange, Green, Blue, Indigo, and Violet. Now pick a color!\n");
                colorInput = Console.ReadLine();
                colorSelect = colorInput.ToLower();
                if (colorSelect == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter. SMH - Bye Felicia!");
                    return;
                }
            }
            else if (colorSelect == "quit")
            {
                Console.WriteLine("Nobody likes a quitter. SMH - Bye Felicia!");
                return;
            }

            Console.WriteLine("How many brothers and sisters do you have?");
            int numSiblings = int.Parse(Console.ReadLine());

            // Users fortune variables.
            int retireYears = 0;
            decimal retireMoney = 0;
            string location = "";
            string transportation = "";

            // Set the year of retirement.
            if (age % 2 == 0)
            {
                retireYears = 10;
            }
            else
            {
                retireYears = 35;
            }

            // Set location of vacation home.
            switch (numSiblings)
            {
                case 0:
                    location = "Fiji";
                    break;
                case 1:
                    location = "Hawaii";
                    break;
                case 2:
                    location = "Daytona";
                    break;
                case 3:
                    location = "Lake Michigan";
                    break;
                default:
                    location = "Put-in-Bay";
                    break;
            }

            //Set mode of transportation.
            switch (colorSelect)
            {
                case "red":
                    transportation = "pick-up truck";
                    break;
                case "orange":
                    transportation = "jet pack";
                    break;
                case "yellow":
                    transportation = "school Bus";
                    break;
                case "green":
                    transportation = "horse";
                    break;
                case "blue":
                    transportation = "Tesla";
                    break;
                case "indigo":
                    transportation = "helicopter";
                    break;
                case "violet":
                    transportation = "200 foot yacht";
                    break;
                default:
                    transportation = "RTA pass";
                    break;
            }

            // Set retirement money.

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                retireMoney = 6500000.00m;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                retireMoney = 25000000.00m;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                retireMoney = 800000.00m;
            }
            else
            {
                retireMoney = 0;

            }



            // Output story.
            Console.WriteLine("\n***** FOURTUNE *****\n");
            string formatMoney = String.Format("{0:C}", retireMoney); //$et money format.
            Console.WriteLine(string.Concat(firstName, " ", lastName, " will retire in ", retireYears, " years with ", formatMoney, " in the bank, ", "a vacation home in ", location, " and a ", transportation, "!"));
            Console.Read();

        }
    }
}

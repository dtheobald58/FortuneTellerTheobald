using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerTheobald
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("THE FORTUNE TELLER\n");

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birth month as a number:");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.Write("Please enter your favorite ROYGBIV color\n(If you do not know what ROYGBIV is, enter \"Help\")\n");
            string color = Console.ReadLine();
            string lowerColor = color.ToLower();
                if (lowerColor == "help")
                {
                Console.WriteLine("\"R\" = red");
                Console.WriteLine("\"O\" = orange");
                Console.WriteLine("\"Y\" = yellow");
                Console.WriteLine("\"G\" = green");
                Console.WriteLine("\"B\" = blue");
                Console.WriteLine("\"I\" = indigo");
                Console.WriteLine("\"V\" = violet");
                lowerColor = Console.ReadLine();
                }

            Console.WriteLine("Please enter the number of siblings you have:");
            int siblings = int.Parse(Console.ReadLine());

            //if/else statements to determine fortune

            //retire
            string retire = "defualt";
            if (userAge % 2==1)
            {
                retire = "10 years";
            }
            else
            {
                retire = "17 years";
            }

            //vacation home
            string vacation = "Alcatraz";
            if (siblings == 0)
            {
                vacation = "Malta";
            }
            else if (siblings == 1)
            {
                vacation = "Havana";
            }
            else if (siblings == 2)
            {
                vacation = "Hawaii";
            }
            else if (siblings == 3)
            {
                vacation = "Barbados";
            }
            else if (siblings > 3)
            {
                vacation = "the Cayman Islands";
            }
            else if(siblings <= 0)
            {
                vacation = "Alcatraz";
            }

            //mode of transportation
            string transport = "Hoveround";
            if (lowerColor == "red")
            {
                transport = "Ferrari";
            }
            else if (lowerColor == "orange")
            {
                transport = "Segway";
            }
            else if (lowerColor == "yellow")
            {
                transport = "pogo stick";
            }
            else if (lowerColor == "green")
            {
                transport = "skateboard";
            }
            else if (lowerColor == "blue")
            {
                transport = "helicopter";
            }
            else if (lowerColor == "indigo")
            {
                transport = "unicycle";
            }
            else if (lowerColor == "violet")
            {
                transport = "Honda Civic";
            }

            //money
            string money = "0.00";
            if (birthMonth == 1 || birthMonth == 2 || birthMonth == 3 || birthMonth == 4)
            {
                money = "$5,000,000,000";
            }
            else if (birthMonth == 5 || birthMonth == 6 || birthMonth == 7 || birthMonth == 8)
            {
                money = "$15,000,000";
            }
            else if (birthMonth == 9 || birthMonth == 10 || birthMonth == 11 || birthMonth == 12)
            {
                money = "$5,000,000";
            }

            //compiled fortune
            Console.Write(firstName + " " + lastName + " will retire in " + retire + " with " + money + " in the bank,\n" + "a vacation home in " + vacation + " and a " + transport+".\n");

        }
    }
}

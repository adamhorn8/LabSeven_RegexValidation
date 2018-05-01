using System;
using System.Text.RegularExpressions;

namespace LabSeven_ValidateInputsRegex
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Establish variable Name
            string Name = "";

            //Create while loop to ensure name in the correct format is received
            while (true)
            {
                //Ask user to input a name
                Console.WriteLine();
                Console.WriteLine("Please enter a valid name ");
                Name = Console.ReadLine();

                //Call to IsName method to validate name input
                bool NameBool = IsName(Name);

                //If name is valid, break the loop
                if (NameBool == true)
                {
                    break;
                }
                //If name is not valid return and ask for another name
                else
                {
                    Console.WriteLine("That name was not vaild");
                }
            }

            //Create while look to ensure correct email address input
            while (true)
            {
                //Ask for user to input email address
                Console.WriteLine();
                Console.WriteLine("Please enter your email address");
                string Email = Console.ReadLine();

                //Call IsEmail method to validate the email input
                bool EmailBool = IsEmail(Email);

                //If email is valid break the while loop
                if (EmailBool == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That email was not vaild");
                }
            }

            //Create while loop to validate phone number
            while (true)
            {
                //Ask user to input phone number
                Console.WriteLine();
                Console.WriteLine("Please enter your phone number in the format xxx-xxx-xxxx");
                string Number = Console.ReadLine();

                //Call IsNum method to validate phone number
                bool NumberBool = IsNum(Number);

                if (NumberBool == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That phone number was not valid");
                }
            }

            //Create while loop to validate date
            while (true)
            {
                //Ask user to input date
                Console.WriteLine();
                Console.WriteLine("Please enter the date in the format dd/mm/yy");
                string Date = Console.ReadLine();

                //Call the IsDate method to validate the date
                bool DateBool = IsDate(Date);

                if (DateBool == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for all of your information");
                    Console.WriteLine("Your account is now being created");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid date");
                }
            }
        }

        //Validation methods
        static bool IsName(string Name)
        {
            return Regex.IsMatch(Name, "[A-Z]{1}[a-z]{1,29}");
        }

        static bool IsEmail(string Email)
        {
            return Regex.IsMatch(Email, "[\\w\\.]{5,30}@[\\w.]{5,10}.\\w{2,3}");
        }

        static bool IsNum(string Number)
        {
            return Regex.IsMatch(Number, "\\d{3}\\-\\d{3}\\-\\d{4}");
        }

        static bool IsDate(string Date)
        {
            return Regex.IsMatch(Date, "^\\d{1,2}\\/\\d{1,2}\\/\\d{2,4}");
        }
    }
}
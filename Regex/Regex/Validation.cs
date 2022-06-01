using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class Validation
    {
        public string FirstName = ("^[A-Z]{1}[A-Za-z]{3,}$");
        public string LastName = ("^[A-Z]{1}[A-Za-z]{3,}$");

        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("First Name is Valid :" + firstName);
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
            return firstName;
        }
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LastName))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
            return lastName;
        }
    }
}
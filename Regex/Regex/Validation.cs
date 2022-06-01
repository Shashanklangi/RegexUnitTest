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
        public string Email = ("^[A-Za-z]{3,}@[a-z]{3,}.[a-z]{3,}$");
        public string PhoneNumber = ("^[A-Za-z]{3,}@[a-z]{3,}.[a-z]{3,}$");
        public string PassWord = "^[A-Z]{1,}[A-Za-z0-9]{5,}[!@#$%^&*+]{1}[0-9]{1,}$";
        public string allEmails = ("^[A-Za-z0-9]+([.+_-]?[A-Za-z0-9])*@[A-Za-z0-9]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$");



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
        public string EmailID(string Email_ID)
        {
            if (Regex.IsMatch(Email_ID, Email))
            {
                Console.WriteLine("Valid Email_ID");
            }
            else
            {
                Console.WriteLine("Invalid Email_ID");
            }
            return Email_ID;
        }
        public string Phonenumber(string Phone_Number)
        {
            if (Regex.IsMatch(Phone_Number, PhoneNumber))
            {
                Console.WriteLine("Valid Phone_Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone_Number");
            }
            return Phone_Number;
        }
        public string Password(string Password)
        {
            if (Regex.IsMatch(Password, PassWord))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            return Password;
        }
        public string PasswordRule2(string Password)
        {
            if (Regex.IsMatch(Password, PassWord))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            return Password;
        }
        public string PasswordRule3(string Password)
        {
            if (Regex.IsMatch(Password, PassWord))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            return Password;
        }
        public string PasswordRule4(string Password)
        {
            if (Regex.IsMatch(Password, PassWord))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            return Password;
        }
        public string AllEmails(string AllEmails)
        {
            if (Regex.IsMatch(AllEmails, allEmails))
            {
                Console.WriteLine("Valid AllEmails");
            }
            else
            {
                Console.WriteLine("Invalid AllEmails");
            }
            return AllEmails;
        }
    }
}
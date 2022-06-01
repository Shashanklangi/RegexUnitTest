using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            Validation person = new Validation();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            person.ValidateFirstName(firstName);

            //UC2
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Last Name: ");
            string lastname = Console.ReadLine();
            person.ValidateLastName(lastname);

            //UC3
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Email_ID: ");
            string EmailID = Console.ReadLine();
            person.EmailID(EmailID);

            //UC4
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Phone_Number: ");
            string Phone_Number = Console.ReadLine();
            person.Phonenumber(Phone_Number);

            //UC5
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Password: ");
            string Password = Console.ReadLine();
            person.Password(Password);

            //UC6
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Password: ");
            string PasswordRule2 = Console.ReadLine();
            person.Password(PasswordRule2);

            //UC7
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Password: ");
            string PasswordRule3 = Console.ReadLine();
            person.Password(PasswordRule3);

            //UC8
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Password: ");
            string PasswordRule4 = Console.ReadLine();
            person.Password(PasswordRule4);
        }
    }
}
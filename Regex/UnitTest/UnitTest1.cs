using NUnit.Framework;
using RegexPattern;

namespace UnitTest1
{
    public class Tests
    {
        Validation person;
        [SetUp]
        public void Setup()
        {
            person = new Validation();
        }

        [Test]
        public void Validating_Firstname()
        {
            //Arrange
            string firstname = "Shashank";
            person = new Validation();

            //Act
            string expected = "Shashank";
            string actual = person.ValidateFirstName(firstname);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validating_Lastname()
        {
            //Arrange
            string lastname = "Langi";
            person = new Validation();

            //Act
            string expected = "Langi";
            string actual = person.ValidateLastName(lastname);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validating_EmailID()
        {
            //Arrange
            string Email_ID = "YouGetShashank@gmail.com";
            person = new Validation();

            //Act
            string expected = "YouGetShashank@gmail.com";
            string actual = person.EmailID(Email_ID);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validating_PhoneNumber()
        {
            //Arrange
            string phonenumber = "91 1234567890";
            person = new Validation();

            //Act
            string expected = "91 1234567890";
            string actual = person.Phonenumber(phonenumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validating_Password()
        {
            //Arrange
            string password = "Shashank@#$1234";
            person = new Validation();

            //Act
            string expected = "Shashank@#$1234";
            string actual = person.Password(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validating_PasswordRule2()
        {
            //Arrange
            string password = "Shashank@#$1234";
            person = new Validation();

            //Act
            string expected = "Shashank@#$1234";
            string actual = person.Password(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
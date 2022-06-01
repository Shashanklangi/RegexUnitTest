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
    }
}
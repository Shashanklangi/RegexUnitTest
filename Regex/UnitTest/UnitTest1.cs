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
    }
}
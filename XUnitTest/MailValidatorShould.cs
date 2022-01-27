using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTest {
    public class MailValidatorShould {
        //[Fact] //-> TestMethod
        //public void ValidateValidEmails() {
        //    //Arrange
        //    XUnitTestExample.MailValidator mailValidator = new XUnitTestExample.MailValidator();
        //    string emailAddress = "thecodercaveok@gmail.com";

        //    //Act
        //    bool IsValid = mailValidator.IsValidEmail(emailAddress);

        //    //Assert
        //    Assert.True(IsValid, $"{emailAddress} is not valid");
        //}
        //[Fact] //-> TestMethod
        //public void InvalidateInvalidEmails() {
        //    //Arrange
        //    XUnitTestExample.MailValidator mailValidator = new XUnitTestExample.MailValidator();
        //    string emailAddress = "invalid@invalid.invalid";

        //    //Act
        //    bool isValid = mailValidator.IsValidEmail(emailAddress);

        //    //Assert
        //    Assert.False(isValid);
        //}
        [Theory]
        [InlineData("invalid@invalid.invalid", false)]
        [InlineData("thecodercaveok@gmail.com", true)]
        public void ValidateEmail(string emailAddress, bool expected) {
            //Arrange
            XUnitTestExample.MailValidator mailValidator = new XUnitTestExample.MailValidator();

            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);

            //Assert
            Assert.Equal(expected, isValid);
        }
        [Theory]
        [InlineData("spam@gmail.com", "INBOX")]
        [InlineData("spam@spam.com", "SPAM")]
        public void identifySpam(string emailAddress, string expected) {
            //Arrange
            XUnitTestExample.MailValidator mailValidator = new XUnitTestExample.MailValidator();

            //Act
            string isValid = mailValidator.IsSpam(emailAddress);

            //Assert
            Assert.Equal(expected, isValid);
        }

        [Fact]
        public void RaiseErrorWhemEmailIsEmpty() {
            //Arrange
            XUnitTestExample.MailValidator mailValidator = new XUnitTestExample.MailValidator();

            //Act

            //Assert
            Assert.Throws<XUnitTestExample.EmailNotProviderException>(() => mailValidator.IsValidEmail(null));
        } 
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UserMSTest
{
    [TestClass]
    public class UserRegisterationMSTest
    {
        UserRegisterationTest.UserValidator userValidator = new UserRegisterationTest.UserValidator();

        /// <summary>
        /// Givens the proper first name should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperFirstName_ShouldReturnTrue()
        {
            //Arrange
            string firstName = "Chetan";

            //Act
            bool result = userValidator.ValidateFirstName(firstName);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper first name should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperFirstName_ShouldReturnFalse()
        {
            //Arrange
            string firstName = "chetan";

            //Act
            bool result = userValidator.ValidateLastName(firstName);

            //Assert
            Assert.IsFalse(result);

        }

        /// <summary>
        /// Givens the proper last name should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperLastName_ShouldReturnTrue()
        {    
            //Arrange
            string lastName = "Kohli";

            //Act
            bool result = userValidator.ValidateLastName(lastName);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper last name should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperLastName_ShouldReturnFalse()
        {
            //Arrange
            string lastName = "kohli";

            //Act
            bool result = userValidator.ValidateLastName(lastName);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Givens the proper email should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperEmail_ShouldReturnTrue()
        {
            //Arrange
            string email = "bmchetan2028@gmail.com";

            //Act
            bool result = userValidator.ValidateEmail(email);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper email should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperEmail_ShouldReturnFalse()
        {
            //Arrange
            string email = ".bmchetan2028@gmail.com";

            //Act
            bool result = userValidator.ValidateEmail(email);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Givens the proper password should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperPassword_ShouldReturnTrue()
        {
            //Arrange
            string password = "Akbar@1bgm89";

            //Act
            bool result = userValidator.ValidatePassword(password);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper password should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperPassword_ShouldReturnFalse()
        {
            //Arrange
            string password = "akbar@woqyeoi";

            //Act
            bool result = userValidator.ValidatePassword(password);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Givens the proper mobile number should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperMobileNumber_ShouldReturnTrue()
        {
            //Arrange
            string number = "91 8951604950";

            //Act
            bool result = userValidator.ValidateMobileNumber(number);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper mobile number should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperMobileNumber_ShouldReturnFalse()
        {
            //Arrange
            string number = "91 895160495";

            //Act
            bool result = userValidator.ValidateMobileNumber(number);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCVZ.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var user = new Users { Password = "password1" };

            //Act
            var result = user.PasswordCorrect("password1");

            //Assert
            Assert.IsTrue(result);
        }
    }
}

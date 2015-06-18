using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agile.BL;

namespace Agile.BLTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestFullNameValid()
        {
            //Arrange
            var user = new User("Tyrion", "Lannister");
            var expected = "Tyrion Lannister";
            //Act
            var actual = user.FullName;
            //Assert
            Assert.AreEqual(actual, expected);
        }

    }
}

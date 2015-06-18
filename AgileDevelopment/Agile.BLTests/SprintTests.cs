using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agile.BL;

namespace Agile.BLTests
{
    [TestClass]
    public class SprintTests
    {
        [TestMethod]
        public void DateDueIsCorrectWithGivenDate()
        {
            //Arrange
            var sprint = new Sprint("Hello World", new TimeSpan(3, 0, 0, 0));
            var currentTime = DateTimeOffset.Now;
            var expected = currentTime.Add(new TimeSpan(3, 0, 0, 0));
            
            //Act
            var actual = sprint.DateDue;

            //Assert
        }

        [TestMethod]
        public void DateDueIsCorrectWithNoDate()
        {
            //Arrange
            var sprint = new Sprint("Hello World");
            var currentTime = DateTimeOffset.Now;
            var expected = currentTime.Add(new TimeSpan(14, 0, 0, 0));

            //Act
            var actual = sprint.DateDue;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

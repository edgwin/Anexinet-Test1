using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetPi()
        {
            //Arrange
            var expected = Convert.ToDouble("3,14159365359077");
            expected = Math.Round(expected, 4);
            //Act
            var result = Math.Round(Program.process(),4);
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}

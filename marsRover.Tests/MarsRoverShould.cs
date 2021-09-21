using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Tests
{
    [TestClass]
    public class MarsRoverShould
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("0 0 N", "", "0 0 N")]
        [DataRow("0 0 N", "M", "0 1 N")]
        [DataRow("1 1 N", "M", "1 2 N")]
        [DataRow("1 1 W", "M", "0 1 W")]
        [DataRow("1 1 E", "M", "2 1 E")]
        [DataRow("1 1 S", "M", "1 0 S")]
        [DataRow("1 1 S", "R", "1 1 W")]
        [DataRow("1 1 W", "R", "1 1 N")]
        [DataRow("1 1 N", "R", "1 1 E")]
        [DataRow("1 1 E", "R", "1 1 S")]
        [DataRow("1 1 S", "L", "1 1 E")]
        [DataRow("1 1 E", "L", "1 1 N")]
        [DataRow("1 1 N", "L", "1 1 W")]
        [DataRow("1 1 W", "L", "1 1 S")]
        public void ExecuteTest(string initialState, string commands , string finalState)
        {
            var marsRover = new MarsRover(initialState);
            var result = marsRover.Execute(commands);
            Assert.IsTrue(result == finalState);

        }
        


    }
}

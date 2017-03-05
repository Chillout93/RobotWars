using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotWars.Test
{
    [TestClass]
    public class RobotTests
    {
        private Robot robot;
        private int position;
        private string orientation;

        [TestInitialize]
        public void SetUp()
        {
            orientation = "N";
            position = 3;
            robot = new Robot($"{position} {position}", orientation.ToString(), 5, 5);
        }

        [TestMethod]
        public void Robot_ParseMove_SetsOrientationCorrectly()
        {
            orientation = "N";
            Assert.AreEqual(orientation, robot.Orientation.ToString());
            robot.ParseMove('L');
            Assert.AreEqual("W", robot.Orientation.ToString());
            robot.ParseMove('R');
            Assert.AreEqual("N", robot.Orientation.ToString());
        }
    }
}

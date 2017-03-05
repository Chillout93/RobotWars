using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotWars.Test
{
    [TestClass]
    public class OrientationTests
    {
        private Robot robot;
        private int position;
        private string orientation;

        [TestInitialize]
        public void SetUp()
        {
            orientation = "N";
            position = 3;
            robot = new Robot($"{position} {position}", orientation, 5, 5);
        }

        [TestMethod]
        public void RightOrientation_WitMove_IncrementsXBy1()
        {
            robot.Orientation = robot.RightOrientation;

            Assert.AreEqual(position, robot.Position.X);
            robot.ParseMove('M');
            Assert.AreEqual(position + 1, robot.Position.X);
        }

        [TestMethod]
        public void LeftOrientation_WithMove_DecreasesXBy1()
        {
            robot.Orientation = robot.LeftOrientation;

            Assert.AreEqual(position, robot.Position.X);
            robot.ParseMove('M');
            Assert.AreEqual(position - 1, robot.Position.X);
        }

        [TestMethod]
        public void UpOrientation_WithMove_IncreasesYBy1()
        {
            robot.Orientation = robot.UpOrientation;

            Assert.AreEqual(position, robot.Position.Y);
            robot.ParseMove('M');
            Assert.AreEqual(position + 1, robot.Position.Y);
        }

        [TestMethod]
        public void DownOrientation_WithMove_DecreasesYBy1()
        {
            robot.Orientation = robot.DownOrientation;

            Assert.AreEqual(position, robot.Position.Y);
            robot.ParseMove('M');
            Assert.AreEqual(position - 1, robot.Position.Y);
        }
    }
}

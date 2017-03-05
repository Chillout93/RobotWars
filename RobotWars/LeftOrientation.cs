namespace RobotWars
{
    public class LeftOrientation : IOrientationState
    {
        private Robot robot;
        public LeftOrientation(Robot robot)
        {
            this.robot = robot;
        }

        public bool ParseMove(char move)
        {
            switch (move)
            {
                case 'L':
                    robot.Orientation = robot.DownOrientation;
                    return true;
                case 'R':
                    robot.Orientation = robot.UpOrientation;
                    return true;
                case 'M':
                    robot.Position = new Position(robot.Position.X - 1 == 0 ? robot.GridXSize : robot.Position.X - 1, robot.Position.Y);
                    return true;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return "W";
        }
    }
}

namespace RobotWars
{
    public class DownOrientation : IOrientationState
    {
        private Robot robot;
        public DownOrientation(Robot robot)
        {
            this.robot = robot;
        }

        public bool ParseMove(char move)
        {
            switch (move)
            {
                case 'L':
                    robot.Orientation = robot.RightOrientation;
                    return true;
                case 'R':
                    robot.Orientation = robot.LeftOrientation;
                    return true;
                case 'M':
                    robot.Position = new Position(robot.Position.X, robot.Position.Y - 1 == 0 ? robot.GridYSize : robot.Position.Y - 1);
                    return true;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return "S";
        }
    }
}

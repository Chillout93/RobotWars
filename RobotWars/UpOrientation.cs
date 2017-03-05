namespace RobotWars
{
    public class UpOrientation : IOrientationState
    {
        private Robot robot;
        public UpOrientation(Robot robot)
        {
            this.robot = robot;
        }

        public bool ParseMove(char move)
        {
            switch (move)
            {
                case 'L':
                    robot.Orientation = robot.LeftOrientation;
                    return true;
                case 'R':
                    robot.Orientation = robot.RightOrientation;
                    return true;
                case 'M':
                    robot.Position = new Position(robot.Position.X, robot.Position.Y + 1 > robot.GridYSize ? 1 : robot.Position.Y + 1);
                    return true;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return "N";
        }
    }
}

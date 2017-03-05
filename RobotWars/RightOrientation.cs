namespace RobotWars
{
    public class RightOrientation : IOrientationState
    {
        private Robot robot;
        public RightOrientation(Robot robot)
        {
            this.robot = robot;
        }

        public bool ParseMove(char move)
        {
            switch (move)
            {
                case 'L':
                    robot.Orientation = robot.UpOrientation;
                    return true;
                case 'R':
                    robot.Orientation = robot.DownOrientation;
                    return true;
                case 'M':
                    robot.Position = new Position(robot.Position.X + 1 > robot.GridXSize ? 1 : robot.Position.X + 1, robot.Position.Y);
                    return true;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return "E";
        }
    }
}

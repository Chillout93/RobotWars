using System.Linq;

namespace RobotWars
{
    public class Robot : IOrientationState
    {
        public IOrientationState Orientation { get; set; }
        public IOrientationState UpOrientation { get; private set; }
        public IOrientationState RightOrientation { get; private set; }
        public IOrientationState DownOrientation { get; private set; }
        public IOrientationState LeftOrientation { get; private set; }
        public Position Position { get; set; }
        public int GridXSize { get; private set; }
        public int GridYSize { get; private set; }

        public Robot(string position, string orientation, int xSize, int ySize)
        {
            this.UpOrientation = new UpOrientation(this);
            this.RightOrientation = new RightOrientation(this);
            this.DownOrientation = new DownOrientation(this);
            this.LeftOrientation = new LeftOrientation(this);

            this.Position = ParsePosition(position);
            this.Orientation = ParseOrientation(orientation);

            this.GridXSize = xSize;
            this.GridYSize = ySize;
        }

        // State Pattern
        // What moves happens will be based on whichever state above is set as the current orientation, which then changes said orientation if the command demands it.
        public bool ParseMove(char move)
        {
            return Orientation.ParseMove(move);
        }

        private IOrientationState ParseOrientation(string orientation)
        {
            switch (orientation)
            {
                case "N":
                    return UpOrientation;
                case "S":
                    return DownOrientation;
                case "E":
                    return RightOrientation;
                case "W":
                    return LeftOrientation;
                default:
                    throw new System.Exception($"{orientation} is an invalid orientation.");
            }
        }

        private Position ParsePosition(string startingPosition)
        {
            var values = startingPosition.Split(' ');
            return new Position(int.Parse(values[0]), int.Parse(values[1]));         
        }
    }
}

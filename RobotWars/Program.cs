using System;
using System.Linq;

namespace RobotWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int gridX = 0;
            int gridY = 0;
        
            while (gridX == 0 || gridY == 0)
            {
                Console.Write("Grid Size?: ");
                var input = Console.ReadLine()?.Trim()?.Split(' ');
                if (input.Length != 2) continue;

                int.TryParse(input[0], out gridX);
                int.TryParse(input[1], out gridY);
            }

            do
            {
                Console.WriteLine("Enter Robot position then moveset, press escape to cancel.");
                Console.Write("Robot position? (e.g. 1 2 N): ");
                var values = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(values) || values.Length != 5 || !"NESW".Contains(values.Substring(4, 1))) continue;

                var robot = new Robot(values.Substring(0, 3), values.Substring(4, 1), gridX, gridY);
    
                Console.Write("Robot moveset? (e.g. LMLMLMLMM): ");
                var moveset = Console.ReadLine();
                if (string.IsNullOrEmpty(moveset) || moveset.Any(x => !"LRM".Contains(x))) continue;

                foreach (var move in moveset.ToCharArray())
                {
                    robot.ParseMove(move);
                    Console.WriteLine($"{robot.Position.X} {robot.Position.Y} {robot.Orientation}");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
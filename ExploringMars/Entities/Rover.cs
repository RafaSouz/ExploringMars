using ExploringMars.Entities.Enums;

namespace ExploringMars.Entities;

public class Rover
{
    public Position Position { get; set; }
    public Direction Direction { get; set; }
    public List<char> Commands { get; set; }

    private Rover(int x, int y, Direction direction, List<char> commands)
    {
        Commands = commands;
        Direction = Direction;
        Position = Position.Create(x, y);
    }

    public static Rover Create(int x, int y, Direction direction, List<char> commands)
    {
        if (x < 0 || y < 0)
            throw new ArgumentOutOfRangeException("X and Y positions must be a positive number");

        return new Rover(x, y, direction, commands);
    }
}

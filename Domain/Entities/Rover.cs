using ExploringMars.Entities.Enums;

namespace ExploringMars.Entities;

public class Rover
{
    public Position Position { get; set; }
    public Direction Direction { get; set; }
    public List<Command> Commands { get; set; }

    private Rover(int x, int y, Direction direction, List<Command> commands)
    {
        Commands = commands;
        Direction = Direction;
        Position = Position.Create(x, y);
    }

    public static Rover Create(int x, int y, Direction direction, List<Command> commands)
    {
        if (x < 0 || y < 0)
            throw new ArgumentOutOfRangeException("X and Y positions must be a positive number or 0.");

        return new Rover(x, y, direction, commands);
    }

    public static void GetPosition(Rover rover)
    {
        Console.WriteLine($"{rover.Position.X} {rover.Position.Y} {rover.Direction.ToString()}");
    }
}

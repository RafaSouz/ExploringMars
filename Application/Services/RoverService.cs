using Application.Helpers;
using ExploringMars.Entities;
using ExploringMars.Entities.Enums;

namespace Application.Services;

public static class RoverService
{
    public static void GetRoverPosition(this Rover rover) => Rover.GetPosition(rover);

    public static List<Rover> CreateRoverList(int x, int y)
    {
        var rovers = new List<Rover>();

        do
        {
            var positionDetails = GetRoverInitialPosition();

            if (positionDetails == null)
                break;

            rovers.Add(Rover.Create(int.Parse(positionDetails[0]), int.Parse(positionDetails[1]), DirectionHelper.StringToCommand(positionDetails[2]), GetCommands()));

            ValidateInitialPosition(rovers, x, y);
        }
        while (true);

        return rovers;
    }

    private static void ValidateInitialPosition(List<Rover> rovers, int x, int y)
    {
        foreach (var rover in rovers)
        {
            ValidateLimits(rover.Position, x, y);

            ValidateFreePosition(rover.Position, rovers.Where(x => x.RoverId != rover.RoverId).Select(x => x.Position).ToList());
        }
    }

    private static void ValidateFreePosition(Position position, List<Position> positions)
    {
        if(positions.Where(x => x.X == position.X &&  x.Y == position.Y).Any())
            throw new ArgumentException("Initial rover position its already occupied.");
    }

    private static void ValidateLimits(Position position, int x, int y)
    {
        if (position.X > x || position.Y > y)
            throw new ArgumentException("Initial rover position exceeds limites of plateau.");
    }

    private static List<Command> GetCommands()
    {
        var commandString = Console.ReadLine();

        return commandString.ToCharArray().Select(CommandHelper.StringToCommand).ToList();
    }

    private static List<string> GetRoverInitialPosition()
    {
        var positionSpecifications = Console.ReadLine();

        if (positionSpecifications == null || positionSpecifications == string.Empty)
            return null;

        var positionDetails = positionSpecifications.Split(" ");

        if (positionDetails.Count() != 3)
            throw new ArgumentOutOfRangeException("Initial position of a rover must have only three specifications.");

        return positionDetails.ToList();
    }
}

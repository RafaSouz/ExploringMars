using ExploringMars.Entities.Enums;

namespace Application.Helpers;

public static class DirectionHelper
{
    public static Direction StringToCommand(string command)
    {
        switch (command)
        {
            case "N":
                return Direction.N;
            case "W":
                return Direction.W;
            case "S":
                return Direction.S;
            case "E":
                return Direction.E;
            default:
                throw new ArgumentException("Direction not identified.");
        }
    }
}

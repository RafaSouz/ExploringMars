using Application.Helpers;
using ExploringMars.Entities;

namespace Application.Services;

public static class RoverService
{
    public static void GetRoverPosition(this Rover rover) => Rover.GetPosition(rover);

    public static List<Rover> CreateRoverList()
    {
        var roverList = new List<Rover>();

        do
        {
            var positionSpecifications = Console.ReadLine();

            if (positionSpecifications == null || positionSpecifications == string.Empty)
                break;

            var positionDetais = positionSpecifications.Split(" ");

            if (positionDetais.Count() != 3)
                throw new ArgumentOutOfRangeException("Initial position of a rover must have only three specifications.");

            var commandString = Console.ReadLine();

            var commands = commandString.ToCharArray().Select(CommandHelper.StringToCommand).ToList();

            roverList.Add(Rover.Create(int.Parse(positionDetais[0]), int.Parse(positionDetais[1]), DirectionHelper.StringToCommand(positionDetais[2]), commands));
        }
        while (true);

        return roverList;
    }
}

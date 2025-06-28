using ExploringMars.Entities;

namespace Application.Services;

public static class RoverService
{
    public static void GetRoverPosition(this Rover rover) => Rover.GetPosition(rover);

}

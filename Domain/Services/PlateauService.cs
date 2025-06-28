using ExploringMars.Entities;

namespace Application.Services;

public static class PlateauService
{
    public static Plateau CreatePlateau()
    {
        var specs = GetPlateauSpecs();

        return Plateau.Create(specs.First(), specs.Last());
    }

    public static void GetExplorationResults(Plateau plateau)
    {
        if (plateau.Rovers.Count == 0)
        {
            Console.WriteLine("");
            return;
        }

        foreach(var rover in plateau.Rovers)
        {

        }
    }

    private static List<int> GetPlateauSpecs()
    {
        var plateauSpecs = Console.ReadLine();

        if (plateauSpecs == string.Empty)
            throw new ArgumentOutOfRangeException("Plateau specifications cannot be empty.");

        var specs = plateauSpecs.Split(" ").Select(int.Parse).ToList();

        if (specs == null || specs.Count != 2)
            throw new ArgumentOutOfRangeException("Plateau must have two specifications.");

        return specs;
    }
}

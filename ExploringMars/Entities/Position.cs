
namespace ExploringMars.Entities;

public class Position
{
    public int X { get; set; } 
    public int Y { get; set; }

    private Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Position Create(int x, int y)
    {
        return new Position(x, y);
    }
}

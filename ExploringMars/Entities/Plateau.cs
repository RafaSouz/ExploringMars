namespace ExploringMars.Entities;

public class Plateau
{
    public int Height { get; set; }
    public int Width { get; set; }

    public List<Rover> Rovers { get; set; }

    private Plateau(int height, int width)
    {
        Height = height; 
        Width = width;
        Rovers = new List<Rover>();
    }

    public static Plateau Create(int height, int width)
    {
        if (height < 0 || width < 0)
            throw new ArgumentOutOfRangeException("Height and width must be a positive number");

        return new Plateau(height, width);
    }
}

using ExploringMars.Entities.Enums;

namespace Application.Helpers;

public static class CommandHelper
{
    public static Command StringToCommand(char command)
    {
        switch (command)
        {
            case 'L':
                return Command.L;
            case 'R':
                return Command.R;
            case 'M':
                return Command.M;
            default:
                return Command.N;
        }
    }
}

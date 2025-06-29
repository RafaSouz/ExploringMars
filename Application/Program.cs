using Application.Services;

var plateau = PlateauService.CreatePlateau();

plateau.Rovers = RoverService.CreateRoverList(plateau.Height, plateau.Width);

ExplorationService.ExecuteRoversCommands(plateau);

PlateauService.GetExplorationResults(plateau);
namespace MazeGame
{
    public sealed class InitializeController
    {
        public InitializeController(MainController mainController, BallData ballData)
        {
            new BallInitializator(mainController, ballData);
        }
    }
}

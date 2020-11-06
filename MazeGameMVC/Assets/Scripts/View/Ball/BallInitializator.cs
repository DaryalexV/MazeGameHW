using UnityEngine;


namespace MazeGame
{
    public sealed class BallInitializator
    {
        public BallInitializator(MainController mainController, BallData ballData)
        {
            var spawnedBall = Object.Instantiate(ballData.ballStruct.Ball,
                ballData.ballStruct.StartPosition,
                Quaternion.identity);

            var ballStruct = ballData.ballStruct;
            ballStruct.Ball = spawnedBall;

            var ballModel = new BallModel(ballStruct);
            mainController.AddUpdatable(new BallController(ballModel));
        }
    }
}

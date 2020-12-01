using System;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Maze
{
    public sealed class GameController : MonoBehaviour, IDisposable
    {
        public PlayerType PlayerType = PlayerType.Ball;
        private ListExecuteObject _interactiveObject;
        private DisplayEndGame _displayEndGame;
        private DisplayBonuses _displayBonuses;
        private CameraController _cameraController;
        private InputController _inputController;
        private int _countBonuses;
        private Reference _reference;

        private void Awake()
        {
            var reference = new Reference();

            _interactiveObject = new ListExecuteObject();
            _displayEndGame = new DisplayEndGame(reference.GameOver);
            _displayBonuses = new DisplayBonuses(reference.Bonus);


            PlayerBase player = null;
            if (PlayerType == PlayerType.Ball)
            {
                player = reference.PlayerBall;
            }

            _cameraController = new CameraController(reference.PlayerBall.transform, reference.MainCamera.transform);
            _interactiveObject.AddExecuteObject(_cameraController);

            _inputController = new InputController(reference.PlayerBall);
            _interactiveObject.AddExecuteObject(_inputController);

            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayerChange += CaughtPlayer;
                    badBonus.OnCaughtPlayerChange += _displayEndGame.GameOver;
                }

                if ( o is GoodBonus goodBonus)
                {
                    goodBonus.OnPointChange += AddBonus;
                }
            }

            _reference.RestartButton.onClick.AddListener(RestartGame);
            _reference.RestartButton.gameObject.SetActive(false);

        }

        private void RestartGame()
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
            Time.timeScale = 1.0f;
        }

        private void CaughtPlayer(string value, Color args)
        {
            _reference.RestartButton.gameObject.SetActive(true);
            Time.timeScale = 0.0f;
        }

        private void AddBonus(int value)
        {
            _countBonuses += value;
            _displayBonuses.Display(_countBonuses);
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    if (o is BadBonus badBonus)
                    {
                        badBonus.OnCaughtPlayerChange += CaughtPlayer;
                        badBonus.OnCaughtPlayerChange += _displayEndGame.GameOver;
                    }

                    if (o is GoodBonus goodBonus)
                    {
                        goodBonus.OnPointChange += AddBonus;
                    }
                }
            }
        }
    }
}

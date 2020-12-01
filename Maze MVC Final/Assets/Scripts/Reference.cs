using UnityEngine;
using UnityEngine.UI;



namespace Maze
{
    public sealed class Reference
    {
        private PlayerBall _playerBall;
        private Camera _mainCamera;
        private GameObject _bonus;
        private GameObject _gameOver;
        private Canvas _canvas;
        private Button _restartButton;

        public Button RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    var gameObject = Resources.Load<Button>("UI/Restart");
                    _restartButton = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _restartButton;
            }
        }

        public Canvas Canvas
        {
            get
            {
                if (_canvas = null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
        }
        public GameObject Bonus
        {
            get
            {
                if (_bonus == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/Bonus");
                    _bonus = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _bonus;
            }
        }

        public GameObject GameOver
        {
            get
            {
                if (_gameOver == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/GameOver");
                    _gameOver = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _gameOver;
            }
        }

        public PlayerBall PlayerBall
        {
            get
            {
                if (_playerBall == null)
                {
                    var gameObject = Resources.Load<PlayerBall>("Player");
                    _playerBall = Object.Instantiate(gameObject);
                }
                return _playerBall;
            }
        }

        public Camera MainCamera
        {
            get
            {
                if (_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
        }
    }
}

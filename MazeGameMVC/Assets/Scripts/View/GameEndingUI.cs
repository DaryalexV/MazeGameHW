using UnityEngine;
using UnityEngine.SceneManagement;


namespace MazeGame
{
    public class GameEndingUI : MonoBehaviour
    {
        [SerializeField] private GameObject _gameEndingMenu;
        private FloatProxy _myFloat;

        public GameEndingUI(FloatProxy myFloat)
        {
            _myFloat = myFloat;
        }

        public void GameEndingMenu()
        {
            if (_myFloat.Value == 0)
            {
                _gameEndingMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        public void StartAgain()
        {
            SceneManager.LoadScene("SampleScene");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

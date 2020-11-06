using UnityEngine;


namespace MazeGame
{
    public class GameControllerHP : MonoBehaviour
    {
        private FloatProxy _myFloat = new FloatProxy();
        private TextController _textController;
        private ChangeController _changeController;

        public GameControllerHP()
        {
            _textController = new TextController(_myFloat);
            _changeController = new ChangeController(_myFloat);
        }

        public void Update()
        {
            _textController.Execute();
            _changeController.Execute();
            //Debug.Log($"_myFloat.Value: {_myFloat.Value}");
        }
    }
}

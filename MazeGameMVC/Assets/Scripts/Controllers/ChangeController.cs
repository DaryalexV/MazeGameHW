using UnityEngine;


namespace MazeGame
{
    public class ChangeController : MonoBehaviour
    {
        private FloatProxy _myFloat;
        private float _ballHP = 10.0f;

        public ChangeController(FloatProxy myFloat)
        {
            _myFloat = myFloat;
        }

        public void Execute()
        {
            _myFloat.Value = _ballHP;
        }
    }
}

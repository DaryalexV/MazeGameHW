using UnityEngine.UI;
using UnityEngine;


namespace MazeGame
{
    public sealed class TextController : MonoBehaviour
    {
        private FloatProxy _myfloat;


        public TextController(FloatProxy myFloat)
        {
            _myfloat = myFloat;
        }

        public void Execute()
        {
            GameObject.FindObjectOfType<Text>().text = _myfloat.Value.ToString();
        }
    }
}



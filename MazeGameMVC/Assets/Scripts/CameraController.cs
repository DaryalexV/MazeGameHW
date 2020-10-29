using UnityEngine;


namespace MazeGame
{

    public class CameraController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Vector3 _offset = Vector2.zero;
        [SerializeField] private Transform _target;
        private BallModel _ballModel;

        #endregion


        #region Unity Methods
        private void Start()
        {
           _target = _ballModel._ballStruct.Ball.transform;

            // Как мне сделать из SO target? Не отслеживается... Я сослалась на Ball, это создаваемый на сцене объект.
        }


        private void Update()
        {
            transform.position = _target.position;
            transform.position += _offset;
        }

        #endregion
    }
}

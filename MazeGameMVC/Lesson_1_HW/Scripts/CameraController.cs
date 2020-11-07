using UnityEngine;


namespace MazeGame
{

    public class CameraController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Vector3 _offset = Vector2.zero;
        [SerializeField] private Transform _target;

        #endregion


        #region Unity Methods

        private void Update()
        {
            transform.position = _target.position;
            transform.position += _offset;
        }

        #endregion
    }
}

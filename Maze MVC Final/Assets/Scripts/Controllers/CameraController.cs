using UnityEngine;


namespace Maze
{
    public class CameraController : IExecute
    {
        private Transform _player;
        private Transform _mainCamera;
        private Vector3 _offset;

        public CameraController (Transform player, Transform mainCamera)
        {
            _player = player;
            _mainCamera = mainCamera;
            _mainCamera.LookAt(_player);
            _offset = _mainCamera.position - _player.position;
        }

        private void Execute()
        {
            _mainCamera.position = _player.position + _offset;
        }

    }
}

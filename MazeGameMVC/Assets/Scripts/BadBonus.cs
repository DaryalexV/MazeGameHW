using UnityEngine;


namespace MazeGame
{
    public sealed class BadBonus : InteractiveObject, IFly, IRotation
    {
        private float _flyLenght;
        private float _rotateSpeed;
        private float _minRange = 1.0f;
        private float _maxRange = 5.0f;
        private float _minRotate = 10.0f;
        private float _maxRotate = 50.0f;



        private void Awake()
        {
            _rotateSpeed = Random.Range(_minRotate, _maxRotate);
            _flyLenght = Random.Range(_minRange, _maxRange);
        }

        protected override void Interaction()
        {

        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _flyLenght),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _rotateSpeed), Space.World);
        }
    }
}

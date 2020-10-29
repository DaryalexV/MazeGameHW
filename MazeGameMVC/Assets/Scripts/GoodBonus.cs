using UnityEngine;


namespace MazeGame
{
    public sealed class GoodBonus : InteractiveObject, IFly
    {
        private Material _material;
        private float _flyLenght;
        private float _minRange = 1.0f;
        private float _maxRange = 5.0f;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _flyLenght = Random.Range(_minRange, _maxRange);
        }

        protected override void Interaction ()
        {

        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _flyLenght),
                transform.localPosition.z);
        }
    }
}

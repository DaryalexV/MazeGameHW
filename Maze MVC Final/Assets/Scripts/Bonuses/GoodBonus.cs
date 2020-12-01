using System;
using UnityEngine;
using static UnityEngine.Random;


namespace Maze
{
    public sealed class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        private Material _material;
        private float _lengthFly;
        private float _minLenght = 0.1f;
        private float _maxLenght = 1.0f;

        public int Point;
        public event Action<int> OnPointChange = delegate (int i) { };

        private DisplayBonuses _displayBonuses;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFly = Range(_minLenght, _maxLenght);
        }

        protected override void Interaction()
        {
            OnPointChange.Invoke(Point);
        }

        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Fly();
            Flicker();
        }
        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
               Mathf.PingPong(Time.time, 1.0f));
        }
    }
}

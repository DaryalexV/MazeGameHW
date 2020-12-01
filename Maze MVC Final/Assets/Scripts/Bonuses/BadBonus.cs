using System;
using UnityEngine;
using static UnityEngine.Random;


namespace Maze
{
    public sealed class BadBonus : InteractiveObject, IFly, IRotation
    {
        private float _lengthFly;
        private float _minLength = 0.1f;
        private float _maxLength = 1.0f;
        private float _speedRotation;
        private float _minSpeedRotation = 10.0f;
        private float _maxSpeedRotation = 50.0f;

        public event Action<string, Color> OnCaughtPlayerChange = delegate (string str, Color color) { };

        private void Awake()
        {
            _lengthFly = Range(_minLength, _maxLength);
            _speedRotation = Range(_minSpeedRotation, _maxSpeedRotation);
        }

        protected override void Interaction()
        {
            OnCaughtPlayerChange.Invoke(gameObject.name, _color);
        }

        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Fly();
            Rotation();
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
    }
}

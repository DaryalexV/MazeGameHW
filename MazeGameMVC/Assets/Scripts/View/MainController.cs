using UnityEngine;
using System.Collections.Generic;


namespace MazeGame
{
    public class MainController : MonoBehaviour
    {
        [SerializeField] private BallData _ballData;

        private List<IUpdatable> _iIpdatables = new List<IUpdatable>();

        private void Start()
        {
            new InitializeController(this, _ballData);
        }

        private void Update()
        {
            for (int i = 0; i < _iIpdatables.Count; i++)
            {
                _iIpdatables[i].UpdateTick();
            }

        }

        public void AddUpdatable(IUpdatable iUpdatable)
        {
            _iIpdatables.Add(iUpdatable);
        }

    }
}

using UnityEngine;


namespace MazeGame
{
    public sealed class BallController : MonoBehaviour, IUpdatable
    {
        private BallModel _ballModel;
        private Rigidbody _ballRB;
        public BallController(BallModel ballModel)
        {
            _ballModel = ballModel;
            _ballRB = _ballModel._ballStruct.Ball.GetComponent<Rigidbody>();

        }

        public void UpdateTick()
        {

            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _ballRB.AddForce(movement * _ballModel._ballStruct.BallSpeed);

        }
    }
}

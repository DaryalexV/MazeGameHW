using System;
using UnityEngine;

namespace MazeGame
{ 

    [Serializable]
    public struct BallStruct 
    {
        public Vector3 StartPosition;
        public GameObject Ball;
        public float BallSpeed;
        public float BallHP;
    }

}

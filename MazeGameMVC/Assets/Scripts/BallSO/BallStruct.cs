using System;
using UnityEngine;

namespace MazeGame
{ 

    [Serializable]
    public struct BallStruct 
    {
        public GameObject Ball;
        public float BallSpeed;
        public Vector3 StartPosition;
    }

}

using UnityEngine;


namespace MazeGame
{
    [CreateAssetMenu(fileName = "BallData", menuName = "Data")]
    public sealed class BallData : ScriptableObject
    {
        public BallStruct ballStruct;
    }

}

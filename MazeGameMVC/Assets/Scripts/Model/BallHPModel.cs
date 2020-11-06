using MazeGame;
using UnityEngine;

public sealed class BallHPModel
{
    private FloatProxy _ballHP;
    private BallModel _ballModel;

    public BallHPModel (BallModel ballModel)
    {
        _ballModel = ballModel;
        _ballHP = new FloatProxy { Value = _ballModel._ballStruct.BallHP };
    }

    public class FloatProxy
    {
        public float Value;
    }
}

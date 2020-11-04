using System;
using UnityEngine;

namespace MazeGame
{
    public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }
        // Можем дописать сколько угодно свойств
        public CaughtPlayerEventArgs(Color Color)
        {
            Color = Color;
        }

    }
}

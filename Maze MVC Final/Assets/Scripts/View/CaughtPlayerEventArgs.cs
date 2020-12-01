using UnityEngine;


namespace Maze
{
    public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }

        public CaughtPlayerEventArgs (Color color)
        {
            color = Color;
        }
    }
}

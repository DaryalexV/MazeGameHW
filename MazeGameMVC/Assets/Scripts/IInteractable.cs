using UnityEngine;


namespace MazeGame
{

    public interface IInteractable : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }

}

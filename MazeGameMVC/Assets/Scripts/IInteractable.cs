namespace MazeGame
{
    public interface IInteractable : IInitialization
    {
        bool IsInteractable { get; }
    }
}

namespace GuessGame;

/// <summary>
/// Single Responsibility Principle (SRP)
/// Dependency Inversion Principle (DIP)
/// Open/Closed Principle (OCP)
/// </summary>
public abstract class Game
{
    private readonly IView _view;

    protected Game(IView view)
    {
        _view = view;
    }

    public virtual void Play() { }
}
namespace GuessGame;

/// <summary>
/// Single Responsibility Principle (SRP)
/// </summary>
public class ConsoleView : IView
{
    public void Show(string message)
    {
        Console.WriteLine(message);
    }
}
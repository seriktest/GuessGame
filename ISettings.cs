namespace GuessGame;

/// <summary>
/// Interface Segregation Principle (ISP)
/// </summary>
public interface ISettings
{
    int MaxTries { get; set; }
    int MaxNumber { get; }
}
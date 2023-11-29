namespace GuessGame;


/// <summary>
/// Dependency Inversion Principle (DIP)
/// Liskov Substitution Principle (LSP)
/// Single Responsibility Principle (SRP)
/// </summary>
public class GuessGame : Game
{
    private readonly IView _view;
    private readonly ISettings _settings;
    

    public GuessGame(IView view, ISettings settings) 
        : base(view)
    {
        _view = view;
        _settings = settings;
    }
    
    public override void Play()
    {
        PlayGame();
    }

    private void PlayGame()
    {
        _view.Show($"Guess a number between 1 and {_settings.MaxNumber}");

        var lastGuess = -1;
        
        while (lastGuess != _settings.MaxNumber && _settings.MaxTries != 0)
        {
            if (!int.TryParse(Console.ReadLine(), out lastGuess))
            {
                _view.Show("Enter a valid number...");
                continue;
            }

            if (lastGuess == _settings.MaxNumber)
            {
                _view.Show("Congratulations! You guessed the number.");
                break;
            }

            _view.Show(lastGuess < _settings.MaxNumber ? "The number is higher" : "The number is lower");

            _settings.MaxTries--;

            if (_settings.MaxTries != 0) continue;
            
            _view.Show($"You have run out of tries. The number was {_settings.MaxNumber}");
            break;
        }
        
    }
}
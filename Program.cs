
using GuessGame;

var game = new GuessGame.GuessGame(new ConsoleView(), new Settings(3, 10));
game.Play();
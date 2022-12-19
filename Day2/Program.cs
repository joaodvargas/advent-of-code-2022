namespace Day2;

public class Program : Utils.BaseProgram
{
  private const int EXPECTED_ARGS = 1;

  static void Main(string[] args)
  {
    // validate
    if (args.Length != EXPECTED_ARGS)
    {
      Console.WriteLine($"Expected {EXPECTED_ARGS} args, got {args.Length}");
      return;
    }

    var lines = ReadFile(args[0]);

    // score plays
    int score = 0;
    foreach (var plays in lines)
    {
      var splitPlays = plays.Split(" ");
      var opp = RockPaperScissors.Map(splitPlays[0]);
      var you = RockPaperScissors.Map(splitPlays[1]);

      score += (int)you + RockPaperScissors.Eval(you, opp);
    }

    Console.WriteLine($"Total score of the game was {score}");

    // Keep the console window open in debug mode.
    Hang();
  }
}

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
      var opp = RockPaperScissors.MapToPlay(splitPlays[0]);
      var you = RockPaperScissors.MapToPlay(splitPlays[1]);

      score += (int)you + RockPaperScissors.Eval(you, opp);
    }

    Console.WriteLine($"Part1 - total score of the game was {score}");

    // part 2
    score = 0;
    foreach (var plays in lines)
    {
      var splitPlays = plays.Split(" ");
      var opp = RockPaperScissors.MapToPlay(splitPlays[0]);
      var outcome = RockPaperScissors.MapToResult(splitPlays[1]);
      var you = RockPaperScissors.FindPlay(opp, outcome);

      score += (int)you + (int)outcome;
    }

    Console.WriteLine($"Part2 - total score of the game was {score}");
    // Keep the console window open in debug mode.
    Hang();
  }
}

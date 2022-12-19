namespace Day2;

public static class RockPaperScissors
{
  public enum Play
  {
    Rock = 1,
    Paper = 2,
    Scissors = 3
  }

  public enum PlayResult
  {
    Loss = 0,
    Draw = 3,
    Win = 6
  }

  public static Play MapToPlay(string play)
  {
    if (play == "A" || play == "X")
    {
      return Play.Rock;
    }
    if (play == "B" || play == "Y")
    {
      return Play.Paper;
    }
    if (play == "C" || play == "Z")
    {
      return Play.Scissors;
    }

    throw new Exception("Should not get here");
  }

  public static PlayResult MapToResult(string outcome)
  {
    if (outcome == "X")
    {
      return PlayResult.Loss;
    }
    if (outcome == "Y")
    {
      return PlayResult.Draw;
    }
    if (outcome == "Z")
    {
      return PlayResult.Win;
    }

    throw new Exception("Should not get here");
  }

  public static Play FindPlay(Play opp, PlayResult outcome)
  {
    if (outcome == PlayResult.Draw)
    {
      return opp;
    }
    if (opp == Play.Rock)
    {
      return outcome == PlayResult.Win ? Play.Paper : Play.Scissors;
    }
    if (opp == Play.Paper)
    {
      return outcome == PlayResult.Win ? Play.Scissors : Play.Rock;
    }
    if (opp == Play.Scissors)
    {
      return outcome == PlayResult.Win ? Play.Rock : Play.Paper;
    }

    throw new Exception("Should not get here");
  }

  public static int Eval(Play you, Play opp)
  {
    if (you == opp)
    {
      return 3;
    }

    if (you == Play.Rock)
    {
      if (opp == Play.Paper)
      {
        return 0;
      }
      else
      {
        return 6;
      }
    }

    if (you == Play.Paper)
    {
      if (opp == Play.Scissors)
      {
        return 0;
      }
      else
      {
        return 6;
      }
    }

    if (you == Play.Scissors)
    {
      if (opp == Play.Rock)
      {
        return 0;
      }
      else
      {
        return 6;
      }
    }

    throw new Exception("Should not get here");
  }

}
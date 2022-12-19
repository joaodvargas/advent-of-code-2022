namespace Day2;

public static class RockPaperScissors
{
  public enum Play
  {
    Rock = 1,
    Paper = 2,
    Scissors = 3
  }

  public static Play Map(string play)
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
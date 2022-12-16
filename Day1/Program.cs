namespace Day1
{
  public class Program
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


      var lines = default(string[]);
      var elfs = new List<Elf>();
      // read file
      try
      {
        lines = System.IO.File.ReadAllLines(args[0])
          .ToArray();
      }
      catch
      {
        Console.WriteLine($"Unable to load and read file: {args[0]}");
        return;
      }

      // fill structures
      var latestElf = default(Elf);
      foreach (var l in lines)
      {
        if (string.IsNullOrWhiteSpace(l))
        {
          latestElf = null;
          continue;
        }
        if (latestElf == null)
        {
          latestElf = new Elf();
          elfs.Add(latestElf);
        }
        latestElf.AddCalorie(l);
      }

      // 1st half
      Console.WriteLine($"Found {elfs.Count} elfs, highest total is {elfs.Max(e => e.CaloriesTotal)}");

      // 2nd half
      var top3Elfs = elfs
        .OrderByDescending(e => e.CaloriesTotal)
        .Take(3);

      Console.WriteLine($"The top 3 elfs are carrying {top3Elfs.Sum(e => e.CaloriesTotal)} calories.");


      // Keep the console window open in debug mode.
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }

  public class Elf
  {
    public List<int> Calories { get; } = new List<int>();
    public int CaloriesTotal => Calories.Sum();

    public void AddCalorie(int calorie)
    {
      Calories.Add(calorie);
    }

    public void AddCalorie(string calorie) =>
      AddCalorie(Int32.Parse(calorie.Trim()));
  }
};
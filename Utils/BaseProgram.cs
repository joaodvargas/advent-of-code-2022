namespace Utils;
public abstract class BaseProgram
{
  protected static string[] ReadFile(string file, bool skipEmptyLines = false)
  {
    var lines = new string[0];
    // read file
    try
    {
      lines = System.IO.File.ReadAllLines(file)
        .Where(l => !skipEmptyLines || !string.IsNullOrWhiteSpace(l))
        .ToArray();
    }
    catch (Exception ex)
    {
      throw new Exception($"Unable to load and read file: {file}", ex);
    }

    return lines;
  }

  protected static void Hang()
  {
    // Keep the console window open in debug mode.
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
  }
}

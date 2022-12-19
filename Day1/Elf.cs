namespace Day1;

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
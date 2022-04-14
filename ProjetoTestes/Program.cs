using System;

namespace ProjetoTestes
{
  public class Program
  {
    public int ExpectedMinutesInOver()
    {
      return 40;
    }
    static void Main(string[] args)
    {
      Program lasagna = new Program();


      Console.WriteLine(lasagna.ExpectedMinutesInOver());
    }
  }
}
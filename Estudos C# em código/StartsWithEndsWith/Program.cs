using System;

namespace StartsWithEndsWith
{
  public class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.StartsWith("Este"));
      //this method returns a bolean
    }
  }
}
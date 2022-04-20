using System.Globalization;
using System;

namespace Equals
{
  public class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.Equals("Este texto é um teste"));
      Console.WriteLine(texto.Equals("este texto é um teste"));
      Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
    }
  }
}
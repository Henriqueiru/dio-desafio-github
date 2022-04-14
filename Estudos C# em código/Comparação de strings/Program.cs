using System;

namespace ComparacaodeStrings
{
  public class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.Contains("teste"));
      //return a boolean
      Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
      //ignore the case sensitive
    }

  }
}
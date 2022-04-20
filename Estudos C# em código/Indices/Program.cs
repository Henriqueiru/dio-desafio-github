using System;

namespace Indices
{
  public class Program
  {
    static void Main(string[] args)
    {
      var texto = "Vamos testar em";
      Console.WriteLine(texto.IndexOf("em"));
      Console.WriteLine(texto.LastIndexOf("s"));
    }
  }
}
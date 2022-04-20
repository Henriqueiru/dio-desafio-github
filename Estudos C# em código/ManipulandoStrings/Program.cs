using System.Globalization;
using System;

namespace ManipulandoStrings
{
  public class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.Replace("e", "X"));

    }
  }
}
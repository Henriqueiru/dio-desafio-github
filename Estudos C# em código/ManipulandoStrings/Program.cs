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

      var divisao = texto.Split(" ");
      Console.WriteLine(divisao[0]);
      Console.WriteLine(divisao[1]);
      Console.WriteLine(divisao[2]);
      Console.WriteLine(divisao[3]);

      var resultado = texto.Substring(5, 5);
      Console.WriteLine(resultado);

      Console.WriteLine(texto.Trim());
    }
  }
}
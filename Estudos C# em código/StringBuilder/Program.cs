using System.Globalization;
using System;
using System.Text;

namespace BuilderString
{
  public class Program
  {
    static void Main(string[] args)
    {
      var texto = new StringBuilder();
      texto.Append("Este texto é um teste");
      texto.Append("é um teste");
      texto.Append("Este texto");
      texto.Append("Este um teste");

      texto.ToString();
      Console.WriteLine(texto);
    }
  }
}
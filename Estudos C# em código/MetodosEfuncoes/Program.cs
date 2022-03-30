using System;
// See https://aka.ms/new-console-template for more information
namespace MetodosEfuncoes
{
  public class Program
  {
    static void Main(string[] args)
    {
      MeuMetodo();

      string nome = RetornaNome("André", "Baltieri");
      Console.WriteLine(nome);
    }

    static void MeuMetodo()
    {
      Console.WriteLine("C# é legal");
    }

    static string RetornaNome(
      string nome,
      string sobrenome,
      int idade = 34
    )
    {
      return nome + " " + sobrenome + "tem" + idade.ToString();
    }
  }
}

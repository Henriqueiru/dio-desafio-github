using System;
// See https://aka.ms/new-console-template for more information
namespace Usando_IF
{
  public class Program
  {
    static void Main(string[] args)
    {

      int idade = 21;
      int maioridade = 21;
      int idadeMaxima = 65;
      if (idade >= maioridade || idade < idadeMaxima)
      {
        Console.WriteLine("Ele é de maior");
      }
      else
      {
        Console.WriteLine("É de menor");
      }
      Console.WriteLine("Finalizou o programa");
    }
  }
}

using System;

namespace TestesMetodos
{
  public class Program
  {
    static string NewPessoa(string nome, string sobrenome)
    {
      return nome + " " + sobrenome;
    }
    static void Main(string[] args)
    {
      var person = NewPessoa("Henrique", "Lima");
      Console.WriteLine(person);
    }


  }
}
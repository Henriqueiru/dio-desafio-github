using System;

namespace UsandoSwitch
{
  public class Program
  {
    static void Main(string[] args)
    {
      string valor = "paulo";
      switch (valor)
      {
        case "joao": Console.WriteLine("Não é o cara"); break;
        case "marcelo": Console.WriteLine("Não é o cara"); break;
        case "andre": Console.WriteLine("É este cara"); break;
        default: Console.WriteLine("Não encontrei"); break;
      }
    }
  }
}

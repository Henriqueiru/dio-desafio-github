using System;
// See https://aka.ms/new-console-template for more information
namespace ReferenceValueTypes
{
  public class Program
  {
    static void Main(string[] args)
    {

      var arr = new string[2];
      arr[0] = "Item 1";
      // 1 dado e 2 arrays apontando para esses dados
      var arr2 = arr;

      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      arr[0] = "Item 2";
      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);
    }
  }
}

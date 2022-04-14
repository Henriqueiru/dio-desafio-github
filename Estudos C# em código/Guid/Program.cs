using System;

namespace Guid2
{
  public class Program
  {
    static void Main(string[] args)
    {
      var id = Guid.NewGuid();
      id.ToString();

      id = new Guid("kdapskdapsdkasdkadk");
      Console.WriteLine(id.ToString().Substring(0, 8));
    }
  }
}
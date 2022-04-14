using System;

namespace InterpolaçãodeString
{
  public class Program
  {
    static void Main(string[] args)
    {
      var price = 10.2;
      var text = "O preço do produto é " + price;
      //Concatenação = junção de algo
      var text = string.Format("O preço do produto é {0} apenas na promoção", price);
      //O que está dentro de chaves ele substitui pelo que tem depois da virgula da string. 0 é a primeira opção da virgula, 1, 2 e etc são os que vem em sequencia
      var text = $"O preço do produto é {price} na promoção";
      // Este estilo de formatação é melhor. Outra dica, quando precisar escrever multiplas linhas e voce quiser quebrar, se voce der um enter nao funciona, mas é só adicionar um @
      Console.WriteLine(text);
    }
  }
}
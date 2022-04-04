using System;

namespace Herança
{
  public class Ponto
  {
    public int x, y;
    private int distancia;


    public Ponto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    protected void CalcularDistancia()
    {

    }

    private void CalcularDisancia2()
    {

    }

    public virtual void CalcularDitancia3()
    {

    }
  }
}
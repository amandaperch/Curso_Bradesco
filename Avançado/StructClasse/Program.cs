class StructClasse
{
  public struct PontoA
  {
    public int X;
    public int Y;
  }

  public class PontoB
  {
    public int X;
    public int Y;
  }
    public static void Main()
    {
      // Struct
      PontoA ponto = new PontoA { X = 5, Y = 3};
      PontoA ponto2 = ponto;
      ponto.X = 3;

      Console.WriteLine("(Struct)Ponto 1: {0}", ponto.X);
      Console.WriteLine("(Struct)Ponto 2: {0}", ponto2.X);

      // Classe
      PontoB ponto3 = new PontoB { X = 6, Y = 9};
      PontoB ponto4 = ponto3;
      ponto3.X = 3;

      Console.WriteLine("(Classe)Ponto 3: {0}", ponto3.X);
      Console.WriteLine("(Classe)Ponto 4: {0}", ponto4.X);

    }
}
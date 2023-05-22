namespace numero
{
  class Formatacao
  {

    static void Main()
    {
      double x = 20.232;
      Console.WriteLine(x.ToString("F3"));
      Console.WriteLine(x.ToString("C"));
      Console.WriteLine(x.ToString("P"));
    }
  }
}

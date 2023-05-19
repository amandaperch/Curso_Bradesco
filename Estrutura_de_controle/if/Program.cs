namespace EstruturasDeControle
{
  class If
  {

    static void Main()
    {
      var n1 = 5;
      var n2 = 9;
      var n3 = 10;

      if (n1 < n2) {
        Console.WriteLine("Condição 1 é satisfeita");
        Console.WriteLine("Resultado da soma é {0}", n1 + n2);
      }
      if (n3 < n2) {
        Console.WriteLine(n3 + n2);
      }
      else
      {
        Console.WriteLine("Condição 2 não é satisfeita");
      }

    }
  }
}


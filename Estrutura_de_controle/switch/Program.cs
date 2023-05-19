namespace EstruturasDeControle
{
  class Switch
  {

    static void Main()
    {
      Console.WriteLine("Qual a nota você da para o prato? 0, 5, ou 10");
      string notaString = Console.ReadLine();
      int nota = Convert.ToInt32(notaString);

      switch(nota)
      {
        case 0:
          Console.WriteLine("Comida muito ruim!");
          break;
        case 5: 
          Console.WriteLine("Comida razóavel.");
          break;
        case 10:
          Console.WriteLine("Comida muito boa!");
          break;
        default:
          Console.WriteLine("Nota inexistente");
          break;
      }

    }
  }
}


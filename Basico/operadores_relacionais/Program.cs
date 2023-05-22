namespace OperadoresRelacionais
{
  class Notas
  {

    static void Main()
    {
      // double nota1 = 8.0;
      // double nota2 = 9.0;
      // Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
      // Console.WriteLine("Tirou 10? {0}", nota2 == 10.0);

      Console.WriteLine("Digite sua nota: ");
      double notaInt = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Nota maior que 7? {0}", notaInt > 7.0);
      Console.WriteLine("Tirou 10? {0}", notaInt == 10);      

    }
  }
}

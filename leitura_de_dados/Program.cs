namespace Dados
{
  class LeituraDeDados
  {

    static void Main()
    {
      Console.WriteLine("Qual seu nome?"); 
      string nome = Console.ReadLine();
      Console.WriteLine("Quantos anos você tem?");
      int idade = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Seu nome é {0} e a sua idade é {1}", nome, idade);

    }
  }
}

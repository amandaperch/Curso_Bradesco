namespace numeroDaCasa 
{
  class Conversão 
  {

    static void Main()
    {
      Console.WriteLine("Digite qual número é sua casa: ");
      int numero = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Número da sua casa é: {0}", numero);
    }
  }
}

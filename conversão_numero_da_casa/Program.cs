namespace numeroDaCasa 
{
  class Conversão 
  {

    static void Main()
    {
      Console.WriteLine("Digite qual número é sua casa: ");
      string numeroCasa = Console.ReadLine();
      int numero = Convert.ToInt32(numeroCasa);
      Console.WriteLine("Número da sua casa é: {0}", numero);
    }
  }
}

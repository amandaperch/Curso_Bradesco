namespace Desafios
{
  class CalculadoraDeSoma
  {

    static void Main()
    {    
      bool opcao = true;

      Console.WriteLine("Olá, irei realizar a soma de nuero que você deseja até você desejar parar");
      Console.WriteLine("Digite o valor inicial");
      double inicial = Convert.ToDouble(Console.ReadLine());

      while (opcao == true)
      {
        Console.WriteLine("Digite o número que deseja somar ao número inicial");
        double inicial1 = Convert.ToDouble(Console.ReadLine());
        inicial = inicial + inicial1;
        Console.WriteLine("A soma até o momento é {0}", inicial);
        Console.WriteLine("Deseja sair do programa? 1- sim 2-não");
        int saida = Convert.ToInt32(Console.ReadLine());

        switch (saida) 
        {
          case 1: 
            Console.WriteLine("Saindo do Programa.");
            opcao = false;
            break;
          case 2: 
            Console.WriteLine("Continua a soma.");
            break;
          default:
            Console.WriteLine("Opção Inválida. Retornado para soma.");
            break;
        }
      }
    }
  }
}



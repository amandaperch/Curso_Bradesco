namespace Desafios
{
  class LeituraDeNotas
  {

    static void Main()
    {    
      double media = 0;

      Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");
      Console.WriteLine("Qual seu nome ?");
      string nomeProfessor = Console.ReadLine();
      Console.WriteLine("Qual nome do Aluno?");
      string nomeAluno = Console.ReadLine();

      Console.WriteLine("Digite a primeira nota:");
      double nota1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite a segunda nota:");
      double nota2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite a terceira nota:");
      double nota3 = Convert.ToDouble(Console.ReadLine());

      media = (nota1 + nota2 + nota3) / 3;
      Console.WriteLine("A média do(a) aluno(a) {0} é: {1}", nomeAluno, media);

      if(media < 7) 
      {
        Console.WriteLine("Professor {0} o(a) aluno(a) {1} está em recuperação", nomeProfessor, nomeAluno);
      } 
      else
      {
        Console.WriteLine("Professor {0} o(a) aluno(a) {1} está aprovado(a)", nomeProfessor, nomeAluno);
      }

    }
  }
}


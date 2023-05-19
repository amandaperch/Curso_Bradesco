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
      string n1 = Console.ReadLine();
      double nota1 = Convert.ToDouble(n1);

      Console.WriteLine("Digite a segunda nota:");
      string n2 = Console.ReadLine();
      double nota2 = Convert.ToDouble(n2);

      Console.WriteLine("Digite a terceira nota:");
      string n3 = Console.ReadLine();
      double nota3 = Convert.ToDouble(n3);

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


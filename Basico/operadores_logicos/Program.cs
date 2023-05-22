namespace OperadoresLogicos
{
  class Tarefas
  {

    static void Main()
    {
      var atividade1 = true;
      var atividade2 = false; 

      var todas = atividade1 && atividade2; 
      Console.WriteLine("Fez todas atividades? {0}", todas);

      var apenasUma = atividade1 || atividade2; 
      Console.WriteLine("Fez pelo menos uma das atividades? {0}", apenasUma);
      Console.WriteLine("Não fez nenhuma? {0}", !apenasUma);
    }
  }
}


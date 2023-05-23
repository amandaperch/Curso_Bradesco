static void AlterarRef(ref int numero)
{ 
  numero = numero + 500;
}
static void AlteraOut(int numero)
{
  numero = 0;
  numero = numero + 50;
}
static void Main()
{
  int x = 5;
  AlterarRef(ref x);
  Console.WriteLine(x);

  int y = 8;
  AlteraOut(y);
  Console.WriteLine(y);

}

Main();
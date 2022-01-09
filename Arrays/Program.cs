using System;

namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var array = new Teste[2];
      array[0] = new Teste();

      Console.WriteLine(array[0].Id);

      var meuArray = new int[4];
      meuArray[3] = 30;

      Console.WriteLine(meuArray[3]);

      AlterandoValores();
    }

    struct Teste
    {
      public int Id { get; set; }
    }

    public static void PercorrendoArray()
    {
      Console.Clear();

      var myArray = new int[5] { 1, 2, 3, 4, 5 };
      myArray[4] = 100;

      for (var item = 0; item < myArray.Length; item++)
      {
        Console.WriteLine(myArray[item]);
      }
    }

    // Foreach
    public static void ForEachs()
    {
      Console.Clear();

      var chazinho = new int[5] { 1, 2, 3, 4, 5 };
      chazinho[4] = 150;

      var funcionarios = new Funcionario[4];
      funcionarios[0] = new Funcionario() { Id = 200, Nome = "Claudio Jr" } ;

      foreach (var funcionario in funcionarios)
      {
        Console.WriteLine(funcionario.Id);
        Console.WriteLine(funcionario.Nome);
      }
    }

    public struct Funcionario
    {
      public int Id { get; set; }
      public string Nome { get; set; }
    }

    //Alterando valores
    public static void AlterandoValores()
    {
      Console.Clear();

      var cha = new int[5] { 1,2,3,4,5 };
      var chazin = new int[5];

      cha[3] = chazin[3];
      chazin[3] = 350;

      Console.WriteLine(cha[3]);
    }
  }
}

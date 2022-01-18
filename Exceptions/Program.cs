using System;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // var except = new int[3];

      // for (var index = 0; index < 10; index++)
      // {
      //   // System.IndexOutOfRangeException
      //   Console.WriteLine(except[index]);
      // }
      TratandoErros();
    }

    // TryCatch
    public static void TryCatch()
    {
      var trys = new int[3];

      try
      {
        for (var index = 0; index < 10; index++)
        {
          Console.WriteLine(trys[index]);
        }
      }
      catch (System.Exception)
      {
        Console.WriteLine("Algo deu errado meu amigo.");
      }
    }

    public static void TratandoErros()
    {
      Console.Clear();

      var tratandoErros = new int[3];

      try
      {
        for (var ind = 0; ind < 10; ind++)
        {
          Console.WriteLine(tratandoErros[ind]);
        }
      }
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o índice na lista");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ops, algo deu errado!");
      }
    }
    //Disparando excecoes
    public static void DisparandoExcecoes(string texto)
    {
      if (string.IsNullOrEmpty(texto))
        throw new MinhaException(DateTime.Now);
    }

    public class MinhaException : Exception
    {
      public MinhaException(DateTime date)
      {
        QuandoAconteceu = date;
      }
      public DateTime QuandoAconteceu {get; set;}
    }
  }
}

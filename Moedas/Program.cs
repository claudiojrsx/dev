using System;
using System.Globalization;


namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10.25m;

      Console.WriteLine(
          valor.ToString(
            "C",
              CultureInfo.CreateSpecificCulture("en-US")));

      Maths();
    }

    //Math
    public static void Maths()
    {
      Console.Clear();

      decimal valor = 10536.25m;
      string.Format("{0:C}", valor);

      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

      Console.WriteLine(Math.Round(valor));//Round = arredondar
      Console.WriteLine(Math.Floor(valor));
      Console.WriteLine(Math.Ceiling(valor));
    }
  }
}

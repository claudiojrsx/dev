using System;

namespace Strings
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var data = new DateTime(2022, 01, 08); //Precisando especificar a data para que seja exibida

      //var date = DateTime.Now; //Pegando a data atual
      Console.WriteLine(data);
      Console.WriteLine((int)data.DayOfWeek); //Pegando dia da semana atual.

      Mes();
    }

    public static void FormatandoDatas()
    {
      Console.Clear();

      var data = DateTime.Now;

      var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
      Console.WriteLine(formatada);
    }

    public static void PadroesFormatacao()
    {
      Console.Clear();

      var data = DateTime.Now;

      var formatada = String.Format("{0:T}", data);
      Console.WriteLine(formatada);
    }

    //Adicionando valores em datas (clock)
    public static void AdicionandoValores()
    {
      Console.Clear();

      var data = DateTime.Now;
      Console.WriteLine("Data atual: " + data);
      Console.WriteLine("-------------------");
      Console.WriteLine(data.AddDays(1));
      Console.WriteLine(data.AddMonths(1));
      Console.WriteLine(data.AddYears(1));
      Console.WriteLine(data.AddHours(1));
    }

    //Comparando datas
    public static void ComparandoDatas()
    {
      Console.Clear();

      var data = DateTime.Now;
      string dt;

      // if Ternario
      dt = (data.Date != DateTime.Now.Date) ? "É igual" : "Não é igual";

      // if (data.Date < DateTime.Now.Date)
      // {
      //   Console.WriteLine("É igual");
      // }
      // else
      // {
      //   Console.WriteLine("Não é igual");
      // }

      Console.WriteLine(dt);
    }

    // Culture Info, pegando datas de outros paises.
    public static void CultureInfo()
    {
      Console.Clear();

      var br = new System.Globalization.CultureInfo("pt-BR");
      var en = new System.Globalization.CultureInfo("en-UK");
      var de = new System.Globalization.CultureInfo("de-DE");
      var atual = System.Globalization.CultureInfo.CurrentCulture;

      Console.WriteLine(DateTime.Now.ToString("D", de));
      Console.WriteLine(string.Format("{0:D}", DateTime.Now));
      Console.WriteLine(DateTime.Now.ToString("D", atual));
    }

    //TimeZone
    public static void TimeZone()
    {
      Console.Clear();

      var utcDate = DateTime.UtcNow;

      // Console.WriteLine(DateTime.Now);
      // Console.WriteLine(utcDate);

      // Console.WriteLine(utcDate.ToLocalTime());

      // var tmzAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      // Console.WriteLine(tmzAustralia);

      // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, tmzAustralia);
      // Console.WriteLine(horaAustralia);

      var tmz = TimeZoneInfo.GetSystemTimeZones();
      foreach (var timezone in tmz)
      {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
        Console.WriteLine("---------");
      }
    }

    //TimeSpan
    public static void TimeSpan()
    {
      Console.Clear();

      var timeSpan = new TimeSpan();
      Console.WriteLine(timeSpan);

      var nanoSegundos = new TimeSpan(1);
      Console.WriteLine(nanoSegundos);

      var hms = new TimeSpan(5, 12, 8);
      Console.WriteLine(hms);
    }

    //Revisao
    public static void Mes()
    {
      Console.Clear();

      Console.WriteLine(DateTime.DaysInMonth(2022, 2));
      Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
      Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
    }

    static bool IsWeekend(DayOfWeek today)
    {
      return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
  }
}

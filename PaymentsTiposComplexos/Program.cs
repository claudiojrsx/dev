using System;

namespace PaymentsTiposComplexos
{
  class Program
  {
    static void Main(string[] args)
    {
      var payment = new Payments();

      Console.WriteLine("Hello World!");
    }
  }

  // private, protected, internal e public
  public class Payments
  {
    // Propriedades
    public DateTime DueDate { get; set; }

    private DateTime datePayment;
    public DateTime DatePayment
    {
      get { return datePayment; }
      set { datePayment = value; }
    }

    // Métodos
    void Pay()
    {

    }

    public class Address
    {
      string ZipCode;
    }
  }
}

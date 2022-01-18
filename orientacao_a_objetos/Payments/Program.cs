using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      // Tipo de referência
      // -> Endereço dos dados
      Console.Clear();

      var customer = new Customer();
      customer.Name = "Claudio";
      Console.WriteLine(customer.Name);
    }
  }

  class Customer
  {
    string Name;
  }
}

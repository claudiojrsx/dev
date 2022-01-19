using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer();
      customer.Name = "Claudio Junior";

      Console.WriteLine(customer.Name);
    }

    struct Customer
    {
      public string Name;
    }
  }
}

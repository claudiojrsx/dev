using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentTicket = new PaymentsTicket();
            paymentTicket.Pay();
            paymentTicket.DueDate = DateTime.Now;
            paymentTicket.NumberTicket = "123";

            Console.WriteLine("Hello World!");
        }
    }

    class Payments {
        // Propriedades
        public DateTime DueDate;

        // Métodos
        public void Pay() {}
    }

    class PaymentsTicket : Payments {
        public string NumberTicket;
    }
}

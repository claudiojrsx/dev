using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe PaymentsTicket utilizando alguns métodos
            var paymentTicket = new PaymentsTicket();
            paymentTicket.Pay();
            paymentTicket.DueDate = DateTime.Now;
            paymentTicket.NumberTicket = "123";

            var payment = new Payments();
            payment.ToString();

            Console.WriteLine("Hello World!");
        }
    }

    class Payments {
        // Propriedades
        public DateTime DueDate;

        // Métodos
        public virtual void Pay() {}

        public override string ToString() {
            return DueDate.ToString("ddMMyyyy");
        }
    }

    // Payments seria uma Heranca para o PaymentsTicket
    class PaymentsTicket : Payments {
        public string NumberTicket;
    }

    class PaymentCreditCard : Payments {
        public string CardNumber;

        public override void Pay() {

        }
    }
}

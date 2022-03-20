using System;

namespace PaymentsModificadoresDeAcesso
{
    // private, protected, internal e public
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payments();

            Console.WriteLine("Hello World!");
        }
    }

    // private, protected, internal e public
    public class Payments {
        // Propriedades
        protected DateTime DueDate;

        // Métodos
        private void Pay() {

        }
    }

        public class PaymentsTicket : Payments {
            
    }
}

using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamentoBoleto = new PagamentoBoleto();
      pagamentoBoleto.Pagar();
      pagamentoBoleto.Vencimento = DateTime.Now;
      pagamentoBoleto.NumeroBoleto = "123";

      var pagamento = new Pagamento();
      pagamento.ToString();

      Console.WriteLine(pagamentoBoleto);
    }
  }

  class Pagamento
  {
    // Propriedades
    public DateTime Vencimento;
    // Métodos
    public virtual void Pagar() {}

    public override string ToString()
    {
      return Vencimento.ToString("dd/MM/yyyy");
    }
  }

  class PagamentoBoleto : Pagamento
  {
    public string NumeroBoleto;

    public override void Pagar()
    {
      // Regra do boleto
    }
  }

  class PagamentoCartaoCredito : Pagamento
  {
    public string Numero;

    public override void Pagar()
    {
      // Regra do Cartão de Crédito
    }
  }

  // Private, protected
  class PagamentoModificadores
  {
    DateTime Vencimento;

    void Pagar()
    {
      
    }
  }
}

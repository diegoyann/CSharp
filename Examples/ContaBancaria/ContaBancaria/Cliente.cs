using System.Globalization;

namespace ContaBancaria
{
    class Cliente
    {

        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double ValorParaDeposito { get; set; }
        public double ValorParaSaque { get; set; }
        public double SaldoAtual { get; private set; }

       public Cliente (int numero, string titular)
        {
            NumeroDaConta = numero;
            NomeDoTitular = titular;
        }
        
        public Cliente (int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia)
        {
            SaldoAtual += quantia;
        }

        public void Saque(double quantia)
        {
            SaldoAtual -= quantia + 5;
        }
        public override string ToString()
        {
            return " Conta: "
                + NumeroDaConta
                + ", Titular: "
                + NomeDoTitular
                + ", Saldo: R$ "
                + SaldoAtual.ToString("F2", CultureInfo.InvariantCulture);
        }
      
    }



}



using System;

namespace Aula03Ex1.Models
{
    public class ContaCorrente
    {

        public Cliente cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
         public decimal Saldo { get; set; }
        public double Numero { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public decimal Juros { get; set; }

        public int dias { get; set; }
        public decimal valor { get; set; }
        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }
        public bool Retirar(decimal valor)
        {

            if (Especial)
            {
                if (Limite + Saldo >= valor) { Saldo -= valor; return true; }
                return false;
            }
            if (Saldo >= valor) { Saldo -= valor; return true; }
            return false;
        }
        public decimal RetornarSaldoTotal(decimal valor)
        {
            if (Especial) { return Saldo + Limite; }
            return Saldo;
        }

        public bool TranferirParaPoupanca(decimal valor)
        {
            if (Saldo > 0 && valor >= Saldo)
            {
                Saldo -= valor;
                ContaPoupanca.Depositar(valor);
                return true;
            }
            return false;
        }
        public decimal CalcularValorTaxaJuros(int dias)
        {

                if (Saldo < 0)
                {
                    return Saldo * Juros * dias * -1;
                }
        return 0;
        }
    }
}


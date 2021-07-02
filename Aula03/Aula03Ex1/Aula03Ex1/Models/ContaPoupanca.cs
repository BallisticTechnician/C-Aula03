using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Ex1.Models
{
    public class ContaPoupanca
    {
        ContaCorrente ContaCorrente = new ContaCorrente();
        public decimal Saldo { get; set; }
        public double Numero { get; set; }
        public decimal Limite { get; set; }

        public decimal Rendimentos { get; set; }

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

            if (Saldo >= valor) { Saldo -= valor; return true; }
            return false;



        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using Aula03Ex1.Models;
namespace Aula03Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do cliente :");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do cliente :");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente :");
            string telefone = Console.ReadLine();


            Console.WriteLine("Digite a conta Corrente:");
            double numeroCc = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a conta Poupanca:");
            double numeroCp = double.Parse(Console.ReadLine());
            Console.WriteLine("Possuir especial");
            var especial = bool.Parse(Console.ReadLine());

            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Telefone = telefone;

            var cp = new ContaPoupanca();
            cp.Numero = numeroCp;

            var Cc = new ContaCorrente();
            Cc.Numero = numeroCc;
            Cc.Especial = especial;
            Cc.ContaPoupanca = cp;

            if (especial)
            {
                Console.WriteLine("Digite o limite :");
                var limite = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite o juros :");
                var juros = decimal.Parse(Console.ReadLine());
                Cc.Limite = limite;
                Cc.Juros = juros;
            }
            int opcao;
            do
            {
                Console.WriteLine("-------Selecione a opção desejada--------\n\n 1 - Depositar \n 2- Retirar \n 3 - Transferir \n 4 - Calcular Juros \n 5 - Para sair:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Depositando na conta corrente ");
                            Console.WriteLine("Digite o valor ");
                            var valor = decimal.Parse(Console.ReadLine());
                            Cc.Depositar(valor);
                            Console.WriteLine($"O saldo é de {Cc.Saldo} e o saldo total é de {Cc.RetornarSaldoTotal(valor)}");
                        }

                        break;
                    case 2:
                        {
                            Console.WriteLine("Retirando na conta corrente");
                            Console.WriteLine("Digite o valor :");
                            var valor = decimal.Parse(Console.ReadLine());
                            Cc.Retirar(valor);
                            Console.WriteLine($"O saldo é de {Cc.Saldo} e o saldo total é de {Cc.RetornarSaldoTotal(valor)}");

                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Transferindo para conta poupanca");
                            Console.WriteLine("Digite o valor :");
                            var valor = decimal.Parse(Console.ReadLine());
                            Cc.TranferirParaPoupanca(valor);
                            Console.WriteLine($"O saldo é de {Cc.Saldo} e o saldo total é de {Cc.RetornarSaldoTotal(valor)}");
                            Console.WriteLine($"O saldo é da poupanca é de {Cc.ContaPoupanca.Saldo}");

                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Calculando Juros");
                            Console.WriteLine("Digite a quantidade de dias :");
                            var dias = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O juros é de {Cc.CalcularValorTaxaJuros(dias)}");


                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Finalizando o sistema");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Opção invalida digite novamente");

                        }
                        break;
                }
            }
            while (opcao != 5);


        }
    }
}
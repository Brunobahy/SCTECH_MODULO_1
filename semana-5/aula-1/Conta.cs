using System;
using System.Net.Http.Headers;
namespace ScBank
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        private List<string> Extrato { get; set; } = new List<string>();
        public int Numero { get; private set; }

        public Conta(string titular)
        {
            Titular = titular;
            Numero = new Random().Next();
            Saldo = 0;
        }

        public void Transferir(decimal valor, Conta destino)
        {
            if (VerificaSaldo(valor))
            {
                Saldo -= valor;
                destino.Receber(valor);
                Extrato.Add($"- R${valor}");
            }
        }

        public void Sacar(decimal valor)
        {
            if (VerificaSaldo(valor))
            {
                Saldo -= valor;
                Extrato.Add($"- R${valor}");

            }
        }

        public void ImprimirExtrato()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Extrato: ");
            foreach (string transacao in Extrato)
            {
                Console.WriteLine(transacao);
                Console.WriteLine();


            }
        }

        public void Depositar(decimal valor)
        {
            if (ValidaValor(valor))
            {
                Saldo += valor;
                Extrato.Add($"+ R${valor}");
            }

        }

        public bool VerificaSaldo(decimal valor)
        {
            if (!ValidaValor(valor))
            {
                return false;
            }
            if (valor > Saldo)
            {

                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            return true;
        }
        public bool ValidaValor(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor Invalido!");
                return false;
            }
            return true;
        }

        public void Receber(decimal valor)
        {
            Saldo += valor;
            Extrato.Add($"+ R${valor}");
        }

        public void DadosConta()
        {
            Console.WriteLine($"Numero da conta: {Numero}");
            Console.WriteLine($"Titular da conta: {Titular}");
            Console.WriteLine($"Saldo da conta: {Saldo}");
            ImprimirExtrato();
        }

    }
}
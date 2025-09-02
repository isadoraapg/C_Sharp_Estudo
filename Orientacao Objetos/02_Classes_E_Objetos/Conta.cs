using System;

namespace Contas
{
    public class Conta
    {
        //propriedade estática
        public static double TaxaRendimento = 0.5f;

        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        public Conta()
        {
            Numero = DateTime.Now.ToString("yyyyMMddhhmmss");
            DataAbertura = DateTime.Now;
            Saldo = 0;
            Console.WriteLine("Conta criada");
        }

        public Conta(string numero, DateTime dataAbertura, decimal saldo)
        {
            Numero = numero;
            DataAbertura = dataAbertura;
            Saldo = saldo;
        }

        public string ExibirExtrato()
        {
            return $"Conta Nº: {Numero}{Environment.NewLine}" +
                    $"Data de Abertura: {DataAbertura.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
                    $"Saldo: {Saldo.ToString("C")}{Environment.NewLine}" +
                    $"--------------------------";
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        //SOBRECARGA DE MÉTODO
        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor de {valor} foi creditado na sua conta e será debitado dentro de 30 dias.");
        }

        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine($"O valor de {valor} foi creditado na sua conta e será debitado em {parcelas} vezes.");
        }

        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1 + TaxaRendimento, meses); // 1 + taxa elevado ao numero de meses
        }
    }
}
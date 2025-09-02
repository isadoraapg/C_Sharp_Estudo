// See https://aka.ms/new-console-template for more information

using System;
using Contas;

//ORIENTAÇÃO A OBJETOS

//CRIANDO CLASSES E OBJETOS
//ADICIONANDO MÉTODOS
//MÉTODOS ESTÁTICOS

namespace _02_Classes_E_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            Console.WriteLine(conta.ExibirExtrato());

            var conta2 = new Conta("0001", DateTime.Now, 100);
            Console.WriteLine(conta2.ExibirExtrato());

            //conta.Depositar(50);
            //Console.WriteLine(conta.ExibirExtrato());
            //conta.Sacar(10);
            //Console.WriteLine(conta.ExibirExtrato());
            conta.RealizarEmprestimo(100, 2);
            Console.WriteLine(conta.ExibirExtrato());


            Console.WriteLine($"Taxa de rendimento: {Conta.TaxaRendimento}");
            Console.WriteLine($"Cálculo de rendimento(100 reais em 12 meses): { Conta.CalcularRendimento(100, 12) }");
        }

    }
}



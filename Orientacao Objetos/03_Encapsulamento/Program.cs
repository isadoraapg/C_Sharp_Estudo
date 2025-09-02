// See https://aka.ms/new-console-template for more information

using System;
using RH;

namespace _03_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Fulano", "000.000.000-00");
            // Console.WriteLine(funcionario.GetCPF());
            // funcionario.SetCPF("123.456.789-00");
            // Console.WriteLine(funcionario.GetCPF());

            funcionario.CPF = "123.456.789-00";
            Console.WriteLine(funcionario.CPF);

            
        }
    }
}


using System;
using Notificacoes;

namespace _05_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de notificação: 1-Email | 2-SMS | 3-Whatsapp");
            var tipo = Console.ReadLine();

            Console.WriteLine("Digite o destinatário: ");
            var destinatario = Console.ReadLine();

            Console.WriteLine("Digite a mensagem: ");
            var mensagem = Console.ReadLine();

            Notificacao notificacao;

            switch (tipo)
            {
                case "1":
                    notificacao = new NotificacaoEmail(destinatario, mensagem);
                    break;
                case "2":
                    notificacao = new NotificacaoSms(destinatario, mensagem);
                    break;
                case "3":
                    notificacao = new NotificacaoWhatsApp(destinatario, mensagem);
                    break;
                default:
                    notificacao = new NotificacaoEmail(destinatario, mensagem);
                    break;
            }
            notificacao.Enviar();





        }
    }
}
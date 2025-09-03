using System;

namespace Personagens
{
    public class Cavaleiro : Personagem
    {
        public Cavaleiro(string nome, int vida) : base(nome, vida)
        {
            //Id = "CAVALEIRO1";
        }


        public override void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com espada.");
        }
        
        public override void AtacarEspecial()
        {
            Console.WriteLine($"{ Nome } Atacou Escpecial com espada");
        }
    }
}
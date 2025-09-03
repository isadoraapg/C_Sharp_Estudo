using System;

namespace Personagens
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }

        // protected string Id { get; set; } //Visivel apenas nas classes filhas, na classe Program nao 
        // private int Id2 { get; set; } //não vísivel em outras classes


        public Personagem(string nome, int vida)
        {
            Nome = nome;
            Vida = vida;
        }

        //virtual - modificador
        // permite q eu crie uma definição pra esse metodo, 
        // coloque funcionamento que as classes filhas possam 
        // alterar o funcionamento
        public virtual void Atacar()
        {
            Console.WriteLine($"{Nome} atacou.");
        }

        public void Defender()
        {
            Console.WriteLine($"{Nome} defendeu.");
        }

        public abstract void AtacarEspecial();
        //cabe a cada tipo de personagem definir o ataque
        //cada classe filha tem que implementar o metodo
    }
}
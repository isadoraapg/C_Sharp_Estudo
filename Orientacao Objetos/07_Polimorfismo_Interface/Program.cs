using System;
using Itens;
class Program
{
    static void Main(string[] args)
    {
        var espada = new Espada("Excalibur", 10, 10, 100);
        //espada.Colecionar();

        var pocao = new Pocao("Poção de vida", 20, 20, 50);
        //pocao.Consumir();

        var joia = new Joia("Diamante", 30, 30, 100);
        //joia.Colecionar();
        //joia.Consumir();

        var itens = new List<Item>();
        itens.Add(espada);
        itens.Add(pocao);
        itens.Add(joia);

        foreach (var item in itens)
        {
            //Console.WriteLine(item.Nome);

            if (item is IColecionavel)
            {
                (item as IColecionavel).Colecionar();
            }
            if (item is IConsumivel)
            {
                (item as IConsumivel).Consumir();
            }

            if (item is Espada)
            {
                Console.WriteLine((item as Espada).Dano);
            }
        }

    }
}
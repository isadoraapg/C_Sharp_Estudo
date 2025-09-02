// See https://aka.ms/new-console-template for more information

//FUNDAMENTOS DO C#

//ESTRUTURAS DE REPETIÇÃO

//WHILE
var contador = 1;
while (contador <= 10)
{
    Console.WriteLine(contador);
    contador++;
}


//percorrer itens de um array
var indice = 0;
var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };
while (indice < versoes.Length)
{
    Console.WriteLine(versoes[indice]);
    indice++;
}



//DO WHILE
var contador1 = 10;
var opcao = "";
do
{
    Console.WriteLine("Digite uma opção: ");
    Console.WriteLine("1 - Saque | 2 - Depósito | 3 - Saldo | 0 - Sair");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Saque");
            break;
        case "2":
            Console.WriteLine("Depósito");
            break;
        case "3":
            Console.WriteLine("Saldo");
            break;
    }
}
while (opcao != "0");


//FOR 
for (var indice1 = 0; indice1 < 5; indice1++)
{
    Console.WriteLine(indice1);
}

var numeros = new[] { 1, 10, 100, 1000 };
for (var indice2 = 0; indice2 < numeros.Length; indice2++)
{
    Console.WriteLine(numeros[indice2]);
}


//FOR EACH
var nomes = new[] { "Isa", "Fulano", "Ciclano" };
foreach (var item in nomes)
{
    Console.WriteLine(item);
}
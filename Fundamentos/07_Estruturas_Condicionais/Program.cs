// See https://aka.ms/new-console-template for more information

//FUNDAMENTOS DO C# 

//ESTRUTURAS CONDICIONAIS

var a = 3;
var b = 2;

if (a > b)
{
    Console.WriteLine("É maior");
}
else
{
    Console.WriteLine("Não é maior");
}


var nota = 7.5m;

if (nota >= 4 && nota < 7)
{
    Console.WriteLine("Nota = " + nota + " - Recuperação");
}
else if (nota >= 7)
{
    Console.WriteLine("Nota = " + nota + " - Aprovado");
}
else
{
    Console.WriteLine("Nota = " + nota + " - Reprovado");
}


//operador ternário 

var nota1 = 5;
var mensagem = "";

if (nota1 >= 7)
{
    mensagem = "aprovado";
}
else
{
    mensagem = "reprovado";
}
Console.WriteLine(mensagem);

//condição ? valor se verdadeiro : valor se falso
mensagem = nota1 >= 7 ? "Aprovado" : "Reprovado";
Console.WriteLine(mensagem);

//Switch
Console.WriteLine("Digite uma opção de 1 a 3: ");
var opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
        Console.WriteLine("Saldo");
        break;
    case "2":
        Console.WriteLine("Depósito");
        break;
    case "3":
        Console.WriteLine("Saque");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
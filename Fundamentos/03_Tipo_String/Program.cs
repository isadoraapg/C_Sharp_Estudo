// See https://aka.ms/new-console-template for more information


//FUNDAMENTOS DO C# 

//O TIPO STRING

var nome = "Isadora";
var sobrenome = "Peixoto";
var nomeCompleto = nome + " " + sobrenome;

Console.WriteLine(nomeCompleto);

//Interpolação de Strings
var nomeCompleto2 = $"{nome} {sobrenome}";

Console.WriteLine(nomeCompleto2);

//ToUpper e ToLower
Console.WriteLine(nomeCompleto.ToUpper());
Console.WriteLine(nomeCompleto.ToLower());

//Vai imprimir a partir de uma posição especificada
Console.WriteLine(nomeCompleto.Substring(3));
//a partir do indice 3, quero imprimir apenas 5 caracteres
Console.WriteLine(nomeCompleto.Substring(3, 5));

//V ou F se contem 
// o caractere 'o' (em qlqr posição) ou se contem a string "fa"
Console.WriteLine(nomeCompleto.Contains('o'));
Console.WriteLine(nomeCompleto.Contains("fa"));

//se inicia ou termina com caracteres específicos
Console.WriteLine(nomeCompleto.StartsWith("I"));
Console.WriteLine(nomeCompleto.EndsWith("o"));

//Qual o indice do caracter específico (primeiro a que aparece e o ultimo a q aparece)
Console.WriteLine(nomeCompleto.IndexOf('a'));
Console.WriteLine(nomeCompleto.LastIndexOf('a'));
// See https://aka.ms/new-console-template for more information


//FUNDAMENTOS DO C#

//OPERADORES

//ARITMÉTICOS

var a = 7;
var b = 3.0m;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b); 
Console.WriteLine(a % b); //resto da divisão inteiro


//ARITMÉTICOS DE ATRIBUIÇÃO

var c = 5;
var d = 5;
var e = 5;
var f = 5.0m;
var g = 5;

c += 2; //c = c + 2
d -= 2; //d = d - 2
e *= 2; //e = e * 2
f /= 2; //f = f / 2
g %= 2; //g = g % 2

Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);


//OPERADORES UNÁRIOS DE INCREMENTO E DECREMENTO

var h = 5;
var i = 5;

h++; //h + 1
i--; //i - 1
Console.WriteLine(h); 
Console.WriteLine(i);

var j = 5;
var k = 5;
Console.WriteLine(j++); //não vai imprimir incrementado, só depois
Console.WriteLine(k--);
Console.WriteLine(j); //aqui imprime incrementado
Console.WriteLine(k);

var l = 5;
var m = 5;
Console.WriteLine(++l); //aqui ja vai imprimir incrementado
Console.WriteLine(--m);


//OPERADORES DE COMPARAÇÃO
var n = 2;
var o = 3;
var iguais = n == o;
var diferentes = n != o;
var maior = n > o;
var menor = n < o;
var maiorOuIgual = n >= o;
var menorOuIgual = n <= o;

Console.WriteLine(iguais);
Console.WriteLine(diferentes);
Console.WriteLine(maior);
Console.WriteLine(menor);
Console.WriteLine(maiorOuIgual);
Console.WriteLine(menorOuIgual);


//OPERADORES LÓGICOS
var ativo = true;
Console.WriteLine(!ativo); // ! inverte o valor da operação

var p = 3;
var q = 5;
Console.WriteLine(!(p > q));

Console.WriteLine(ativo == true && p > q);
Console.WriteLine(ativo == false && p < q);
Console.WriteLine(ativo == true || p > q);
Console.WriteLine(ativo == false || p < q);


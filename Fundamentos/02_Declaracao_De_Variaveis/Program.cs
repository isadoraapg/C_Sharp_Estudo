// See https://aka.ms/new-console-template for more information

//FUNDAMENTOS DO C#

//DECLARAÇÃO DE VARIÁVEIS

//Variável - armazenar informações 

//    int idade;  //numero inteiro
//    decimal altura; //decimal - com virgula
//    string nome; //texto


//Type Inference - Inferencia de Tipo
//declaramos uma variável sem indicar o tipo dela
//o compilador é capaz de deduzir o tipo dela 
//utilizamos o "var"

//não posso declarar ela nula, pq o compilador não é 
// tão adivinha assim

var nome = "Joel";
var ativo = false;


//Conversão de tipos
//Conversão implícita:
//consigo, por exemplo, transformar um inteiro em um double
int ano = 2020;
double ano2 = ano;

//Conversão explícita
//não é possível transformar um numero decimal em inteiro
decimal taxa = 12.98m;
//         int taxa2 = taxa;
//para conseguir realizar esse tipo de conversão:
//as casas decimais serão perdidas, mostrará apenas o valor inteiro
int taxa2 = (int)taxa;
//realizar em string não da pra fazer dessa forma:
//         string taxa2 = (string)taxa;
//precisamos utilizar o toString
string taxa3 = taxa.ToString();

//o mesmo para DateTime:
DateTime data = DateTime.Now;
string data2 = data.ToString();

//para converter string em outro tipo:
string resposta = "11";
int idade2 = int.Parse(resposta);

int idade3 = Convert.ToInt32(resposta);

Console.WriteLine(idade3);





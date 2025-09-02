// See https://aka.ms/new-console-template for more information

//FUNDAMENTOS DO C#

//O TIPO DATETIME

//dia mes e ano
var hoje = DateTime.Today;

//dia mes ano e horario
var agora = DateTime.Now;

//dia mes ano de uma data especifica
var data1 = new DateTime(2020, 03, 28);

//dia mes ano de uma data especifica
var data2 = new DateTime(2020, 03, 28, 11, 25, 30);

//criar datetime a partir da sua representação textual - converter string para datetime
var data3 = DateTime.Parse("15/08/2020 12:21:32");

Console.WriteLine(hoje);
Console.WriteLine(agora);
Console.WriteLine(data1);
Console.WriteLine(data2);
Console.WriteLine(data3);

Console.WriteLine(data3.Day);
Console.WriteLine(data3.Month);
Console.WriteLine(data3.Year);
Console.WriteLine(data3.Hour);
Console.WriteLine(data3.Minute);
Console.WriteLine(data3.Second);

//adiciona dias 
Console.WriteLine(data3.AddDays(5));

//remover um mes
Console.WriteLine(data3.AddMonths(-1));


Console.WriteLine(data3.ToLongDateString());
Console.WriteLine(data3.ToLongTimeString());

Console.WriteLine(data3.ToShortDateString());
Console.WriteLine(data3.ToShortTimeString());
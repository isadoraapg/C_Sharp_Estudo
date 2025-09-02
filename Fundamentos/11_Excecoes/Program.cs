// See https://aka.ms/new-console-template for more information

//FUNDAMENTOS DO C#

//TRATAMENTO DE EXCEÇÕES

try
{
    var nomes = new[] { "João", "Fulano", "Ciclano" };

    for (var indice = 0; indice <= nomes.Length; indice++)
    {
        Console.WriteLine(nomes[indice]);
    }

}
catch(Exception excecao)
{
    Console.WriteLine("Ocorreu um erro: " + excecao.Message);
}



try
{
    var nomes2 = new[] { "João", "Fulano", "Ciclano" };

    for (var indice2 = 0; indice2 < nomes2.Length; indice2++)
    {
        Console.WriteLine(nomes2[indice2]);
    }

}
catch (Exception excecao)
{
    Console.WriteLine("Ocorreu um erro: " + excecao.Message);
}
finally
{
    Console.WriteLine("Prgrama encerrado");
}


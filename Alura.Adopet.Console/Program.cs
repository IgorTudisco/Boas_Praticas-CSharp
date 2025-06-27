using Alura.Adopet.Console.Comandos;

ComandosDoSistema comandos = new();

Console.ForegroundColor = ConsoleColor.Green;
try
{
    string comando = args[0].Trim();
    IComando? comandoASerExecutado = comandos[comando];
    if (comandoASerExecutado is not null) await comandoASerExecutado.ExecutaAsync(args);
    else Console.WriteLine("Comando inválido!");
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}



/*
 * Documentação de convenções de nomenclatura do .NET:
 * https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions
 * 
 * Estrutura de dados:
 * 
 * Estruturas de dados: uma introdução https://www.alura.com.br/artigos/estruturas-de-dados-introducao
 * 
 * C# Collections parte 1: Listas, arrays, listas ligadas, dicionários e conjuntos https://cursos.alura.com.br/course/csharp-collections
 * 
 */
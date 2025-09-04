using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.UI;
using FluentResults;

IComando? comando = ComandosDoSistema.CriarComando(args);

if (comando is not null)
{
    var result = await comando.ExecutaAsync();
    ConsoleUI.ExibirResultado(result);
} 
else ConsoleUI.ExibirResultado(Result.Fail("Comando inválido!"));



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
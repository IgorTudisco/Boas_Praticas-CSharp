using FluentResults;

namespace Alura.Adopet.Console.Comandos;

internal interface IComando
{
    Task<Result> ExecutaAsync(string[] args);
}


/*
 * Artigos:
 * 
 * Cenários de programação assíncrona: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/async-scenarios
 * 
 * Modelo de programação assíncrona baseado em tarefas: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model
 * 
 */

/*
 * Para saber sobre padrões de projeto, acesse os links abaixo:
 * 
 * Artigo POO: o que é programação orientada a objetos? https://www.alura.com.br/artigos/poo-programacao-orientada-a-objetos
 * Artigo Design patterns: Breve introdução aos padrões de projeto; https://www.alura.com.br/artigos/design-patterns-introducao-padroes-projeto
 * Curso Design Patterns C# I; https://cursos.alura.com.br/course/design-patterns-dotnet
 * Curso Design Patterns C# II. https://cursos.alura.com.br/course/design-patterns-2-dot-net
 * 
 */
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

/*
 * Link da biblioteca FluentResults:
 * 
 *  The Operation Result Pattern — A Simple Guide https://medium.com/@cummingsi1993/the-operation-result-pattern-a-simple-guide-fe10ff959080
 *  Result Object Pattern https://wiki.c2.com/?ResultObjectPattern
 *  My take on the Result class in C# https://josef.codes/my-take-on-the-result-class-in-c-sharp/
 *  Documentação do tipo ViewResult https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.viewresult?view=aspnetcore-9.0
 *  Documentação do tipo NotFoundResult https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.notfoundresult?view=aspnetcore-9.0
 *  Documentação do tipo UnauthorizedResult https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.unauthorizedresult?view=aspnetcore-9.0
 *  Documentação do tipo OkObjectResult https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.okobjectresult?view=aspnetcore-9.0
 *  Biblioteca FluentResults https://github.com/altmann/FluentResults
 *  
 */

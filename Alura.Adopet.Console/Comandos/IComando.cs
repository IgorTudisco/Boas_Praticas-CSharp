namespace Alura.Adopet.Console.Comandos;

internal interface IComando
{
    Task ExecutaAsync(string[] args);
}


/*
 * Artigos:
 * 
 * Cenários de programação assíncrona: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/async-scenarios
 * 
 * Modelo de programação assíncrona baseado em tarefas: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model
 * 
 */
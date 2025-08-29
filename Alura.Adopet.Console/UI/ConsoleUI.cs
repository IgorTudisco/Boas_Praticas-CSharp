using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.UI;

public static class ConsoleUI
{
    public static void ExibirResultado(Result result)
    {
        System.Console.ForegroundColor = ConsoleColor.Green;
        try
        {
            //string comando = args[0].Trim();
            //IComando? comandoASerExecutado = comandos[comando];
            //if (comandoASerExecutado is not null) await comandoASerExecutado.ExecutaAsync(args);
            //else Console.WriteLine("Comando inválido!");

            if (result.IsFailed)
            {
                ExibeFalha(result);
            }
            else
            {
                ExibirSucesso(result);
            }
        }
        //catch (Exception ex)
        //{
        //    // mostra a exceção em vermelho
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
        //}
        finally
        {
            System.Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void ExibirSucesso(Result result)
    {
        var sucesso = result.Successes.First();
        switch (sucesso)
        {
            case SuccessWhithPets successWhithPets:
                ExibirPets(successWhithPets);
                break;
            case SuccessWhithDocs successWhithDocs:
                ExibirDocumentacao(successWhithDocs);
                break;
            default:
                break;
        }
    }

    private static void ExibirDocumentacao(SuccessWhithDocs documentacaoComando)
    {
        System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
        System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets. \n");
        foreach (var doc in documentacaoComando.Documentacao)
        {
            System.Console.WriteLine(doc);
        }
    }

    private static void ExibirPets(SuccessWhithPets successWhithPets)
    {
        foreach (var pet in successWhithPets.Data)
        {
            System.Console.WriteLine(pet);
        }
        System.Console.WriteLine(successWhithPets.Message);
    }

    private static void ExibeFalha(Result result)
    {
        System.Console.ForegroundColor = ConsoleColor.Red;
        var erros = result.Errors.FirstOrDefault();
        System.Console.WriteLine($"Aconteceu um exceção: {erros!.Message}");
    }
}


/*
 * 
 * Para saber ainda mais sobre Pattern Matching recomendamos a leitura dos links abaixo:
 * 
 *  Documentação MS Visão geral dos padrões correspondentes https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/functional/pattern-matching
 *  Novidades do C# 7: Pattern Matching https://www.lambda3.com.br/2016/08/novidades-do-c-7-pattern-matching/
 *  
 */
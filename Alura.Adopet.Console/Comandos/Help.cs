using Alura.Adopet.Console.Util;
using FluentResults;
using System.Reflection;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "Help", documentacao: "adopet help comando que exibe informações de ajuda.")]
public class Help: IComando
{
    private readonly Dictionary<string, DocComando> Docs;

    public Help()
    {
        Docs = DocumentacaoDoSistema.ToDicrionary(Assembly.GetExecutingAssembly());
    }

    public Task<Result> ExecutaAsync(string[] args)
    {
        this.ShowHelp(argsHelp: args);
        return Task.FromResult(Result.Ok());
    }

    private void ShowHelp(string[] argsHelp)
    {
        System.Console.WriteLine("Lista de comandos.");
        // se não passou mais nenhum argumento mostra help de todos os comandos
        if (argsHelp!.Length == 1)
        {
            System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                 "comando que exibe informações de ajuda dos comandos.");
            System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
            System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
            System.Console.WriteLine("Comando possíveis: ");

            foreach (var doc in Docs.Values)
            {
                System.Console.WriteLine(doc.Documentacao);
            }
        }
        // exibe o help daquele comando específico
        else if (argsHelp.Length == 2)
        {
            string comandoASerExibido = argsHelp[1];

            if (!Docs.ContainsKey(comandoASerExibido))
            {
                var comando = Docs[comandoASerExibido];
            System.Console.WriteLine(comando.Documentacao);
            }

        }
    }
}

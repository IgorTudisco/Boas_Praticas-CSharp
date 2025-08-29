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
        try
        {
            var success = this.GeneratesHelp(argsHelp: args);
            return Task.FromResult(Result.Ok().WithSuccess(new SuccessWhithDocs(success)));
        }
        catch (Exception exception)
        {
            return Task.FromResult(Result.Fail(new Error("Exibição da documentação falhou!").CausedBy(exception)));
        }        
    }

    private IEnumerable<string> GeneratesHelp(string[] argsHelp)
    {
        List<string> resultado = new();
        System.Console.WriteLine("Lista de comandos.");
        // se não passou mais nenhum argumento mostra help de todos os comandos
        if (argsHelp!.Length == 1)
        {            
            foreach (var doc in Docs.Values)
            {
                resultado.Add(doc.Documentacao);
            }
        }
        // exibe o help daquele comando específico
        else if (argsHelp.Length == 2)
        {
            string comandoASerExibido = argsHelp[1];

            if (!Docs.ContainsKey(comandoASerExibido))
            {
                var comando = Docs[comandoASerExibido];
                resultado.Add(comando.Documentacao);
            }
            else
            {
                resultado.Add($"Comando {comandoASerExibido} não encontrado!");
            }

        }

        return resultado;
    }
}

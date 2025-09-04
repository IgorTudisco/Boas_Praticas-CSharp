using Alura.Adopet.Console.Util;
using FluentResults;
using System.Reflection;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "Help", documentacao: "adopet help comando que exibe informações de ajuda.")]
public class Help: IComando
{
    private readonly Dictionary<string, DocComando> Docs;
    private string? _comando;

    public Help(string? comando = null)
    {
        Docs = DocumentacaoDoSistema.ToDicrionary(Assembly.GetExecutingAssembly());
        _comando = comando;
    }

    public Task<Result> ExecutaAsync()
    {
        try
        {
            var success = this.GerarDocumentacao();
            return Task.FromResult(Result.Ok().WithSuccess(new SuccessWhithDocs(success)));
        }
        catch (Exception exception)
        {
            return Task.FromResult(Result.Fail(new Error("Exibição da documentação falhou!").CausedBy(exception)));
        }        
    }

    private IEnumerable<string> GerarDocumentacao()
    {
        List<string> resultado = new();
        System.Console.WriteLine("Lista de comandos.");
        // se não passou mais nenhum argumento mostra help de todos os comandos
        if (_comando is null)
        {            
            foreach (var doc in Docs.Values)
            {
                resultado.Add(doc.Documentacao);
            }
        }
        // exibe o help daquele comando específico
        else
        {

            if (!Docs.ContainsKey(_comando))
            {
                var comando = Docs[_comando];
                resultado.Add(comando.Documentacao);
            }
            else
            {
                resultado.Add($"Comando {_comando} não encontrado!");
            }

        }

        return resultado;
    }
}

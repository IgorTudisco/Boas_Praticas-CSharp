using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show",
       documentacao: "adopet show <ARQUIVO> comando que exibe no terminal o conteúdo do arquivo importado.")]
    internal class Show : IComando
    {
        private readonly LeitorDeArquivo leitor;

        public Show(LeitorDeArquivo leitor)
        {
            this.leitor = leitor;
        }

        public Task<Result> ExecutaAsync(string[] args)
        {
            try
            { 
                this.ExibeConteudoArquivo(caminhoDoArquivoASerExibido: args[1]);
                return Task.FromResult(Result.Ok());
            }
            catch (Exception exception)
            {
                return Task.FromResult(Result.Fail(new Error("mensagem de falha!").CausedBy(exception)));
            }
        }

        private void ExibeConteudoArquivo(string caminhoDoArquivoASerExibido)
        {
            var listaDepets = leitor.RealizaLeitura();
            Result.Ok().WithSuccess(new SuccessWhithPets(listaDepets!, "Importação realizada com sucesso!"));
        }
    }
}
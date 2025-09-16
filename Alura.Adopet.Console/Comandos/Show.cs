using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show",
       documentacao: "adopet show <ARQUIVO> comando que exibe no terminal o conteúdo do arquivo importado.")]
    public class Show : IComando
    {
        private readonly LeitorDeArquivo leitor;

        public Show(LeitorDeArquivo leitor)
        {
            this.leitor = leitor;
        }

        public Task<Result> ExecutaAsync()
        {
            try
            { 
                this.ExibeConteudoArquivo();
                return Task.FromResult(Result.Ok());
            }
            catch (Exception exception)
            {
                return Task.FromResult(Result.Fail(new Error("mensagem de falha!").CausedBy(exception)));
            }
        }

        private void ExibeConteudoArquivo()
        {
            var listaDepets = leitor.RealizaLeitura();
            Result.Ok().WithSuccess(new SuccessWhithPets(listaDepets!, "Importação realizada com sucesso!"));
        }
    }
}
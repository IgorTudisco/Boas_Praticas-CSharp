using Alura.Adopet.Console.Util;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "Show", documentacao: "adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]
internal class Show: IComando
{
    public Task ExecutaAsync(string[] args)
    {
        this.ShowArquivoImportado(caminhoDoArquivoAserExibido: args[1]);
        return Task.CompletedTask;
    }

    private void ShowArquivoImportado(string caminhoDoArquivoAserExibido)
    {
        LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
        var listaDePets = leitorDeArquivo.RealizaLeitura();
        foreach (var pet in listaDePets)
        {
            System.Console.WriteLine($"ID: {pet.Id}, Nome: {pet.Nome}, Tipo: {pet.Tipo}");
        }
    }
}

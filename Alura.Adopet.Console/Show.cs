using System.Threading.Tasks;

namespace Alura.Adopet.Console;

[DocComando(instrucao: "Show", documentacao: "adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]
internal class Show
{
    public void ShowArquivoImportado(string caminhoDoArquivoAserExibido)
    {
        LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
        var listaDePets = leitorDeArquivo.RealizaLeitura(caminhoDoArquivoAserExibido);
        foreach (var pet in listaDePets)
        {
            System.Console.WriteLine($"ID: {pet.Id}, Nome: {pet.Nome}, Tipo: {pet.Tipo}");
        }
    }
}

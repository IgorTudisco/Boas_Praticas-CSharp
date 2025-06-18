using System.Threading.Tasks;

namespace Alura.Adopet.Console;

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

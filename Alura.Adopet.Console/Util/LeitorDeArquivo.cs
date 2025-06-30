using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

internal class LeitorDeArquivo
{
    public List<Pet> RealizaLeitura(string caminhoDoArquivoASerLido)
    {
        List<Pet> listaDePets = new List<Pet>();
        using (StreamReader sr = new StreamReader(caminhoDoArquivoASerLido))
        {
            System.Console.WriteLine("----- Serão importados os dados abaixo -----");
            while (!sr.EndOfStream)
            {
                var linha = sr.ReadLine()!;
                var pet = linha.ConverteDoTexto();
                listaDePets.Add(pet);
            }
        }
        
        return listaDePets;
    }
}

/*
 * Documentação de diretrizes para coleções:
 * https://learn.microsoft.com/pt-br/dotnet/standard/design-guidelines/guidelines-for-collections
 */
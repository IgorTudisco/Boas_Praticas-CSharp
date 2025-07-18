using Alura.Adopet.Console.Modelos;
using System.Runtime.CompilerServices;

namespace Alura.Adopet.Console.Util;

public class LeitorDeArquivo
{
    public virtual List<Pet> RealizaLeitura(string? caminhoDoArquivoASerLido)
    {
        if(caminhoDoArquivoASerLido is null)
        {
            throw new ArgumentNullException(nameof(caminhoDoArquivoASerLido), "O caminho do arquivo não pode ser nulo.");
        }

        List<Pet> listaDePets = new List<Pet>();
        using (StreamReader sr = new StreamReader(caminhoDoArquivoASerLido!))
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
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

public class LeitorDeArquivo
{
    private readonly string _caminhoDoArquivo;
    public LeitorDeArquivo(string? caminhoDoArquivo = "")
    {
        _caminhoDoArquivo = caminhoDoArquivo!;
    }

    public virtual List<Pet>? RealizaLeitura()
    {
        if (string.IsNullOrWhiteSpace(_caminhoDoArquivo))
        {
            return null;
        }

        List<Pet> listaDePets = new List<Pet>();
        using (StreamReader sr = new StreamReader(_caminhoDoArquivo))
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
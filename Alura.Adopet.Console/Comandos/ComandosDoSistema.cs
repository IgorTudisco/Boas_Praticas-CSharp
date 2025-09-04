using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos;

internal static class ComandosDoSistema
{
    public static IComando? CriarComando(string[] argumentos)
    {
        var comando = argumentos[0];
        switch (comando)
        {
            case "import":
                var httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().GetHttpClient());
                // LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo(caminhoDoArquivo: args[1]); // Erro, pois o args[1] não está disponível aqui
                LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
                return new Import(httpClientPet, leitorDeArquivo);
            case "list":
                var httpClientPetList = new HttpClientPet(new AdopetAPIClientFactory().GetHttpClient());
                return new List(httpClientPetList);
            case "show":
                // LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo(caminhoDoArquivo: args[1]); // Erro, pois o args[1] não está disponível aqui
                LeitorDeArquivo leitorDeArquivos = new LeitorDeArquivo();
                return new Show(leitorDeArquivos);
            case "help":
                //return new Help(comando: args[]) // Erro, pois o args[1] não está disponível aqui
                return new Help();
            default: return null;
        }
    }
}


/*
 * Padrão Command em bibliotecas famosas:
 * 
 * ADO.NET - https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/commands-and-parameters
 * 
 * MediatR - https://github.com/jbogard/MediatR
 *  
 */
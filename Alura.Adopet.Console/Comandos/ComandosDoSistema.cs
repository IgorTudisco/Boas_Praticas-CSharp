using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos;

internal class ComandosDoSistema
{
    private readonly HttpClientPet _httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().GetHttpClient());
    private readonly Dictionary<string, IComando> comandosDoSistema;
    // private readonly LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo(caminhoDoAquivoASerLido: args[1]); Erro, pois o args[1] não está disponível aqui
    private readonly LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo();

    public ComandosDoSistema()
    {
        comandosDoSistema = new Dictionary<string, IComando>
        {
            {"help", new Help() },
            {"import", new Import(_httpClientPet, _leitorDeArquivo) },
            {"list", new List(_httpClientPet) },
            {"show", new Show() },
        };
    }

    public IComando? this[string key] => comandosDoSistema.ContainsKey(key) ? comandosDoSistema[key] : null;
}

/*
 * Padrão Command em bibliotecas famosas:
 * 
 * ADO.NET - https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/commands-and-parameters
 * 
 * MediatR - https://github.com/jbogard/MediatR
 *  
 */

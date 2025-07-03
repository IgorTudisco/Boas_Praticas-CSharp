using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Console.Comandos;

internal class ComandosDoSistema
{
    private readonly HttpClientPet _httpClientPet = new HttpClientPet();
    private readonly Dictionary<string, IComando> comandosDoSistema;

    public ComandosDoSistema()
    {
        comandosDoSistema = new Dictionary<string, IComando>
        {
            {"help", new Help() },
            {"import", new Import(_httpClientPet) },
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
 * Orientações da documentação da Microsoft para trabalhar com esse tipo de HttpClient:
 * 
 * Doc - https://learn.microsoft.com/pt-br/dotnet/fundamentals/networking/http/httpclient-guidelines
 * 
 * Uso recomendado - https://learn.microsoft.com/pt-br/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
 */

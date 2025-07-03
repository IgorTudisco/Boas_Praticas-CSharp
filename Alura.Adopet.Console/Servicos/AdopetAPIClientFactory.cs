using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Net.Http.Headers;

namespace Alura.Adopet.Console.Servicos;

internal class AdopetAPIClientFactory : IHttpClientFactory
{
    private string url = "http://localhost:5057";

    public HttpClient GetHttpClient()
    {
        HttpClient _client = new HttpClient();
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _client.BaseAddress = new Uri(url);
        return _client;
    }
}

/*
 * Orientações da documentação da Microsoft para trabalhar com esse tipo de HttpClient:
 * 
 * Doc - https://learn.microsoft.com/pt-br/dotnet/fundamentals/networking/http/httpclient-guidelines
 * 
 * Uso recomendado - https://learn.microsoft.com/pt-br/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
 * 
 * HttpClient Classe - https://learn.microsoft.com/pt-br/dotnet/api/system.net.http.httpclient?view=net-7.0
 * 
 * Usar IHttpClientFactory para implementar solicitações HTTP resilientes - https://learn.microsoft.com/pt-br/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests
 */


/*
 * Exemplo do get com HttpClient:
 * 
 * HttpClient client = new HttpClient();
 * var response = await client.GetAsync("https://www.exemplo.com/api/documento");
 * var conteudo = await response.Content.ReadAsStringAsync();
 */
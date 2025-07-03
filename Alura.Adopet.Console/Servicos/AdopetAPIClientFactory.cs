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

﻿using Alura.Adopet.Console.Modelos;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "List", documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.")]
internal class List: IComando
{
    HttpClient client;

    public List()
    {
        client = ConfiguraHttpClient("http://localhost:5057");
    }

    private async Task ListDePets()
    {
        var pets = await ListPetsAsync();
        foreach (var pet in pets!)
        {
            System.Console.WriteLine(pet);
        }
    }

    async Task<IEnumerable<Pet>?> ListPetsAsync()
    {
        HttpResponseMessage response = await client.GetAsync("pet/list");
        return await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();
    }

    HttpClient ConfiguraHttpClient(string url)
    {
        HttpClient _client = new HttpClient();
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _client.BaseAddress = new Uri(url);
        return _client;
    }

    public async Task ExecutaAsync(string[] args)
    {
        await this.ListDePets();
    }
}

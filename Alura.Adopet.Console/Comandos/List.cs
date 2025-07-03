using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "List", documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.")]
internal class List: IComando
{
    private readonly HttpClientPet _httpClientPet;
    public List(HttpClientPet httpClientPet)
    {
        _httpClientPet = httpClientPet;
    }
    private async Task ListaDadosPetsDaAPIAsync()
    {
        IEnumerable<Pet>? pets = await _httpClientPet.ListPetsAsync();
        System.Console.WriteLine("----- Lista de Pets importados no sistema -----");
        foreach (var pet in pets!)
        {
            System.Console.WriteLine(pet);
        }
    }

    public async Task ExecutaAsync(string[] args)
    {
        await this.ListaDadosPetsDaAPIAsync();
    }
}

using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using FluentResults;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "List", documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.")]
internal class List: IComando
{
    private readonly HttpClientPet _httpClientPet;
    public List(HttpClientPet httpClientPet)
    {
        _httpClientPet = httpClientPet;
    }
    private async Task<Result> ListaDadosPetsDaAPIAsync()
    {
        try
        {
            IEnumerable<Pet>? pets = await _httpClientPet.ListPetsAsync();
            System.Console.WriteLine("----- Lista de Pets importados no sistema -----");
            foreach (var pet in pets!)
            {
                System.Console.WriteLine(pet);
            }

            return Result.Ok();
        }
        catch (Exception exception)
        {
            return Result.Fail(new Error("Listagem falhou!").CausedBy(exception));
        }
    }

    public async Task<Result> ExecutaAsync(string[] args)
    {
        return await this.ListaDadosPetsDaAPIAsync();
    }
}

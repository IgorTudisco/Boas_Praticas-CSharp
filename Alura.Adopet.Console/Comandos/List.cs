using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "List", documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.")]
public class List: IComando
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
            return Result.Ok().WithSuccess(new SuccessWhithPets(pets!, "Importação realizada com sucesso!"));
        }
        catch (Exception exception)
        {
            return Result.Fail(new Error("Listagem falhou!").CausedBy(exception));
        }
    }

    public async Task<Result> ExecutaAsync()
    {
        return await this.ListaDadosPetsDaAPIAsync();
    }
}

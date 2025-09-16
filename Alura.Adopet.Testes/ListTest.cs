using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using Alura.Adopet.Testes.Builder;

namespace Alura.Adopet.Testes;

public class ListTest
{
    [Fact]
    public async Task QuandoExecutarOComandoListMostrarAListaDePet()
    {
        //Arrange
        List<Pet>? listaDePet = new();
        var pet = new Pet(new Guid("456b24f4-19e2-4423-845d-4a80e8854a99"),
                                            "Lima", TipoPet.Cachorro);
        listaDePet.Add(pet);

        var httpClientPet = HttpClientPetMockBuilder.GetMockList(listaDePet);

        //Act
        var retorno = await new Console.Comandos.List(httpClientPet.Object).ExecutaAsync();

        //Assert
        var resultado = (SuccessWhithPets)retorno.Successes[0];
        Assert.Single(resultado.Data);
    }
}

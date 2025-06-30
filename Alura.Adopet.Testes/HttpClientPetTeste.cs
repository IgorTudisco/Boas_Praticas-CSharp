using Alura.Adopet.Console.Servicos;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes;

public class HttpClientPetTeste
{
    [Fact]
    public async Task ListaPetsDeveRetornarUmaListaNaoVazia()
    {
        // Arrange
        var clientePet = new HttpClientPet();

        // Act
        var lista = await clientePet.ListPetsAsync();

        // Assert
        Assert.NotNull(lista);
        Assert.NotEmpty(lista);

    }

    [Fact]
    public async Task QuandoApiForaDeveRetornarUmaExecao()
    {
        // Arrange
        var clientePet = new HttpClientPet(uri: "http://localhost:1111");

        // Act + Assert
        await Assert.ThrowsAnyAsync<Exception>(() => clientePet.ListPetsAsync());

    }
}
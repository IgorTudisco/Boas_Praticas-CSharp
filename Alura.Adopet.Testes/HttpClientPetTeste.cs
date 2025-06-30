using Alura.Adopet.Console.Servicos;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes;

public class HttpClientPetTeste
{
    [Fact]
    public async Task ListaPetsDeveRetornarUmaListaDePetsNaoVazia()
    {
        // Arrange
        var clientePet = new HttpClientPet();

        // Act
        var lista = await clientePet.ListPetsAsync();

        // Assert
        Assert.NotNull(lista);
        Assert.NotEmpty(lista);

    }
}
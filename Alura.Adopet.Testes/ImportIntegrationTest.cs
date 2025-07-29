using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using Alura.Adopet.Testes.Builder;
using Moq;

namespace Alura.Adopet.Testes;

public class ImportIntegrationTest
{
    // Teste com falha
    [Fact]
    public async Task QuandoApiEstaNoArDeveRetornarListaDePet()
    {
        List<Pet> listaDePets = new();
        var pet = new Pet(new Guid("456b24f4-19e2-4423-845d-4a80e8854a41"), "Lima", TipoPet.Cachorro);
        listaDePets.Add(pet);

        var leitorDeArquivo = LeitorDeArquivosMockBuilder.CriaMock(listaDePets);

        var httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().GetHttpClient());
        var import = new Import(httpClientPet, leitorDeArquivo.Object);
        string[] args = { "import", "lista.csv" };
        //Act
        await import.ExecutaAsync(args);
        //Assert 
        var listaPet = await httpClientPet.ListPetsAsync();
        Assert.NotNull(listaPet);

    }
}


using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using Alura.Adopet.Testes.Builder;
using Moq;

namespace Alura.Adopet.Testes;

public class ImportTest
{
    // Teste com falha
    [Fact]
    public async Task QuandoListaVaziaNaoDeveChamarCreatPetAsync()
    {
        // Arrange
        List<Pet> listaDePets = new();
        var leitorDeArquivo = LeitorDeArquivosMockBuilder.CriaMock(listaDePets);

        var httpClientPet = new Mock<HttpClientPet>(MockBehavior.Default, It.IsAny<HttpClient>());

        var import = new Import(httpClientPet.Object, leitorDeArquivo.Object);
        string[] args = { "import", "lista.csv" };
            
        // Act
        await import.ExecutaAsync(args);

        // Assert
        httpClientPet.Verify(x => x.CreatePetAsync(It.IsAny<Pet>()), Times.Never);

    }

    // Teste com falha
    [Fact]
    public async Task QuandoArquivoNaoExistenteDeveGerarException()
    {
        //Arrange
        List<Pet> listaDePet = new();
        var leitor = LeitorDeArquivosMockBuilder.CriaMock(listaDePet);
        leitor.Setup(_ => _.RealizaLeitura()).Throws<FileNotFoundException>();

        var httpClientPet = HttpClientPetMockBuilder.GetMock();

        string[] args = { "import", "lista.csv" };

        var import = new Import(httpClientPet.Object, leitor.Object);

        //Act+Assert
        await Assert.ThrowsAnyAsync<Exception>(() => import.ExecutaAsync(args));
    }
}


using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using Moq;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes;

public class ImportTest
{
    // Teste com falha
    [Fact]
    public async Task QuandoListaVaziaNaoDeveChamarCreatPetAsync()
    {
        // Arrange
        var leitorDeArquivo = new Mock<LeitorDeArquivo>(MockBehavior.Default, It.IsAny<string>());
        var listaDePets = new List<Pet>();        

        leitorDeArquivo.Setup(x => x.RealizaLeitura("")).Returns(listaDePets);

        var httpClientPet = new Mock<HttpClientPet>(MockBehavior.Default, It.IsAny<HttpClient>());

        var import = new Import(httpClientPet.Object, leitorDeArquivo.Object);
        string[] args = { "import", "lista.csv" };

        // Act
        await import.ExecutaAsync(args);

        // Assert
        httpClientPet.Verify(x => x.CreatePetAsync(It.IsAny<Pet>()), Times.Never);

    }
}

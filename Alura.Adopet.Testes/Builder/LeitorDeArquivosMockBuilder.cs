using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using Moq;

namespace Alura.Adopet.Testes.Builder;

internal static class LeitorDeArquivosMockBuilder
{
    public static Mock<LeitorDeArquivo> CriaMock(List<Pet> listaDePets)
    {
        var leitorDeArquivo = new Mock<LeitorDeArquivo>(MockBehavior.Default, It.IsAny<string>());
        
        leitorDeArquivo.Setup(x => x.RealizaLeitura()).Returns(listaDePets);

        return leitorDeArquivo;
    }
}

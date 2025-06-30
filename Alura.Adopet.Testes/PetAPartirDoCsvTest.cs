using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes;

public class PetAPartirDoCsvTest
{
    [Fact]
    public void QuandoStringForValidaDeveRetornarUmPet()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";
        var conversor = new PetAPartirDoCsv();


        // Act
        var pet = conversor.ConverteDoTexto(linha);

        // Assert
        Assert.NotNull(pet);
    }
}

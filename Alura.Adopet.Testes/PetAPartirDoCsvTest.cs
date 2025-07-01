using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes;

public class PetAPartirDoCsvTest
{
    [Fact]
    public void QuandoStringForValidaDeveRetornarUmPet()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.NotNull(pet);
    }

    [Fact]
    public void QuandoStringNaoForNulaEVaziaDeveRetornarUmPet()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.NotNull(pet);
        Assert.NotEmpty(pet.Nome!);
        Assert.NotEmpty(pet.Id.ToString());
        Assert.NotEmpty(pet.Tipo.ToString());
    }

    [Fact]
    public void VerificaSeOsCamposSaoValidos()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.NotEmpty(pet.Nome!);
        Assert.NotEmpty(pet.Id.ToString());
        Assert.NotEmpty(pet.Tipo.ToString());
        Assert.NotNull(pet.Nome!);
        Assert.NotNull(pet.Id.ToString());
        Assert.NotNull(pet.Tipo.ToString());
    }

    [Fact]
    public void VerificaSeOGuidValido()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.Equal("Lima Limão", pet.Nome);
        Assert.Equal(Guid.Parse("456b24f4-19e2-4423-845d-4a80e8854a41"), pet.Id);
    }

    [Fact]
    public void VerificaSeOTipoValido()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.Equal(TipoPet.Gato, pet.Tipo);
        Assert.Equal("Gato", pet.Tipo.ToString());

    }


}


/*
 * Bibliotecas que empregam testes automatizados:
 * 
 * EF Core - https://github.com/dotnet/efcore
 * 
 * Dapper - https://github.com/DapperLib/Dapper
 * 
 * Humanizer - https://github.com/Humanizr/Humanizer
 * 
 * AutoMapper - https://github.com/AutoMapper/AutoMapper/
 * 
 */
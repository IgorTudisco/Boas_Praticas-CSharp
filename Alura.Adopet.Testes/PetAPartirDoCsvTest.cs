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
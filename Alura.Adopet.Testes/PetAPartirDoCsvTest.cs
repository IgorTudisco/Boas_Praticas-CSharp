﻿using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes;

public class PetAPartirDoCsvTest
{
    [Fact]
    public void QuandoStringForValidaDeveRetornarUmPet()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;0";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.NotNull(pet);
    }

    [Fact]
    public void QuandoStringNaoForNulaEVaziaDeveRetornarUmPet()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;0";

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
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;0";

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
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;0";

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
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;0";

        // Act
        var pet = linha.ConverteDoTexto();

        // Assert
        Assert.Equal(TipoPet.Gato, pet.Tipo);
        Assert.Equal("Gato", pet.Tipo.ToString());

    }

    [Fact]
    public void QuandoStringNulaDevelancarArgumentNullException()
    {
        // Arrange
        string? linha = null;

        // Act e Assert
        Assert.Throws<ArgumentNullException>(() => linha!.ConverteDoTexto());
    }

    [Fact]
    public void QuandoAStringForVaziaLancarAgumentException()
    {
        // Arrange
        string linha = string.Empty;

        // Act e Assert
        Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
    }

    [Fact]
    public void QuandoCamposInsufucientesDeveLancarArgumentException()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";
        // Act e Assert
        Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
    }

    [Fact]
    public void QuandoGuidInvalidoDeveLancarArgumentException()
    {
        // Arrange
        string linha = "jadsjfajklj554;Lima Limão;0";
        // Act e Assert
        Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
    }

    [Fact]
    public void QuandoTipoInvalidoDeveLancarArgumentException()
    {
        // Arrange
        string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;3";
        // Act e Assert
        Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
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
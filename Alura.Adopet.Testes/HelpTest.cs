using Alura.Adopet.Console.Comandos;

namespace Alura.Adopet.Testes;

public class HelpTest
{
    [Fact]
    public async Task QuandoComandoNaoExistirDeveRetornarFalha()
    {
        //Arrange
        var comando = "Inválido";
        var help = new Help(comando);
        //Act
        var resultado = await help.ExecutaAsync();
        //Assert
        Assert.NotNull(resultado);
        Assert.True(resultado.IsFailed);
    }

    // Theory para testar vários comandos existentes, ou seja, os comando que possuem documentação
    [Theory]
    [InlineData("help")]
    [InlineData("show")]
    [InlineData("list")]
    [InlineData("import")]
    public async Task QuandoComandoExistirDeveRetornarSucesso(string comando)
    {

        //Arrange   
        var help = new Help(comando);
        //Act
        var resultado = await help.ExecutaAsync();
        //Assert
        Assert.NotNull(resultado);
        Assert.True(resultado.IsSuccess);
    }
}

using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using Alura.Adopet.Testes.Builder;

namespace Alura.Adopet.Testes;

public class ShowTest
{
    [Fact]
    public async Task QuandoArquivoExistenteDeveRetornarMensagemDeSucesso()
    {
        //Arrange
        List<Pet> listaDePet = new();
        var pet = new Pet(new Guid("456b24f4-19e2-4423-845d-4a80e8854a99"),
                          "Lima", TipoPet.Cachorro);
        listaDePet.Add(pet);
        var leitor = LeitorDeArquivosMockBuilder.CriaMock(listaDePet);
        leitor.Setup(s => s.RealizaLeitura());

        var show = new Show(leitor.Object);

        //Act
        var resultado = await show.ExecutaAsync();

        //Assert
        Assert.NotNull(resultado);
        var sucesso = (SuccessWhithPets)resultado.Successes[0];
        Assert.Equal("Importação realizada com sucesso!",
            sucesso.Message);
    }
}

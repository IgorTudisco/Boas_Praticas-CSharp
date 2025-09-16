using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos;

public static class FabricaDeComandos
{
    public static IComando? CriarComando(string[] argumentos)
    {
        var comando = argumentos[0];
        switch (comando)
        {
            case "import":
                var httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().GetHttpClient());
                // LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo(caminhoDoArquivo: args[1]); // Erro, pois o args[1] não está disponível aqui
                LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
                return new Import(httpClientPet, leitorDeArquivo);
            case "list":
                var httpClientPetList = new HttpClientPet(new AdopetAPIClientFactory().GetHttpClient());
                return new List(httpClientPetList);
            case "show":
                // LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo(caminhoDoArquivo: args[1]); // Erro, pois o args[1] não está disponível aqui
                LeitorDeArquivo leitorDeArquivos = new LeitorDeArquivo();
                return new Show(leitorDeArquivos);
            case "help":
                //return new Help(comando: args[]) // Erro, pois o args[1] não está disponível aqui
                return new Help();
            default: return null;
        }
    }
}


/*
 * Padrão Command em bibliotecas famosas:
 * 
 * ADO.NET - https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/commands-and-parameters
 * 
 * MediatR - https://github.com/jbogard/MediatR
 *  
 */

/*
 * 
 * Para saber mais sobre padrões de projeto GoF e do padrão Factory, consulte os seguintes materiais:
 * 
 * Design patterns: Breve introdução aos padrões de projeto https://www.alura.com.br/artigos/design-patterns-introducao-padroes-projeto
 * Factory Method https://refactoring.guru/pt-br/design-patterns/factory-method
 * Exemplo de implementação do padrão factory method https://github.com/alura-cursos/CalculadoraFactoryApp
 * 
 */
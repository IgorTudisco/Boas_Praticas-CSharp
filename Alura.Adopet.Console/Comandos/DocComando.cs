namespace Alura.Adopet.Console.Comandos;

[AttributeUsage(AttributeTargets.Class)]
public class DocComando: Attribute
{

    public string Instrucao { get; }
    public string Documentacao { get; }

    public DocComando(string instrucao, string documentacao)
    {
        Instrucao = instrucao;
        Documentacao = documentacao;
    }
   
}

/*
 * 
 * Documentação de Atributos (diretrizes de design do .NET Framework):
 * https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/attributes
 * 
 * Arquitete aplicações web modernas com ASP.NET Core e Azure
 * https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/
 * 
 * Repositório no GitHub com exemplos de atributos:
 * https://github.com/dotnet-architecture/eShopOnWeb
 * 
 * Biblioteca Swashbuckle. Essa biblioteca é responsável por olhar para o nosso código, através de reflections,
 * trazer informações e montar uma página como a Swagger UI da Alura.Adopet.API.
 * https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger
 * 
 */
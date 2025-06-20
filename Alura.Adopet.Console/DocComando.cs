namespace Alura.Adopet.Console;

[AttributeUsage(AttributeTargets.Class)]
internal class DocComando: System.Attribute
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
 * Documentação de Atributos (diretrizes de design do .NET Framework):
 * https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/attributes
 */
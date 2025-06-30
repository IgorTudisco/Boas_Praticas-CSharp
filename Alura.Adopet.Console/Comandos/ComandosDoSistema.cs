namespace Alura.Adopet.Console.Comandos;

internal class ComandosDoSistema
{
    private readonly Dictionary<string, IComando> comandosDoSistema = new()
    {
        {"help",new Help() },
        {"import",new Import() },
        {"list",new List() },
        {"show",new Show() },
    };

    public IComando? this[string key] => comandosDoSistema.ContainsKey(key) ? comandosDoSistema[key] : null;
}

/*
 * Padrão Command em bibliotecas famosas:
 * 
 * ADO.NET - https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/commands-and-parameters
 * 
 * MediatR - https://github.com/jbogard/MediatR
 * 
 */
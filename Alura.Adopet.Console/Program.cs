using Alura.Adopet.Console.Comandos;

Dictionary<string, IComando> comandosDoSistema = new Dictionary<string, IComando>
{
    { "import", new Import() },
    { "help", new Help() },
    { "show", new Show() },
    { "list", new List() }
};

Console.ForegroundColor = ConsoleColor.Green;
try
{
    string comando = args[0].Trim();
    IComando? comandoASerExecutado = comandosDoSistema[comando];
    if (comandosDoSistema.ContainsKey(comando) )
    {
        IComando comandoExecutar = comandosDoSistema[comando];
        await comandoExecutar.ExecutaAsync(args);
    }
    else
    {
        Console.WriteLine("Comando inválido!");
    }
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}



/*
 * Documentação de convenções de nomenclatura do .NET:
 * https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions
 */
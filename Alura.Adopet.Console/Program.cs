using Alura.Adopet.Console;

Console.ForegroundColor = ConsoleColor.Green;
try
{
    string comando = args[0].Trim();
    switch (comando)
    {
        case "import":

            var import = new Import();
            await import.ImportacaoDeArquivoPetAsyc(caminhoDoArquivoDeImportacao: args[1]);
            break;
        case "help":

            var help = new Help();
            Help.ShowHelp(argsHelp: args[1]);            
            break;
        case "show":

            var show = new Show();
            show.ShowArquivoImportado(caminhoDoArquivoAserExibido: args[1]);            
            break;
        case "list":

            var list = new List();
            await list.ListDePets();            
            break;
        default:
            // exibe mensagem de comando inválido
            Console.WriteLine("Comando inválido!");
            break;
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
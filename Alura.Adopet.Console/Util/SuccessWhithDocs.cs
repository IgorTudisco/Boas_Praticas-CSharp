using FluentResults;

namespace Alura.Adopet.Console.Util;

public class SuccessWhithDocs : Success
{
    public IEnumerable<string> Documentacao { get; }
    public SuccessWhithDocs(IEnumerable<string> documentacao)
    {
        Documentacao = documentacao;
    }
}

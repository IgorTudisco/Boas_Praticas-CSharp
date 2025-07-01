using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

public static class PetAPartirDoCsv
{
    public static Pet ConverteDoTexto(this string? linha)
    {

        string[] propriedades = linha?.Split(';') ?? throw new ArgumentNullException(nameof(linha), "Linha não pode ser nula");

        if(string.IsNullOrEmpty(linha)) throw new ArgumentException("Linha não pode ser vazia", nameof(linha));

        if (propriedades.Length != 3) throw new ArgumentException("Linha deve conter exatamente 3 propriedades separadas por ponto e vírgula", nameof(linha));

        bool isGuidValid = Guid.TryParse(propriedades[0], out Guid petId);
        if (!isGuidValid) throw new ArgumentException("O primeiro campo deve ser um GUID válido", nameof(linha));

        Pet pet = new Pet(Guid.Parse(propriedades[0]),
        propriedades[1],
        int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
        );

        return pet;
    }
}

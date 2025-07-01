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

        bool isTipoPetValid = int.TryParse(propriedades[2], out int tipoPetValue);
        if (!isTipoPetValid) throw new ArgumentException("O terceiro campo deve ser 0 (Cachorro) ou 1 (Gato)", nameof(linha));

        if (tipoPetValue != 0 && tipoPetValue != 1) throw new ArgumentException("O terceiro campo deve ser 0 (Cachorro) ou 1 (Gato)", nameof(linha));

        Pet pet = new Pet(Guid.Parse(propriedades[0]),
        propriedades[1],
        int.Parse(propriedades[2]) == 0 ? TipoPet.Gato : TipoPet.Cachorro
        );

        return pet;
    }
}

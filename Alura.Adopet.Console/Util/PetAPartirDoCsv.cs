using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

public static class PetAPartirDoCsv
{
    public static Pet ConverteDoTexto(this string? linha)
    {
        if(linha == null) throw new ArgumentNullException(nameof(linha), "Linha não pode ser nula");

        string[] propriedades = linha!.Split(';');

        Pet pet = new Pet(Guid.Parse(propriedades[0]),
        propriedades[1],
        int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
        );

        return pet;
    }
}

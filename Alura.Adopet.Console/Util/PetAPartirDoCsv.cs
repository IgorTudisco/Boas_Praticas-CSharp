using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

public class PetAPartirDoCsv
{
    public Pet ConverteDoTexto(string linha)
    {

        string[] propriedades = linha.Split(';');

        Pet pet = new Pet(Guid.Parse(propriedades[0]),
        propriedades[1],
        TipoPet.Cachorro
        );

        return pet;
    }
}

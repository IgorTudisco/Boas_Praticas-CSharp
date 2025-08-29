using Alura.Adopet.Console.Modelos;
using FluentResults;

namespace Alura.Adopet.Console.Util;

public class SuccessWhithPets : Success
{
    public IEnumerable<Pet> Data { get; }

    public SuccessWhithPets(IEnumerable<Pet> data)
    {
        Data = data;
    }
}

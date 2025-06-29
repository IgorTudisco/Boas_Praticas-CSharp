﻿using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

internal class LeitorDeArquivo
{
    public List<Pet> RealizaLeitura(string caminhoDoArquivoASerLido)
    {
        List<Pet> listaDePets = new List<Pet>();
        using (StreamReader sr = new StreamReader(caminhoDoArquivoASerLido))
        {
            System.Console.WriteLine("----- Serão importados os dados abaixo -----");
            while (!sr.EndOfStream)
            {
                // separa linha usando ponto e vírgula
                string[] propriedades = sr.ReadLine().Split(';');
                // cria objeto Pet a partir da separação
                Pet pet = new Pet(Guid.Parse(propriedades[0]),
                propriedades[1],
                TipoPet.Cachorro
                );
                listaDePets.Add(pet);
            }
        }
        
        return listaDePets;
    }
}

/*
 * Documentação de diretrizes para coleções:
 * https://learn.microsoft.com/pt-br/dotnet/standard/design-guidelines/guidelines-for-collections
 */
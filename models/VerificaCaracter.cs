using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Gupy.models
{
    public class VerificaCaracter
    {
        public string Texto { get; private set; }
    public char Caracter { get; private set; }

    public VerificaCaracter(string texto, char caracter)
    {
        Texto = texto;
        Caracter = char.ToLower(caracter);
    }

    public bool VerificarExistencia()
    {
        return Texto.ToLower().Contains(Caracter);
    }

    public int ContarOcorrencias()
    {
        int contador = 0;
        foreach (char c in Texto.ToLower())
        {
            if (c == Caracter)
            {
                contador++;
            }
        }
        return contador;
    }

    public void ExibirResultado()
    {
        if (VerificarExistencia())
        {
            int ocorrencias = ContarOcorrencias();
            Console.WriteLine($"O caractere '{Caracter}' aparece {ocorrencias} vezes na string.");
        }
        else
        {
            Console.WriteLine($"O caractere '{Caracter}' não foi encontrado na string.");
        }
    }
    }
}
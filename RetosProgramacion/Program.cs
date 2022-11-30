using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Enunciado: Crea un función que reciba un texto y retorne la cantidad de vocales.
        // Si no hay vocales podrá devolver vacío.
        Console.WriteLine("Hello World");
        List<char> lista_vocales = new List<char>{ 'a','e','i','o','u' };
        var contadorVocales = 0;

        string texto = "palabra";
        string RetornarVocalRepetida(string texto)
            {
            foreach (var letra in texto)
            {
                for (int i = 0; i < lista_vocales.Count; i++)
                {
                    if(letra == lista_vocales[i])
                    {
                        contadorVocales+=1;
                    };
                };
            };
            return $"La cantidad de vocales es: ({contadorVocales})";
            }
        Console.WriteLine(RetornarVocalRepetida(texto));
    }
}
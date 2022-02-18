using System;

namespace Prova3ExerciciosAcademiadoProgramador.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis

            int nRepetido = 0;
            int nDiferente = 0;
            int[] numeros = new int[] { 7, 7, 7, 3, 3, 4 };

            #endregion

            #region For de Verificar quantas vezes apareceu

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int k = 0; k < nDiferente; k++)
                {
                    if (numeros[k] == numeros[i])
                    {
                        nRepetido = 1;
                    }
                }

                if (nRepetido == 0)
                {
                    int somarn = 0;
                    for (int j = i; j < numeros.Length; j++)
                    {
                        if (numeros[j] == numeros[i])
                        {
                            somarn = somarn + 1;
                        }
                    }

                    numeros[nDiferente] = numeros[i];
                    nDiferente = nDiferente + 1;

                    Console.Write("Numero " + numeros[i] + " aparece " + somarn + " vezes");

                    #region Colocar numero em ordem crescente ( aprendi utilizando o google )

                    Array.Sort(numeros);
                    foreach (int p in numeros) Console.WriteLine(p);
                    Console.WriteLine("\n");

                    #endregion

                }
            }

            #endregion

            #region Colocar numero em ordem crescente

            #endregion


        }
    }
}

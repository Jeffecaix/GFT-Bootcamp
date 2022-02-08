using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 5 valores:");
            string[] numeros = Console.ReadLine().Split(' ');
            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]);
            int c = int.Parse(numeros[2]);
            int d = int.Parse(numeros[3]);
            int e = int.Parse(numeros[4]);

            int numeroMaior = 0;
            int numeroMenor = 1;
            int mediaNumero = (a + b + c + d + e) / 5;

            for (int i = 0; i < numeros.Length; i++)
            {

                if(int.Parse(numeros[i]) > numeroMenor)
                {
                    numeroMaior = int.Parse(numeros[i]);                    
                }
                else if (int.Parse(numeros[i]) <= numeroMenor)
                {
                    numeroMenor = int.Parse(numeros[i]);
                }                
            }
                        

            if (a == b && b == c && c == d && d == e)
            {
                Console.WriteLine("Os 5 valores informados são iguais");
            } 
            else
            {
                Console.WriteLine($"Maior número digitado foi: {numeroMaior}.");
                Console.WriteLine($"Menor número digitado foi: {numeroMenor}.");
                Console.WriteLine($"E a media dos 5 valores informados é: {mediaNumero}");
            }
        }
    }
}

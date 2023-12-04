using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            // Calcula o número de horas
            var hours = timeInSeconds / 3600;

            // Calcula o número de minutos restantes
            var minutes = (timeInSeconds % 3600) / 60;

            // Calcula o número de segundos restantes
            var seconds = timeInSeconds % 60;

            // Imprime o resultado
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
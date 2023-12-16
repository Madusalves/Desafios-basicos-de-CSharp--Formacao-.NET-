using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Escreva um programa que receba um número de um usuário e calcule a soma dos seus dígitos.

namespace Desafio 7
{
    public class Usuario
    {
        // Variavel
        int numero, digito, soma = 0;
        Console.WriteLine("Digite um numero");
        numero = Convert.ToInt32(Console.ReadLine());

        while (numero > 0)
        {
            digito = numero % 10;
            soma += digito;
            numero /= 10;
        }

        //Imprimir
        Console.WriteLine("A soma é: {0}, soma");
    }
}
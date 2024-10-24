/* Escreva um programa que leia o lado de um quadrado e 
imprima o seu perímetro, área e diagonal.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double perimetro, area, diagonal, lado;

            Console.WriteLine("Insira o valor referente ao lado do quadrado: ");
            lado = double.Parse(Console.ReadLine());

            perimetro = lado * 4;
            area = lado * lado;
            diagonal = lado * Math.Sqrt(2);

            Console.WriteLine($"\nO perímetro do quadrado é: {perimetro}");
            Console.WriteLine($"A área do quadrado é: {area}");
            Console.WriteLine($"A diagonal do quadrado é: {diagonal:F1}");
            Console.ReadLine();
        }
    }
}
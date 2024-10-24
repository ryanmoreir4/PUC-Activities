/* Escreva um programa que leia a base e a altura de um retângulo
e imprima o seu perímetro, área e diagonal.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double perimetro, area, diagonal;

        Console.Write("Insira o valor referente a base do triângulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Insira o valor referente a altura do triângulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        perimetro = 2 * (baseTriangulo + alturaTriangulo);
        area = baseTriangulo * alturaTriangulo;
        diagonal = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));

        Console.WriteLine($"O perímetro do triângulo é: {perimetro}");
        Console.WriteLine($"A área do triângulo é: {area}");
        Console.WriteLine($"A diagonal do triângulo é: {diagonal}");

    }
}
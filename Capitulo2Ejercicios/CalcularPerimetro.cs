using System;

namespace Capitulo2Ejercicios
{
    class CalcularPerimetro
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule el perimetro de cualquier poligono regular (Ejercicio 1)
            int numeroLados = 0;
            float longitudLado = 0.0f;
            Console.WriteLine("Calculador del perimetro de una figuras poligonas regulares");
            Console.WriteLine("Escriba el numero de lados de la figura");
            numeroLados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la longitud de los lados");
            longitudLado = Convert.ToSingle(Console.ReadLine());
            float resultadoPerimetro = numeroLados * longitudLado;
            Console.WriteLine("El resultado es {0}", resultadoPerimetro);

          




        }
    }
}

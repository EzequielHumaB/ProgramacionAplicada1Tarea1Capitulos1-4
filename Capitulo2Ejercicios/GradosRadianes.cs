using System;

namespace GradoaRadianesConvertor
{
   public class GradosRadianes
    {
        static void Main(string[] args)
        {
            //Convertir de grados a radianes
            float grados = 0.0f;
            Console.WriteLine("Convertor de grados a radianes");
            Console.WriteLine("Ingrese los grados");
            grados =Convert.ToSingle(Console.ReadLine());
            float resultado = grados / 180;
            Console.WriteLine("El equivalente en de {0} grados en radianes es {1}", grados,resultado);

        }
    }
}

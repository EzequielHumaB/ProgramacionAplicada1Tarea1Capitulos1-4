using System;

namespace ParoImpar
{
    class ParOImparnumero
    {
        static void Main(string[] args)
        {
            //Verificar si un numero es impar
            int numero = 1;
            Console.WriteLine("Escriba un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero  % 2 == 0)
            {
                Console.WriteLine("El numero {0} es par", numero);
            } else
            {
                Console.WriteLine("El numero {0} es impar", numero);
            }
        }
    }
}

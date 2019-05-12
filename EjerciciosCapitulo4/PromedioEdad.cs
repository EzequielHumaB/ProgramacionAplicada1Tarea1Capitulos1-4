using System;

namespace PromedioEdad
{
    class PromedioEdad
    {
        static void Main(string[] args)
        {
            int numeroPersonas = 0;
            int mayor = 0;
            int Edad = 0;
            int menor = 1000;
            int promedio = 0;
            Console.WriteLine("Escribe el numero de personas");
            numeroPersonas = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=numeroPersonas; i++)
            {
                Console.WriteLine("Escribe el nombre de la persona {0}", i);
                Edad = Convert.ToInt32(Console.ReadLine());
               
                promedio += Edad;
                if (Edad>mayor)
                {
                    mayor = Edad;
                }

                if (menor>Edad)
                {
                    menor = Edad;
                    
                }
                
            }
            Console.WriteLine("Promedio = {0}",promedio/numeroPersonas);
            Console.WriteLine("La edad mayor es: {0}", mayor);
            Console.WriteLine("La edad menor es: {0}", menor);


        }
    }
}

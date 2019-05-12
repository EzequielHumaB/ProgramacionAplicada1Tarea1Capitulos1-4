using System;

namespace ElevarNumero
{
    class ElevarNumero
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int exponente = 0;
            
            Console.WriteLine("Escriba un numero para elevar");
            numero = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;
            Console.WriteLine("Escriba el exponente");
            exponente = Convert.ToInt32(Console.ReadLine());
            for(int i  = 0; i<exponente; i++)
            {
                resultado *=numero;
                
            }
            Console.WriteLine("La potencia es {0}" ,resultado);

        }
    }
}

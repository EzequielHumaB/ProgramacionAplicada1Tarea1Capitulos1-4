using System;

namespace TablaMultiplicacion
{
    class TablaMultiplicar
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Escriba un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            int resultado;
            for (int i = 1; i<=10; i++)
            {
                resultado = i * numero;
                Console.WriteLine("{0} * {1} = {2}", numero,i,resultado);
            }


        }
    }
}

using System;

namespace Dia1_7
{
    class Dias1al7
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Escriba un numero del 1 al 7");
            numero = Convert.ToByte(Console.ReadLine());
            if (numero>0 && numero<=7)
            {
                switch(numero)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                }
            } else
            {
                Console.WriteLine("Numero invalido");
            }
        }
    }
}

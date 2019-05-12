using System;

namespace DolaresaEurosyViceversa
{
    class ConvertorEuroDolar
    {
        static void Main(string[] args)
        {
            double dolar = 0.0f;
            double euro = 0.0f;
            double resultado = 0.0d;

            byte i = 0;
            Console.WriteLine("Convertor de dolares y euros");
            Console.WriteLine("1. Convertir de dolares a euros");
            Console.WriteLine("2. Convertir de euros a dolaress");
            i = Convert.ToByte(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("Escriba la cantidad en dolares");
                dolar = Convert.ToDouble(Console.ReadLine());
                resultado = dolar * 1.10;
                Console.WriteLine("El equivalente de {0} dolares en euros es {1}", dolar,resultado);
;            } 

            if (i==2)
            {
                Console.WriteLine("Escriba la cantidad en euros");
                euro = Convert.ToDouble(Console.ReadLine());
                resultado = euro * 0.10;
                Console.WriteLine("El equivalente de {0} euros en dolares es {1}", euro, resultado);

            }

            Console.WriteLine("Convertor de dolares a euros y viceversa");
           
        }
    }
}

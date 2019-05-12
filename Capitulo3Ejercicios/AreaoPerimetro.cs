using System;


namespace areaOperimetro
{
    class AreaoPerimetro
    {
        static void Main(string[] args)
        {
            byte opcion = 0;
            int numeroLados = 0;
           
            float longitudLado = 0.0f;
            float radio = 0.0f;
            Console.WriteLine("Calculadora de area y perimetro de un poligono regular");
            Console.WriteLine("Eliga una opcion");
            Console.Write("1.Area \n2.Perimetro \n");
            opcion = Convert.ToByte(Console.ReadLine());
            if (opcion==1)
            {
                Console.WriteLine("Escriba los numeros de lados de la figura");
                numeroLados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba la longitud de los lados");
                longitudLado = Convert.ToSingle(Console.ReadLine());
                float area = numeroLados * longitudLado;
                Console.WriteLine("EL area es {0}", area);
            } else if(opcion==2)
            {
                Console.WriteLine("Escriba los numeros de lados de la figura");
                numeroLados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba la longitud de los lados");

                longitudLado = Convert.ToSingle(Console.ReadLine());
                float Perimetro = numeroLados * longitudLado;
                Console.WriteLine("EL area es {0}", Perimetro);
                

            }
            else
            {
                Console.WriteLine("Numero invalido");
            }


        }
    }
}

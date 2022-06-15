using System;

namespace _45_NumeroCorrespondienteADiasDeSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Ingrese un numero de 1 a 7 para mostrar el nombre del dia o ingrese 0 para cerrar:");

            a = Convert.ToInt32(Console.ReadLine());


            while (a < 0 || a > 7)
            {
                Console.WriteLine("Valor fuera de rango, re-ingrese:");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a != 0)
            {
                

                if (a == 1)
                {
                    Console.WriteLine("Es lunes");
                }
                
                if (a == 2)
                {
                    Console.WriteLine("Es martes");
                }
                
                if (a == 3)
                {
                    Console.WriteLine("Es Miercoles");
                }
                
                if (a == 4)
                {
                    Console.WriteLine("Es jueves");
                }
                
                if (a == 5)
                {
                    Console.WriteLine("Es viernes");
                }
                
                if (a == 6)
                {
                    Console.WriteLine("Es sabado");
                }
                
                if (a == 7)
                {
                    Console.WriteLine("Es domingo");
                }
                a = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.ReadKey();
           
        }
    }
}

using System;


namespace costo_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1, p2, p3, p4, promedio;
            string entrada1, entrada2, entrada3, entrada4, entrada5;

            Console.WriteLine("nombre del alumno:");
            entrada1 = Console.ReadLine();

            Console.WriteLine("ingrese calificacion del parcial 1");
            entrada2 = Console.ReadLine();

            Console.WriteLine("ingrese calificacion del parcial 2");
            entrada3 = Console.ReadLine();

            Console.WriteLine("ingrese calificacion del parcial 3");
            entrada4 = Console.ReadLine();

            Console.WriteLine("ingrese calificacion del parcial 4");
            entrada5 = Console.ReadLine();

            p1 = Convert.ToInt32(entrada2);
            p2 = Convert.ToInt32(entrada3);
            p3 = Convert.ToInt32(entrada4);
            p4 = Convert.ToInt32(entrada5);

            promedio = (p1 + p2 + p3 + p4) / 4;

            Console.WriteLine("nombe: {0}", entrada1);
            Console.Read();

            Console.WriteLine("su promedio es: {0}", promedio);
            Console.Read();

            if (promedio >= 7)
            {
                Console.WriteLine("aprobado");
                Console.Read();
            }
            else
            {
                Console.WriteLine("reprobado");
                Console.Read();
            }


        }
    }
}

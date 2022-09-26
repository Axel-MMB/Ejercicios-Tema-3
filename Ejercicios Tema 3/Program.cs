using System;

namespace Ejercicios_Tema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = suma(3, 4, 5);
            Console.WriteLine(total);
            Console.ReadKey();
            int suma(int numero1, int numero2, int numero3)
            {
                return numero1 + numero2 + numero3;
            }

            Coche miCoche = new Coche();
            miCoche.incremetarPuertas();
            Console.WriteLine(miCoche.numeroPuertas);
            Console.ReadKey();
        }

        class Coche
        {
            public int numeroPuertas = 0;
            public void incremetarPuertas()
            {
                this.numeroPuertas++;

            }
        }
    }
}

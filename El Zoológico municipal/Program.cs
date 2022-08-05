using System;

namespace El_Zoológico_municipal
{
    class Program
    {
        static void Main(string[] args)
        {
           

               Console.WriteLine("Ingrese el numero de animales");
               int num_animales = int.Parse(Console.ReadLine());

                string[] nombre = new string[num_animales];
                string[] pais = new string[num_animales];
                string[] especie = new string[num_animales];
                string v1, v2, v3;

                for (int x = 0; x <= num_animales-1; x++)
                {
                    Console.WriteLine("Nombre del animal");
                    v1 = Console.ReadLine();
                    nombre[x] = v1;

                    Console.WriteLine("Pais de Origen");
                    v2 = Console.ReadLine();
                    pais[x] = v2;

                    Console.WriteLine("Especie");
                    v3 = Console.ReadLine();
                    especie[x] = v3;

                }

                Console.WriteLine("Total de animales: " + num_animales);

                for (int i = 0; i <= num_animales - 1; i++)
                    { Console.WriteLine("\n\nNombre del animal: " + nombre[i] + "  Pais de origen: " + pais[i] + "  Especie: " + especie[i] ); }
        }
    }
}

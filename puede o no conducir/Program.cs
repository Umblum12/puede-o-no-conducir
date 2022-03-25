using System;

namespace puede_o_no_conducir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un veiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿Tienes carnet?");
            string carnet = Console.ReadLine();

            if (edad <= 17)
            {
                Console.WriteLine("No puedes conducir chamaco pendejo");
            }


            if (edad >=18 && carnet=="si")
            {
                Console.WriteLine("Puedes conducir vehiculos");
            }
            else 
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }
        }
    }
}

using System;

namespace POOUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intancion de un objeto con el contructor por defecto
            Persona persona = new Persona();

            persona.Cedula = "001-200798100V";
            persona.Nombres = "Josiel Antonio";
            persona.Apellidos = "Castillo Valle";
            persona.Edad = 20;
            persona.Peso = 120.5;
            persona.EsEstudiante = true;

            //Intancion de un objeto con el contructor por parametros
            Persona persona1 = new Persona("002-146845-456123", "Pedro Pablo", "Ruiz Peralta", 50, 150, false);


            Console.WriteLine(persona.Nombres);
            persona.Estudiar();

            Console.WriteLine(persona1.Nombres);
            persona1.Estudiar();

            Console.ReadKey();
        }
    }
}

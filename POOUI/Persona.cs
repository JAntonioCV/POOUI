using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUI
{
    //Clase o Plantilla
    public class Persona
    {
        //Caracteristicas o Atributos
        public string Cedula;
        public string Nombres;
        public string Apellidos;
        public int Edad;
        public double Peso;
        public bool EsEstudiante;

        //Constructor por Defecto
        public Persona()
        {

        }

        //Contrustor con parametros
        public Persona(string Cedula, string Nombres, string Apellidos, int Edad, double Peso, bool EsEstudiante)
        {
            this.Cedula = Cedula;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Peso = Peso;
            this.EsEstudiante = EsEstudiante;
        }

        //Comportamientos o Metodos
        public void Estudiar()
        {
            Console.WriteLine("La Persona {0} esta Estudiando", Nombres);
        }
    }
}

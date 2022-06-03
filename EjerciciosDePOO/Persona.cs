using System;

namespace EjerciciosDePOO
{
    class Persona
    {
        private string nombre;
        public int edad;
        private int dni;

        public Persona()
        {

        }

        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        private string GetNombre()
        {
            return this.nombre;
        }

        public int GetEdad()
        {
            return this.edad;
        }

        private int GetDni()
        {
            return this.dni;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {this.GetNombre()}");
            Console.WriteLine($"Edad: {this.GetEdad()}");
            Console.WriteLine($"DNI: {this.GetDni()}\n");
        }

        public bool EsMayorDeEdad()
        {
            return GetEdad() >= 18;
        }
    }
}

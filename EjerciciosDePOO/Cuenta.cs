using System;

namespace EjerciciosDePOO
{
    class Cuenta
    {
        private Persona titular;
        private double dinero;

        public Cuenta()
        {

        }

        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }

        public Cuenta(Persona titular, double dinero)
        {
            this.titular = titular;
            this.dinero = dinero;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Titular:");
            titular.Mostrar();
            Console.WriteLine("Dinero:");
            Console.WriteLine($"{this.dinero}\n");
        }

        public virtual double Ingresar(double ingresos)
        {
            return this.dinero += ingresos;
        }

        public virtual double Retirar(double retirar)
        {
            return this.dinero -= retirar;
        }
    }
}

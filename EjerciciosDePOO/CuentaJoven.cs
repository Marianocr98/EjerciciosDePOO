using System;

namespace EjerciciosDePOO
{
    class CuentaJoven : Cuenta
    {
        public Persona titularCuentaJoven;
        private double dineroCuentaJoven;
        private double bonificacion;

        public CuentaJoven()
        {

        }

        public CuentaJoven(Persona titularCuentaJoven)
        {
            this.titularCuentaJoven = titularCuentaJoven;
        }
        public CuentaJoven(Persona titularCuentaJoven, double dineroCuentaJoven)
        {
            this.titularCuentaJoven = titularCuentaJoven;
            this.dineroCuentaJoven = dineroCuentaJoven;
        }

        private bool EsTitularValido()
        {
            return this.titularCuentaJoven.EsMayorDeEdad() && this.titularCuentaJoven.edad < 25;
        }

        public override double Ingresar(double ingresos)
        {
            return this.dineroCuentaJoven += ingresos;
        }

        public override double Retirar(double retirar)
        {
            this.bonificacion = 0.07;
            double diner = this.dineroCuentaJoven;
            if (EsTitularValido())
            {
                return this.dineroCuentaJoven = this.dineroCuentaJoven - retirar + (retirar * bonificacion);
            }
            return diner;
        }

        public override void Mostrar()
        {
            Console.WriteLine("Cuenta Joven");
            Console.WriteLine($"{this.dineroCuentaJoven}\n");
        }
    }
}

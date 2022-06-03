namespace EjerciciosDePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mariano", 23, 41283249);
            Persona persona2 = new Persona("CR7", 22, 41283249);

            Cuenta cuenta1 = new Cuenta(persona2);
            cuenta1.Ingresar(1000);
            cuenta1.Retirar(500);
            cuenta1.Mostrar();

            CuentaJoven cuenta01 = new CuentaJoven(persona2);
            cuenta01.Ingresar(100);
            cuenta01.Retirar(50);
            cuenta01.Mostrar();
        }
    }
}

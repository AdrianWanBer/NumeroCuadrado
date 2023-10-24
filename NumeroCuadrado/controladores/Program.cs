using NumeroCuadrado.servicios;

namespace NumeroCuadrado
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuYNumeroInterfaz myn = new MenuYNumeroImplementacion();
            int numeroInt = myn.MenuYNum();

            int numeroCuadrado = Convert.ToInt32(Math.Sqrt(numeroInt));
            int operacion = numeroCuadrado * numeroCuadrado;
           

            if (operacion==numeroInt)
            {
                Console.WriteLine("El numero que elevado al cuadrado da " + numeroInt + " es: " + numeroCuadrado);
            }
            else
            {
                Console.WriteLine("No tiene numero que elevado al cuadrado de: " + numeroInt);
            }
        }
    }
}
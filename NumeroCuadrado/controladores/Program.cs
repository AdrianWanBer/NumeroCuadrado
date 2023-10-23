using NumeroCuadrado.servicios;

namespace NumeroCuadrado
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuYNumeroInterfaz myn = new MenuYNumeroImplementacion();
            int numeroint = myn.MenuYNum();

            if ((Math.Sqrt(numeroint) % 2)== 0 )
            {
                Console.WriteLine(Math.Sqrt( numeroint ));
            }
            else
            {
                Console.WriteLine("No tiene raiz entera");
            }
        }
    }
}
using NumeroCuadrado.servicios;

namespace NumeroCuadrado
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///<summary>
            ///Llamada a los metodos
            ///<author>241023 - awb</author>
            /// </summary>
            MenuYNumeroInterfaz myn = new MenuYNumeroImplementacion();
            int numeroInt = myn.MenuYNum();
            ///<summary>
            ///Declaracion de variables y operaciones matematicas para saber si tiene numero al un numero que 
            ///elevado al cuadrado de = numeroInt
            /// <author>241023 - awb</author>
            /// </summary>
            int numeroCuadrado = Convert.ToInt32(Math.Sqrt(numeroInt));
            int operacion = numeroCuadrado * numeroCuadrado;

            ///<summary>
            ///"If" que mostrara el mensaje segun el resultado de las operaciones
            /// <author>241023 - awb</author>
            /// </summary>
            if (operacion == numeroInt)
            {
                Console.WriteLine("El numero que elevado al cuadrado da " + numeroInt + " es: " + numeroCuadrado);
            }
            else
            {
                Console.WriteLine("No tiene numero entero que elevado al cuadrado de: " + numeroInt);
            }
        }
    }
}
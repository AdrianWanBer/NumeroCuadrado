namespace NumeroCuadrado.servicios
{
    internal class MenuYNumeroImplementacion : MenuYNumeroInterfaz
    {
        public int MenuYNum()
        {
            ///<summary>
            ///Metodo que se lanzara para solicitar el dato al usuario
            /// <author>241023 - awb</author>
            /// </summary>
            Console.WriteLine("Escriba su numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}

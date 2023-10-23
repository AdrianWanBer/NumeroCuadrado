using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroCuadrado.servicios
{
    internal class MenuYNumeroImplementacion : MenuYNumeroInterfaz
    {
        public int MenuYNum()
        {
            Console.WriteLine("Escriba su numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}

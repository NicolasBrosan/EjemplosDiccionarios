using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDiccionarios
{
    public class OpcionesDeMenu
    {
        public void Ejemplo3()
        {
            //Diccionarios dentro de diccionarios (Carta de Menu)

            Dictionary<string,Dictionary<string, double>> menu = new Dictionary<string,Dictionary<string,double>>();

            menu.Add("Bebidas sin alcohol", new Dictionary<string, double>
            {
                {"Juego de naranja                ", 110},
                {"Coca Cola                       ", 120},
                {"Agua sin Gas                    ", 115},
            });

            menu.Add("Bebidas con alcohol", new Dictionary<string, double>
            {
                {"Whiskey Jhonny Walker blue label", 4000},
                {"Vinos Malbec                    ", 1120},
                {"Cerveza Corona                  ", 270},
            });

            Console.WriteLine("Seccion\t\t\t\t\tProducto\t\t\t\t\tPrecio\n");
            foreach(KeyValuePair<string, Dictionary<string, double>> ordenMenu in menu)
            {
                Console.WriteLine("{0}",ordenMenu.Key);

                foreach(KeyValuePair<string, double> detalleYPrecio in ordenMenu.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", detalleYPrecio.Key, detalleYPrecio.Value);
                }
            }

        }
    }
}

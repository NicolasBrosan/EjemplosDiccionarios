using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDiccionarios
{
    public class DiccionariosDentroDeDiccionarios
    {
        public void Ejemplo2()
        {
            // ejemplo diccionario dentro de un diccionario
            Dictionary<string, Dictionary<string, double>> catalogoPetShop = new Dictionary<string, Dictionary<string, double>>();
            catalogoPetShop.Add("Alimentos para Gatos Adultos", new Dictionary<string, double>
             {
                 {"Cat Chow", 90},
                 {"Whiskas ", 85},
                 {"Pedigree", 95}
             });

            catalogoPetShop.Add("Alimentos para Gatos Cachorros", new Dictionary<string, double>
             {
                 {"Cat Chow", 88},
                 {"Whiskas ", 80},
                 {"Pedigree", 85}
             });

            catalogoPetShop.Add("Alimentos para Perros Adultos", new Dictionary<string, double>
             {
                 {"Dog Chow", 88},
                 {"Pro Plan", 87},
                 {"Pedigree", 100}
             });

            catalogoPetShop.Add("Alimentos para Perros Cachorros", new Dictionary<string, double>
             {
                 {"Dog Chow", 85},
                 {"Pro Plan", 80},
                 {"Pedigree", 95}
             });

            Console.WriteLine("Seccion\t\t\t\t\tProducto\t\tPrecio\n");
            foreach(KeyValuePair<string, Dictionary<string, double>> seccion in catalogoPetShop)
            {
                Console.WriteLine("{0}",seccion.Key);

                foreach(KeyValuePair<string,double> productoYPrecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYPrecio.Key, productoYPrecio.Value);
                }
            }
            
        }
    }
}

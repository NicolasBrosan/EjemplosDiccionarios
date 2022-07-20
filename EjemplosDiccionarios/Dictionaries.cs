using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDiccionarios
{
    public class Dictionaries
    {
        public void Ejemplo()
        {
            //Ejemplo de diccionarios
            Dictionary<string, string> ciudadesXPaises = new Dictionary<string, string>();
            Dictionary<string, string[]> diccionariosConMasDeUnValue = new Dictionary<string, string[]>();
           
            ciudadesXPaises.Add("Buenos Aires", "Argentina");
            ciudadesXPaises.Add("Bogota", "Colombia");
            ciudadesXPaises.Add("Puebla", "Mexico");
            ciudadesXPaises.Add("New York", "Estados Unidos");

            Console.WriteLine("Las ciudades por paises antes del uso de propiedades son: ");
            foreach(KeyValuePair<string, string> ciudadYPais in ciudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ciudadYPais.Key, ciudadYPais.Value);
            }

            ciudadesXPaises.Remove("Buenos Aires");
            ciudadesXPaises["Lima"] = "Peru";

            Console.WriteLine("\nLas ciudades por paises despues del uso de propiedades son: ");
            foreach(KeyValuePair<string, string> ciudadYPais in ciudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ciudadYPais.Key, ciudadYPais.Value);
            }
        }
        




    }
}

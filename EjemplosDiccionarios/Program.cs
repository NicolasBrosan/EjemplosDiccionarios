using EjemplosDiccionarios;
Dictionaries diccionarios = new Dictionaries();
var presentacion1="### Primer ejemplo con diccionarios ###\n";
Console.WriteLine(presentacion1.ToUpper());
diccionarios.Ejemplo();

var presentacion2 = "\n\n### Segundo ejemplo. Diccionario dentro de Diccionario ###\n\n";
Console.WriteLine(presentacion2.ToUpper());

DiccionariosDentroDeDiccionarios nuevoDiccionario = new DiccionariosDentroDeDiccionarios();
nuevoDiccionario.Ejemplo2();

var presentacion3 = "\n\n### Tercer ejemplo. Diccionario dentro de Diccionario (Menu) ###\n\n";
Console.WriteLine(presentacion3.ToUpper());

OpcionesDeMenu cartaMenu = new OpcionesDeMenu();
cartaMenu.Ejemplo3();
//DECLARACION IMPLICITA DE VARIABLES

//fuertemente tipado = cuando tiene un tipo de dato y solo se puede añadir datos de ese tipo
//    ej, si tengo una variable int no le puedo asignar un string o null

//si usamos la palabra reservada var automaticamente crea una variable segun el dato que se le otorgue
// no confundir el var de c# con el de javascript ya que aqui en c# es fuertemente tipado.

// se debe colocar un valor al declararlo y no pude ser null,
// recomendable en LINQ porque el query resultado puede ser dinamico.

var a = 5; // int32
var b = "fesf"; //string
var c = 13.5; // double

//usamos reflexion para saber el tipo
Console.WriteLine(a.GetType().Name);
Console.WriteLine(b.GetType().Name);
Console.WriteLine(c.GetType().Name);


//valores nulleables
int? dato = 5;
Console.WriteLine("dato {0}", dato);


int? datoNull = null;
Console.WriteLine("dato {0}", datoNull);


// el string no es nulleable .. porque ya es un tipo por referencia
string? nombre = "KEvin";
nombre = null;
Console.WriteLine(nombre);


//saber si tiene valor o no
double? precio = null;
precio = 23.4;
if (precio.HasValue) Console.WriteLine("Tiene valor");

// operador ?? nos permite asignar un valor en caso que tenga null, caso contrario asigna el valor de la derecha
double? numero = asignador() ?? 5.55;
Console.WriteLine(numero);

static double? asignador()
{
    //return 3.33;
    return null;
}

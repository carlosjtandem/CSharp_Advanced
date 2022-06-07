using System.Collections.Generic;

int x = 5;
int y = 3;

Console.WriteLine("x= {0} , y={1} ",x,y);
Intercambio<int>(ref x, ref y);
Console.WriteLine("x= {0} , y={1} ", x, y);

// T no sabemos que tipo de datos vendra por eso usamos un tipo generico T
static void Intercambio<T>(ref T a, ref T b)
{
    T temporal;
    temporal = a;
    a = b;
    b = temporal;
}


// Ahora usaremos la misma funcion con tipo dobles
double n = 34.5;
double m = 15.5;

Console.WriteLine("n= {0} , m={1} ", n, m);
Intercambio<double>(ref n, ref m);
Console.WriteLine("n= {0} , m={1} ", n, m);

// Ahora usaremos la misma funcion con tipo string
string o = "Carlos";
string p = "Javier";

Console.WriteLine("o= {0} , p={1} ", o, p);
Intercambio<string>(ref o, ref p);
Console.WriteLine("o= {0} , p={1} ", o, p);


//lo mismo podremos hacer con nuestros propios clases.

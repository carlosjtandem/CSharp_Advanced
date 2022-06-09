using System;
using System.Collections.Generic;

//Handle para string
static void HandlerString(string valor)
{
    Console.WriteLine("uso string como tipo y el valor es:{0}", valor);
}

static void HandlerDouble(double valor)
{
    Console.WriteLine("uso double como tipo y el valor es:{0}", valor);
}

//REgistro y usamos string
miDelegado<string> deCadena = new miDelegado<string>(HandlerString);
deCadena("Hola carlos");

//Registramos y usamos doble
miDelegado<double> deDouble = new miDelegado<double>(HandlerDouble);
deDouble(45.7);


public delegate void miDelegado<T>(T p);


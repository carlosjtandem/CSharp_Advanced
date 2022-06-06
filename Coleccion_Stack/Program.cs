using System.Collections;

//Stack es una coleccion tipo LIFO

Stack miStack= new Stack();
miStack.Push("Manzana");
miStack.Push("banano");
miStack.Push("pera");
miStack.Push("mandarina");


//iteramos el stack
foreach (string fruta in miStack)
{
    Console.WriteLine("{0}",fruta);
}

//pop.. obtener un elemento del stack -- lo saca del stack si imprimos nuevamente entonces ya no esta ese elemento
Console.WriteLine("El primer elemento del stack es:"+miStack.Pop());
foreach (string fruta in miStack)
{
    Console.WriteLine("{0}", fruta);
}

//peek.. obtener un elemento del stack -- NO lo saca del stack SOLO lo muestra
Console.WriteLine("El primer elemento del stack es:" + miStack.Peek());
foreach (string fruta in miStack)
{
    Console.WriteLine("{0}", fruta);
}
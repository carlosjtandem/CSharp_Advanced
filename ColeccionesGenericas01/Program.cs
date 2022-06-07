using ColeccionesGenericas01;
using System.Collections.Generic;

List<int> valores = new List<int>();
int n=0;
int r = 0;

valores.Add(5);
valores.Add(11);
valores.Add(43);
valores.Add(2);
valores.Add(53);
valores.Add(2);

//REcorremos con un ciclo FOR
for (int i = 0; i < valores.Count; i++)
{
    Console.WriteLine("valor {0} es:{1}",i, valores[i]);
}

//Veamos si contiene un determinado elemento
Console.WriteLine(valores.Contains(11));

// Obtner el indice de un elemento
Console.WriteLine(valores.IndexOf(43));  // salida 2

//insertammos elemento en un indice 
valores.Insert(1, 332);

Console.WriteLine("---------------");

foreach (var item in valores)
{
    Console.WriteLine(item);
}

//eliminar un elemento en un indice
Console.WriteLine("---------------");
valores.RemoveAt(2);

//eliminar la primera ocurrencia de un valor
valores.Remove(2);
foreach (var item in valores)
{
    Console.WriteLine(item);
}

//coloca la lista en sentido contrario
valores.Reverse();

//ordenar un lista SORT
Console.WriteLine("---------------");
valores.Sort();
foreach (var item in valores)
{
    Console.WriteLine(item);
}

//Sort con letras
List<string> valoresTexto = new List<string>();
valoresTexto.Add("carlos");
valoresTexto.Add("tomas");
valoresTexto.Add("andres");
valoresTexto.Sort();
Console.WriteLine("---------------");
foreach (var item in valoresTexto)
{
    Console.WriteLine(item);
}

//////////////////////////************** con clase Punto
///
Console.WriteLine("---------------");
Console.WriteLine("---- CLASES -------");


List<Punto> listaPuntos = new List<Punto>();
listaPuntos.Add(new Punto(5, 3));
listaPuntos.Add(new Punto(2, 9));
listaPuntos.Add(new Punto(1, 23));
listaPuntos.Add(new Punto(5, 33));

foreach (Punto punto in listaPuntos)
{
    Console.WriteLine(punto);
}

listaPuntos.Sort();  // ESTO DA ERROR porque la clase Punto no implementa iComparable


// otra forma de crear la lista (sin add)

List<Punto> listaPuntos2 = new List<Punto>{
   new Punto(2,5),
   new Punto(5,2),
   new Punto(3,1),

};

//insertamos un punto en el indice 2
listaPuntos2.Insert(1,new Punto(2,5));

//Copiamos de una lista a arreglo
Punto[] arregloPuntos = listaPuntos2.ToArray();

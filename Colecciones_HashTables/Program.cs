// See https://aka.ms/new-console-template for more information

using System.Collections;

Hashtable miTabla = new Hashtable();

//add elements
miTabla.Add(123, "Hola");
miTabla.Add(155, "CArlos");
miTabla.Add(5, "como ");
miTabla.Add(645, "estás?");

foreach (DictionaryEntry item in miTabla)
{
    Console.WriteLine("({0},{1})", item.Key, item.Value);
}

//Intentamos crear un elemento con una llave ya definida
//miTabla.Add(123, "Hola ffdfd ");  // esto da una excepcion

//Cantidad de elementos
Console.WriteLine(miTabla.Count);

// Acceder a un elemento por su llave
Console.WriteLine(miTabla[155]);  // imprime CArlos
Console.WriteLine(miTabla[444]);  // no imprime nada, imprime un espacio en blanco


// Añadir un elemento a una llave existente --- reemplaza el valor anterior
miTabla[155]="Javier";  // imprime CArlos
miTabla[156] = "nuevo valor";  // si no existe el indice lo crea

foreach (DictionaryEntry item in miTabla)
{
    Console.WriteLine("({0},{1})", item.Key, item.Value);
}

//valida si existe un valor por la llave .. devuelve true o false
miTabla.Contains(155);

//eliminar un elemento
miTabla.Remove(155);

foreach (var llave in miTabla.Keys)
{
    Console.WriteLine(llave);
}
Console.WriteLine("----");

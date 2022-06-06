using System.Collections;

// es una lista que tiene llave y valor y automaticamente la ordena

    SortedList miSLista=new SortedList();
//adicion de elementos

miSLista.Add(458, "onda");
miSLista.Add(218, "Volvo");
miSLista.Add(38, "Nissan");
miSLista.Add(758, "Fiat");

//iteramos  y vemos q esta ordenada por la llave ascendentemente  
foreach (DictionaryEntry elemento in miSLista)
{
    Console.WriteLine("{0},{1}", elemento.Key, elemento.Value);
}

//cantidad de elementos
Console.WriteLine(miSLista.Count);

//contiene elemento
Console.WriteLine(miSLista.Contains(128));
Console.WriteLine(miSLista.Contains(218));

Console.WriteLine("+++++");
Console.WriteLine(miSLista.ContainsKey(128));
Console.WriteLine(miSLista.ContainsValue("Volvo"));




// es como un metodo anonimo
// is a shorter way of representing annonymous method using some especial syntax

List<int> numeros = new List<int>();
numeros.AddRange(new int[] { 2, 4, 5, 6, 7, 8, 9, 22, 34, 33, 55 });

// hacemos uso de findAll
List<int> numerosPares = numeros.FindAll(i => (i % 2) == 0);

//impresion
foreach (int item in numerosPares)
{
    Console.WriteLine(item);
}
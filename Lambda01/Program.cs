// PREDICADO -- es un delegado generico
// va a definir un criterio y dice si cumple o no con el criterio
//public List<T> FindAll(Predicate<T> match) recorre los elementos de la lista
//y los pasa como parametro al delegaod, si este regresa true los pne en la lista de retorno
// hay varios metodos que hacen uso del predicado como remove, find,etc

List<int> numeros = new List<int>();
numeros.AddRange(new int[] { 2, 4, 5, 6, 7, 8, 9, 22, 34, 33, 55 });

//Indicamos el delegado
Predicate<int> delegado = new Predicate<int>(Rango);
//Predicate<int> delegado = new Predicate<int>(Pares);


//Invocamos el metodo
List<int> numPares = numeros.FindAll(delegado);

//Mostramos
foreach (int item in numPares)
{
    Console.WriteLine(item);
}


static bool Pares(int n)
{
    if (n % 2 == 0) return true;
    else return false;
}

static bool Rango(int n)
{
    if (n > 2 && n < 18) return true;
    else return false;
}


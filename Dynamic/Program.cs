
//Dynamic se puede ver como una forma de System.Object
//no es fuertemente tipado
//cualquier valor se puede asignar a dinamic
//sim primero le asigno un string, despues le puedo cambiar a int, y despues a otro

dynamic a = 5;
Console.WriteLine("valor {0} es {1}",a, a.GetType());

a = "Hola";
Console.WriteLine("Ahora valor {0} es {1}", a, a.GetType());

// no puede ser utilizado en expresiones lambda
//dynamic se puede usar como tipo de retorno
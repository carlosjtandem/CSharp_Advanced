int x = 5;
int y = 6;

// Func se usa para crear delegados en el momento 
//Func se usa con handler que tienen un tipo de retorno
//La diferencia con Action es que Action devuelve void
//Func permite retornar un delegado con un tipo de valor especifico
//    el ultimo parametro corresponde al tipo de dato retornado


//metodo handler para Func
static int Suma(int a, int b)
{
    int r = 0;
    r = a + b;
    return r;
}

//MAIN
// nuestro delegado tiene 3 parametros porque son dos de la funcion suma y el ultimo es el retorno
Func<int, int, int> delFunc = new Func<int, int, int>(Suma);
Console.WriteLine(delFunc(x, y));
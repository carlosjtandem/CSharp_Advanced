// Parametros POR VALOR cuando pasamos variables a un metodo.
// Mandamos una copa del valor de esa variable al metodo, si modificamos el valor en le metodo
// entonces la variable original no se modificara

int valorActual = 10;
ActualizaValor(valorActual);
Console.WriteLine("Valor(original) despues del ejecutar el metodo es:{0}", valorActual);

void ActualizaValor(int valor)
{
    valor += 5;
    Console.WriteLine("Valor actualizado es:{0}", valor);
}

//Por referencia out, ref, in
// no se manda una copia del parametro sino que se envia la direccion de memoria de la variable.
// eso quiere decir que se modifica fuera del metodo
// REF ... ese parametro va a cambiar de valor dentro del metodo
// OUT ... es cuando deseamos inicializar el valor de una variable dentro de un metodo.(previamente debe ser null la variable)
// IN .. es cuando deseamos inicializar afuera del metodo, es decir bloquea la modificacion dentro del metodo

//REF -- se defe usar ref en la llamada y en el metodo
Console.WriteLine("****** REF *******");
ActualizaValorREF(ref valorActual);
Console.WriteLine("Valor(original) despues del ejecutar el metodo es:{0}", valorActual);

void ActualizaValorREF(ref int valor)
{
    valor += 5;
    Console.WriteLine("Valor actualizado en metodo es:{0}", valor);
}

//OUT -- se defe usar out en la llamada y en el metodo
Console.WriteLine("******* out ******");

//int valorActualTest = 10; // no debe iniciarlizrlo porq o hare dentro del metodo
int valorActualTest;
ActualizaValorOUT(out valorActualTest);
Console.WriteLine("Valor(original) despues del ejecutar el metodo es:{0}", valorActualTest);

void ActualizaValorOUT(out int valor)
{
    valor = 77;
    Console.WriteLine("Valor inicializado en el metodo es:{0}", valor);
}


//IN -- se deBe usar in en la llamada y en el metodo
Console.WriteLine("****** in *****");

int valorActualTest1 = 5;
ActualizaValorIN(in valorActualTest1);
Console.WriteLine("Valor(original) despues del ejecutar el metodo es:{0}", valorActualTest1);

void ActualizaValorIN(in int valor)
{
    //valor = 77; // DA error .. porque la variable la toma como REadOnly
    Console.WriteLine("Valor inicializado en el metodo es:{0}", valor);
}


//CASO ESPECIAL CON OBJETOS
// funciona como REF.. pero no es necesario escribir ref
Console.WriteLine("****** CON OBJETOS - REF *****");
ObjEjemplo obj = new ObjEjemplo(10);

ActualizarObj(obj);
Console.WriteLine("Valor actualizado es:{0}", obj.Entero);


void ActualizarObj(ObjEjemplo obj)
{
    obj.Entero = 12;
}
class ObjEjemplo
{
    public int Entero { get; set; }
    public ObjEjemplo(int entero)
    {
        Entero = entero;
    }
}



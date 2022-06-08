CPunto<int> puntoI = new CPunto<int>(3,4);

CPunto<double> puntoD = new CPunto<double>(3.4, 4.22);

CPunto<float> puntoF = new CPunto<float>(3.55f, 4.2f);

Console.WriteLine(puntoI);
Console.WriteLine(puntoD);
Console.WriteLine(puntoF);

//colocamos el valor de default
puntoI.Reset();
Console.WriteLine(puntoI);

puntoI.encuentraTipo();
puntoF.encuentraTipo();

class CPunto<T>
{
    //atributos tipo t
    private T x;
    private T y;

    //Podemos recibir parametros de tipo T
    public CPunto(T px, T py)
    {
        x = px;
        y = py;
    }

    public override string ToString()
    {
        return String.Format("X={0} ,Y={1}", x, y);
    }

    public void Reset()
    {
        // Colocamos el valor de default para el tipo T
        //Numericos 0
        //referencias null
        x = default(T);
        y = default(T);

    }

    public void encuentraTipo()
    {
        if (typeof(T) == typeof(int))
            Console.WriteLine("Trabajo como entero");
        else
            Console.WriteLine("soy otro tipo");

    }
}
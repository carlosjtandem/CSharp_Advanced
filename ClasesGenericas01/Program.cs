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
}
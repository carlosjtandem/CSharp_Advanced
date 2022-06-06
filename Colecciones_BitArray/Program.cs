// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 });
Console.WriteLine(miArreglo.Count);
MuestraArreglo(miArreglo);

Console.WriteLine("---**--");

//Obtenemos un bit en particular
Console.WriteLine(miArreglo.Get(8));

// Agregar un bit en particular por el indice
miArreglo.Set(3, true);
MuestraArreglo(miArreglo);


static void MuestraArreglo(BitArray pArreglo, string pNombre = "")
{
    int c = 0;
    Console.Write("{0}\t" + pNombre);
    foreach (bool item in pArreglo)
    {
        c++;
        if (item)
            Console.Write("1");
        else
            Console.Write("0");
        if (c % 8 == 0)
            Console.Write(",");

    }

    Console.WriteLine();
}
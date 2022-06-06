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

//Clonamos un bit Array 
BitArray arreglo2 = (BitArray)miArreglo.Clone();  // Importante el cast a BitArray
MuestraArreglo(arreglo2, "array clonado\n");

//Invertimos un bitArray .. NOT
arreglo2.Not();
MuestraArreglo(arreglo2, "invert");

//creamos otros array
BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
MuestraArreglo(arreglo3, "Arreglo3");
Console.WriteLine();

//and entre arreglos
arreglo3.Or(miArreglo);
//muestra
MuestraArreglo(miArreglo, "miArreglo");
MuestraArreglo(arreglo3, "miArreglo3");


//miArreglo.And(miArreglo);
//MuestraArreglo(miArreglo, "miArreglo");



//XOR entre arreglos
//devuelve 1 si son diferentes 1 xor 0 = 1
//devuelve 0 si son iguales 0 xor 0 = 0


static void MuestraArreglo(BitArray pArreglo, string pNombre = "")
{
    int c = 0;
    Console.Write("{0}\t", pNombre);
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
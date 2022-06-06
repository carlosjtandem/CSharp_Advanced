// See https://aka.ms/new-console-template for more information
using System.Collections;

Type tipo;
//1 ARRAY LIST
ArrayList palabras = new ArrayList();
palabras.AddRange(new string[] { "Hola", "Carlos", "como vas?" });
Console.WriteLine("Cantidad elementos:{0}", palabras.Count);
//REcorremos el ciclo con for
for (int i = 0; i < palabras.Count; i++)
{
    Console.WriteLine("{0}", palabras[i]);
}
Console.WriteLine("");
Console.WriteLine("----------------------------");

//Add element- with Add()
palabras.Add("Bien y tu?");
palabras.Add(3);
//REcorremos el ciclo con foreach
foreach (var palabra in palabras)
{
    Console.WriteLine("{0}", palabra + " tipo:" + palabra.GetType());

}

Console.WriteLine("");
Console.WriteLine("----------------------------");
//Array de enteros
ArrayList valores = new ArrayList();
valores.Add(10);
valores.Add(20);
valores.Add(40);


//Añadir en un indice particular
valores.Insert(2, 30);

int r = 0;
for (int i = 0; i < valores.Count; i++)
{
    r = (int)valores[i];
    Console.WriteLine(valores[i] + "--" + i.GetType());
}

//remover valores del array por valor o indice
valores.Remove(10);  // valores.RemoveAt(0)  // importante validar si el indice existe
for (int i = 0; i < valores.Count; i++)
{
    r = (int)valores[i];
    Console.WriteLine(valores[i] + "--" + i.GetType());
}






//What happened if I add a int value?

// un metodo anonimo es un metodo que no tiene nombre
// 

using MetodosAnonimos;

Punto miPunto = new Punto(3, 4);

//creamos el metodo aninimo para el delegado
//+= sirve para asignar un handler al delegado
miPunto.mensaje += delegate ()
{
    Console.WriteLine("EStoy desde el metodo anonimo"); // este es el metodo anonimo que se invocara cuando invoquemos a mensaje
};
Console.WriteLine(miPunto.ToString());

//invocamos
miPunto.mensaje(); // esto invocara todos los handlers que tenga asignado

// Tambien se puede crear mas handler al delegado , lo haremos como metodos anonimos
miPunto.mensaje += delegate ()
{
    Console.WriteLine("Handler 2"); // este es el metodo anonimo que se invocara cuando invoquemos a mensaje
};
miPunto.mensaje(); // esto invocara todos los handlers que tenga asignado
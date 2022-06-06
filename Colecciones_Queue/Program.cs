using System.Collections;

Queue myQ= new Queue();  //  son tipo FIFO

//adicionamos objetos
myQ.Enqueue("Manzana");
myQ.Enqueue("Fresa");
myQ.Enqueue("Pera");
myQ.Enqueue("Limon");


foreach (var fruta in myQ)
{
    Console.WriteLine("-- {0}", fruta);  // imprime en el orden que se ingresa.
}

// Obtener un objeto  DEQUEUE

Console.WriteLine("Dequeue {0}",myQ.Dequeue());
//Console.WriteLine("Dequeue {0}", myQ.Dequeue());

foreach (string fruta in myQ)
{
    Console.WriteLine("Despues del queue--- {0}",fruta);
}


//Adicionamis objetos
myQ.Enqueue("coco");
myQ.Enqueue("babaco");
myQ.Enqueue("ciruela");

//observamo sobjecto con peek
Console.WriteLine("Peek {0}", myQ.Peek());

// Conteo de objetos
Console.WriteLine(myQ.Count);

//verificamos si existe elemento
Console.WriteLine(myQ.Contains("coco"));
Console.WriteLine(myQ.Contains("coco Loco"));


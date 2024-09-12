// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*int limite = 1;
while (limite < 100) 
{
    Console.WriteLine(limite);
    limite++;
}
*/


/*int respuesta;
Console.WriteLine("Desde donde quieres empezar = ");
respuesta = int.Parse(Console.ReadLine());
while (respuesta > 0)
{
    Console.WriteLine(respuesta);
    respuesta--;
}
*/


int respuesta;
do
{
    Console.WriteLine("¿Que numero de la tabla quieres que te muestre 1 ? = ");
    respuesta = int.Parse(Console.ReadLine());

} while (respuesta <= 0);

int respuesta2;
int respuesta3 = 1;
Console.WriteLine("¿Que numero de la tabla quieres que te muestre? = ");
respuesta2=int.Parse(Console.ReadLine());
while (respuesta3 < 13 && respuesta2 < 13 )
{
    if(respuesta2 > 0)
    {
        Console.WriteLine(respuesta2 + "X" + respuesta3 + "=" + (respuesta2 * respuesta3));
        respuesta3++;
    }
    else
    {
        Console.WriteLine("ESTAS PONIENDO NUMERO NEGATIVO o 0 ");
        respuesta3++;
    }
   
}
Console.WriteLine("AH FINALIZADO.. "); 

/* int respuesta;
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ingresa un numero positivo = ");
    respuesta = int.Parse(Console.ReadLine());

} while (respuesta <= 0);

int respuesta2;
int suma = 0;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nIngresa un  numero = ");
respuesta2 = int.Parse(Console.ReadLine());
while(respuesta2 >= 0)
{
    suma = suma + respuesta2;
    Console.WriteLine("\ningresa un numero = ");
    respuesta2 = int.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("se acabo el programa");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Este es la suma de todos los pares e impares = "+suma);
*/






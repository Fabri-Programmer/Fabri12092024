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
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("QUE QUIERES INGRESAR = ");
respuesta = int.Parse(Console.ReadLine());
while(respuesta != 0)
{
    Console.Write("QUE QUIERES INGRESAR =  ");
    respuesta = int.Parse(Console.ReadLine());
    


}
Console.ForegroundColor =ConsoleColor.Green;
Console.WriteLine("\nSE ACABO"); 
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





/* int respuesta;
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
   
} */

//Console.WriteLine("AH FINALIZADO.. "); 

int respuesta;
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ingresa un numero positivo = ");
    respuesta = int.Parse(Console.ReadLine());

} while (respuesta <= 0);

int respuesta2;
int suma = 0;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n !!   Okey perfecto    !! ");
Console.WriteLine("Ingresa un numero y se sumara : ");
respuesta2 = int.Parse(Console.ReadLine());
while(respuesta2 != 0)
{
    suma = suma + respuesta2;
    Console.WriteLine("Ingresa un numero y se sumara : ");
    respuesta2 = int.Parse(Console.ReadLine());
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Este es la suma de todos los pares e impares = "+suma);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nFINALIZO EL PROGRAMA CRACK <3 !! ");


/*for (int i = 4; i <= 16; i+=4)
{
    Console.Write("Hola = " +i );
    
*/











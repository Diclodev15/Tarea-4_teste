int numero1 = 1;
int numero2 = 2;
string opcion = "";



Console.WriteLine("Desea ejecutar el programa? (si/no)");
opcion = Console.ReadLine().ToLower();
if (opcion == "si")
{
    Console.Clear();
    saludar();

}
else if (opcion == "no")
{
    Console.WriteLine("Programa no ejecutado");

}
else
{
    Console.WriteLine("Opcion no valida");
}
void saludar()
{

    Console.WriteLine("Ingrese el primer numero");
    numero1 = Convert.ToInt32(Console.ReadLine());

    if (numero1 == 1)

    {
        Console.WriteLine("Hola mundo esta es mi prueba de mi practica #4, de electiva 2 ");
    }
    else if (numero2 == 2)
    {
        Console.WriteLine("Esta es mi prueba, Hola Mundo");
    }
    else
    {
        Console.WriteLine("Los numeros no son iguales a 1 y 2");
    }
}
Console.ReadKey();


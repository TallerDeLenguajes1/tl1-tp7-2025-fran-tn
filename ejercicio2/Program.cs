using System;
using EspacioEmpleado;

Empleado[] lista = new Empleado[3];
string recibirDato;
int edad, antiguedad;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese la edad del empleado");
    recibirDato = Console.ReadLine();

    while (!(int.TryParse(recibirDato, out edad)))
    {
        Console.WriteLine("Ingrese la edad del empleado");
        recibirDato = Console.ReadLine();
    }


    Console.WriteLine("Ingrese la antiguedad del empleado");
    recibirDato = Console.ReadLine();

    while (!(int.TryParse(recibirDato, out antiguedad)))
    {
        Console.WriteLine("Ingrese la antiguedad del empleado");
        recibirDato = Console.ReadLine();
    }


    lista[i] = new Empleado();
    lista[i].CargarEdad(edad);
    lista[i].CargarAntiguedad(antiguedad);
}

for(int i = 0; i < 3; i++)
{
    Console.WriteLine($"Edad: {lista[i].Edad}, Antiguedad: {lista[i].Antiguedad}");
}

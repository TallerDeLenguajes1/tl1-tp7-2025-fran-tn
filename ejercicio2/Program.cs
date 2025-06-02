using System;
using EspacioEmpleado;

Empleado[] lista = new Empleado[3];
string recibirDato = "", cargo;
int edad, antiguedad, estadoCivil, mostrar = -1, auxiliar = 0;
double sueldo, total = 0;

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

    Console.WriteLine("Ingrese el salario del empleado");
    recibirDato = Console.ReadLine();

    while (!(double.TryParse(recibirDato, out sueldo)))
    {
        Console.WriteLine("Ingrese el salario del empleado");
        recibirDato = Console.ReadLine();
    }

    Console.WriteLine("Ingrese el cargo del empleado");
    cargo = Console.ReadLine();

    Console.WriteLine("El empleado se encuentra casado?");
    Console.WriteLine("1)SI");
    Console.WriteLine("0)NO");
    recibirDato = Console.ReadLine();


    while (!(int.TryParse(recibirDato, out estadoCivil)))
    {   
            Console.WriteLine("El empleado se encuentra casado?");
            Console.WriteLine("1)SI");
            Console.WriteLine("0)NO");
            recibirDato = Console.ReadLine();    
    }

    if (estadoCivil != 1)
    {
        estadoCivil = 0;
    }


    lista[i] = new Empleado();
    lista[i].CargarEdad(edad);
    lista[i].CargarAntiguedad(antiguedad);
    lista[i].cargarRol(cargo);
    lista[i].cargarCasado(estadoCivil);
    lista[i].InfoSalario.cargarSueldo(sueldo);
    lista[i].InfoSalario.calcularPorTiempo(antiguedad);
    lista[i].InfoSalario.calcularPorRol(cargo);
    lista[i].InfoSalario.calcularPorEstadoCivil(estadoCivil);
}

for (int i = 0; i < 3; i++)
{
    total = total + lista[i].InfoSalario.Sueldo + lista[i].InfoSalario.Adicional;
    if (lista[i].Edad < 65 && lista[i].Edad > auxiliar)
    {
        auxiliar = lista[i].Edad;
        mostrar = i;
    }

   /* Console.WriteLine("~~~~~~~~~~~~AAAAAA~~~~~~");
    Console.WriteLine($"Edad: {lista[i].Edad}, Antiguedad: {lista[i].Antiguedad}");

    Console.WriteLine($"Años para jubilarse: {65 - lista[i].Edad}");

    Console.WriteLine($"Salario: {lista[i].InfoSalario.Sueldo}, adicional: {lista[i].InfoSalario.Adicional}");
    Console.WriteLine($"Rol: {lista[i].Rol}");
    Console.WriteLine($"Esta casado: {lista[i].Casado}");
   */


}

if (mostrar != -1)
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~");
    Console.WriteLine($"Edad: {lista[mostrar].Edad}, Antiguedad: {lista[mostrar].Antiguedad}");

    Console.WriteLine($"Años para jubilarse: {65 - lista[mostrar].Edad}");
    
    Console.WriteLine($"Salario: {lista[mostrar].InfoSalario.Sueldo}, Monto a cobrar: {lista[mostrar].InfoSalario.Sueldo + lista[mostrar].InfoSalario.Adicional}");

    Console.WriteLine($"Dinero gastado en sueldos: {total}");

}
else
{
    Console.WriteLine("Los  empleados no cumplen los requisitos");
}

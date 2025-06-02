// See https://aka.ms/new-console-template for more information

using System;
using EspacioCalculadora;


        int iterar = 1, operacion;
        double num2;
        string auxiliar;
        Calculadora Operaciones = new Calculadora();


        while (iterar == 1)
        {
            Console.WriteLine("Seleccione una operacion");
            Console.WriteLine("1)SUMA");
            Console.WriteLine("2)RESTA");
            Console.WriteLine("3)PRODUCTO");
            Console.WriteLine("4)DIVISION");
            Console.WriteLine("0)SALIR");
            auxiliar = Console.ReadLine();
            

            while (!int.TryParse(auxiliar, out operacion))
        {
                Console.WriteLine("Seleccione una operacion");
                Console.WriteLine("1)SUMA");
                Console.WriteLine("2)RESTA");
                Console.WriteLine("3)PRODUCTO");
                Console.WriteLine("4)DIVISION");
                Console.WriteLine("0)SALIR");
                auxiliar = Console.ReadLine();
        }


        if (operacion != 0)
        {
                Console.WriteLine("Ingrese un numero");
                auxiliar = Console.ReadLine();

                while (!double.TryParse(auxiliar, out num2))
                {
                        Console.WriteLine("Ingrese un numero");
                        auxiliar = Console.ReadLine();
                }


                switch (operacion)
                {
                        case 1:
                                Operaciones.Suma(num2);
                                Console.WriteLine($"Reultado: {Operaciones.Resultado}");
                                break;

                        case 2:
                                Operaciones.Restar(num2);
                                Console.WriteLine($"Reultado: {Operaciones.Resultado}");
                                break;

                        case 3:
                                Operaciones.Multiplicar(num2);
                                Console.WriteLine($"Reultado: {Operaciones.Resultado}");
                                break;

                        case 4:
                                if (num2 != 0)
                                {
                                        Operaciones.Dividir(num2);
                                        Console.WriteLine($"Resultado: {Operaciones.Resultado}");
                                }
                                else
                                {
                                        Console.WriteLine("No se puede dividir por 0");
                                }
                                break;

                        default:
                                Console.WriteLine("Opcion incorrecta");
                                break;
                }
        }
        else
        {
                iterar = 0;
                Operaciones.Limpiar();
        }
        


        }
    

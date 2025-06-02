namespace EspacioEmpleado;

public class Empleado
{
    private int antiguedad; //declaro las variables privadas
    private int edad;

    private bool jubilado;

    public int Antiguedad   //Declaro variables que me permitiran obtener las privadas
    {
        get => antiguedad;
    }

    public int Edad
    {
        get => edad;
    }

    public void CargarAntiguedad(int cargar)
    {
        antiguedad = cargar;
    }

    public void CargarEdad(int cargar)
    {
        edad = cargar;
    }

}
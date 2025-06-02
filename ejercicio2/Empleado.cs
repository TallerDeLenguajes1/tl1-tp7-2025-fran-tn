namespace EspacioEmpleado;

 public class Salario
    {
        private double sueldo;

        private double adicional;

        public double Sueldo
        {
            get => sueldo;
        }

        public double Adicional
        {
            get => adicional;
        }

        public void cargarSueldo(double cargar)
        {
            sueldo = cargar;
        }

        public void calcularPorTiempo(int anio)
        {
            adicional += (sueldo * 0.01 * anio);
        }

        public void calcularPorRol(string ingresarRol)
        {
            switch (ingresarRol)
            {
                case "Ingeniero":
                case "Especialista":
                    adicional += (adicional * 0.5);
                    break;
                default:
                    break;
            }
        }

        public void calcularPorEstadoCivil(int estado)
        {
            switch (estado)
            {
                case 1:
                    adicional += 150000;
                    break;
                default:
                    break;
            }
        }
    }

public class Empleado
{
    private int antiguedad; //declaro las variables privadas

    private int edad;

    private string rol = "";

    private int casado;

    private Salario infoSalario = new Salario();

    public int Antiguedad   //Declaro variables que me permitiran obtener las privadas
    {
        get => antiguedad;
    }

    public int Edad
    {
        get => edad;
    }

    public string Rol
    {
        get => rol;
    }

    public int Casado
    {
        get => casado;
    }

    public Salario InfoSalario
    {
        get => infoSalario;
    }

   

    public void CargarAntiguedad(int cargar) //Esto me permite cargar las variables
    {
        antiguedad = cargar;
    }

    public void CargarEdad(int cargar)
    {
        edad = cargar;
    }

    public void cargarRol(string cargar)
    {
        rol = cargar;
    }

    public void cargarCasado(int cargar)
    {
        casado = cargar;
    }

}

namespace EspacioEmpleado;

enum Cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
class Empleado
{
    private string nombre;

    public string Nombre{
        get 
        {
            return nombre;
        }
        set
        {
            nombre=value;
        }
    }

    private string apellido;
    public String Apellido { get => apellido; set => apellido = value; }

    private DateTime fechaNac; 
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    private char estadoCivil;
    public global::System.Char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    private double sueldoBas;
    public global::System.Double SueldoBas { get => sueldoBas; set => sueldoBas = value; }
    internal Cargo Cargo { get => cargo; set => cargo = value; }

    private Cargo cargo;
}
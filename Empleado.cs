
namespace EspacioEmpleado;

enum PosiblesCargos
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
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    
    private double sueldoBas;
    public double SueldoBas { get => sueldoBas; set => sueldoBas = value; }

    private PosiblesCargos cargo;
    public PosiblesCargos Cargo { get => cargo; set => cargo = value; }
    
    public int Antiguedad()
    {
        DateTime hoy=DateTime.Now;
        int antiguedad = hoy.Year-fechaIngreso.Year;
        return antiguedad;
    }
        
    public int Edad()
    {
        DateTime hoy=DateTime.Now;
        int edad = hoy.Year-fechaNac.Year;
        return edad;
    }
    public int Jubilacion()
    {
        int jubilacion= 65- Edad();
        return jubilacion;
    }
    public double Salario()
    {
        double salario;
        if(Antiguedad()<20)
        {
            salario=SueldoBas+(SueldoBas*Antiguedad())/100;
        }else
        {
            salario=SueldoBas*1.25;
        }
        if(Cargo==PosiblesCargos.Ingeniero||Cargo==PosiblesCargos.Especialista)
        {
            salario=salario*1.5;
        }
        if(EstadoCivil=='c'||EstadoCivil=='C')
        {
            salario=salario+150000;
        }
        return salario;
    }

    public void mostrarEmpleado()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nNombre="+Nombre+"\nApellido:"+Apellido+"\nFecha de nacimiento:"+FechaNac+"\nEstado civil:"+EstadoCivil+"\nFecha de ingreso:"+FechaIngreso+"\nSueldo Basico:"+SueldoBas+"\nCargo:"+Cargo);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nAntiguedad:"+Antiguedad()+" anios \nEdad:"+Edad()+" anios\nJubilacion:"+ Jubilacion()+" anios faltan para la jubulacion \nSalario:"+Salario());
    }
}
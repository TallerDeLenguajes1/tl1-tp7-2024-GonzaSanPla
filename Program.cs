using EspacioCalculadora;
using EspacioEmpleado;

//----- Ejericio 1 -----

    // string? eleccion="10";  //El ? es para decir que es nulleable 
    // string? numS="";
    // double num=0;


    // Calculadora calc= new Calculadora();

    // while(eleccion!="0")
    // {   
    //     while(eleccion!="0"&&eleccion!="1"&&eleccion!="2"&&eleccion!="3"&&eleccion!="4"&&eleccion!="5")
    //     {
    //         Console.WriteLine("\nElija que operacion desea realizar:\n1-Sumar \n2-Restar \n3-Multiplicar \n4-Dividir\n5-Refresacar\n0-Salir");
    //         eleccion=Console.ReadLine();
    //         if(eleccion!="0" && eleccion!="5")
    //         {
    //             Console.WriteLine("\nIngrese el numero para operar:");
    //             numS=Console.ReadLine();
    //         } 
    //     }

    //     if(double.TryParse(numS, out num))
    //     {
    //         switch (eleccion)
    //         {
    //             case "1":
    //                 calc.Sumar(num);
    //                 break;

    //             case "2":
    //                 calc.Restar(num);
    //                 break;

    //             case "3":
    //                 calc.Multiplicar(num);
    //                 break;

    //             case "4":
    //                 if(num!=0)
    //                 {
    //                     calc.Dividir(num);
    //                 }else
    //                 {
    //                     Console.WriteLine("No se puede divir en 0");
    //                 }
                        
    //                 break;

    //             case "5":
    //                 calc.Limpiar();
    //                 break;
    //         }

    //         Console.WriteLine("\nEl resultado es:"+ calc.Resultado());
    //     }
    //     if(eleccion!="0")
    //     {
    //         eleccion="A";
    //     }
    // }


//----- Ejercicio 2 -----



double montoTotal=0;
int jubilacionMenor = 100;
int iJub=0;
int i=0;
Empleado[] empleados =new Empleado[3];

empleados[0]= new Empleado();
empleados[0].Apellido="Perez";
empleados[0].Nombre="Lucio";
empleados[0].FechaNac=new DateTime(1995,5,15);
empleados[0].EstadoCivil='S';
empleados[0].FechaIngreso=new DateTime(2021,4,5);
empleados[0].SueldoBas=50000;
empleados[0].Cargo=PosiblesCargos.Auxiliar;

empleados[1]= new Empleado();
empleados[1].Apellido="Rodriguez";
empleados[1].Nombre="Maria";
empleados[1].FechaNac=new DateTime(1968,3,20);
empleados[1].EstadoCivil='C';
empleados[1].FechaIngreso=new DateTime(2010,9,15);
empleados[1].SueldoBas=50000;
empleados[1].Cargo=PosiblesCargos.Ingeniero;

empleados[2]= new Empleado();
empleados[2].Apellido="Martines";
empleados[2].Nombre="Rodrigo";
empleados[2].FechaNac=new DateTime(1980,10,1);
empleados[2].EstadoCivil='S';
empleados[2].FechaIngreso=new DateTime(2016,6,10);
empleados[2].SueldoBas=50000;
empleados[2].Cargo=PosiblesCargos.Especialista;

foreach (var emp in empleados)
{
    
    emp.mostrarEmpleado();

    montoTotal=montoTotal+emp.Salario();

    if(emp.Jubilacion()<jubilacionMenor)
    {
        jubilacionMenor=emp.Jubilacion();
        iJub=i;
    }
    i++;
}

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nEl monto total a pagar a los empleado es de:"+montoTotal);

Console.WriteLine("\nEl empleado mas proximo a la jubilacion es:");
empleados[iJub].mostrarEmpleado();



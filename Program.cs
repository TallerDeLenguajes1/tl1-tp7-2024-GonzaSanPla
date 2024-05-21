using EspacioCalculadora;

//----- Ejericio 1 -----

    string? eleccion="10";  //El ? es para decir que es nulleable 
    string? numS="";
    double num=0;


    Calculadora calc= new Calculadora();

    while(eleccion!="0")
    {   
        while(eleccion!="0"&&eleccion!="1"&&eleccion!="2"&&eleccion!="3"&&eleccion!="4"&&eleccion!="5")
        {
            Console.WriteLine("\nElija que operacion desea realizar:\n1-Sumar \n2-Restar \n3-Multiplicar \n4-Dividir\n5-Refresacar\n0-Salir");
            eleccion=Console.ReadLine();
            if(eleccion!="0" && eleccion!="5")
            {
                Console.WriteLine("\nIngrese el numero para operar:");
                numS=Console.ReadLine();
            } 
        }

        if(double.TryParse(numS, out num))
        {
            switch (eleccion)
            {
                case "1":
                    calc.Sumar(num);
                    break;

                case "2":
                    calc.Restar(num);
                    break;

                case "3":
                    calc.Multiplicar(num);
                    break;

                case "4":
                    if(num!=0)
                    {
                        calc.Dividir(num);
                    }else
                    {
                        Console.WriteLine("No se puede divir en 0");
                    }
                        
                    break;

                case "5":
                    calc.Limpiar();
                    break;
            }

            Console.WriteLine("\nEl resultado es:"+ calc.Resultado());
        }
        if(eleccion!="0")
        {
            eleccion="A";
        }
    }


//----- Ejercicio 2 -----

Empleado emp =new Empleado()
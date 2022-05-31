const string nombreAlumno = Jorge Castillo;

while (Menu(nombreAlumno))
{
    Console.ReadKey(); // pausa, solicitar la entrada de una tecla
}


static bool Menu(string nombreAlumno)
{ 
    bool continuar = true;

    Console.Clear(); // Limpia la pantalla
    Console.Title = $"Evaluación II: {nombreAlumno}";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1) Listar préstamos");
    Console.WriteLine("2) Agregar préstamo");
    Console.WriteLine("3) Actualizar préstamo");
    Console.WriteLine("4) Eliminar préstamo");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");

    string opcion = Console.ReadLine().Trim(); // " 1 " => "1"

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Listado de préstamos registrados");
            // ToDo: Lógica GUI de listado
            
            break;
        case "2":
            Console.WriteLine("Insertar un nuevo préstamo");
            // ToDo: Lógica GUI de inserción
            break;
        case "3":
            Console.WriteLine("Actualizar un préstamo existente");
            // ToDo: Lógica GUI de actualización
            break;
        case "4":
            Console.WriteLine("Eliminar un préstamo existente");
            // ToDo: Lógica GUI de eliminación
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    return continuar;
}


// ToDo: lógica de GUI

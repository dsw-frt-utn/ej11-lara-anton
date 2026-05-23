using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{   
    public static void EjemploList()
    {
        CasoList lista = new CasoList();
        //Agregar 3 alumnos a la lista
        lista.AgregarAlumno("Lara");
        lista.AgregarAlumno("Vale");
        lista.AgregarAlumno("Juan");

        //Listar por consola los alumnos
        Console.WriteLine("Lista de alumnos:");
        foreach (var alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine(lista.BuscarAlumno("Lara")); // True

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine(lista.BuscarAlumno("Jade")); // False

        //Eliminar un alumno y listar por consola los alumnos
        lista.EliminarAlumno("Juan");

        Console.WriteLine("Alumnos después de eliminar a Juan:");
        foreach (var alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        lista.EliminarAlumnoEnPosicion(0);

        Console.WriteLine("Alumnos después de eliminar el primer elemento:");
        foreach (var alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();
        //Agregar 3 alumnos al diccionario
        diccionario.AgregarAlumno(56317, "Lara");
        diccionario.AgregarAlumno(56206, "Vale");
        diccionario.AgregarAlumno(60852, "Juan");

        //Listar por consola los alumnos
        Console.WriteLine("Alumnos en el diccionario:");
        foreach (var dic in diccionario.ObtenerAlumnos())
        {
            Console.WriteLine($"Legajo: {dic.Key}, Alumno: {dic.Value}");
        }

        //Buscar un alumno por clave y mostrar por consola
        diccionario.BuscarAlumno(56317);
        foreach (var dic in diccionario.ObtenerAlumnos())
        {
            if (dic.Key == 56317)
            {
                Console.WriteLine($"Alumno: {dic.Value}");
            }  
        }

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        diccionario.BuscarAlumno(34232);
        foreach (var dic in diccionario.ObtenerAlumnos())
        {
            if (dic.Key == 34232)
            {
                Console.WriteLine($"Alumno: {dic.Value}");
            }
            else Console.WriteLine("No existe el alumno cuyo legajo sea el ingresado.");
        }

        //Eliminar un alumno por clave y listar por consola los alumnos
        diccionario.EliminarAlumno(56206);
        Console.WriteLine("Alumnos después de eliminar a Vale:");
        foreach (var dic in diccionario.ObtenerAlumnos())
        {
            Console.WriteLine($"Legajo: {dic.Key}, Alumno: {dic.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();
        linq.GetPrimero();
        linq.GetUltimo();
        linq.GetTotalPrecios();
        linq.GetPromedioPrecios();
        linq.GetListById();
        linq.GetMayorPrecio();
        linq.GetMenorPrecio();
        linq.GetMayorPromedio();
        linq.GetLibrosOrdenadosPorTituloDescendente();

        // Ejemplo de obtener lista de strings con título y precio
        var listaFormateada = linq.GetLibros();
        Console.WriteLine("\nLista formateada:");
        foreach (var item in listaFormateada)
        {
            Console.WriteLine(item);
        }
    }
}

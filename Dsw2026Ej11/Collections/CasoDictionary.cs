namespace Dsw2026Ej11.Collections;


public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    Dictionary<int, string> alumnos = new Dictionary<int, string>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(int legajo, string alumno)
    {
        alumnos.Add(legajo, alumno);
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public string BuscarAlumno(int legajo)
    {
        return alumnos.ContainsKey(legajo) ? alumnos[legajo] : null;
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, string> ObtenerAlumnos()
    {
        return alumnos;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int legajo)
    {
        alumnos.Remove(legajo);
    }

}

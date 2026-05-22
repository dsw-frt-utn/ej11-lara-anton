namespace Dsw2026Ej11.Collections;

using System;
using System.Collections.Generic;


public class CasoList
{
    //Crear un campo que represente una lista de alumnos (List<>)
    List<string> alumnos = new List<string>();
    //Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(string alumno)
    {
        alumnos.Add(alumno);
    }
    //Incluir un método para retornar la lista
        public List<string> ObtenerAlumnos()
    {
        return alumnos;
    }
    //Incluir un método para buscar un alumno por nombre
    public bool BuscarAlumno(string alumno)
    {
        return alumnos.Contains(alumno);
    }
    //Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(string alumno)
    {
        alumnos.Remove(alumno);
    }
    //Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
    }
}

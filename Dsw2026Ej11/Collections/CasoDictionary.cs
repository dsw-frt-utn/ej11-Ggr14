using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int,Alumno> alumnosDic = new Dictionary<int,Alumno>();
    public void AddAlumno(int legajo, Alumno alumno)
    {
        if (!alumnosDic.ContainsKey(legajo))
        {
            alumnosDic.Add(legajo, alumno);
            Console.WriteLine("El alumno se agrego exitosamente");
        }
        else
        {
            Console.WriteLine("El legajo ya existe");
        }
    }
    public void ListarAlumno (int legajo)
    {
        if (alumnosDic.ContainsKey (legajo))
        {
           var alumnoEncontrado= alumnosDic[legajo];
            Console.WriteLine($"se encontro al alumno '{alumnoEncontrado}' existosamente");
        }
        else
        {
            Console.WriteLine("No se encontro al alumno");

        }
    }
    public void ListarDictionary ()
    {
        Console.WriteLine("El diccionario contiene: ");
        foreach(KeyValuePair<int,Alumno> elemento in alumnosDic ) 
        {
            int leg= elemento.Key;
            var al= elemento.Value;
            Console.WriteLine($"Legajo: {leg}; Alumnos: {al}");
        }
    }
    public void EliminarAlumno(int legajo)
    {
        if (alumnosDic.Remove(legajo))
        {
            Console.WriteLine($"El alumno {legajo} fue eliminado");
            Console.WriteLine("La lista se modifico: ");
            foreach (KeyValuePair<int, Alumno> elemento in alumnosDic)
            {
                int leg = elemento.Key;
                var al = elemento.Value;
                Console.WriteLine($"Legajo: {leg}; Alumnos: {al}");
            }
        }
        else { Console.WriteLine("Alumno no encontrado"); }
    }

}

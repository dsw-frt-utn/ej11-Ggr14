using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
     
     List<Alumno> alumnos = new List<Alumno>();
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }
    public void RetornarList()
    {
       Console.WriteLine($"Lista de alumnos:");
       for (int i = 0; i < alumnos.Count; i++)
        {
           var alum = alumnos[i];
            Console.WriteLine( alum);
        }
    }
    public void BuscarAlumno(string nombre)
    {
        foreach (Alumno alumno in alumnos)
        {
            if( alumno.Nombre == nombre )
            {
                Console.WriteLine($"Alumno encontrado por su nombre: {alumno}");
            }
                
        }



        Console.WriteLine("Alumno NO encontrado");
    }
    public void EliminarAlumno(Alumno alumno)
    {


        if (alumnos.Remove(alumno))
        {
            Console.WriteLine("Alumno eliminado");
            Console.WriteLine("La lista actualizada queda asi:");
            for (int i = 0; i < alumnos.Count; i++)
            {
                var alum = alumnos[i];
                Console.WriteLine(alum);
            }
        }
        else
        {
            Console.WriteLine("Alumno no encontrado");
        }       
    }
    public void EliminarPorIndice(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            Alumno alumexist = alumnos[posicion];
            alumnos.RemoveAt(posicion);
            Console.WriteLine($"El alumno '{alumexist}' fue eliminado");
            Console.WriteLine("la lista queda de la siguiente manera");
            for (int i = 0; i < alumnos.Count; i++)
            {
                var alum = alumnos[i];
                Console.WriteLine(alum);
            }
        }
        else { Console.WriteLine("la posicion es invalida o no se encuentra"); }
    }
    

}

using Dsw2026Ej11.Domain;
using Dsw2026Ej11.Collections;
namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Alumno a1 = new Alumno(1, "Lautaro", 7);
        Alumno a2 = new Alumno(2, "Maria", 8);
        Alumno a3 = new Alumno(3, "Juan", 6);
        Alumno a4 = new Alumno(4, "Pablo", 5);
        Alumno a5 = new Alumno(5, "Sofia", 9);
        CasoList list= new CasoList();
        list.AgregarAlumno(a1);
        list.AgregarAlumno(a2);
        list.AgregarAlumno(a3);
        list.AgregarAlumno(a4);
        list.AgregarAlumno(a5);
        list.RetornarList();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        list.EliminarAlumno(a2);
        list.EliminarPorIndice(0);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Alumno m1 = new Alumno(6, "Lucas", 7);
        Alumno m2 = new Alumno(7, "Alberto", 8);
        Alumno m3 = new Alumno(8, "Ana", 6);
        CasoDictionary dic = new CasoDictionary();
        dic.AddAlumno(1234,m1);
        dic.AddAlumno(5678, m2);
        dic.AddAlumno(8910,m3);
        dic.ListarDictionary();
        dic.ListarAlumno(1234);
        dic.ListarAlumno(127);
        dic.EliminarAlumno(1234);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();
        linq.GetPrimero();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetUltimo();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetTotalPrecios();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetPromedioPrecios();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetListById();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetLibros();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetMayorPrecio();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetMenorPrecio();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetMayorPromedio();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        linq.GetOrdenado();

    }
}

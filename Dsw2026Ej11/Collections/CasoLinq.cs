using System;
using System.Collections.Generic;
using System.Linq;
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

/*
/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    protected List<Libro> libro = Libro.CrearLista();
    public void GetPrimero()
    {
        var primero = libro.First();
        Console.WriteLine("El primer libro de la lista es: ");
        Console.WriteLine($"{primero.Id},{primero.Titulo},{primero.Precio}");
    }

    public void GetUltimo()
    {
        var ultimo = libro.Last();
        Console.WriteLine("El ultimo  libro de la lista es: ");
        Console.WriteLine($"{ultimo.Id},{ultimo.Titulo},{ultimo.Precio}");
    }
    public void GetTotalPrecios()
    {
        var total = libro.Sum(libro => libro.Precio);
        Console.WriteLine($"La suma de los precios es : {total}");
    }
    public void GetPromedioPrecios()
    {
        var promedio = libro.Average(libro => libro.Precio);
        Console.WriteLine($"El promedio de los precios es : {promedio}");
    }
    public void GetListById()
    {
        var condicion = libro.Where(libro => libro.Id > 15);
        Console.WriteLine($"Los libros cuya ID es mayor a 15 son:");

        foreach (Libro libro in condicion)
        {
            Console.WriteLine($"{libro.Id},{libro.Titulo},{libro.Precio}");
        }
    }
    public void GetLibros()
    {
        var listar = libro.Select(libro => $"{libro.Titulo}-{libro.Precio:c}");
        foreach (string libros in listar)
        {
            Console.WriteLine(libros);
            Console.WriteLine("/////////////////////////////////////");
        }
    }
    public void GetMayorPrecio()
    {
        var mayor = libro.OrderByDescending(libro => libro.Precio);
        var first = mayor.First();
        Console.WriteLine("El libro mas caro es: ");
        Console.WriteLine($"{first.Id},{first.Titulo}");
        Console.WriteLine($"Con un precio de ${first.Precio}");
    }
    public void GetMenorPrecio()
    {
        var menor = libro.OrderByDescending(libro => libro.Precio);
        var last = menor.Last();
        Console.WriteLine("El libro mas barato es: ");
        Console.WriteLine($"{last.Id},{last.Titulo}");
        Console.WriteLine($"Con un precio de ${last.Precio}");
    }
    public void GetMayorPromedio()
    {
        var promedio = libro.Average(libro => libro.Precio);
        var mayorprom = libro.Where(libro=> libro.Precio>promedio);
        Console.WriteLine("Los libros con precio mayor al promedio son: ");
        
        foreach( var libros in mayorprom)
        {
            Console.WriteLine($"{libros.Id}-{libros.Titulo}-{libros.Precio}");
        }
    }
    public void GetOrdenado()
    {
        var orden = libro.OrderByDescending(libro => libro.Titulo);
        Console.WriteLine("Libros ordenados de forma descendente por titulo: ");
        foreach ( var libros in orden)
        {
            Console.WriteLine($"{libros.Id}-{libros.Titulo}-{libros.Precio}");
        }
    }

}

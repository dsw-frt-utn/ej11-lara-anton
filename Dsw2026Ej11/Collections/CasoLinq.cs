using Dsw2026Ej11.Domain;
using System.Timers;

namespace Dsw2026Ej11.Collections;

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
     //* 1. Obtener el primer libro(GetPrimero)
     public void GetPrimero()
    {
        IEnumerable<string> books = new List<string>();
        IEnumerable<string> firstBook = books.Select( b => b.FirstOrDefault);

        foreach (string book in firstBook)
        {
            Console.WriteLine(book);
        }
    }

    //* 2. Obtener el último libro(GetUltimo)
    public void GetUltimo()
    {
        IEnumerable<string> books = new List<string>();
        IEnumerable<string> firstBook = books.Select(static b => b.LastOrDefault);

        foreach (string book in firstBook)
        {
            Console.WriteLine(book);
        }
    }

    //* 3. Obtener la suma de precios(GetTotalPrecios)
    public void GetTotalPrecios()
    {
        IEnumerable<double> prices = new List<double>();
        double totalPrice = prices.Sum();

        Console.WriteLine($"La suma total de precios es: {totalPrice}");
    }

    //* 4.Obtener el promedio de precios(GetPromedioPrecios)
    public void GetPromedioPrecios()
    {
        IEnumerable<double> prices = new List<double>();
        double averagePrice = prices.Average();

        Console.WriteLine($"El promedio de precios es: {averagePrice}");
    }

    //* 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public void GetListById()
    {
        IEnumerable<Libro> books = new List<Libro>();
        IEnumerable<Libro> booksWithIdGreaterThan15 = books.Where(b => b.Id > 15);
       
        foreach (Libro book in booksWithIdGreaterThan15)
        {
            Console.WriteLine(book);
        }
    }

    // //* 6. Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        IEnumerable<Libro> books = new List<Libro>();
        IEnumerable<string> bookTitlesAndPrices = books.Select(b => $"{b.Titulo} - {b.Precio:C}");
        
        return bookTitlesAndPrices.ToList();
    }

            Console.WriteLine(book);
        }
    }

    // * 7. Obtener el libro con el precio más alto(GetMayorPrecio)
    public void GetMayorPrecio()
    {
       IEnumerable<Libro> books = new List<Libro>();
        Libro bookWithHighestPrice = books.OrderByDescending(b => b.Precio).FirstOrDefault();
        if (bookWithHighestPrice != null)
        {
             Console.WriteLine($"El libro con el precio más alto es: {bookWithHighestPrice}");
        }
         else
         {
             Console.WriteLine("No se encontraron libros.");
         }
    }

// * 8. Obtener el libro con el precio más bajo(GetMenorPrecio)
public void GetMenorPrecio()
{
    IEnumerable<Libro> books = new List<Libro>();
    Libro bookWithLowestPrice = books.OrderBy(b => b.Precio).FirstOrDefault();
    if (bookWithLowestPrice != null)
    {
        Console.WriteLine($"El libro con el precio más bajo es: {bookWithLowestPrice}");
    }
    else
    {
        Console.WriteLine("No se encontraron libros.");
    }
}

// * 9. Obtener los libros cuyo precio sea mayor al promedio(GetMayorPromedio)
public void GetMayorPromedio()
{
    IEnumerable<Libro> books = new List<Libro>();
    double averagePrice = books.Average(b => b.Precio);
    IEnumerable<Libro> booksAboveAveragePrice = books.Where(b => b.Precio > averagePrice);
    Console.WriteLine($"El precio promedio es: {averagePrice}");
    Console.WriteLine("Libros con precio mayor al promedio:");
    foreach (Libro book in booksAboveAveragePrice)
    {
        Console.WriteLine(book);
    }
}

// * 10.Obtener los libros ordenados por título de forma descendente
public void GetLibrosOrdenadosPorTituloDescendente()
{
    IEnumerable<Libro> books = new List<Libro>();
    IEnumerable<Libro> booksOrderedByTitleDescending = books.OrderByDescending(b => b.Titulo);
    Console.WriteLine("Libros ordenados por título de forma descendente:");
    
    foreach (Libro book in booksOrderedByTitleDescending)
    {
        Console.WriteLine(book);
    }

}

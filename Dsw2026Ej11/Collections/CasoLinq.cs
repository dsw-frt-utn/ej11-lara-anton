using Dsw2026Ej11.Domain;
using System.Timers;

namespace Dsw2026Ej11.Collections;

/*
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros;
    public CasoLinq()
    {
        // Inicializa la lista con los datos de Libro.CrearLista()
        libros = Libro.CrearLista();
    }

    //* 1. Obtener el primer libro(GetPrimero)
    public void GetPrimero()
    {
        var firstBook = libros.FirstOrDefault();
        if (firstBook != null)
        {
            Console.WriteLine($"Primer libro: {firstBook.Titulo}");
        }
        else Console.WriteLine("No hay libros en la lista.");
    }

    //* 2. Obtener el último libro(GetUltimo)
    public void GetUltimo()
    {
        var lastBook = libros.LastOrDefault();
        if (lastBook != null)
        {
            Console.WriteLine($"Último libro: {lastBook.Titulo}");
        }
        else Console.WriteLine("No hay libros en la lista.");
    }

    //* 3. Obtener la suma de precios(GetTotalPrecios)
    public void GetTotalPrecios()
    {
        decimal totalPrice = libros.Sum(b => b.Precio);
        Console.WriteLine($"La suma total de precios es: {totalPrice}");
    }

    //* 4.Obtener el promedio de precios(GetPromedioPrecios)
    public void GetPromedioPrecios()
    {
        decimal averagePrice = libros.Average(b => b.Precio);
        Console.WriteLine($"El promedio de precios es: {averagePrice}");
    }

    //* 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public void GetListById()
    {
        IEnumerable<Libro> booksWithIdGreaterThan15 = libros.Where(b => b.Id > 15);
        Console.WriteLine("Lista de libros con ID mayor a 15:");
        foreach (Libro book in booksWithIdGreaterThan15)
        {
            Console.WriteLine($"{book.Titulo} - {book.Precio:C}");
        }
    }

    // //* 6. Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        IEnumerable<string> bookTitlesAndPrices = libros.Select(b => $"{b.Titulo} - {b.Precio:C}");
        return bookTitlesAndPrices.ToList();
    }

    // * 7. Obtener el libro con el precio más alto(GetMayorPrecio)
    public void GetMayorPrecio()
    {
        Libro bookWithHighestPrice = libros.OrderByDescending(b => b.Precio).FirstOrDefault();
        if (bookWithHighestPrice != null)
        {
            Console.WriteLine($"El libro con el precio más alto es: {bookWithHighestPrice}");
        }
    }

    // * 8. Obtener el libro con el precio más bajo(GetMenorPrecio)
    public void GetMenorPrecio()
    {
        Libro bookWithLowestPrice = libros.OrderBy(b => b.Precio).FirstOrDefault();
        if (bookWithLowestPrice != null)
        {
            Console.WriteLine($"El libro con el precio más bajo es: {bookWithLowestPrice}");
        }

    }

    // * 9. Obtener los libros cuyo precio sea mayor al promedio(GetMayorPromedio)
    public void GetMayorPromedio()
    {
        decimal averagePrice = libros.Average(b => b.Precio);
        IEnumerable<Libro> booksAboveAveragePrice = libros.Where(b => b.Precio > averagePrice);
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
        IEnumerable<Libro> booksOrderedByTitleDescending = libros.OrderByDescending(b => b.Titulo);
        Console.WriteLine("Libros ordenados por título de forma descendente:");
        foreach (Libro book in booksOrderedByTitleDescending)
        {
            Console.WriteLine(book);
        }
    }
}
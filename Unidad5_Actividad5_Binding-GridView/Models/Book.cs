using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5_Actividad5_Binding_GridView.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Museo de Antopología", Author = "", CoverImage = "Assets/Antropologia.jpg" });
            books.Add(new Book { BookId = 2, Title = "Bellas Artes", Author = "", CoverImage = "Assets/Bellas Artes.jpg" });
            books.Add(new Book { BookId = 3, Title = "Cuauhnauac", Author = "", CoverImage = "Assets/Cuauhnauac.jpg" });
            books.Add(new Book { BookId = 4, Title = "Ferrocarrilero", Author = "", CoverImage = "Assets/Ferrocarrileros.jpg" });
            books.Add(new Book { BookId = 5, Title = "José Luis Cuevas", Author = "", CoverImage = "Assets/Jose-Luis-Cuevas.jpg" });
            books.Add(new Book { BookId = 6, Title = "Soumaya", Author = "", CoverImage = "Assets/Soumaya.jpg" });
            return books;
        }
    }
}

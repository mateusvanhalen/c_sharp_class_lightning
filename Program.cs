using System;

namespace libraryC
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Clifford = new Book() {
                Title = "Clifford The Big Red Dog",
                Author = "Matt Hall",
                ISBN = "123ABC",
            };
//or this method works too

            Book tomSawyer = new Book(); {
            tomSawyer.Title = "Tom Sawyer",
            tomSawyer.Author = "Mark Twain",
            tomSawyer.ISBN = "22VMN",
            };

            Book book1 = new Book(){
                Title = "Book1",
                Author = "Author1",
                ISBN = "1A",
            };

            Book book2 = new Book (){
                Title = "Book2",
                Author = "Author2",
                ISBN = "2B",
            };

    List<Book> books = new List<Book> (){
        book1, book2
    };

    Library library = new Library(books, "Downtown Library", "5th Ave")
    // {
        // These are now passed into the parameters of the new Library - due to the CONSTRUCTOR!
        // Name = "Downtown Library",
        // Address = "5th Ave North"
    // };

    library.AddToInventory(tomSawyer);
    library.AddToInventory(Clifford);
    if (library.IsAvailable("2B"))
    {
        Console.WriteLine("2B is available");
    }
    else
    {
        Console.WriteLine("2B is not available");
    }

    //another way to add, but would not have variable
    library.AddToInventory(
        new Book() {Title = "foo", Author = "Big Guy", ISBN = "123"
        });

        }
    }
}

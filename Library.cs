
using System.Collections.Generic;

namespace libraryC
{
    public class Library {

        //This is creating a constructor. it NEEDS to be the same name as the class . There will not be a return type (void)
        public Library(List<Book> initialInventory, string name, string address)
        {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }


        //read only willhave only one property get
        public string Name { get; set; }
        public string Address { get; set; }
                    //everythingon right hand side makes the new list
        private List<Book> _bookList = new List<Book>();

        // class.method(parameter- needs type and then name)
        public void AddToInventory(Book book)
        {
            // can be this._bookList.Add(book) but do not need .this- however the editor will show rules if it is used
            _bookList.Add(book);

// Create 4 instances of books and use the method on your Library class to add them to the list of books in an instance of Library
        }
        public void Checkout(string isbn, CardHolder cardHolder)
        {
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn && book.IsAvailable)
                {
                    cardHolder.CheckoutBook(foundBook);
                    foundBook.IsAvailable = false;
                }
            }

        }
        public bool IsAvailable(string isbn)
        {
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn)
                {
                    return book.IsAvailable;
                }
            }
        return false;
        }

    }
}
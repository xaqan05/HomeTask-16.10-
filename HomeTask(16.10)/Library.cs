using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16._10_
{
    public class Library
    {
        public Book[] books;

        public Library()
        {
            books = new Book[0];    
        }
        public void AddBook(Book book)
        {
            Book[] newBooks = new Book[books.Length + 1];

            for (int i = 0; i < books.Length; i++)
            {
                newBooks[i] = books[i];
            }
            newBooks[books.Length] = book;
            books = newBooks;

        }
        public Book GetFilteredBooks(string genre)
        {
            Book filteredBook = null;

            for (int i = 0; i < books.Length; i++)
            {
                if (genre == books[i].Genre)
                {
                    filteredBook = books[i];
                    return filteredBook;
                }
            }

            return filteredBook;
        }

        public Book GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book filteredBook = null;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Price > minPrice && books[i].Price < maxPrice)
                {
                    filteredBook = books[i];
                    return filteredBook;
                }
            }
            return filteredBook;
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i].showInfo();
            }
        }
    }
}

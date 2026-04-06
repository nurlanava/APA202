using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _10.Generic_Types__Collections
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowBook { get; set; }
        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowBook = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (BorrowBook.Count >= 3)
            {
                Console.WriteLine("Maksimum 3 kitab goturmek olar");
                return;
            }
            BorrowBook.Add(book);
            Console.WriteLine($"Kitab goturuldu : {book.Title}");
        }
        public void RemoveBook(int bookid)
        {
            foreach (Book book in BorrowBook)
            {
                if (book.İd == bookid)
                {
                    BorrowBook.Remove(book);
                    Console.WriteLine($"Kitab qaytarildi : {book.Title}");
                    return;
                }
            }
        }
        public void DisplayBorrowBook()
        {
            if (BorrowBook.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdu");
                return;
            }
            foreach (Book book in BorrowBook)
            {
                book.DisplayInfo();
            }
        }

    }
}

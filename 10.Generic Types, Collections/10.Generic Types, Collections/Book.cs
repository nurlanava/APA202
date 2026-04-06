using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Generic_Types__Collections
{
    public class Book
    {
        public int İd {  get; set; }    
        public int Year { get; set; }   
        public string Author { get; set; }  
        public int PageCount {  get; set; }
       public  string Title { get; set; }    
        public Book(int id, int year, string author, int pageCount, string title    )
        {
            İd = id;
            Year = year;
            Author = author;
            PageCount = pageCount;
            Title = title;
        }
        public void DispInfo()
        {
            Console.WriteLine($"[{İd}] {Title} - {Author}({Year})-{PageCount}sehife");
        }
    }
}

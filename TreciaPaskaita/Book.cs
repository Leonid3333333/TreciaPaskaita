using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaPaskaita
{
   public class Book
    {
       public string title;
       public string author;
       public int pages;
       public static int bookCount = 0;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            bookCount++;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Library_Management
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public virtual string ShowDetails()
        {
            return $"Book: {Title}\nAuthor: {Author}\n";
        }
    }
}

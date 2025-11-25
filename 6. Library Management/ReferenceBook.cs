using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Library_Management
{
    internal class ReferenceBook : Book
    {
        public string Subject { get; set; }

        public ReferenceBook(string title, string author, string subject) : base(title, author)
        {
            Subject = subject;
        }

        public override string ShowDetails()
        {
            return base.ShowDetails() + $"Reference Subject: {Subject}";
        }
    }
}

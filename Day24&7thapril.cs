using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lynq
{
    class Book1
    {
      
      public static void Main()
        {
            IList<Book> Bodata = new List<Book> {
new Book(){BookID=1,Title="Here, There and Everywhere",Author="Sudha moorthy",price="$132" },
new Book(){BookID=2,Title="Everything I Never Told You",Author="Ajay Roy",price="$126" },
new Book(){BookID=3,Title="The Power of Positive Thinking",Author="peale norman vincent",price= "$265"},
                };
            var bqry = from Title in Bodata
                      select Title;
            foreach (var b in bqry)
                Console.WriteLine(b.BookID+"   "+b.Title+"   "+b.Author+"   "+b.price);
            var Titqry = from boo in Bodata
                         where boo.Author.Contains("Ajay Roy")
                         select boo;
            foreach (var names in Titqry)
                Console.WriteLine(names.Title);
                                       var obaqry = from s in Bodata
                                          orderby s.price ascending
                                          select s;
            foreach (var s in obaqry)
                Console.WriteLine(s.price);
            var auqry = from a in Bodata
                         orderby a.Author ascending
                         select a;
            foreach (var a in auqry)
                Console.WriteLine(a.Author+"   "+a.Title);


        }

        

        private class Book
        {
            public Book()
            {
            }
            public int BookID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string price { get; set; }
        }
    }
}

    

